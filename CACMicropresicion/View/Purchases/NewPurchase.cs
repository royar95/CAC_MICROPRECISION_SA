using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CACMicropresicion.Model;

namespace CACMicropresicion.View.Sales
{
    public partial class NewPurchase : UserControl
    {

        private Dictionary<Object, dynamic> data;
        private TipoPago paymentMethod;
        private DateTime purchaseDate;
        private decimal total;
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
            dgMaterialsList.CurrentCell = null;
            String searchValue = txtSearch.text.TrimStart().TrimEnd();
            int valueLength = searchValue.Length;

            foreach (DataGridViewRow row in dgMaterialsList.Rows)
            {
                
                row.Visible = true;

                if (!searchValue.Equals(String.Empty))
                {
                    if (valueLength > row.Cells[1].Value.ToString().Length)
                    {
                        row.Visible = false;
                        continue;
                    }

                    string cellValue = row.Cells[1].Value.ToString().Substring(0, valueLength);

                    if (!cellValue.Equals(searchValue))
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

            this.paymentMethod = (TipoPago)this.cmbPaymentTypes.SelectedItem;
            this.purchaseDate = cmbPurchaseDate.Value;
            this.total = Decimal.Parse(txtTotal.Text.TrimStart().TrimEnd());
            this.items = this.dgPurchaseSummary.DataSource;

        }

        private void modBtnSaveUserChanges_Click(object sender, EventArgs e)
        {
            this.catchData();
        }

    }
}
