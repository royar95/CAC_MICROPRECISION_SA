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

namespace CACMicropresicion.View.Users
{
    public partial class ViewUsers : UserControl
    {

        private UserCtrl controller;

        public ViewUsers()
        {
            InitializeComponent();
            this.Location = new Point(235, 97);
            this.Anchor = AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top;
        }

        public void loadDataGrid (Object list) {

            this.dgViewUsers.DataSource = list;
            CurrencyManager cm = (CurrencyManager)BindingContext[dgViewUsers.DataSource];
            cm.SuspendBinding();

            dgViewUsers.RowHeadersVisible = false;
            dgViewUsers.Columns[0].Visible = false;

            setColumnsSize();
            setFontConf();
        }

        private void setColumnsSize () {
            this.dgViewUsers.Columns[0].Width = 100;
            this.dgViewUsers.Columns[1].Width = 120;
            this.dgViewUsers.Columns[2].Width = 250;
            this.dgViewUsers.Columns[3].Width = 220;
            this.dgViewUsers.Columns[4].Width = 120;
            this.dgViewUsers.Columns[5].Width = 100;
        }

        private void setFontConf() { 
            foreach (DataGridViewColumn column in this.dgViewUsers.Columns) {
                column.DefaultCellStyle.Font = new Font("Segoe UI Light", 11);
                column.HeaderCell.Style.Font = new Font("Segoe UI Light", 12, FontStyle.Bold);
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void btnIdSearch_OnTextChange(object sender, EventArgs e)
        {

            String searchValue = txtSearch.text.TrimStart().TrimEnd();
            int valueLength = searchValue.Length;

            foreach (DataGridViewRow row in dgViewUsers.Rows)
            {
                row.Visible = true;

                if (!searchValue.Equals(String.Empty))
                {
                    if (valueLength > row.Cells[1].Value.ToString().Length)
                    {
                        row.Visible = false;
                        continue;
                    }

                    string cellValue = row.Cells[1].Value.ToString().Substring(0, valueLength);

                    if (!cellValue.Equals(searchValue))
                    {
                        row.Visible = false;
                    }
                }
            }

        }

        private void dgViewUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.controller = new UserCtrl();
            int rowIndex = e.RowIndex;
            int IdUser = -1;

            DataGridViewRow rowToModify = dgViewUsers.Rows[rowIndex];
            IdUser = Int32.Parse(rowToModify.Cells[0].Value.ToString());

            Dictionary<Object, dynamic> result = controller.getUserById(IdUser);

            if (result["code"] == Result.Failed) {
                MessageBox.Show(result["msg"]);
            }

            if (result["code"] == Result.Processed) {
                Usuario userToModify = result["content"];
                showsUserModifyControl(userToModify);
            }

        }

        private void showsUserModifyControl(Usuario userToModify) {

            ModifyUser control = new ModifyUser();
            control.fillUserInputs(userToModify);
            Parent.Controls.Add(control);
            Parent.Controls.RemoveByKey("ViewUsers");
        }

    }
}
