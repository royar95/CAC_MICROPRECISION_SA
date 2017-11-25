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
using CACMicropresicion.View.Users;
using CACMicropresicion.Globals;

namespace CACMicropresicion.View.Main
{
    public partial class ManagamentOptions : UserControl
    {
        public ManagamentOptions()
        {
            InitializeComponent();
            this.Location = new Point(235, 50);
        }

        public string Mantenimiento { get; set; }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            removeAllManagamentControls();

            switch (this.Mantenimiento) {
                case "Users":
                    AddUser addUser = new AddUser();
                    Parent.Controls.Add(addUser);
                    break;
            }

        }

        public void btnModify_Click(object sender, EventArgs e)
        {
            removeAllManagamentControls();

            switch (this.Mantenimiento)
            {
                case "Users":

                    ModifyUser modifyUser = new ModifyUser();
                    Parent.Controls.Add(modifyUser);
                    break;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            removeAllManagamentControls();

            switch (this.Mantenimiento)
            {
                case "Users":
                    DeleteUser deleteUser = new DeleteUser();
                    Parent.Controls.Add(deleteUser);
                    break;
            }
        }


        private void btnList_Click(object sender, EventArgs e)
        {
            removeAllManagamentControls();

            switch (this.Mantenimiento)
            {
                case "Users":

                    ViewUsers viewUser = new ViewUsers();
                    UserCtrl userCtrl = new UserCtrl();

                    viewUser.Height = Parent.Height;
                    viewUser.Width = Parent.Width;

                    Dictionary<Object, dynamic> result = userCtrl.getAllUsers();
                    if (result["code"] == Result.Failed) {
                        MessageBox.Show(result["msg"]);
                        return;
                    }

                    if (result["code"] == Result.Processed)
                    {
                        viewUser.loadDataGrid(result["content"]);
                        Parent.Controls.Add(viewUser);
                    }

                    break;
            }

        }

        private void removeAllManagamentControls()
        {
            Parent.Controls.RemoveByKey("AddUser");
            Parent.Controls.RemoveByKey("ModifyUser");
            Parent.Controls.RemoveByKey("DeleteUser");
            Parent.Controls.RemoveByKey("ViewUsers");
        }


    }
}
