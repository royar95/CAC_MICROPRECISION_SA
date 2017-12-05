using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CACMicropresicion.Controller;
using CACMicropresicion.Globals;
using CACMicropresicion.View.Purchases;

namespace CACMicropresicion.View.Purchases
{
    public partial class ViewPurchases : UserControl
    {

        private PurchaseController controller;

        public ViewPurchases()
        {
            InitializeComponent();
            this.Location = new Point(235, 97);
            this.Anchor = AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top;
        }

        private void purchaseDate_onValueChanged(object sender, EventArgs e)
        {
            this.controller = new PurchaseController();

            DateTime date = purchaseDate.Value.Date;
            Dictionary<Object, dynamic> result = this.controller.getPurchasesByDate(date);

            if (result["code"] == Result.Failed) {
                MessageBox.Show(result["msg"]);
                return;
            }

            this.populateDataGrid(result["content"]);

        }

        private void populateDataGrid(Object list) {
            this.dgPurchases.DataSource = list;
            dgPurchases.RowHeadersVisible = false;
            dgPurchases.Columns[0].Visible = false;
            this.setColumnsSize();
            this.setFontConf();
        }

        private void setColumnsSize()
        {
            this.dgPurchases.Columns[1].Width = 120;
            this.dgPurchases.Columns[2].Width = 120;
            this.dgPurchases.Columns[3].Width = 120;
            this.dgPurchases.Columns[4].Width = 250;
            this.dgPurchases.Columns[5].Width = 120;
            this.dgPurchases.Columns[6].Width = 200;
        }

        private void setFontConf()
        {
            foreach (DataGridViewColumn column in this.dgPurchases.Columns)
            {
                column.DefaultCellStyle.Font = new Font("Segoe UI Light", 11);
                column.HeaderCell.Style.Font = new Font("Segoe UI Light", 12, FontStyle.Bold);
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void dgPurchases_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.controller = new PurchaseController();
            int rowIndex = e.RowIndex;
            int IdPurchase = -1;

            DataGridViewRow rowToModify = dgPurchases.Rows[rowIndex];
            IdPurchase = Int32.Parse(rowToModify.Cells[0].Value.ToString());

            Dictionary<Object, dynamic> result = controller.getPurchaseById(IdPurchase);

            if (result["code"] == Result.Failed)
            {
                MessageBox.Show(result["msg"]);
            }

            if (result["code"] == Result.Processed)
            {
                showPurchaseModifyControl(result["content"]);
            }
        }

        private void showPurchaseModifyControl (Dictionary<Object, dynamic> purchase)
        {

            ModifyPurchase control = new ModifyPurchase();
            control.fillUserInputs(purchase);
            Parent.Controls.Add(control);
            Parent.Controls.RemoveByKey("ViewPurchases");
        }
    }
}
