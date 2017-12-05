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
        MaterialTypeController controller;

        public ModifyMaterialType()
        {
            InitializeComponent();
            this.Location = new Point(235, 97);
            this.loadCombos();
        }

        public void loadCombos()
        {
            controller = new MaterialTypeController();
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

            this.cmbStatus.DataSource = data;
            this.cmbStatus.ValueMember = "IdEstado";
            this.cmbStatus.DisplayMember = "Descripcion";

        }

        public void fillInputs (TipoMaterial materialType)
        {
            this.registeredMaterialType = materialType;
            txtDescription.Text = this.registeredMaterialType.Descripcion;
            cmbStatus.SelectedValue = this.registeredMaterialType.IdEstado;

        }

        private void modBtnSaveMaterialType_Click(object sender, EventArgs e)
        {
            this.controller = new MaterialTypeController();
            Dictionary<string, dynamic> data = new Dictionary<string, dynamic>();

            TipoMaterial modifiedMaterialType = new TipoMaterial()
            {
                IdTipoMaterial = registeredMaterialType.IdTipoMaterial,
                Descripcion = txtDescription.Text.TrimStart().TrimEnd(),
                FechaAgrega = registeredMaterialType.FechaAgrega,
                FechaElimina = registeredMaterialType.FechaElimina,
                UsuarioAgrega = registeredMaterialType.UsuarioAgrega,
                Eliminado = registeredMaterialType.Eliminado,
                IdEstado = (int)this.cmbStatus.SelectedValue
            };

            data["user"] = Session.getInstance().session["identification"];
            controller.data = data;

            Dictionary<Object, dynamic> result = controller.modifyMaterialType(registeredMaterialType, modifiedMaterialType);

            if (result["code"] == Result.Processed)
            {
                this.loadDataGridView();
            }

            MessageBox.Show(result["msg"]);
        }

        private void loadDataGridView() {

            ViewMaterialTypes viewMaterials = new ViewMaterialTypes();
            MaterialTypeController contr = new MaterialTypeController();

            viewMaterials.Height = Parent.Height;
            viewMaterials.Width = Parent.Width;

            Dictionary<Object, dynamic> result = contr.getAllMaterialTypes();
            if (result["code"] == Result.Failed)
            {
                MessageBox.Show(result["msg"]);
                return;
            }

            if (result["code"] == Result.Processed)
            {
                viewMaterials.loadDataGrid(result["content"]);
                Parent.Controls.Add(viewMaterials);
            }

            Parent.Controls.RemoveByKey("ModifyMaterialType");
        
        }


    }
}
