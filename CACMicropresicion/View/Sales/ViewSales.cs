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

namespace CACMicropresicion.View.Sales
{
    public partial class ViewSales : UserControl
    {

        private SalesController controller;

        public ViewSales()
        {
            InitializeComponent();
            this.Location = new Point(235, 97);
            this.Anchor = AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top;
        }

        private void salesDate_onValueChanged(object sender, EventArgs e)
        {
            this.controller = new SalesController();

            DateTime date = salesDate.Value.Date;
            Dictionary<Object, dynamic> result = this.controller.getSalesByDate(date);

            if (result["code"] == Result.Failed)
            {
                MessageBox.Show(result["msg"]);
                return;
            }

            this.populateDataGrid(result["content"]);
        }

        private void populateDataGrid(Object list)
        {
            this.dgSales.DataSource = list;
            dgSales.RowHeadersVisible = false;
            dgSales.Columns[0].Visible = false;
            this.setColumnsSize();
            this.setFontConf();
        }

        private void setColumnsSize()
        {
            this.dgSales.Columns[1].Width = 120;
            this.dgSales.Columns[2].Width = 200;
            this.dgSales.Columns[3].Width = 120;
            this.dgSales.Columns[4].Width = 120;
            this.dgSales.Columns[5].Width = 200;
            this.dgSales.Columns[6].Width = 120;
            this.dgSales.Columns[6].Width = 140;
        }

        private void setFontConf()
        {
            foreach (DataGridViewColumn column in this.dgSales.Columns)
            {
                column.DefaultCellStyle.Font = new Font("Segoe UI Light", 11);
                column.HeaderCell.Style.Font = new Font("Segoe UI Light", 12, FontStyle.Bold);
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void dgSales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.controller = new SalesController ();
            int rowIndex = e.RowIndex;
            int IdPurchase = -1;

            DataGridViewRow rowToModify = dgSales.Rows[rowIndex];
            IdPurchase = Int32.Parse(rowToModify.Cells[0].Value.ToString());

            Dictionary<Object, dynamic> result = controller.getSaleById(IdPurchase);

            if (result["code"] == Result.Failed)
            {
                MessageBox.Show(result["msg"]);
            }

            if (result["code"] == Result.Processed)
            {
                showSaleModifyControl(result["content"]);
            }
        }

        private void showSaleModifyControl (Dictionary<Object, dynamic> purchase)
        {

            ModifySale control = new ModifySale();
            control.fillUserInputs(purchase);
            Parent.Controls.Add(control);
            Parent.Controls.RemoveByKey("ViewSales");
        }

    }
}
