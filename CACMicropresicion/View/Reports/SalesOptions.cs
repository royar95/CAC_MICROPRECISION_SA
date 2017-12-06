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
    public partial class SalesOptions : UserControl
    {
        private SalesRevenueController controller;
        private Dictionary<Object, dynamic> data;


        public SalesOptions()
        {
            InitializeComponent();
            this.Location = new Point(237, 50);
        }

        private void btnExtractSales_Click(object sender, EventArgs e)
        {
            Parent.Controls.RemoveByKey("SalesRevenue");
            catchData();
        }
        
        private void catchData()
        {

            this.data = new Dictionary<object, dynamic>();
            SalesRevenueController controller = new SalesRevenueController();
            SalesRevenue control = new SalesRevenue();

            this.data["startDate"] = startDateLog.Value;
            this.data["endDate"] = endDateLog.Value;

            controller.data = this.data;
            Dictionary<Object, dynamic> result = controller.getSales();

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
