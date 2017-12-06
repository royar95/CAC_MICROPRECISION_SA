using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CACMicropresicion.Globals;
using CACMicropresicion.Model;
using CACMicropresicion.Controller;

namespace CACMicropresicion.View.Sales
{
    public partial class ModifySale : UserControl
    {
        private Dictionary<Object, dynamic> data;
        private SalesController controller;
        private Venta saleHeader;
        private Factura bill;
        private DataGridViewRowCollection saleDetail;
        private decimal total, subtotal, tax, discount;

        public ModifySale()
        {
            InitializeComponent();
            this.Location = new Point(235, 97);
            this.loadCombos();
        }

        private void loadCombos()
        {

            this.controller = new SalesController();
            Dictionary<object, dynamic> resultProducts = this.controller.getAllProducts();
            Dictionary<object, dynamic> resultPaymentTypes = this.controller.getAllPaymentTypes();
            Dictionary<object, dynamic> resultCustomers = this.controller.getAllCustomers();
            Dictionary<object, dynamic> resultStatus = this.controller.getAllProcessStatus();

            if (resultProducts["code"] == Result.Failed ||
                resultPaymentTypes["code"] == Result.Failed ||
                resultStatus["code"] == Result.Failed ||
                resultCustomers["code"] == Result.Failed)
            {
                MessageBox.Show(resultProducts["msg"]);
                return;
            }

            this.populateProducts(resultProducts["content"]);
            this.populatePaymentTypes(resultPaymentTypes["content"]);
            this.populateCustomers(resultCustomers["content"]);
            this.populateStatus(resultStatus["content"]);

        }

        public void populateProducts (Object list)
        {

            this.dgProductsList.DataSource = list;

            CurrencyManager cm = (CurrencyManager)BindingContext[dgProductsList.DataSource];
            cm.SuspendBinding();

            dgProductsList.RowHeadersVisible = false;
            dgProductsList.Columns[0].Visible = false;

            setProductListColumnSize();
            setFontConf();

        }

        private void setProductListColumnSize ()
        {
            this.dgProductsList.Columns[0].Width = 80;
            this.dgProductsList.Columns[1].Width = 180;
            this.dgProductsList.Columns[2].Width = 156;
            this.dgProductsList.Columns[3].Width = 156;
        }

        private void setFontConf()
        {
            foreach (DataGridViewColumn column in this.dgProductsList.Columns)
            {
                column.DefaultCellStyle.Font = new Font("Segoe UI Light", 11);
                column.HeaderCell.Style.Font = new Font("Segoe UI Light", 12, FontStyle.Bold);
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            foreach (DataGridViewColumn column in this.dgSaleSummary.Columns)
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

        public void populateCustomers (Object list)
        {
            this.cmbCustomer.DataSource = list;
            this.cmbCustomer.ValueMember = "IdCliente";
            this.cmbCustomer.DisplayMember = "Descripcion";
        }

        public void populateStatus(Object list)
        {
            this.cmbStatus.DataSource = list;
            this.cmbStatus.ValueMember = "IdEstado";
            this.cmbStatus.DisplayMember = "Descripcion";
        }

        public void fillUserInputs(Dictionary<Object, dynamic> purchase)
        {

            this.saleHeader = purchase["header"];
            var detail = purchase["detail"];

            this.cmbPaymentTypes.SelectedValue = saleHeader.IdTipoPago;
            this.cmbSaleDate.Value = saleHeader.FechaVenta;
            this.cmbCustomer.SelectedValue = saleHeader.IdCliente;
            this.txtTax.Text = saleHeader.Impuesto.ToString();
            this.txtDiscount.Text = saleHeader.Descuento.ToString();
            this.txtSubtotal.Text = saleHeader.Subtotal.ToString();
            this.txtTotal.Text = saleHeader.Total.ToString();
            this.cmbStatus.SelectedValue = saleHeader.IdEstado;

            foreach (var item in detail)
            {
                dgSaleSummary.Rows.Add(new String[] {
                    Convert.ToString(item.IdVenta),
                    Convert.ToString(item.IdProducto),
                    Convert.ToString(item.Descripcion),
                    Convert.ToString(item.Precio),
                    Convert.ToString(item.Cantidad)
                });
            }

            dgSaleSummary.RowHeadersVisible = false;
            dgSaleSummary.Columns[0].Visible = false;

            this.saleDetail = new DataGridViewRowCollection(this.dgSaleSummary);
            foreach (DataGridViewRow row in dgSaleSummary.Rows)
            {
                DataGridViewRow newRow = (DataGridViewRow)row.Clone();
                newRow.Cells[0].Value = row.Cells[0].Value;
                newRow.Cells[1].Value = row.Cells[1].Value;
                newRow.Cells[2].Value = row.Cells[2].Value;
                newRow.Cells[3].Value = row.Cells[3].Value;
                newRow.Cells[4].Value = row.Cells[4].Value;
                this.saleDetail.Add(newRow);
            }

            this.accessibilityByStatus();

        }

        private void accessibilityByStatus()
        {

            this.enableAllComponents();

            if (!this.cmbStatus.SelectedValue.ToString().Equals(Status.Registered.ToString()))
            {
                this.disableAllComponents();
            }

            if (this.saleHeader.IdEstado == Status.Paid || this.saleHeader.IdEstado == Status.Canceled)
            {
                this.saveChanges.Enabled = false;
            }

            if (this.saleHeader.IdEstado == Status.Paid || this.saleHeader.IdEstado == Status.WaitingForPayment) {
                this.btnPrintBill.Enabled = true;
            }

        }

        private void disableAllComponents()
        {
            this.txtDiscount.Enabled = false;
            this.txtTax.Enabled = false;
            this.cmbPaymentTypes.Enabled = false;
            this.cmbSaleDate.Enabled = false;
            this.cmbCustomer.Enabled = false;
            this.dgProductsList.ReadOnly = true;
            this.dgSaleSummary.ReadOnly = true;
        }

        private void enableAllComponents()
        {
            this.btnPrintBill.Enabled = false;
            this.saveChanges.Enabled = true;
            this.txtDiscount.Enabled = true;
            this.txtTax.Enabled = true;
            this.cmbPaymentTypes.Enabled = true;
            this.cmbSaleDate.Enabled = true;
            this.cmbCustomer.Enabled = true;
            this.dgProductsList.ReadOnly = false;
            this.dgSaleSummary.ReadOnly = false;
        }

        private void txtTax_Enter(object sender, EventArgs e)
        {
            if (!txtTax.Text.Equals(String.Empty) && !txtDiscount.Text.Equals(String.Empty))
            {
                this.sumAllProductPrices();
            }
        }

        private void txtTax_Leave(object sender, EventArgs e)
        {
            if (!txtTax.Text.Equals(String.Empty) && !txtDiscount.Text.Equals(String.Empty))
            {
                this.sumAllProductPrices();
            }
        }

        private void txtDiscount_Enter(object sender, EventArgs e)
        {
            if (!txtTax.Text.Equals(String.Empty) && !txtDiscount.Text.Equals(String.Empty))
            {
                this.sumAllProductPrices();
            }
        }

        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            if (!txtTax.Text.Equals(String.Empty) && !txtDiscount.Text.Equals(String.Empty))
            {
                this.sumAllProductPrices();
            }
        }

        private void dgSaleSummary_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                this.sumAllProductPrices();
            }
        }

        private void txtTax_OnValueChanged(object sender, EventArgs e)
        {
            if (this.txtTax.Text.Equals(String.Empty))
            {
                this.txtTax.Text = 0.ToString();
            }
        }

        private void txtDiscount_OnValueChanged(object sender, EventArgs e)
        {
            if (this.txtTax.Text.Equals(String.Empty))
            {
                this.txtTax.Text = 0.ToString();
            }
        }

        public void catchData() {

            this.data = new Dictionary<Object, dynamic>();

            //Nuevo
            this.data["total"] = Convert.ToDecimal(this.txtTotal.Text);
            this.data["subtotal"] = Convert.ToDecimal(this.txtSubtotal.Text);
            this.data["tax"] = Convert.ToDecimal(this.txtTax.Text);
            this.data["discount"] = Convert.ToDecimal(this.txtDiscount.Text);
            this.data["statusId"] = ((Estado)this.cmbStatus.SelectedItem).IdEstado;
            this.data["customerId"] = ((Cliente)this.cmbCustomer.SelectedItem).IdCliente;
            this.data["paymentMethodId"] = ((TipoPago)this.cmbPaymentTypes.SelectedItem).IdTipoPago;
            this.data["saleDate"] = this.cmbSaleDate.Value.Date;
            this.data["saleDetail"] = this.dgSaleSummary.Rows;

            //Anterior
            this.data["oldSaleHeader"] = this.saleHeader;
            this.data["oldSaleDetail"] = this.saleDetail;

            //Usuario para bitacora
            this.data["user"] = Session.getInstance().session["identification"];

        }



        private void loadDataGridView() {
            ViewSales control = new ViewSales();
            Parent.Controls.Add(control);
            Parent.Controls.RemoveByKey("ModifySale");
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.saleHeader != null)
            {
                switch (this.saleHeader.IdEstado)
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

        private void saveChanges_Click(object sender, EventArgs e)
        {
            this.controller = new SalesController();
            this.catchData();
            this.controller.data = this.data;

            Dictionary<Object, dynamic> result = controller.modifySale();

            if (result["code"] == Result.Processed)
            {
                if (Convert.ToInt32(this.data["statusId"]) == Status.Paid) {

                    this.printBill();

                }
                this.loadDataGridView();
            }

            MessageBox.Show(result["msg"]);
        }

        private void printBill() {

            Dictionary<Object, dynamic> resultBill = this.controller.getBillBySaleId(this.saleHeader.IdVenta);
            if (resultBill["code"] == Result.Failed)
            {
                MessageBox.Show(resultBill["msg"]);
                return;
            }

            this.bill = resultBill["content"];
            this.createDataToPrint();
            this.controller.data = this.data;
            this.controller.createDocument();

        }

        private void createDataToPrint () {

            this.data = new Dictionary<object, dynamic>();
            this.data["name"] = this.bill.Referencia.ToString() + "-" + this.bill.NumImpresion.ToString();
            this.data["reference"] = this.bill.Referencia.ToString();
            this.data["saleDate"] = this.cmbSaleDate.Value.Date;
            this.data["customer"] = ((Cliente)this.cmbCustomer.SelectedItem).Descripcion;
            this.data["paymentMethod"] = ((TipoPago)this.cmbPaymentTypes.SelectedItem).Descripcion;
            this.data["total"] = Convert.ToDecimal(this.txtTotal.Text);
            this.data["subtotal"] = Convert.ToDecimal(this.txtSubtotal.Text);
            this.data["tax"] = Convert.ToDecimal(this.txtTax.Text);
            this.data["discount"] = Convert.ToDecimal(this.txtDiscount.Text);
            this.data["status"] = ((Estado)this.cmbStatus.SelectedItem).Descripcion;
            this.data["saleDetail"] = this.dgSaleSummary.Rows;

        }

        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            this.printBill();
        }

        private void dgProductsList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            string IdProduct = dgProductsList[0, rowIndex].Value.ToString();
            string description = dgProductsList[1, rowIndex].Value.ToString();
            string price = dgProductsList[2, rowIndex].Value.ToString();

            foreach (DataGridViewRow row in dgSaleSummary.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    if (row.Cells[1].Value.Equals(IdProduct))
                    {
                        return;
                    }
                }
            }

            dgSaleSummary.Rows.Add(new String[] {
                this.saleHeader.IdVenta.ToString(),
                IdProduct,
                description,
                price
            });
        }

        private void dgSaleSummary_KeyDown(object sender, KeyEventArgs e)
        {
            if (!this.dgSaleSummary.ReadOnly)
            {
                if (e.KeyData == Keys.Delete)
                {
                    if (this.dgSaleSummary.CurrentRow.Cells[1].Value != null)
                    {
                        this.dgSaleSummary.Rows.Remove(this.dgSaleSummary.CurrentRow);
                        this.sumAllProductPrices();
                    }
                }
            }
        }

        public void sumAllProductPrices()
        {

            this.subtotal = 0;
            this.total = 0;

            foreach (DataGridViewRow product in dgSaleSummary.Rows)
            {

                if (String.IsNullOrEmpty(product.Cells[4].EditedFormattedValue.ToString()))
                {
                    return;
                }

                this.subtotal += (Convert.ToDecimal(product.Cells[3].Value) * Convert.ToInt32(product.Cells[4].EditedFormattedValue));
            }

            this.tax = 0;
            if (Convert.ToDecimal(this.txtTax.Text) != 0)
            {
                this.tax = (this.subtotal * (Convert.ToDecimal(this.txtTax.Text) / 100));
            }

            this.total = this.subtotal + this.tax;

            this.discount = 0;
            if (Convert.ToDecimal(this.txtDiscount.Text) != 0)
            {
                this.discount = (this.total * (Convert.ToDecimal(this.txtDiscount.Text) / 100));
            }

            this.total -= this.discount;

            this.txtSubtotal.Text = this.subtotal.ToString();
            this.txtTotal.Text = this.total.ToString();

        }

    }
}
