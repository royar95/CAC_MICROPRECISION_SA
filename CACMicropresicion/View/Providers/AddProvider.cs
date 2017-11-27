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

namespace CACMicropresicion.View.Providers
{
    public partial class AddProvider : UserControl
    {

        private string nombre, correo, telefono, provincia, canton, distrito, direccion;
        private Dictionary<Object, dynamic> data;

        public AddProvider()
        {
            InitializeComponent();
            this.Location = new Point(235, 94);
            cmbProvincia.SelectedIndex = 0;
        }

        private void catchInformation()
        {
            this.nombre = txtName.Text.TrimStart().TrimEnd();
            this.correo = txtEmail.Text.TrimStart().TrimEnd();
            this.telefono = txtPhone.Text.TrimStart().TrimEnd();
            this.provincia = cmbProvincia.Text;
            this.canton = txtCanton.Text.TrimStart().TrimEnd();
            this.distrito = txtDistrito.Text.TrimStart().TrimEnd();
            this.direccion = txtAddress.Text.TrimStart().TrimEnd();
            

            MessageBox.Show(nombre + correo + telefono + provincia + canton + distrito + direccion);

        }

        private void storeDataIntoArray()
        {

            this.data = new Dictionary<Object, dynamic>();
            data["name"] = this.nombre;
            data["address"] = this.direccion;
            data["email"] = this.correo;
            data["phone"] = this.telefono;
            data["provincia"] = this.provincia;
            data["canton"] = this.canton;
            data["distrito"] = this.distrito;
            data["userDeleted"] = 0;
            data["userStatus"] = Status.Active;
            data["user"] = Session.getInstance().session["identification"];
            data["value"] = this.correo;

        }

        private void AddProvider_Load(object sender, EventArgs e)
        {
            //catchInformation();
           // storeDataIntoArray();


        }

        private void btnAddProvider_Click(object sender, EventArgs e)
        {
            catchInformation();
            storeDataIntoArray();

            ProviderController providerControl = new ProviderController();
            providerControl.data = this.data;
            Dictionary<Object, dynamic> result = providerControl.insertProvider();
            MessageBox.Show(result["msg"]);
        }
    }
}
