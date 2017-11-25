using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CACMicropresicion.Globals;
using CACMicropresicion.Controller;

namespace CACMicropresicion.View.Users
{
    public partial class AddUser : UserControl
    {

        private string identification, name, lastName1, lastName2, userName, password;
        private Dictionary<Object, dynamic> data;

        public AddUser()
        {
            InitializeComponent();
            this.Location = new Point(235, 97);
        }

        private void addbtnSaveUser_Click(object sender, EventArgs e)
        {
            catchData();
            storeDataIntoArray();

            UserCtrl userControl = new UserCtrl();  
            userControl.data = this.data;
            Dictionary<Object, dynamic> result = userControl.insertUserFromMaintenance();
            MessageBox.Show(result["msg"]);
        }

        private void catchData()
        {

            this.identification = addtxtIdentification.Text.TrimStart().TrimEnd();
            this.name = addtxtName.Text.TrimStart().TrimEnd();
            this.lastName1 = addtxtLastname1.Text.TrimStart().TrimEnd();
            this.lastName2 = addtxtLastname2.Text.TrimStart().TrimEnd();
            this.userName = addtxtUsername.Text.TrimStart().TrimEnd();
            this.password = addtxtPassword.Text.TrimStart().TrimEnd();

        }

        private void storeDataIntoArray()
        {

            this.data = new Dictionary<Object, dynamic>();
            data["identification"] = this.identification;
            data["userType"] = UserTypes.Operator;
            data["name"] = this.name;
            data["lastName1"] = this.lastName1;
            data["lastName2"] = this.lastName2;
            data["userName"] = this.userName;
            data["password"] = this.password;
            data["userDeleted"] = 0;
            data["userStatus"] = Status.Active;
            data["user"] = Session.getInstance().session["identification"];

        }

        private void addBtnContactInfo_Click(object sender, EventArgs e)
        {
            new AddContactInfo().ShowDialog();
        }

    }
}
