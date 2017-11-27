using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CACMicropresicion.View.Products
{
    public partial class ViewProducts : UserControl
    {
        public ViewProducts()
        {
            InitializeComponent();
            this.Location = new Point(235, 97);
        }

        public void loadDataGrid(Object list)
        {
            this.dtViewProducts.DataSource = list;
            changeHeadersText();
            setColumnsSize();
            setFontConf();
        }

        private void changeHeadersText()
        {
            this.dtViewProducts.Columns[0].HeaderText = "Id de Producto";
            this.dtViewProducts.Columns[1].HeaderText = "Categoría";
            this.dtViewProducts.Columns[2].HeaderText = "Descripción";
            this.dtViewProducts.Columns[3].HeaderText = "Precio";
            this.dtViewProducts.Columns[4].HeaderText = "Cantidad";
            this.dtViewProducts.Columns[5].HeaderText = "Estado";
            this.dtViewProducts.Columns[6].HeaderText = "Eliminado";

        }

        private void setColumnsSize()
        {
            this.dtViewProducts.Columns[0].Width = 100;
            this.dtViewProducts.Columns[1].Width = 100;
            this.dtViewProducts.Columns[2].Width = 100;
            this.dtViewProducts.Columns[3].Width = 100;
            this.dtViewProducts.Columns[4].Width = 100;
            this.dtViewProducts.Columns[5].Width = 100;
            this.dtViewProducts.Columns[6].Width = 100;

        }

        private void setFontConf()
        {
            foreach (DataGridViewColumn column in this.dtViewProducts.Columns)
            {
                column.DefaultCellStyle.Font = new Font("Segoe UI Light", 11);
                column.HeaderCell.Style.Font = new Font("Segoe UI Light", 12, FontStyle.Bold);
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
    }
}
