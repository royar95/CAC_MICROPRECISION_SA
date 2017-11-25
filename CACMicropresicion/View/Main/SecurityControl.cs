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
    public partial class SecurityControl : UserControl
    {
        public SecurityControl()
        {
            InitializeComponent();
            this.Location = new Point(0, 50);
            this.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Parent.Controls.RemoveByKey("ManagamentOptions");
            ManagamentOptions managament = new ManagamentOptions();
            managament.Mantenimiento = "Users";
            Parent.Controls.Add(managament);
        }

        private void removeAllControls() {
            Parent.Controls.RemoveByKey("ManagamentOptions");
            Parent.Controls.RemoveByKey("AddUser");
            Parent.Controls.RemoveByKey("ModifyUser");
            Parent.Controls.RemoveByKey("DeleteUser");
            Parent.Controls.RemoveByKey("ViewUsers");
        }

    }
}
