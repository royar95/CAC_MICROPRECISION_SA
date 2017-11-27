using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CACMicropresicion.View.ProductTypes
{
    public partial class ViewProductTypes : UserControl
    {
        public ViewProductTypes()
        {
            InitializeComponent();
            this.Location = new Point(235, 97);
        }

        public void loadDataGrid(Object list)
        {
            this.dgViewProductTypes.DataSource = list;
            changeHeadersText();
            setColumnsSize();
            setFontConf();
        }

        private void changeHeadersText()
        {
            this.dgViewProductTypes.Columns[0].HeaderText = "Id de Categoría";
            this.dgViewProductTypes.Columns[1].HeaderText = "Descripción";
            this.dgViewProductTypes.Columns[2].HeaderText = "Estado";
            this.dgViewProductTypes.Columns[3].HeaderText = "Eliminado";
            
        }

        private void setColumnsSize()
        {
            this.dgViewProductTypes.Columns[0].Width = 150;
            this.dgViewProductTypes.Columns[1].Width = 150;
            this.dgViewProductTypes.Columns[2].Width = 150;
            this.dgViewProductTypes.Columns[3].Width = 150;
            
        }

        private void setFontConf()
        {
            foreach (DataGridViewColumn column in this.dgViewProductTypes.Columns)
            {
                column.DefaultCellStyle.Font = new Font("Segoe UI Light", 11);
                column.HeaderCell.Style.Font = new Font("Segoe UI Light", 12, FontStyle.Bold);
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
    }
}
