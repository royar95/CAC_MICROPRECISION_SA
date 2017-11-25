using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CACMicropresicion.View.Products
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
            this.CenterToScreen();
            SidePanel.Height = btnAddProduct.Height;
            addProduct.BringToFront();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnAddProduct.Height;
            addProduct.BringToFront();
        }

        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnViewProducts.Height;
            viewProducts.BringToFront();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnEditProduct.Height;
            editProduct.BringToFront();
        }
    }
}
