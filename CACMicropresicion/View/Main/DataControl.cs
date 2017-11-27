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
    public partial class DataControl : UserControl
    {
        public DataControl()
        {
            InitializeComponent();
            this.Location = new Point(0, 50);
            this.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            removeAllControls();
            ManagamentOptions managament = new ManagamentOptions();
            managament.Mantenimiento = "Clients";
            Parent.Controls.Add(managament);
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            removeAllControls();
            ManagamentOptions managament = new ManagamentOptions();
            managament.Mantenimiento = "States";
            Parent.Controls.Add(managament);
        }

        private void btnPaymentMethods_Click(object sender, EventArgs e)
        {
            removeAllControls();
            ManagamentOptions managament = new ManagamentOptions();
            managament.Mantenimiento = "PaymentMethods";
            Parent.Controls.Add(managament);
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
            Parent.Controls.RemoveByKey("LogOptions");
            Parent.Controls.RemoveByKey("LogList");
            Parent.Controls.RemoveByKey("ViewPaymentMethods");
            Parent.Controls.RemoveByKey("ModifyPaymentMethod");
            Parent.Controls.RemoveByKey("DeletePaymentMethod");
            Parent.Controls.RemoveByKey("AddPaymentMethod");
            Parent.Controls.RemoveByKey("AddMaterialType");
            Parent.Controls.RemoveByKey("DeleteMaterialType");
            Parent.Controls.RemoveByKey("ModifyMaterialType");
            Parent.Controls.RemoveByKey("ViewMaterialTypes");
        }

        private void btnMaterialTypes_Click(object sender, EventArgs e)
        {
            removeAllControls();
            ManagamentOptions managament = new ManagamentOptions();
            managament.Mantenimiento = "MaterialTypes";
            Parent.Controls.Add(managament);
        }

    }
}
