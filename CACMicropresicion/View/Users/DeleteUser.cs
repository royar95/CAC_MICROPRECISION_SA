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
using CACMicropresicion.Model;
using CACMicropresicion.Globals;

namespace CACMicropresicion.View.Users
{
    public partial class DeleteUser : UserControl
    {

        private Dictionary<Object, dynamic> data;
        private UserCtrl userControl;
        private Usuario registeredUser;

        public DeleteUser()
        {
            InitializeComponent();
            this.Location = new Point(235, 97);
            this.loadCombos();
        }

        public void loadCombos() {

            userControl = new UserCtrl();
            Dictionary<Object, dynamic> resultUsers = this.userControl.getDataToFillUsersCombo();

            if (resultUsers["code"] == Result.Failed)
            {
                MessageBox.Show(resultUsers["msg"]);
                return;
            }

            if (resultUsers["code"] == Result.Processed)
            {
                loadUsersComboBox(resultUsers["content"]);
            }

        }

        public void loadUsersComboBox(Object data)
        {

            this.delDropUserId.DataSource = data;
            this.delDropUserId.ValueMember = "IdUsuario";
            this.delDropUserId.DisplayMember = "Cedula";

        }

        private void delBtnDeleteUser_Click(object sender, EventArgs e)
        {

            this.userControl = new UserCtrl();
            catchData();
            userControl.data = data;

            Dictionary<Object, dynamic> result = userControl.deleteUser(registeredUser);

            if (result["code"] == Result.Processed)
            {
                this.loadCombos();
            }

            MessageBox.Show(result["msg"]);


        }

        private void catchData()
        {

            this.data = new Dictionary<Object, dynamic>();
            this.registeredUser = (Usuario)delDropUserId.SelectedItem;
            data["id"] = registeredUser.IdUsuario;
            data["user"] = Session.getInstance().session["identification"];

        }

        private void delDropUserId_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.registeredUser = (Usuario)delDropUserId.SelectedItem;
            this.delTxtName.Text = registeredUser.NombreCompleto + " " + registeredUser.PrimerApellido + " " + registeredUser.SegundoApellido;

        }
    }
}
