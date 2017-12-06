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

namespace CACMicropresicion.View.Products
{
    public partial class ModifyProduct : UserControl
    {
        private Producto registeredProduct;
        //string description;
        //string price;
        //string stock;
        ProductController controller;
        ProductTypeController conType;

        public ModifyProduct()
        {
            InitializeComponent();
            this.Location = new Point(235, 97);
            loadCombos();
            
        }

        public void loadCombos()
        {
            controller = new ProductController();
            Dictionary<Object, dynamic> resultProduct = this.controller.getDataToFillProductCombo();
            Dictionary<Object, dynamic> resultStatus = this.controller.getAllRegisterStatus();

            if (resultProduct["code"] == Result.Failed)
            {
                MessageBox.Show(resultProduct["msg"]);
                return;
            }
            if (resultProduct["code"] == Result.Processed)
            {
                
                loadTypeCombos();
                loadStatusComboBox(resultStatus["content"]);
                
            }
        }

        private void modDropProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //fillProductFields();
        }

        public void loadStatusComboBox(Object data)
        {
            this.modDropProductStatus.DataSource = data;
            this.modDropProductStatus.ValueMember = "IdEstado";
            this.modDropProductStatus.DisplayMember = "Descripcion";
        }

        public void loadTypeCombos()
        {
            conType = new ProductTypeController();
            Dictionary<Object, dynamic> resultProductType = this.conType.getDataToFillProductTypesCombo();

            if (resultProductType["code"] == Result.Failed)
            {
                MessageBox.Show(resultProductType["msg"]);
                return;
            }
            if (resultProductType["code"] == Result.Processed)
            {
                this.modProductType.DataSource = resultProductType["content"];
                this.modProductType.ValueMember = "IdTipoProducto";
                this.modProductType.DisplayMember = "Descripcion";
            }
        }

        private void modBtnProduct_Click(object sender, EventArgs e)
        {

            this.controller = new ProductController();
            Dictionary<string, dynamic> data = new Dictionary<string, dynamic>();

            Producto modifiedProduct = new Producto()
            {
                IdProducto = registeredProduct.IdProducto,
                IdTipoProducto = Convert.ToInt32(modProductType.SelectedValue),
                Descripcion = txtDescription.Text.TrimStart().TrimEnd(),
                Precio = Convert.ToDecimal(txtPrice.Text),
                CantidadInventariable = Convert.ToInt32(txtStock.Text),
                FechaAgrega = registeredProduct.FechaAgrega,
                FechaElimina = registeredProduct.FechaElimina,
                UsuarioAgrega = registeredProduct.UsuarioAgrega,
                Eliminado = registeredProduct.Eliminado,
                IdEstado = (int)modDropProductStatus.SelectedValue
            };

            data["user"] = Session.getInstance().session["identification"];
            controller.data = data;


            Dictionary<Object, dynamic> result = controller.modifyProduct(registeredProduct, modifiedProduct);

            if (result["code"] == Result.Processed)
            {
                loadDataGridView();
            }
            MessageBox.Show(result["msg"]);
        }

        private void loadDataGridView()
        {

            ViewProducts viewProducts = new ViewProducts();
            ProductController productCtrl = new ProductController();

            viewProducts.Height = Parent.Height;
            viewProducts.Width = Parent.Width;

            Dictionary<Object, dynamic> result = productCtrl.getAllProducts();

            if (result["code"] == Result.Failed)
            {
                MessageBox.Show(result["msg"]);
                return;
            }

            if (result["code"] == Result.Processed)
            {
                viewProducts.loadDataGrid(result["content"]);
                Parent.Controls.Add(viewProducts);
            }

            Parent.Controls.RemoveByKey("ModifyProduct");

        }
        public void fillProductInputs(Producto product)
        {
            this.registeredProduct = product;
            txtDescription.Text = this.registeredProduct.Descripcion;
            txtPrice.Text = Convert.ToString(this.registeredProduct.Precio);
            txtStock.Text = Convert.ToString(this.registeredProduct.CantidadInventariable);
            
            //Tipo de producto
            modProductType.SelectedValue = this.registeredProduct.IdTipoProducto;

            //Estado del producto
            modDropProductStatus.SelectedValue = this.registeredProduct.IdEstado;

        }
    }
}
