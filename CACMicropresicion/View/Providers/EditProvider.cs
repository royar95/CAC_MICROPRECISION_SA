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

namespace CACMicropresicion.View.Providers
{
    public partial class EditProvider : UserControl
    {

        private Dictionary<Object, dynamic> data;
        private ProviderController providerControl;
        private Proveedor registeredProvider;
        private InfoProveedor registeredInfo;
        private DireccionProveedor registeredAddress;


        public EditProvider()
        {
            InitializeComponent();
            comboProvincia.SelectedIndex = 0;
            this.loadCombos();
            this.Location = new Point(235, 94);
        }

        public void loadCombos()
        {

            providerControl = new ProviderController();
            Dictionary<Object, dynamic> resultUsers = this.providerControl.getDataToFillProvidersCombo();

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

            this.modifyProviderCombo.DataSource = data;
            this.modifyProviderCombo.ValueMember = "IdProveedor";
            this.modifyProviderCombo.DisplayMember = "Descripcion";

        }



        private void catchData()
        {

            this.data = new Dictionary<Object, dynamic>();
            this.registeredProvider = (Proveedor)modifyProviderCombo.SelectedItem;
            data["id"] = registeredProvider.IdProveedor;
            data["user"] = Session.getInstance().session["identification"];

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.registeredProvider = (Proveedor)modifyProviderCombo.SelectedValue;
            //this.registeredAddress = (DireccionProveedor)modifyProviderCombo.SelectedValue;
           // this.registeredInfo = (InfoProveedor)modifyProviderCombo.SelectedValue;
            this.txtName.Text = registeredProvider.Descripcion;
        //    this.txtEmail.Text = registeredInfo.Valor;
        //    this.txtDistrito.Text = registeredAddress.Distrito;
        //    this.txtCanton.Text = registeredAddress.Canton;
         //   this.txtAddress.Text = registeredAddress.DireccionExacta;
        }

        private void EditProvider_Load(object sender, EventArgs e)
        {

        }
    }
}
