using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CACMicropresicion.Globals;
using CACMicropresicion.Controller;
using CACMicropresicion.Model;

namespace CACMicropresicion.View.Purchases
{
    public partial class NewPurchase : UserControl
    {

        private PurchaseController controller;
        private Dictionary<Object, dynamic> data;
        private int paymentMethod;
        private DateTime purchaseDate;
        private string total;
        private Object items;

        public NewPurchase()
        {
            InitializeComponent();
            dgPurchaseSummary.RowHeadersVisible = false;
            dgPurchaseSummary.Columns[0].Visible = false;
            this.Location = new Point(235, 97);
        }

        public void populateMaterialList(Object list) {

            this.dgMaterialsList.DataSource = list;

            CurrencyManager cm = (CurrencyManager)BindingContext[dgMaterialsList.DataSource];
            cm.SuspendBinding();

            dgMaterialsList.RowHeadersVisible = false;
            dgMaterialsList.Columns[0].Visible = false;

            setMaterialListColumnSize();
            setFontConf();

        }

        private void setMaterialListColumnSize ()
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

        public void populatePaymentTypes(Object list) {
            this.cmbPaymentTypes.DataSource = list;
            this.cmbPaymentTypes.DisplayMember = "Descripcion";
        }

        private void dgMaterialsList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            string code = dgMaterialsList[0, rowIndex].Value.ToString();
            string description = dgMaterialsList[1, rowIndex].Value.ToString();

            foreach (DataGridViewRow row in dgPurchaseSummary.Rows) {
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

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            String searchValue = txtSearch.text.TrimStart().TrimEnd();
            this.dgMaterialsList.CurrentCell = null;

            foreach (DataGridViewRow row in dgMaterialsList.Rows)
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

        private void dgPurchaseSummary_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete) {
                if (this.dgPurchaseSummary.CurrentRow.Cells[1].Value != null)
                {
                    this.dgPurchaseSummary.Rows.Remove(this.dgPurchaseSummary.CurrentRow);
                }
            }
        }

        private void catchData() {

            this.data = new Dictionary<object, dynamic>();

            this.paymentMethod = ((TipoPago)this.cmbPaymentTypes.SelectedItem).IdTipoPago;
            this.purchaseDate = cmbPurchaseDate.Value;
            this.total = txtTotal.Text.TrimStart().TrimEnd();
            this.items = this.dgPurchaseSummary.Rows;
            int userId = Session.getInstance().session["id"];
            string identification = Session.getInstance().session["identification"];
            int status = Status.Registered;

            this.data["paymentMethod"] = this.paymentMethod;
            this.data["date"] = this.purchaseDate;
            this.data["total"] = this.total;
            this.data["userId"] = userId;
            this.data["user"] = identification;
            this.data["status"] = status;
            this.data["purchaseDetail"] = this.items;

        }

        private void modBtnSaveUserChanges_Click(object sender, EventArgs e)
        {
            this.controller = new PurchaseController();

            this.catchData();
            this.controller.data = this.data;

            Dictionary<Object, dynamic> result = this.controller.insertNewPurchase();
            MessageBox.Show(result["msg"]);

        }

    }
}
