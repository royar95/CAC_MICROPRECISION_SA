
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CACMicropresicion.Controller;
using CACMicropresicion.Globals;
using CACMicropresicion.Model;

namespace CACMicropresicion.View.Purchases
{
    public partial class ModifyPurchase : UserControl
    {

        private PurchaseController controller;
        private Compra header;
        private DataGridViewRowCollection purchaseDetail;
        private Dictionary<Object, dynamic> data;

        public ModifyPurchase()
        {
            InitializeComponent();
            this.Location = new Point(235, 97);
            this.loadCombos();
        }

        private void loadCombos() {

            this.controller = new PurchaseController();
            Dictionary<object, dynamic> resultMaterials = this.controller.getAllMaterials();
            Dictionary<object, dynamic> resultPaymentTypes = this.controller.getAllPaymentTypes();
            Dictionary<object, dynamic> resultStatus = this.controller.getAllProcessStatus();

            if (resultMaterials["code"] == Result.Failed ||
                resultPaymentTypes["code"] == Result.Failed ||
                resultStatus["code"] == Result.Failed) {
                MessageBox.Show(resultMaterials["msg"]);
                return;
            }

            this.populateMaterialList(resultMaterials["content"]);
            this.populatePaymentTypes(resultPaymentTypes["content"]);
            this.populateStatus(resultStatus["content"]);

        }

        public void populateMaterialList(Object list)
        {

            this.dgMaterialsList.DataSource = list;

            CurrencyManager cm = (CurrencyManager)BindingContext[dgMaterialsList.DataSource];
            cm.SuspendBinding();

            dgMaterialsList.RowHeadersVisible = false;
            dgMaterialsList.Columns[0].Visible = false;

            setMaterialListColumnSize();
            setFontConf();

        }

        private void setMaterialListColumnSize()
        {
            this.dgMaterialsList.Columns[0].Width = 80;
            this.dgMaterialsList.Columns[1].Width = 180;
            this.dgMaterialsList.Columns[2].Width = 156;
            this.dgMaterialsList.Columns[3].Width = 156;
        }

        private void setFontConf()
        {
            foreach (DataGridViewColumn column in this.dgMaterialsList.Columns)
            {
                column.DefaultCellStyle.Font = new Font("Segoe UI Light", 11);
                column.HeaderCell.Style.Font = new Font("Segoe UI Light", 12, FontStyle.Bold);
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            foreach (DataGridViewColumn column in this.dgPurchaseSummary.Columns)
            {
                column.DefaultCellStyle.Font = new Font("Segoe UI Light", 11);
                column.HeaderCell.Style.Font = new Font("Segoe UI Light", 12, FontStyle.Bold);
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        public void populatePaymentTypes(Object list)
        {
            this.cmbPaymentTypes.DataSource = list;
            this.cmbPaymentTypes.ValueMember = "IdTipoPago";
            this.cmbPaymentTypes.DisplayMember = "Descripcion";
        }

        public void populateStatus(Object list) {
            this.cmbStatus.DataSource = list;
            this.cmbStatus.ValueMember = "IdEstado";
            this.cmbStatus.DisplayMember = "Descripcion";
        }

        public void fillUserInputs(Dictionary<Object, dynamic> purchase) {

            this.header = purchase["header"];
            var detail = purchase["detail"];

            this.cmbPaymentTypes.SelectedValue = header.IdTipoPago;
            this.cmbPurchaseDate.Value = header.FechaCompra;
            this.txtTotal.Text = header.TotalCompra.ToString();
            this.cmbStatus.SelectedValue = header.IdEstado;

            foreach (var item in detail) {
                dgPurchaseSummary.Rows.Add(new String[] {
                    Convert.ToString(item.IdMaterial),
                    Convert.ToString(item.Descripcion),
                    Convert.ToString(item.Cantidad),
                    Convert.ToString(item.IdDetalleCompra),
                    Convert.ToString(item.Renglon),
                    Convert.ToString(item.IdCompra)
                });
            }

            dgPurchaseSummary.RowHeadersVisible = false;
            dgPurchaseSummary.Columns[0].Visible = false;

            this.purchaseDetail = new DataGridViewRowCollection(this.dgPurchaseSummary);
            foreach (DataGridViewRow row in dgPurchaseSummary.Rows) {
                DataGridViewRow newRow = (DataGridViewRow)row.Clone();
                newRow.Cells[0].Value = row.Cells[0].Value;
                newRow.Cells[1].Value = row.Cells[1].Value;
                newRow.Cells[2].Value = row.Cells[2].Value;
                newRow.Cells[3].Value = row.Cells[3].Value;
                newRow.Cells[4].Value = row.Cells[4].Value;
                newRow.Cells[5].Value = row.Cells[5].Value;
                this.purchaseDetail.Add(newRow);
            }

            this.accessibilityByStatus();

        }

        private void accessibilityByStatus() {

            this.enableAllComponents();

            if (!this.cmbStatus.SelectedValue.ToString().Equals(Status.Registered.ToString())) {
                this.disableAllComponents();
            }

            if (this.header.IdEstado == Status.Paid || this.header.IdEstado == Status.Canceled) {
                this.saveChanges.Enabled = false;
            }

        }

        private void disableAllComponents() {
            this.saveChanges.Enabled = true;
            this.cmbPurchaseDate.Enabled = false;
            this.txtTotal.Enabled = false;
            this.dgPurchaseSummary.ReadOnly = true;
        }

        private void enableAllComponents() {
            this.saveChanges.Enabled = true;
            this.cmbPaymentTypes.Enabled = true;
            this.cmbPurchaseDate.Enabled = true;
            this.txtTotal.Enabled = true;
            this.dgPurchaseSummary.ReadOnly = false;
        }

        private void dgMaterialsList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            string code = dgMaterialsList[0, rowIndex].Value.ToString();
            string description = dgMaterialsList[1, rowIndex].Value.ToString();

            foreach (DataGridViewRow row in dgPurchaseSummary.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    if (row.Cells[0].Value.Equals(code))
                    {
                        return;
                    }
                }
            }

            dgPurchaseSummary.Rows.Add(new String[] {
                code,
                description
            });
        }

        private void dgPurchaseSummary_KeyDown(object sender, KeyEventArgs e)
        {
            if (!this.dgPurchaseSummary.ReadOnly) {
                if (e.KeyData == Keys.Delete)
                {
                    if (this.dgPurchaseSummary.CurrentRow.Cells[1].Value != null)
                    {
                        this.dgPurchaseSummary.Rows.Remove(this.dgPurchaseSummary.CurrentRow);
                    }
                }
            }
        }

        private void catchData()
        {
            this.controller = new PurchaseController();
            this.data = new Dictionary<object, dynamic>();

            Compra newHeader = this.createNewPurchaseHeader();
            Object newPurchaseDetail = this.dgPurchaseSummary.Rows;

            this.data["newHeader"] = newHeader;
            this.data["oldHeader"] = this.header;
            this.data["newDetail"] = newPurchaseDetail;
            this.data["oldDetail"] = this.purchaseDetail;
            this.data["user"] = Session.getInstance().session["identification"];

        }

        private void loadDataGridView()
        {
            ViewPurchases control = new ViewPurchases();
            Parent.Controls.Add(control);
            Parent.Controls.RemoveByKey("ModifyPurchase");
        }


        private Compra createNewPurchaseHeader () {
            return new Compra() {
                IdCompra = this.header.IdCompra,
                IdUsuario = this.header.IdUsuario,
                FechaAgrega = this.header.FechaAgrega,
                FechaElimina = this.header.FechaElimina,
                Eliminado = this.header.Eliminado,
                IdEstado = (int)this.cmbStatus.SelectedValue,
                TotalCompra = Convert.ToDecimal(txtTotal.Text),
                IdTipoPago = (int)this.cmbPaymentTypes.SelectedValue,
                FechaCompra = this.cmbPurchaseDate.Value
            };
        }

        private void saveChanges_Click(object sender, EventArgs e)
        {

            if (txtTotal.Text.Equals(String.Empty)) {
                MessageBox.Show("Existen espacios en blanco, por favor validar");
                return;
            }

            this.catchData();
            this.controller.data = this.data;

            Dictionary<Object, dynamic> result = controller.modifyPurchase();

            if (result["code"] == Result.Processed)
            {
                this.loadDataGridView();
            }

            MessageBox.Show(result["msg"]);

        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.header != null) {
                switch (this.header.IdEstado)
                {
                    case Status.WaitingForPayment:
                        if (Convert.ToInt32(cmbStatus.SelectedValue) == Status.Proforma ||
                            Convert.ToInt32(cmbStatus.SelectedValue) == Status.Canceled)
                        {
                            this.cmbStatus.SelectedValue = Status.WaitingForPayment;
                            MessageBox.Show("No se permite la transición de pendiente de pago a proforma o anulación");
                        }
                        break;
                }
            }
        }
    }
}
