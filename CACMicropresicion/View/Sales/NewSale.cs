using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CACMicropresicion.Controller;
using CACMicropresicion.Globals;
using CACMicropresicion.Model;

namespace CACMicropresicion.View.Sales
{
    public partial class NewSale : UserControl
    {

        private decimal total, subtotal, tax, discount;
        private Dictionary<Object, dynamic> data;
        private SalesController controller;

        public NewSale()
        {
            InitializeComponent();
            this.dgSaleSummary.RowHeadersVisible = false;
            this.dgSaleSummary.Columns[0].Visible = false;
            this.Location = new Point(235, 97);
            this.total = 0;
            this.subtotal = 0;
            this.tax = 0;
            this.discount = 0;
        }

        public void populateProducts(Object list)
        {

            this.dgProductsList.DataSource = list;

            CurrencyManager cm = (CurrencyManager)BindingContext[dgProductsList.DataSource];
            cm.SuspendBinding();

            dgProductsList.RowHeadersVisible = false;
            dgProductsList.Columns[0].Visible = false;

            setProductListColumnSize();
            setFontConf();

        }

        private void setProductListColumnSize()
        {
            this.dgProductsList.Columns[0].Width = 80;
            this.dgProductsList.Columns[1].Width = 180;
            this.dgProductsList.Columns[2].Width = 100;
            this.dgProductsList.Columns[3].Width = 80;
            this.dgProductsList.Columns[4].Width = 160;

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
            this.cmbPaymentTypes.DisplayMember = "IdTipoPago";
            this.cmbPaymentTypes.DisplayMember = "Descripcion";
        }

        public void populateCustomerList (Object list)
        {
            this.cmbCustomer.DataSource = list;
            this.cmbPaymentTypes.DisplayMember = "IdCliente";
            this.cmbCustomer.DisplayMember = "Descripcion";
        }

        private void dgSaleSummary_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3) {
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

        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            if (!txtTax.Text.Equals(String.Empty) && !txtDiscount.Text.Equals(String.Empty))
            {
                this.sumAllProductPrices();
            }
        }

        private void txtTax_Enter(object sender, EventArgs e)
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

        private void txtTax_OnValueChanged(object sender, EventArgs e)
        {
            if (this.txtTax.Text.Equals(String.Empty)) {
                this.txtTax.Text = 0.ToString();
            }
        }

        private void txtDiscount_OnValueChanged(object sender, EventArgs e)
        {
            if (this.txtDiscount.Text.Equals(String.Empty))
            {
                this.txtDiscount.Text = 0.ToString();
            }
        }

        private void catchData() {

            this.data = new Dictionary<Object, dynamic>();
            this.data["userId"] = Session.getInstance().session["id"];
            this.data["total"] = Convert.ToDecimal(this.txtTotal.Text);
            this.data["subtotal"] = Convert.ToDecimal(this.txtSubtotal.Text);
            this.data["tax"] = Convert.ToDecimal(this.txtTax.Text);
            this.data["discount"] = Convert.ToDecimal(this.txtDiscount.Text);
            this.data["dateAdded"] = DateTime.Now;
            this.data["dateDeleted"] = null;
            this.data["deleted"] = (byte)0;
            this.data["statusId"] = Status.Registered;
            this.data["customerId"] = ((Cliente)this.cmbCustomer.SelectedItem).IdCliente;
            this.data["paymentMethodId"] = ((TipoPago)this.cmbPaymentTypes.SelectedItem).IdTipoPago;
            this.data["saleDate"] = this.cmbSaleDate.Value.Date;
            this.data["saleDetail"] = this.dgSaleSummary.Rows;
            this.data["user"] = Session.getInstance().session["identification"];
        }

        private void saveSale_Click(object sender, EventArgs e)
        {
            this.controller = new SalesController();
            this.catchData();
            this.controller.data = this.data;

            Dictionary<Object, dynamic> result = this.controller.insertNewSale();
            MessageBox.Show(result["msg"]);

        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            String searchValue = txtSearch.text.TrimStart().TrimEnd();
            this.dgProductsList.CurrentCell = null;

            foreach (DataGridViewRow row in dgProductsList.Rows)
            {
                row.Visible = true;

                if (!searchValue.Equals(String.Empty))
                {
                    if (!row.Cells[1].Value.ToString().Contains(searchValue))
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void dgProductsList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            string code = dgProductsList[0, rowIndex].Value.ToString();
            string description = dgProductsList[1, rowIndex].Value.ToString();
            string price = dgProductsList[2, rowIndex].Value.ToString();

            foreach (DataGridViewRow row in dgSaleSummary.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    if (row.Cells[0].Value.Equals(code))
                    {
                        return;
                    }
                }
            }

            dgSaleSummary.Rows.Add(new String[] {
                code,
                description,
                price
            });

        }

        public void sumAllProductPrices() {

            this.subtotal = 0;
            this.total = 0;

            foreach (DataGridViewRow product in dgSaleSummary.Rows) {

                if (String.IsNullOrEmpty(product.Cells[3].EditedFormattedValue.ToString())) {
                    return;
                }

                this.subtotal += (Convert.ToDecimal(product.Cells[2].Value) * Convert.ToInt32(product.Cells[3].EditedFormattedValue));
            }

            this.tax = 0;
            if (Convert.ToDecimal(this.txtTax.Text) != 0) {
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
