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

namespace CACMicropresicion.View.States
{
    public partial class DeleteState : UserControl
    {
        private StateController controller;
        private Estado registeredState;

        public DeleteState()
        {
            InitializeComponent();
            this.Location = new Point(235, 94);
            loadCombos();
        }

        public void loadCombos()
        {
            controller = new StateController();

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

            this.delDropStateId.DataSource = data;
            this.delDropStateId.ValueMember = "IdEstado";
            this.delDropStateId.DisplayMember = "Descripcion";

        }

        private void modDropStateId_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillStateInputs();
        }

        private void fillStateInputs()
        {
            this.registeredState = (Estado)this.delDropStateId.SelectedItem;
            txtDescription.Text = this.registeredState.Descripcion;

        }

        private void delBtnDeleteState_Click(object sender, EventArgs e)
        {
            this.controller = new StateController();
            Dictionary<string, dynamic> data = new Dictionary<string, dynamic>();

            this.registeredState = (Estado)delDropStateId.SelectedItem;
            data["id"] = registeredState.IdEstado;
            data["user"] = Session.getInstance().session["identification"];
            controller.data = data;

            Dictionary<Object, dynamic> result = controller.deleteState(registeredState);

            if (result["code"] == Result.Processed)
            {
                this.loadCombos();
            }

            MessageBox.Show(result["msg"]);
        }

        private void delDropStateId_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.registeredState = (Estado)delDropStateId.SelectedItem;
            this.txtDescription.Text = registeredState.Descripcion;
        }
    }
}
