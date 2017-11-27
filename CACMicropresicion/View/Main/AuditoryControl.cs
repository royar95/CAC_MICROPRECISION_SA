using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CACMicropresicion.Controller;
using CACMicropresicion.Globals;
using CACMicropresicion.View.Log;

namespace CACMicropresicion.View.Main
{
    public partial class AuditoryControl : UserControl
    {
        public AuditoryControl()
        {
            InitializeComponent();
            this.Location = new Point(0, 50);
            this.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        }

        private void btnLog_Click(object sender, EventArgs e)
        {

            removeAllControls();
            LogOptions control = new LogOptions();
            control.loadCombos();
            Parent.Controls.Add(control);

        }

        private void removeAllControls()
        {
            Parent.Controls.RemoveByKey("ManagamentOptions");
            Parent.Controls.RemoveByKey("AddUser");
            Parent.Controls.RemoveByKey("AddClient");
            Parent.Controls.RemoveByKey("AddState");
            Parent.Controls.RemoveByKey("ModifyUser");
            Parent.Controls.RemoveByKey("ModifyClient");
            Parent.Controls.RemoveByKey("ModifyState");
            Parent.Controls.RemoveByKey("DeleteUser");
            Parent.Controls.RemoveByKey("DeleteClient");
            Parent.Controls.RemoveByKey("DeleteState");
            Parent.Controls.RemoveByKey("ViewUsers");
            Parent.Controls.RemoveByKey("ClientsList");
            Parent.Controls.RemoveByKey("ViewStates");
            Parent.Controls.RemoveByKey("DeletePaymentMethod");
            Parent.Controls.RemoveByKey("AddPaymentMethod");
            Parent.Controls.RemoveByKey("ModifyPaymentMethod");
            Parent.Controls.RemoveByKey("ViewPaymentMethods");
            Parent.Controls.RemoveByKey("LogOptions");
            Parent.Controls.RemoveByKey("LogList");
        }

    }
}
