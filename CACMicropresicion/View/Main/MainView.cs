using System;
using System.Windows.Forms;

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
