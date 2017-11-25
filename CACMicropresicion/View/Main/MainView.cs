using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CACMicropresicion.View;
using CACMicropresicion.Globals;
using CACMicropresicion.View.Providers;

namespace CACMicropresicion.View.Main
{
    public partial class MainView : Form
    {

        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSecurity_Click(object sender, EventArgs e)
        {
        }

        private void btnData_Click(object sender, EventArgs e)
        {
        }

        private void btnProcesses_Click(object sender, EventArgs e)
        {
        }

        private void btnAuditory_Click(object sender, EventArgs e)
        {
        }

    }
}
