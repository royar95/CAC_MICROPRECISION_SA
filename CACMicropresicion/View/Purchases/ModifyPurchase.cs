
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

            Compra header = purchase["header"];
            var detail = purchase["detail"];

            this.cmbPaymentTypes.SelectedValue = header.IdTipoPago;
            this.cmbPurchaseDate.Value = header.FechaCompra;
            this.txtTotal.Text = header.TotalCompra.ToString();
            this.cmbStatus.SelectedValue = header.IdEstado;

            foreach (var item in detail) {
                dgPurchaseSummary.Rows.Add(new String[] {
                    Convert.ToString(item.IdMaterial),
                    Convert.ToString(item.Descripcion),
                    Convert.ToString(item.Cantidad)
                });
            }

            dgPurchaseSummary.RowHeadersVisible = false;
            dgPurchaseSummary.Columns[0].Visible = false;

        }

    }
}
