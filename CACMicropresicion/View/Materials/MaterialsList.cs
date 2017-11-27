using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CACMicropresicion.View.Materials
{
    public partial class MaterialsList : UserControl
    {
        public MaterialsList()
        {
            InitializeComponent();
            this.Location = new Point(235, 97);
            this.Anchor = AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top;
        }

        public void loadDataGrid(Object list)
        {
            this.dgMaterials.DataSource = list;
            changeHeadersText();
            setColumnsSize();
            setFontConf();
        }

        private void changeHeadersText()
        {
            this.dgMaterials.Columns[0].HeaderText = "Descripción";
            this.dgMaterials.Columns[1].HeaderText = "Estado";
        }

        private void setColumnsSize()
        {
            this.dgMaterials.Columns[0].Width = 350;
            this.dgMaterials.Columns[1].Width = 150;
        }

        private void setFontConf()
        {
            foreach (DataGridViewColumn column in this.dgMaterials.Columns)
            {
                column.DefaultCellStyle.Font = new Font("Segoe UI Light", 11);
                column.HeaderCell.Style.Font = new Font("Segoe UI Light", 12, FontStyle.Bold);
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

    }
}
