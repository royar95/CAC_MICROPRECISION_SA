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

namespace CACMicropresicion.View.ProductTypes
{
    public partial class DeleteProductType : UserControl
    {

        private ProductTypeController controller;
        private TipoProducto registeredProductType;
        public DeleteProductType()
        {
            InitializeComponent();
            this.Location = new Point(235, 97);
            loadCombos();
        }

        public void loadCombos()
        {

            controller = new ProductTypeController();
            Dictionary<Object, dynamic> resultProductType = this.controller.getDataToFillProductTypesCombo();

            if (resultProductType["code"] == Result.Failed)
            {
                MessageBox.Show(resultProductType["msg"]);
                return;
            }

            if (resultProductType["code"] == Result.Processed)
            {
                loadProductTypesComboBox(resultProductType["content"]);
            }
        }

        public void loadProductTypesComboBox(Object data)
        {
            this.delDropProductType.DataSource = data;
            this.delDropProductType.ValueMember = "IdTipoProducto";
            this.delDropProductType.DisplayMember = "Descripcion";

        }

        private void btnDeleteProductType_Click(object sender, EventArgs e)
        {
            this.controller = new ProductTypeController();
            Dictionary<string, dynamic> data = new Dictionary<string, dynamic>();

            this.registeredProductType = (TipoProducto)delDropProductType.SelectedItem;
            data["id"] = registeredProductType.IdTipoProducto;
            data["user"] = Session.getInstance().session["identification"];
            controller.data = data;
            Dictionary<Object, dynamic> result = controller.deleteProductType(registeredProductType);
            if (result["code"] == Result.Processed)
            {
                this.loadCombos();
            }
            MessageBox.Show(result["msg"]);
        }
    }
}
