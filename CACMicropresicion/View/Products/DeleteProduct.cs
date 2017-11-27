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

namespace CACMicropresicion.View.Products
{
    public partial class DeleteProduct : UserControl
    {

        private ProductController controller;
        private Producto registeredProduct;
        public DeleteProduct()
        {
            InitializeComponent();
            this.Location = new Point(235, 97);
            loadCombos();
        }

        public void loadCombos()
        {

            controller = new ProductController();
            Dictionary<Object, dynamic> resultProductType = this.controller.getDataToFillProductCombo();

            if (resultProductType["code"] == Result.Failed)
            {
                MessageBox.Show(resultProductType["msg"]);
                return;
            }

            if (resultProductType["code"] == Result.Processed)
            {
                this.delDropProduct.DataSource = resultProductType["content"];
                this.delDropProduct.ValueMember = "IdProducto";
                this.delDropProduct.DisplayMember = "Descripcion";
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            this.controller = new ProductController();
            Dictionary<string, dynamic> data = new Dictionary<string, dynamic>();

            this.registeredProduct = (Producto)delDropProduct.SelectedItem;
            data["id"] = registeredProduct.IdProducto;
            data["user"] = Session.getInstance().session["identification"];
            controller.data = data;
            Dictionary<Object, dynamic> result = controller.deleteProduct(registeredProduct);
            if (result["code"] == Result.Processed)
            {
                this.loadCombos();
            }
            MessageBox.Show(result["msg"]);
        }
    }
}
