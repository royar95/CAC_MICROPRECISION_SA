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

namespace CACMicropresicion.View.MaterialTypes
{
    public partial class ModifyMaterialType : UserControl
    {
        private TipoMaterial registeredMaterialType;
        string description;
        MaterialTypeController controller;
        public ModifyMaterialType()
        {
            InitializeComponent();
            this.Location = new Point(235, 97);
            loadCombos();
        }


        public void loadCombos()
        {
            controller = new MaterialTypeController();
            Dictionary<Object, dynamic> resultMaterialType = this.controller.getDataToFillMaterialsCombo();


            if (resultMaterialType["code"] == Result.Failed)
            {
                MessageBox.Show(resultMaterialType["msg"]);
                return;
            }

            if (resultMaterialType["code"] == Result.Processed)
            {
                // loadTypesComboBox();
                loadPaymentComboBox(resultMaterialType["content"]);
            }

        }

        public void loadPaymentComboBox(Object data)
        {

            this.modDropMaterialType.DataSource = data;
            this.modDropMaterialType.ValueMember = "IdTipoMaterial";
            this.modDropMaterialType.DisplayMember = "Descripcion";

        }

        private void fillPaymentInputs()
        {
            this.registeredMaterialType = (TipoMaterial)this.modDropMaterialType.SelectedItem;
            txtDescripcion.Text = this.registeredMaterialType.Descripcion;

        }

        private void modDropClientId_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillPaymentInputs();
        }

        private void modBtnSaveMaterialType_Click(object sender, EventArgs e)
        {
            this.controller = new MaterialTypeController();
            Dictionary<string, dynamic> data = new Dictionary<string, dynamic>();

            TipoMaterial modifiedMaterialType = new TipoMaterial()
            {
                Descripcion = txtDescripcion.Text.TrimStart().TrimEnd(),
                FechaAgrega = registeredMaterialType.FechaAgrega,
                FechaElimina = registeredMaterialType.FechaElimina,
                UsuarioAgrega = registeredMaterialType.UsuarioAgrega,
                Eliminado = registeredMaterialType.Eliminado
            };

              data["user"] = Session.getInstance().session["identification"];
            //data["user"] = "probando";
            //quite el otro porque a yo estoy trabajando con mi version  y no esta enlazado el login
            //entonces nada mas descomentelo y elimine ese de arriba.
            controller.data = data;

            Dictionary<Object, dynamic> result = controller.modifyMaterialType(registeredMaterialType, modifiedMaterialType);

            if (result["code"] == Result.Processed)
            {
                this.loadCombos();
            }

            MessageBox.Show(result["msg"]);
        }
    }
}
