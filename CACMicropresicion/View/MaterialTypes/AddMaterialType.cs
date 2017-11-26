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

namespace CACMicropresicion.View.MaterialTypes
{
    public partial class AddMaterialType : UserControl
    {
        string description;
        private Dictionary<string, dynamic> data;
        public AddMaterialType()
        {
            InitializeComponent();
            this.Location = new Point(235, 94);
        }

        private void catchInformation()
        {
            this.description = txtDescription.Text;
        }

        private void storeDataIntoArray()
        {
            this.data = new Dictionary<string, dynamic>();
            data["description"] = this.description.TrimStart().TrimEnd();
        }

        private void btnAddMaterialType_Click(object sender, EventArgs e)
        {
            catchInformation();
            storeDataIntoArray();

            MaterialTypeController controller = new MaterialTypeController();
            data["user"] = Session.getInstance().session["identification"];
            controller.data = this.data;
            Dictionary<Object, dynamic> result = controller.insertPaymentMethodFromMaintenance();
            MessageBox.Show(result["msg"]);
        }
    }
}
