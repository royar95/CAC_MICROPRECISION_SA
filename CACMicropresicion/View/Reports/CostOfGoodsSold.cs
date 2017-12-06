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
    public partial class CostOfGoodsSold : UserControl
    {
        CostsController ctrl;
        double total = 0;
        public CostOfGoodsSold()
        {
            InitializeComponent();
            this.Location = new Point(237, 94);
            this.Anchor = AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top;
        }

        public void loadDataGrid(Object list)
        {
            this.dgCosts.DataSource = list;
            dgCosts.RowHeadersVisible = false;
            changeHeadersText();
            setColumnsSize();
            setFontConf();
            loadTotalSales(dgCosts);
        }

        public void loadTotalSales(DataGridView list)
        {

            foreach (DataGridViewRow row in list.Rows)
            {
                total += Convert.ToDouble(row.Cells[2].Value);
            }

            txtTotal.Text = total + "";
        }

        private void changeHeadersText()
        {
            this.dgCosts.Columns[0].HeaderText = "Fecha de compra";
            this.dgCosts.Columns[1].HeaderText = "Id Compra";
            this.dgCosts.Columns[2].HeaderText = "Total";
        }

        private void setColumnsSize()
        {
            this.dgCosts.Columns[0].Width = 250;
            this.dgCosts.Columns[1].Width = 250;
            this.dgCosts.Columns[2].Width = 250;    
        }

        private void setFontConf()
        {
            foreach (DataGridViewColumn column in this.dgCosts.Columns)
            {
                column.DefaultCellStyle.Font = new Font("Segoe UI Light", 11);
                column.HeaderCell.Style.Font = new Font("Segoe UI Light", 12, FontStyle.Bold);
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            this.ctrl = new CostsController();
            ctrl.ExportToExcel(dgCosts);
        }
    }
}
