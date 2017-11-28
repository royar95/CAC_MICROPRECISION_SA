﻿using System;
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

            changeHeadersText();
            setColumnsSize();
            setFontConf();
        }

        private void changeHeadersText () {
            this.dgViewUsers.Columns[0].HeaderText = "Id";
            this.dgViewUsers.Columns[1].HeaderText = "Cédula";
            this.dgViewUsers.Columns[2].HeaderText = "Nombre";
            this.dgViewUsers.Columns[3].HeaderText = "Nombre de Usuario";
            this.dgViewUsers.Columns[4].HeaderText = "Tipo";
            this.dgViewUsers.Columns[5].HeaderText = "Estado";
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

            String searchValue = btnIdSearch.text.TrimStart().TrimEnd();

            foreach (DataGridViewRow row in dgViewUsers.Rows)
            {
                row.Visible = true;
                if (!searchValue.Equals(String.Empty))
                {
                    if (!row.Cells[1].Value.ToString().Equals(searchValue))
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
