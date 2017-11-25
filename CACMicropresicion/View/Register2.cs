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

namespace CACMicropresicion.View
{
    public partial class Register2 : Form
    {

        private string email;
        private Dictionary<Object, dynamic> data;

        public Register2()
        {
            InitializeComponent();
        }

        public void setData(Dictionary<Object, dynamic> data) {
            this.data = data;
        }

        private void catchInformation()
        {

            this.email = txtEmail.Text;

        }

        private bool emptySpaces()
        {
            return this.email == "";
        }

        private void btnSubmitRegister2_Click(object sender, EventArgs e)
        {

            catchInformation();

            data["contactInfoType"] = ContactInfoType.Email;
            data["value"] = this.email.TrimStart().TrimEnd();
            data["contactInfoDeleted"] = 0;
            data["contactInfoStatus"] = Status.Active;

            UserCtrl userCtrl = new UserCtrl();
            userCtrl.data = data;
            Dictionary<Object, dynamic> result = userCtrl.insertUserFromRegister();

            MessageBox.Show(result["msg"]);

        }

    }
}
