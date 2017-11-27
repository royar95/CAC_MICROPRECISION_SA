using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CACMicropresicion.View.Providers
{
    public partial class Providers : Form
    {
        public Providers()
        {
            InitializeComponent();
            this.CenterToScreen();
            SidePanel.Height = btnAddProvider.Height;
        }

        private void btnAddProvider_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnAddProvider.Height;
            addProvider.BringToFront();
        }

        private void btnViewProviders_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnViewProviders.Height;
            viewProviders.BringToFront();
        }

        private void btnEditProvider_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnEditProvider.Height;
            editProvider.BringToFront();
        }
    }
}
