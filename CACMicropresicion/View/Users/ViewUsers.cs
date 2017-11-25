using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CACMicropresicion.Model;

namespace CACMicropresicion.View.Users
{
    public partial class ViewUsers : UserControl
    {

        public ViewUsers()
        {
            InitializeComponent();
            this.Location = new Point(235, 97);
            this.Anchor = AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top;
        }

        public void loadDataGrid (Object list) {
            this.dgViewUsers.DataSource = list;
            changeHeadersText();
            setColumnsSize();
            setFontConf();
        }

        private void changeHeadersText () {
            this.dgViewUsers.Columns[0].HeaderText = "Cédula";
            this.dgViewUsers.Columns[1].HeaderText = "Nombre";
            this.dgViewUsers.Columns[2].HeaderText = "Nombre de Usuario";
            this.dgViewUsers.Columns[3].HeaderText = "Tipo";
            this.dgViewUsers.Columns[4].HeaderText = "Estado";
            this.dgViewUsers.Columns[5].HeaderText = "Eliminado";
        }

        private void setColumnsSize () {
            this.dgViewUsers.Columns[0].Width = 170;
            this.dgViewUsers.Columns[1].Width = 250;
            this.dgViewUsers.Columns[2].Width = 180;
            this.dgViewUsers.Columns[3].Width = 170;
            this.dgViewUsers.Columns[4].Width = 140;
            this.dgViewUsers.Columns[5].Width = 140;
        }

        private void setFontConf() { 
            foreach (DataGridViewColumn column in this.dgViewUsers.Columns) {
                column.DefaultCellStyle.Font = new Font("Segoe UI Light", 11);
                column.HeaderCell.Style.Font = new Font("Segoe UI Light", 12, FontStyle.Bold);
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

    }
}
