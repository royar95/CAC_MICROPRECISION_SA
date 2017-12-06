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

namespace CACMicropresicion.View.Reports
{
    public partial class CostsOptions : UserControl
    {
        private Dictionary<Object, dynamic> data;

        public CostsOptions()
        {
            InitializeComponent();
            this.Location = new Point(237, 50);
        }

        private void btnExtractCosts_Click(object sender, EventArgs e)
        {
            Parent.Controls.RemoveByKey("CostOfGoodsSold");
            catchData();
        }

        private void catchData()
        {

            this.data = new Dictionary<object, dynamic>();
            CostsController controller = new CostsController();
            CostOfGoodsSold control = new CostOfGoodsSold();

            this.data["startDate"] = startDateLog.Value.Date.AddHours(00).AddMinutes(00).AddSeconds(00);
            this.data["endDate"] = endDateLog.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59); 

            controller.data = this.data;
            Dictionary<Object, dynamic> result = controller.getCosts();

            if (result["code"] == Result.Failed)
            {
                MessageBox.Show(result["msg"]);
            }

            if (result["code"] == Result.Processed)
            {
                control.loadDataGrid(result["content"]);
                Parent.Controls.Add(control);
            }

        }

    }
}