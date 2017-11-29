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
using CACMicropresicion.Globals;
using CACMicropresicion.Model;

namespace CACMicropresicion.View.Materials
{
    public partial class ModifyMaterial : UserControl
    {
        private MaterialController controller;
        private Dictionary<Object, dynamic> data;
        private Material registeredMaterial, modifiedMaterial;
        private string description;
        private int type, provider, status;

        public ModifyMaterial()
        {
            InitializeComponent();
            this.Location = new Point(235, 97);
            loadCombos();
        }

        public void loadCombos()
        {

            this.controller = new MaterialController();
            Dictionary<Object, dynamic> resultTypes = this.controller.getMaterialTypes();
            Dictionary<Object, dynamic> resultProviders = this.controller.getAllProviders();
            Dictionary<Object, dynamic> resultStatus = this.controller.getAllStatus();

            if (resultTypes["code"] == Result.Failed || 
                resultProviders["code"] == Result.Failed || 
                resultStatus["code"] == Result.Failed)
            {
                MessageBox.Show(resultTypes["msg"]);
                return;
            }

            if (resultTypes["code"] == Result.Processed && 
                resultProviders["code"] == Result.Processed &&
                resultStatus["code"] == Result.Processed)
            {
                loadMaterialTypesCombo(resultTypes["content"]);
                loadProvidersCombo(resultProviders["content"]);
                loadStatusComboBox(resultStatus["content"]);
            }

        }

        public void loadMaterialTypesCombo(Object data)
        {

            this.cmbType.DataSource = data;
            this.cmbType.ValueMember = "IdTipoMaterial";
            this.cmbType.DisplayMember = "Descripcion";

        }

        public void loadProvidersCombo(Object data)
        {
            this.cmbProvider.DataSource = data;
            this.cmbProvider.ValueMember = "IdProveedor";
            this.cmbProvider.DisplayMember = "Descripcion";
        }

        public void loadStatusComboBox(Object data)
        {

            this.cmbStatus.DataSource = data;
            this.cmbStatus.ValueMember = "IdEstado";
            this.cmbStatus.DisplayMember = "Descripcion";

        }

        public void fillInputs(Material material)
        {

            this.registeredMaterial = material;
            txtDescription.Text = this.registeredMaterial.Descripcion;
            cmbType.SelectedValue = this.registeredMaterial.IdTipoMaterial;
            cmbProvider.SelectedValue = this.registeredMaterial.IdProveedor;
            cmbStatus.SelectedValue = this.registeredMaterial.IdEstado;

        }

        private bool catchData()
        {

            try
            {

                this.description = txtDescription.Text.TrimStart().TrimEnd();
                this.type = (int)cmbType.SelectedValue;
                this.provider = (int)cmbProvider.SelectedValue;
                this.status = (int)cmbStatus.SelectedValue;
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }

        private void createModifiedMaterial ()
        {

            this.modifiedMaterial = new Material()
            {
                IdMaterial = registeredMaterial.IdMaterial,
                Descripcion = this.description,
                FechaAgrega = registeredMaterial.FechaAgrega,
                FechaElimina = registeredMaterial.FechaElimina,
                UsuarioAgrega = registeredMaterial.UsuarioAgrega,
                Eliminado = registeredMaterial.Eliminado,
                IdEstado = this.status,
                IdTipoMaterial = this.type,
                IdProveedor = this.provider,
                TipoMaterial = this.registeredMaterial.TipoMaterial
            };

        }

        private void storeDataIntoDictionary() {
            this.data = new Dictionary<object, dynamic>();
            this.data["registeredMaterial"] = this.registeredMaterial;
            this.data["modifiedMaterial"] = this.modifiedMaterial;
            this.data["user"] = Session.getInstance().session["identification"];
        }

        private void loadDataGridView() {

            MaterialsList listMaterials = new MaterialsList();
            MaterialController ctrl = new MaterialController();

            listMaterials.Height = Parent.Height;
            listMaterials.Width = Parent.Width;

            Dictionary<Object, dynamic> result = ctrl.getMaterialsToPopulate();
            if (result["code"] == Result.Failed)
            {
                MessageBox.Show(result["msg"]);
                return;
            }

            if (result["code"] == Result.Processed)
            {
                listMaterials.loadDataGrid(result["content"]);
                Parent.Controls.Add(listMaterials);
            }

            Parent.Controls.RemoveByKey("ModifyMaterial");

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            this.controller = new MaterialController();

            catchData();
            createModifiedMaterial();
            storeDataIntoDictionary();

            controller.data = this.data;

            Dictionary<Object, dynamic> result = controller.modifyUser();

            if (result["code"] == Result.Processed)
            {
                this.loadDataGridView();
            }

            MessageBox.Show(result["msg"]);

        }

    }
}
