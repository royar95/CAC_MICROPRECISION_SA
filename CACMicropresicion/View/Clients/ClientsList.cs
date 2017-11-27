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

namespace CACMicropresicion.View.Cients
{
    public partial class ClientsList : UserControl
    {
        ClientsController controller = new ClientsController();
        public ClientsList()
        {
            InitializeComponent();
            this.Location = new Point(235, 94);
            this.Anchor = AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top;
        }

        public void loadDataGrid(Object list)
        {
            this.dataGridViewClients.DataSource = list;
            changeHeadersText();
            setColumnsSize();
            setFontConf();
        }

        private void changeHeadersText()
        {
            this.dataGridViewClients.Columns[0].HeaderText = "Código";
            this.dataGridViewClients.Columns[1].HeaderText = "Descripcion";
            this.dataGridViewClients.Columns[2].HeaderText = "Estado";
            this.dataGridViewClients.Columns[3].HeaderText = "Eliminado";
        }

        private void setColumnsSize()
        {
            this.dataGridViewClients.Columns[0].Width = 170;
            this.dataGridViewClients.Columns[1].Width = 250;
            this.dataGridViewClients.Columns[2].Width = 180;
            this.dataGridViewClients.Columns[3].Width = 170;
        }

        private void setFontConf()
        {
            foreach (DataGridViewColumn column in this.dataGridViewClients.Columns)
            {
                column.DefaultCellStyle.Font = new Font("Segoe UI Light", 11);
                column.HeaderCell.Style.Font = new Font("Segoe UI Light", 12, FontStyle.Bold);
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }


    }
}
