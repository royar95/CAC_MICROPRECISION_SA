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

namespace CACMicropresicion.View.MaterialTypes
{
    public partial class DeleteMaterialType : UserControl
    {
        private MaterialTypeController controller;
        private TipoMaterial registeredMaterialType;

        public DeleteMaterialType()
        {
            InitializeComponent();
            this.Location = new Point(235, 94);
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
                loadMaterialTypesComboBox(resultMaterialType["content"]);
            }
        }

        public void loadMaterialTypesComboBox(Object data)
        {
            this.delDropMaterialType.DataSource = data;
            this.delDropMaterialType.ValueMember = "IdTipoMaterial";
            this.delDropMaterialType.DisplayMember = "Descripcion";

        }

        private void delBtnDeleteMaterialTypes_Click(object sender, EventArgs e)
        {
            this.controller = new MaterialTypeController();
            Dictionary<string, dynamic> data = new Dictionary<string, dynamic>();

            this.registeredMaterialType = (TipoMaterial)delDropMaterialType.SelectedItem;
            data["id"] = registeredMaterialType.IdTipoMaterial;
              data["user"] = Session.getInstance().session["identification"];
            controller.data = data;

            Dictionary<Object, dynamic> result = controller.deleteMaterialType(registeredMaterialType);

            if (result["code"] == Result.Processed)
            {
                this.loadCombos();
            }

            MessageBox.Show(result["msg"]);
        }
    }
}
