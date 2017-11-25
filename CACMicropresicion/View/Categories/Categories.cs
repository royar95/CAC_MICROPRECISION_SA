using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CACMicropresicion.View.Categories
{
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
            this.CenterToScreen();
            SidePanel.Height = btnAddCategory.Height;
            addCategory.BringToFront();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnAddCategory.Height;
            addCategory.BringToFront();
        }

        private void btnViewCategories_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnViewCategories.Height;
            viewCategories.BringToFront();
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnEditCategory.Height;
            editCategory.BringToFront();
        }
    }
}
