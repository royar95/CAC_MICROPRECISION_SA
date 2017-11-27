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

namespace CACMicropresicion.View.ProductTypes
{
    public partial class AddProductType : UserControl
    {

        string description;
        private Dictionary<string, dynamic> data;
        public AddProductType()
        {
            InitializeComponent();
            this.Location = new Point(235, 97);
        }

        private void catchInformation() {
            this.description = txtDescription.Text;
        }

        private void storeDataIntoArray() {
            this.data = new Dictionary<string, dynamic>();
            data["description"] = this.description.TrimStart().TrimEnd();

        }

        private void btnAddProductType_Click(object sender, EventArgs e)
        {
            catchInformation();
            storeDataIntoArray();
            ProductTypeController controller = new ProductTypeController();
            data["user"] = Session.getInstance().session["identification"];
            controller.data = this.data;
            Dictionary<Object, dynamic> result = controller.insertProductTypeFromMaintenance();
            MessageBox.Show(result["msg"]);

        }
    }
}
