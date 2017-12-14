using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CACMicropresicion.Globals;
using CACMicropresicion.Controller;

namespace CACMicropresicion.View.Providers
{
    public partial class AddProvider : UserControl
    {

        string description;
        private Dictionary<string, dynamic> data;

        public AddProvider() {
            InitializeComponent();
            this.Location = new Point(235, 94);
        }

        private void btnAddProvider_Click_1(object sender, EventArgs e)
        {
            catchInformation();
            storeDataIntoArray();

            ProviderController controller = new ProviderController();
            data["user"] = Session.getInstance().session["identification"];
            controller.data = this.data;
            Dictionary<Object, dynamic> result = controller.insertProvider();
            MessageBox.Show(result["msg"]);


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
    }
}
