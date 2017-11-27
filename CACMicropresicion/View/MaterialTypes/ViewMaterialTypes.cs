using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CACMicropresicion.View.MaterialTypes
{
    public partial class ViewMaterialTypes : UserControl
    {
        public ViewMaterialTypes()
        {
            InitializeComponent();
            this.Location = new Point(235, 97);
            this.Anchor = AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top;
        }

        private void changeHeadersText()
        {
            this.dgViewMaterialTypes.Columns[0].HeaderText = "Codigo";
            this.dgViewMaterialTypes.Columns[1].HeaderText = "Descripcion";
        }

        private void setColumnsSize()
        {
            this.dgViewMaterialTypes.Columns[0].Width = 350;
            this.dgViewMaterialTypes.Columns[1].Width = 350;
        }

        private void setFontConf()
        {
            foreach (DataGridViewColumn column in this.dgViewMaterialTypes.Columns)
            {
                column.DefaultCellStyle.Font = new Font("Segoe UI Light", 11);
                column.HeaderCell.Style.Font = new Font("Segoe UI Light", 12, FontStyle.Bold);
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        public void loadDataGrid(Object list)
        {
            this.dgViewMaterialTypes.DataSource = list;
            changeHeadersText();
            setColumnsSize();
            setFontConf();
        }
    }
}
