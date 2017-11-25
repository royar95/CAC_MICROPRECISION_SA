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
using CACMicropresicion.View.Cients;
using CACMicropresicion.View.States;
using CACMicropresicion.Globals;

namespace CACMicropresicion.View.Main
{
    public partial class ManagamentOptions : UserControl
    {

        Dictionary<Object, dynamic> result;

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
                case "Clients":
                    AddClient addClient = new AddClient();
                    Parent.Controls.Add(addClient);
                    break;

                case "States":
                    AddState addState = new AddState();
                    Parent.Controls.Add(addState);
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
                case "Clients":
                    ModifyClient modifyClient = new ModifyClient();
                    Parent.Controls.Add(modifyClient);
                    break;

                case "States":
                    ModifyState modifyState = new ModifyState();
                    Parent.Controls.Add(modifyState);
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
                case "Clients":
                    DeleteClient deleteClient = new DeleteClient();
                    Parent.Controls.Add(deleteClient);
                    break;

                case "States":
                    DeleteState deleteState = new DeleteState();
                    Parent.Controls.Add(deleteState);
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

                    this.result = userCtrl.getAllUsers();
                    if (this.result["code"] == Result.Failed)
                    {
                        MessageBox.Show(this.result["msg"]);
                        return;
                    }

                    if (this.result["code"] == Result.Processed)
                    {
                        viewUser.loadDataGrid(this.result["content"]);
                        Parent.Controls.Add(viewUser);
                    }

                    break;
                case "Clients":
                    ClientsList clientsList = new ClientsList();
                    Parent.Controls.Add(clientsList);
                    break;

                case "States":

                    ViewStates viewState = new ViewStates();
                    StateController controller = new StateController();

                    viewState.Height = Parent.Height;
                    viewState.Width = Parent.Width;

                    this.result = controller.getAllStates();
                    if (this.result["code"] == Result.Failed)
                    {
                        MessageBox.Show(this.result["msg"]);
                        return;
                    }

                    if (this.result["code"] == Result.Processed)
                    {
                        viewState.loadDataGrid(this.result["content"]);
                        Parent.Controls.Add(viewState);
                    }

                    break;
            }

        }

        private void removeAllManagamentControls()
        {

            Parent.Controls.RemoveByKey("AddUser");
            Parent.Controls.RemoveByKey("AddClient");
            Parent.Controls.RemoveByKey("AddState");
            Parent.Controls.RemoveByKey("ModifyUser");
            Parent.Controls.RemoveByKey("ModifyClient");
            Parent.Controls.RemoveByKey("ModifyState");
            Parent.Controls.RemoveByKey("DeleteUser");
            Parent.Controls.RemoveByKey("DeleteClient");
            Parent.Controls.RemoveByKey("DeleteState");
            Parent.Controls.RemoveByKey("ViewUsers");
            Parent.Controls.RemoveByKey("ClientsList");
            Parent.Controls.RemoveByKey("ViewStates");
            
        }


    }
}
