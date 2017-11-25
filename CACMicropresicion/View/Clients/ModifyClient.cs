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
    public partial class ModifyClient : UserControl
    {
        private Cliente registeredClient;
        string description;
        ClientsController controller;

        public ModifyClient()
        {
            InitializeComponent();
             this.Location = new Point(235, 97);
            loadCombos();
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

        public void loadCombos() {
            controller = new ClientsController();
            Dictionary<Object, dynamic> resultClients = this.controller.getDataToFillClientsCombo();
            Dictionary<Object, dynamic> resultStatus = this.controller.getAllStatus();

            if (resultClients["code"] == Result.Failed || resultStatus["code"] == Result.Failed)
            {
                MessageBox.Show(resultClients["msg"]);
                return;
            }

            if (resultClients["code"] == Result.Processed && resultStatus["code"] == Result.Processed)
            {
                loadStatusComboBox(resultStatus["content"]);
                loadUsersComboBox(resultClients["content"]);
            }

        }


        public void loadStatusComboBox(Object data)
        {

            this.modDropClientStatus.DataSource = data;
            this.modDropClientStatus.ValueMember = "IdEstado";
            this.modDropClientStatus.DisplayMember = "Descripcion";

        }

        public void loadUsersComboBox(Object data)
        {

            this.modDropClientId.DataSource = data;
            this.modDropClientId.ValueMember = "IdCliente";
            this.modDropClientId.DisplayMember = "Descripcion";

        }
        

        private void fillUserInputs()
        {
            this.registeredClient = (Cliente)this.modDropClientId.SelectedItem;
            txtDescription.Text = this.registeredClient.Descripcion;
            //Indica el estado del cliente
            modDropClientStatus.SelectedValue = this.registeredClient.IdEstado;

        }

        private void modDropClientId_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillUserInputs();
        }

        private void modBtnSaveClientChanges_Click(object sender, EventArgs e)
        {
            this.controller = new ClientsController();
            Dictionary<string, dynamic> data = new Dictionary<string, dynamic>();

            Cliente modifiedClient = new Cliente()
            {
                IdCliente = registeredClient.IdCliente,
                Descripcion = txtDescription.Text.TrimStart().TrimEnd(),
                FechaAgrega = registeredClient.FechaAgrega,
                FechaElimina = registeredClient.FechaElimina,
                UsuarioAgrega = registeredClient.UsuarioAgrega,
                Eliminado = registeredClient.Eliminado,
                IdEstado = (int)modDropClientStatus.SelectedValue
            };


            data["user"] = Session.getInstance().session["identification"];
            controller.data = data;

            Dictionary<Object, dynamic> result = controller.modifyClient(registeredClient, modifiedClient);

            if (result["code"] == Result.Processed)
            {
                this.loadCombos();
            }

            MessageBox.Show(result["msg"]);
        }
    }
}
