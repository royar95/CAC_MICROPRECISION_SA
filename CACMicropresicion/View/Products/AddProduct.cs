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
    public partial class AddProduct : UserControl
    {
        ProductTypeController cont;
        private Dictionary<string, dynamic> data;
        int productType;
        string description;
        decimal price;
        int stock;
        public AddProduct()
        {
            InitializeComponent();
            this.Location = new Point(235, 97);
            loadCombos();
        }

        public void loadCombos()
        {
            cont = new ProductTypeController();
            Dictionary<Object, dynamic> resultProductType = this.cont.getDataToFillProductTypesCombo();

            if (resultProductType["code"] == Result.Failed)
            {
                MessageBox.Show(resultProductType["msg"]);
                return;
            }
            if (resultProductType["code"] == Result.Processed)
            {
                this.modDropProductType.DataSource = resultProductType["content"];
                this.modDropProductType.ValueMember = "IdTipoProducto";
                this.modDropProductType.DisplayMember = "Descripcion";
            }
        }

        private void catchInformation()
        {
            this.productType = Convert.ToInt32(modDropProductType.SelectedValue);
            this.description = txtDescription.Text;
            this.price = Convert.ToDecimal(txtPrice.Text);
            this.stock = Convert.ToInt32(txtStock.Text);
        }

        private void storeDataIntoArray()
        {
            this.data = new Dictionary<string, dynamic>();
            data["productType"] = this.productType;
            data["description"] = this.description.TrimStart().TrimEnd();
            data["price"] = this.price;
            data["stock"] = this.stock;

        }

        private void addBtnProduct_Click(object sender, EventArgs e)
        {
            catchInformation();
            storeDataIntoArray();
            ProductController controller = new ProductController();
            data["user"] = Session.getInstance().session["identification"];
            controller.data = this.data;
            Dictionary<Object, dynamic> result = controller.insertProductFromMaintenance();
            MessageBox.Show(result["msg"]);
            txtDescription.Text = "";
            txtPrice.Text = "";
            txtStock.Text = "";

        }

        private void txtPrice_OnValueChanged(object sender, EventArgs e)
        {
            if (txtPrice.Text.Equals(String.Empty)) {
                txtPrice.Text = "1";
            }
        }

        private void txtStock_OnValueChanged(object sender, EventArgs e)
        {
            if (txtStock.Text.Equals(String.Empty))
            {
                txtStock.Text = "1";
            }
        }
    }
}
