using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CACMicropresicion.Globals;

namespace CACMicropresicion.View
{
    public partial class Register1 : Form
    {
        private string identification, name, lastName1, lastName2, userName, password;
        private Dictionary<Object, dynamic> data;

        public Register1()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void catchInformation() {

            this.identification = txtIdentification.Text;
            this.name = txtName.Text;
            this.lastName1 = txtLastName1.Text;
            this.lastName2 = txtLastName2.Text;
            this.userName = txtUserName.Text;
            this.password = txtPassword.Text;

        }

        private bool emptySpaces() {
            return
                String.IsNullOrEmpty(this.identification) || 
                String.IsNullOrEmpty(this.name) || 
                String.IsNullOrEmpty(this.lastName1) || 
                String.IsNullOrEmpty(this.lastName2) ||
                String.IsNullOrEmpty(this.userName) ||
                String.IsNullOrEmpty(this.password);
        }

        private void storeDataIntoArray () {

            this.data = new Dictionary<Object, dynamic>();
            data["identification"] = this.identification.TrimStart().TrimEnd();
            data["name"] = this.name.TrimStart().TrimEnd();
            data["lastName1"] = this.lastName1.TrimStart().TrimEnd();
            data["lastName2"] = this.lastName2.TrimStart().TrimEnd();
            data["userName"] = this.userName.TrimStart().TrimEnd();
            data["password"] = this.password.TrimStart().TrimEnd();
            data["userType"] = UserTypes.Operator;
            data["userDeleted"] = 0;
            data["userStatus"] = Status.Active;
            data["user"] = "N/A";

        }

        private void btnRegister1Continue_Click(object sender, EventArgs e)
        {

            catchInformation();
            
            if (emptySpaces()) {
                MessageBox.Show("Existen espacios en blanco, por favor revise");
                return;
            }

            storeDataIntoArray();
            Register2 register2 = new Register2();
            register2.setData(data);
            register2.ShowDialog();

        }

    }
}
