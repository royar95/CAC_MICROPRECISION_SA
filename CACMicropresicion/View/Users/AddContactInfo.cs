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
using CACMicropresicion.Model;
using CACMicropresicion.Globals;

namespace CACMicropresicion.View.Users
{
    public partial class AddContactInfo : Form
    {

        private UserCtrl userControl;
        Dictionary<Object, dynamic> data;

        public AddContactInfo()
        {
            InitializeComponent();
            loadCombos();
        }

        public void loadCombos()
        {

            userControl = new UserCtrl();
            Dictionary<Object, dynamic> resultUsers = this.userControl.getDataToFillUsersCombo();

            if (resultUsers["code"] == Result.Failed)
            {
                MessageBox.Show(resultUsers["msg"]);
                return;
            }

            if (resultUsers["code"] == Result.Processed)
            {
                loadTypesComboBox();
                loadUsersComboBox(resultUsers["content"]);
            }

        }

        public void loadUsersComboBox(Object data)
        {

            this.addContUserId.DataSource = data;
            this.addContUserId.ValueMember = "IdUsuario";
            this.addContUserId.DisplayMember = "Cedula";

        }

        public void loadTypesComboBox()
        {
            List<ContactInfoType> types = new List<ContactInfoType>();
            types.Add(new ContactInfoType(1, "Correo electrónico"));
            types.Add(new ContactInfoType(2, "Teléfono (Trabajo)"));
            types.Add(new ContactInfoType(3, "Teléfono (Personal)"));
            types.Add(new ContactInfoType(4, "Teléfono (Hogar)"));
            this.addContUserType.DataSource = types;
            this.addContUserType.ValueMember = "value";
            this.addContUserType.DisplayMember = "display";
        }




        private void addContUserId_SelectedIndexChanged(object sender, EventArgs e)
        {
            Usuario registeredUser = (Usuario)addContUserId.SelectedItem;
            this.addTxtName.Text = registeredUser.NombreCompleto + " " + registeredUser.PrimerApellido + " " + registeredUser.SegundoApellido;
        }

        private void addContInfoSendInfo_Click(object sender, EventArgs e)
        {

            this.userControl = new UserCtrl();
            catchInformation();
            userControl.data = data;

            Dictionary<Object, dynamic> result = userControl.insertContactInformation();
            MessageBox.Show(result["msg"]);

        }

        private void catchInformation() {

            this.data = new Dictionary<Object, dynamic>();
            data["entity"] = (Usuario)addContUserId.SelectedItem;
            data["contactInfoType"] = ((ContactInfoType)addContUserType.SelectedItem).value;
            data["value"] = addContUserValue.Text.TrimStart().TrimEnd();
            data["contactInfoDeleted"] = 0;
            data["contactInfoStatus"] = Status.Active;
            data["user"] = Session.getInstance().session["identification"];   

        }

    }
}
