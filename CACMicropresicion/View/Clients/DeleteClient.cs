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
    public partial class DeleteClient : UserControl
    {


        private ClientsController controller;
        private Cliente registeredClient;
        public DeleteClient()
        {
            InitializeComponent();
            this.Location = new Point(235, 94);
            loadCombos();
        }


        public void loadCombos()
        {

            controller = new ClientsController();
            Dictionary<Object, dynamic> resultClients= this.controller.getDataToFillClientsCombo();

            if (resultClients["code"] == Result.Failed)
            {
                MessageBox.Show(resultClients["msg"]);
                return;
            }

            if (resultClients["code"] == Result.Processed)
            {
                loadClientsComboBox(resultClients["content"]);
            }
        }

        public void loadClientsComboBox(Object data)
        {

            this.delDropClientId.DataSource = data;
            this.delDropClientId.ValueMember = "IdCliente";
            this.delDropClientId.DisplayMember = "Descripcion";

        }

        private void delDropClientId_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.registeredClient = (Cliente)delDropClientId.SelectedItem;
            this.txtDescription.Text = registeredClient.Descripcion;

        }

        private void DeleteClient_Load(object sender, EventArgs e)
        {

        }

        private void delBtnDeleteClient_Click(object sender, EventArgs e)
        {

            this.controller = new ClientsController();
            Dictionary<string, dynamic> data = new Dictionary<string, dynamic>();

            this.registeredClient = (Cliente)delDropClientId.SelectedItem;
            data["id"] = registeredClient.IdCliente;
            data["user"] = Session.getInstance().session["identification"];
            controller.data = data;

            Dictionary<Object, dynamic> result = controller.deleteClient(registeredClient);

            if (result["code"] == Result.Processed)
            {
                this.loadCombos();
            }

            MessageBox.Show(result["msg"]);
        }
    }
}
