using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CACMicropresicion.View.Sales
{
    public partial class NewSale : UserControl
    {
        public NewSale()
        {
            InitializeComponent();
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
            this.dgMaterialsList.Columns[1].Width = 220;
            this.dgMaterialsList.Columns[2].Width = 188;
            this.dgMaterialsList.Columns[2].Width = 188;
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
        }

        public void populatePaymentTypes(Object list) {
            this.cmbPaymentTypes.DataSource = list;
            this.cmbPaymentTypes.DisplayMember = "Descripcion";
        }

    }
}
