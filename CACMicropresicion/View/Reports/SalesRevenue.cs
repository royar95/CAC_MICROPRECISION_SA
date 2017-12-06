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

namespace CACMicropresicion.View.Reports
{
    public partial class SalesRevenue : UserControl
    {

        double total = 0;
        string a;
        char pad = '0';
        SalesRevenueController ctrl = new SalesRevenueController();

        public SalesRevenue()
        {
            InitializeComponent();
            this.Location = new Point(237, 94);
            this.Anchor = AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top;
        }

        public void loadDataGrid(Object list)
        {
            this.dgSalesRevenue.DataSource = list;
            changeHeadersText();
            setFontConf();
            loadTotalSales(dgSalesRevenue);
        }

        public void loadTotalSales(DataGridView list) {           
            foreach (DataGridViewRow row in list.Rows)
            {
                total += Convert.ToDouble(row.Cells[5].Value);
                
            }
            txtTotal.Text = total +"";
        }

        private void changeHeadersText()
        {
            this.dgSalesRevenue.Columns[0].HeaderText = "Fecha";
            this.dgSalesRevenue.Columns[1].HeaderText = "Código";
            this.dgSalesRevenue.Columns[2].HeaderText = "Impuestos";
            this.dgSalesRevenue.Columns[3].HeaderText = "Descuento";
            this.dgSalesRevenue.Columns[4].HeaderText = "Subtotal";
            this.dgSalesRevenue.Columns[5].HeaderText = "Total";
        }

        private void setColumnsSize()
        {
            this.dgSalesRevenue.Columns[0].Width = 200;
            this.dgSalesRevenue.Columns[1].Width = 200;
            this.dgSalesRevenue.Columns[2].Width = 200;
            this.dgSalesRevenue.Columns[3].Width = 200;
            this.dgSalesRevenue.Columns[4].Width = 200;
            this.dgSalesRevenue.Columns[5].Width = 200;
        }

        private void setFontConf()
        {
            foreach (DataGridViewColumn column in this.dgSalesRevenue.Columns)
            {
                column.DefaultCellStyle.Font = new Font("Segoe UI Light", 11);
                column.HeaderCell.Style.Font = new Font("Segoe UI Light", 12, FontStyle.Bold);
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ctrl = new SalesRevenueController();
            ctrl.ExportToExcel(dgSalesRevenue);
        }
    }
}
