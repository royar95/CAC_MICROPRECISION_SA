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
    public partial class AddMaterial : UserControl
    {

        private MaterialController controller;
        private Dictionary<Object, dynamic> data;
        private string description;
        private int type, provider;

        public AddMaterial()
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

            if (resultTypes["code"] == Result.Failed || resultProviders["code"] == Result.Failed)
            {
                MessageBox.Show(resultTypes["msg"]);
                return;
            }

            if (resultTypes["code"] == Result.Processed && resultProviders["code"] == Result.Processed)
            {
                loadMaterialTypesCombo(resultTypes["content"]);
                loadProvidersCombo(resultProviders["content"]);
            }

        }

        public void loadMaterialTypesCombo (Object data)
        {

            this.cmbType.DataSource = data;
            this.cmbType.ValueMember = "IdTipoMaterial";
            this.cmbType.DisplayMember = "Descripcion";

        }

        public void loadProvidersCombo (Object data)
        {
            this.cmbProvider.DataSource = data;
            this.cmbProvider.ValueMember = "IdProveedor";
            this.cmbProvider.DisplayMember = "Descripcion";
        }

        private bool catchData()
        {

            try {

                if (cmbType.Items.Count == 0)
                {
                    throw new Exception("Primero debe ingresar una categoría de material");
                }

                if (cmbProvider.Items.Count == 0)
                {
                    throw new Exception("Primero debe ingresar un proveedor");
                }

                this.description = txtDescription.Text.TrimStart().TrimEnd();
                this.type = (int)cmbType.SelectedValue;
                this.provider = (int)cmbProvider.SelectedValue;

                return true;

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return false;
            }

        }

        private void storeDataIntoArray()
        {

            this.data = new Dictionary<Object, dynamic>();
            data["description"] = this.description;
            data["user"] = Session.getInstance().session["identification"];
            data["deleted"] = (byte)0;
            data["status"] = Status.Active;
            data["type"] = this.type;
            data["provider"] = this.provider;

        }

        private void btnSendInfo_Click(object sender, EventArgs e)
        {
            if (catchData())
            {
                storeDataIntoArray();

                MaterialController controller = new MaterialController();
                controller.data = this.data;
                Dictionary<Object, dynamic> result = controller.insertMaterial();
                MessageBox.Show(result["msg"]);

            }

        }

    }
}
