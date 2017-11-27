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

namespace CACMicropresicion.View.Cients
{
    public partial class DeleteProvider : UserControl
    {


        private Dictionary<Object, dynamic> data;
        private ProviderController providerControl;
        private Proveedor registeredProvider;

        public DeleteProvider()
        {
            InitializeComponent();
            this.Location = new Point(235, 97);
            this.loadCombos();
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

            this.delDropProviderId.DataSource = data;
            this.delDropProviderId.ValueMember = "IdProveedor";
            this.delDropProviderId.DisplayMember = "IdProveedor";

        }

        

        private void catchData()
        {

            this.data = new Dictionary<Object, dynamic>();
            this.registeredProvider = (Proveedor)delDropProviderId.SelectedItem;
            data["id"] = registeredProvider.IdProveedor;
            data["user"] = Session.getInstance().session["identification"];

        }

        private void delDropProviderId_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.registeredProvider = (Proveedor)delDropProviderId.SelectedItem;
            this.txtDescription.Text = registeredProvider.Descripcion;
        }

        private void delBtnDeleteClient_Click(object sender, EventArgs e)
        {
            this.providerControl = new ProviderController();
            catchData();
            providerControl.data = data;

            Dictionary<Object, dynamic> result = providerControl.deleteProvider(registeredProvider);

            if (result["code"] == Result.Processed)
            {
                this.loadCombos();
            }

            MessageBox.Show(result["msg"]);
        }

        private void DeleteProvider_Load(object sender, EventArgs e)
        {

        }
    }
}
