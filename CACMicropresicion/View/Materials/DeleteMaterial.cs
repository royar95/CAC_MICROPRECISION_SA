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
    public partial class DeleteMaterial : UserControl
    {

        private MaterialController controller;
        private Material registeredMaterial;
        private Dictionary<Object, dynamic> data;

        public DeleteMaterial()
        {
            InitializeComponent();
            this.Location = new Point(235, 97);
            loadCombos();
        }

        public void loadCombos()
        {

            this.controller = new MaterialController();
            Dictionary<Object, dynamic> resultMaterials = this.controller.getMaterials();

            if (resultMaterials["code"] == Result.Failed)
            {
                MessageBox.Show(resultMaterials["msg"]);
                return;
            }

            if (resultMaterials["code"] == Result.Processed)
            {
                loadMaterials(resultMaterials["content"]);
            }

        }

        public void loadMaterials(Object data)
        {
            this.cmbMaterials.DataSource = data;
            this.cmbMaterials.ValueMember = "IdMaterial";
            this.cmbMaterials.DisplayMember = "Descripcion";
        }

        private void catchData()
        {
            this.registeredMaterial = (Material)cmbMaterials.SelectedItem;
        }

        private void storeDataIntoArray()
        {
            this.data = new Dictionary<object, dynamic>();
            this.data["materialToDelete"] = this.registeredMaterial;
            this.data["user"] = Session.getInstance().session["identification"];
            this.data["deletedDate"] = DateTime.Now;
        }

        private void btnDeleteMaterial_Click(object sender, EventArgs e)
        {
            this.controller = new MaterialController();

            catchData();
            storeDataIntoArray();

            controller.data = data;

            Dictionary<Object, dynamic> result = controller.deleteMaterial();

            if (result["code"] == Result.Processed)
            {
                this.loadCombos();
            }

            MessageBox.Show(result["msg"]);
        }

    }
}
