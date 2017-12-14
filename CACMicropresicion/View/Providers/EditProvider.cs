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

        private Proveedor registeredProvider;
        string description;
        ProviderController controller;


        public EditProvider()
        {
            InitializeComponent();
            this.loadCombos();
            this.Location = new Point(235, 94);
        }

        public void loadCombos()
        {
            controller = new ProviderController();
            Dictionary<Object, dynamic> resultStatus = this.controller.getAllRegisterStatus();

            if (resultStatus["code"] == Result.Failed)
            {
                MessageBox.Show(resultStatus["msg"]);
                return;
            }

            if (resultStatus["code"] == Result.Processed)
            {
                loadStatusComboBox(resultStatus["content"]);
            }
        }

        public void loadStatusComboBox(Object data)
        {

            this.modDropProviderStatus.DataSource = data;
            this.modDropProviderStatus.ValueMember = "IdEstado";
            this.modDropProviderStatus.DisplayMember = "Descripcion";

        }


        public bool checkSpaces()
        {
            try
            {
                description = txtDescription.Text;
                return (!String.IsNullOrEmpty(description));
            }
            catch (Exception e)
            {
                MessageBox.Show("Ingrese los espacios de forma correcta");
                return false;
            }
        }

        public void fillProviderInputs(Proveedor provider)
        {
            this.registeredProvider = provider;
            txtDescription.Text = this.registeredProvider.Descripcion;
            modDropProviderStatus.SelectedValue = this.registeredProvider.IdEstado;

        }
        


      

        private void loadDataGridView()
        {

            ViewProviders viewProviders = new ViewProviders();
            UserCtrl userCtrl = new UserCtrl();

            viewProviders.Height = Parent.Height;
            viewProviders.Width = Parent.Width;

            Dictionary<Object, dynamic> result = controller.getAllProvidersToView();

            if (result["code"] == Result.Failed)
            {
                MessageBox.Show(result["msg"]);
                return;
            }

            if (result["code"] == Result.Processed)
            {
                viewProviders.loadDataGrid(result["content"]);
                Parent.Controls.Add(viewProviders);
            }

            Parent.Controls.RemoveByKey("EditProvider");

        }

        private void modBtnSaveClientChanges_Click(object sender, EventArgs e)
        {
            this.controller = new ProviderController();
            Dictionary<string, dynamic> data = new Dictionary<string, dynamic>();

            Proveedor modifiedProvider = new Proveedor()
            {
                IdProveedor = registeredProvider.IdProveedor,
                Descripcion = txtDescription.Text.TrimStart().TrimEnd(),
                FechaAgrega = registeredProvider.FechaAgrega,
                FechaElimina = registeredProvider.FechaElimina,
                UsuarioAgrega = registeredProvider.UsuarioAgrega,
                Eliminado = registeredProvider.Eliminado,
                IdEstado = (int)modDropProviderStatus.SelectedValue
            };


            data["user"] = Session.getInstance().session["identification"];
            controller.data = data;

            Dictionary<Object, dynamic> result = controller.modifyProvider(registeredProvider, modifiedProvider);

            if (result["code"] == Result.Processed)
            {
                this.loadDataGridView();
            }

            MessageBox.Show(result["msg"]);
        }
    }
}
