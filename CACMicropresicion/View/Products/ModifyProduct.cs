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
        string description;
        string price;
        string stock;
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

            if (resultProduct["code"] == Result.Failed)
            {
                MessageBox.Show(resultProduct["msg"]);
                return;
            }
            if (resultProduct["code"] == Result.Processed)
            {
                this.modDropProduct.DataSource = resultProduct["content"];
                this.modDropProduct.ValueMember = "IdProducto";
                this.modDropProduct.DisplayMember = "Descripcion";
            }
        }

        private void modDropProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillProductFields();
        }

        private void fillProductFields()
        {
            this.registeredProduct = (Producto)this.modDropProduct.SelectedItem;
            txtDescription.Text = this.registeredProduct.Descripcion;
            txtPrice.Text = Convert.ToString(this.registeredProduct.Precio);
            txtStock.Text = Convert.ToString(this.registeredProduct.CantidadInventariable);
            loadTypeCombos();
            this.modProductType.SelectedValue = this.registeredProduct.IdTipoProducto;

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

            //Console.WriteLine("Id: " + registeredProduct.IdProducto + " Fecha agrega: " + registeredProduct.FechaAgrega);

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
                IdEstado = registeredProduct.IdEstado
            };

            data["user"] = Session.getInstance().session["identification"];
            controller.data = data;

            //Console.WriteLine("Modificado " + modifiedProduct.FechaAgrega + " Id" + modifiedProduct.IdTipoProducto);

            Dictionary<Object, dynamic> result = controller.modifyProduct(registeredProduct, modifiedProduct);

            if (result["code"] == Result.Processed)
            {
                this.loadCombos();
            }
            MessageBox.Show(result["msg"]);
        }
    }
}
