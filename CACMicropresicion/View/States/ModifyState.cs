using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CACMicropresicion.Model;
using CACMicropresicion.Controller;
using CACMicropresicion.Globals;

namespace CACMicropresicion.View.States
{
    public partial class ModifyState : UserControl
    {
        private Estado registeredState;
        StateController controller;

        public ModifyState()
        {
            InitializeComponent();
            this.Location = new Point(235, 97);
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

            this.modDropStateId.DataSource = data;
            this.modDropStateId.ValueMember = "IdEstado";
            this.modDropStateId.DisplayMember = "Descripcion";

        }

        private void modDropStateId_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillStateInputs();
        }

        private void fillStateInputs()
        {
            this.registeredState = (Estado)this.modDropStateId.SelectedItem;
            txtDescription.Text = this.registeredState.Descripcion;

        }

        private void modBtnSaveStateChanges_Click(object sender, EventArgs e)
        {
            this.controller = new StateController();
            Dictionary<string, dynamic> data = new Dictionary<string, dynamic>();

            Estado modifiedState = new Estado()
            {
                IdEstado = registeredState.IdEstado,
                Descripcion = txtDescription.Text.TrimStart().TrimEnd(),
                FechaAgrega = registeredState.FechaAgrega,
                FechaElimina = registeredState.FechaElimina,
                UsuarioAgrega = registeredState.UsuarioAgrega,
                Eliminado = registeredState.Eliminado
            };


            data["user"] = Session.getInstance().session["identification"];
            controller.data = data;

            Dictionary<Object, dynamic> result = controller.modifyState(registeredState, modifiedState);

            if (result["code"] == Result.Processed)
            {
                this.loadCombos();
            }

            MessageBox.Show(result["msg"]);
        }
    }
}
