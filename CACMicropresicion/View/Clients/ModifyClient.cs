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
            Dictionary<Object, dynamic> resultStatus = this.controller.getAllStatus();

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

            this.modDropClientStatus.DataSource = data;
            this.modDropClientStatus.ValueMember = "IdEstado";
            this.modDropClientStatus.DisplayMember = "Descripcion";

        }
        

        public void fillUserInputs(Cliente client)
        {
            this.registeredClient = client;
            txtDescription.Text = this.registeredClient.Descripcion;
            modDropClientStatus.SelectedValue = this.registeredClient.IdEstado;

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
                this.loadDataGridView();
            }

            MessageBox.Show(result["msg"]);
        }

        private void loadDataGridView() {

            ClientsList clientsList = new ClientsList();
            ClientsController cont = new ClientsController();

            clientsList.Height = Parent.Height;
            clientsList.Width = Parent.Width;

            Dictionary<Object, dynamic> result = cont.getAllClients();
            if (result["code"] == Result.Failed)
            {
                MessageBox.Show(result["msg"]);
                return;
            }
            if (result["code"] == Result.Processed)
            {
                clientsList.loadDataGrid(result["content"]);
                Parent.Controls.Add(clientsList);
            }

            Parent.Controls.RemoveByKey("ModifyClient");

        }
    }
}
