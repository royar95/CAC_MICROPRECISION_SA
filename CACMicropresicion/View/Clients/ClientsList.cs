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
using CACMicropresicion.Globals;
using CACMicropresicion.Model;

namespace CACMicropresicion.View.Cients
{
    public partial class ClientsList : UserControl
    {
        ClientsController controller;
        public ClientsList()
        {
            InitializeComponent();
            this.Location = new Point(235, 94);
            this.Anchor = AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top;
        }

        public void loadDataGrid(Object list)
        {
            this.dataGridViewClients.DataSource = list;

            CurrencyManager cm = (CurrencyManager)BindingContext[dataGridViewClients.DataSource];
            cm.SuspendBinding();

            dataGridViewClients.RowHeadersVisible = false;
            dataGridViewClients.Columns[0].Visible = false;

            setColumnsSize();
            setFontConf();
        }


        private void setColumnsSize()
        {
            this.dataGridViewClients.Columns[0].Width = 80;
            this.dataGridViewClients.Columns[1].Width = 350;
            this.dataGridViewClients.Columns[2].Width = 180;
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

        private void dataGridViewClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.controller = new ClientsController();
            int rowIndex = e.RowIndex;
            int IdClient = -1;

            DataGridViewRow rowToModify = dataGridViewClients.Rows[rowIndex];
            IdClient = Int32.Parse(rowToModify.Cells[0].Value.ToString());

            Dictionary<Object, dynamic> result = controller.getClientById(IdClient);

            if (result["code"] == Result.Failed)
            {
                MessageBox.Show(result["msg"]);
            }

            if (result["code"] == Result.Processed)
            {
                Cliente clientToModify = result["content"];
                showsClientModifyControl(clientToModify);
            }
        }

        private void showsClientModifyControl (Cliente clientToModify)
        {

            ModifyClient control = new ModifyClient();
            control.fillUserInputs(clientToModify);
            Parent.Controls.Add(control);
            Parent.Controls.RemoveByKey("ClientsList");
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            String searchValue = txtSearch.text.TrimStart().TrimEnd();
            this.dataGridViewClients.CurrentCell = null;

            foreach (DataGridViewRow row in dataGridViewClients.Rows)
            {
                row.Visible = true;

                if (!searchValue.Equals(String.Empty))
                {
                    if (!row.Cells[1].Value.ToString().Contains(searchValue))
                    {
                        row.Visible = false;
                    }
                }
            }
        }


    }
}
