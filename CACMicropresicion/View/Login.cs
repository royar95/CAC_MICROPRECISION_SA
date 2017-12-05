using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CACMicropresicion.Controller;
using CACMicropresicion.Globals;
using CACMicropresicion.Model;
using CACMicropresicion.View.Main;

namespace CACMicropresicion.View
{
   
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            Dictionary<string, dynamic> data = new Dictionary<string, dynamic>();
            data["username"] = txtUserName.Text.TrimStart().TrimEnd();
            data["password"] = txtPassword.Text.TrimStart().TrimEnd();

            LoginCtrl lgnCtrl = new LoginCtrl();
            lgnCtrl.data = data;
            Dictionary<Object, dynamic> result = lgnCtrl.validateCredentials();

            if (result["code"] == Result.Failed)
            {
                MessageBox.Show(result["msg"]);
            }

            if (result["code"] == Result.Processed)
            {
                Usuario user = result["content"];
                Session session = Session.getInstance();
                session.setSessionParams(user.IdUsuario, user.Cedula, user.NombreUsuario, (user.NombreCompleto + " " + user.PrimerApellido + " " + user.SegundoApellido), user.Contrasena);
                new MainView().Show();
                this.Hide();
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register1 register1 = new Register1();
            register1.ShowDialog();
        }

    }
}
