using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CACMicropresicion.View.States
{
    public partial class ViewStates : UserControl
    {
        public ViewStates()
        {
            InitializeComponent();
            this.Location = new Point(235, 97);
            this.Anchor = AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top;
        }


        public void loadDataGrid(Object list)
        {
            this.dgViewStates.DataSource = list;
            changeHeadersText();
            setColumnsSize();
            setFontConf();
        }

        private void changeHeadersText()
        {
            this.dgViewStates.Columns[0].HeaderText = "Codigo";
            this.dgViewStates.Columns[1].HeaderText = "Descripcion";
        }

        private void setColumnsSize()
        {
            this.dgViewStates.Columns[0].Width = 100;
            this.dgViewStates.Columns[1].Width = 250;
        }

        private void setFontConf()
        {
            foreach (DataGridViewColumn column in this.dgViewStates.Columns)
            {
                column.DefaultCellStyle.Font = new Font("Segoe UI Light", 11);
                column.HeaderCell.Style.Font = new Font("Segoe UI Light", 12, FontStyle.Bold);
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

    }
}
