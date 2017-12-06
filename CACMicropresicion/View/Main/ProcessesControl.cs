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
    public partial class ProcessesControl : UserControl
    {
        public ProcessesControl()
        {
            InitializeComponent();
            this.Location = new Point(0, 50);
            this.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        }

        private void btnPurchases_Click(object sender, EventArgs e)
        {
            removeAllControls();
            InOutOptions managament = new InOutOptions();
            managament.Operation = "Purchases";
            Parent.Controls.Add(managament);
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            removeAllControls();
            InOutOptions managament = new InOutOptions();
            managament.Operation = "Sales";
            Parent.Controls.Add(managament);
        }

        private void btnBills_Click(object sender, EventArgs e)
        {

        }

        private void removeAllControls()
        {
            Parent.Controls.RemoveByKey("ManagamentOptions");
            Parent.Controls.RemoveByKey("InOutOptions");
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
            Parent.Controls.RemoveByKey("AddMaterial");
            Parent.Controls.RemoveByKey("ModifyMaterial");
            Parent.Controls.RemoveByKey("DeleteMaterial");
            Parent.Controls.RemoveByKey("MaterialsList");
            Parent.Controls.RemoveByKey("AddProductType");
            Parent.Controls.RemoveByKey("DeleteProductType");
            Parent.Controls.RemoveByKey("ModifyProductType");
            Parent.Controls.RemoveByKey("ViewProductTypes");
            Parent.Controls.RemoveByKey("AddProduct");
            Parent.Controls.RemoveByKey("DeleteProduct");
            Parent.Controls.RemoveByKey("ModifyProduct");
            Parent.Controls.RemoveByKey("ViewProducts");
            Parent.Controls.RemoveByKey("AddProvider");
            Parent.Controls.RemoveByKey("EditProvider");
            Parent.Controls.RemoveByKey("DeleteProvider");
            Parent.Controls.RemoveByKey("ViewProviders");
            Parent.Controls.RemoveByKey("NewPurchase");
            Parent.Controls.RemoveByKey("ViewPurchases");
            Parent.Controls.RemoveByKey("ModifyPurchase");
            Parent.Controls.RemoveByKey("SalesRevenue");
            Parent.Controls.RemoveByKey("ReportOptions");
            Parent.Controls.RemoveByKey("SalesOptions");
            Parent.Controls.RemoveByKey("CostsOptions");
            Parent.Controls.RemoveByKey("CostOfGoodsSold");
            Parent.Controls.RemoveByKey("NewSale");

        }

    }
}
