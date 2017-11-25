using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CACMicropresicion.View.Main
{
    public partial class CategoriesControl : UserControl
    {
        public CategoriesControl()
        {
            InitializeComponent();
        }

        private void btnSecurity_Click(object sender, EventArgs e)
        {
            SecurityControl security = new SecurityControl();
            showPanel(security);
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            DataControl data = new DataControl();
            showPanel(data);
        }

        private void btnProcesses_Click(object sender, EventArgs e)
        {
            ProcessesControl processes = new ProcessesControl();
            showPanel(processes);
        }

        private void btnAuditory_Click(object sender, EventArgs e)
        {
            AuditoryControl auditory = new AuditoryControl();
            showPanel(auditory);
        }

        private void showPanel (UserControl control) {
            removeAllSidePanels();
            control.Height = Parent.Height;
            Parent.Controls.Add(control);
        }

        private void removeAllSidePanels()
        {
            Parent.Controls.RemoveByKey("SecurityControl");
            Parent.Controls.RemoveByKey("DataControl");
            Parent.Controls.RemoveByKey("ProcessesControl");
            Parent.Controls.RemoveByKey("AuditoryControl");
        }

    }
}
