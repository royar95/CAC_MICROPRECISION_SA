using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CACMicropresicion.View.Main
{
    public partial class MenuProducts : Form
    {
        public MenuProducts()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnPurchases_Click(object sender, EventArgs e)
        {
            Products.Products products = new Products.Products();
            products.ShowDialog();
            //p.Visible = true;
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            Categories.Categories category = new Categories.Categories();
            category.ShowDialog();
            //c.Visible = true;
        }
    }
}
