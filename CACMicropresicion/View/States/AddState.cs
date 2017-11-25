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

namespace CACMicropresicion.View.States
{
    public partial class AddState : UserControl
    {
        string description;
        int id;
        private Dictionary<string, dynamic> data;
        public AddState()
        {
            InitializeComponent();
            this.Location = new Point(235, 94);
        }



        private void catchInformation()
        {
            this.description = txtDescription.Text;
            this.id =Convert.ToInt32(txtId.Text.TrimStart().TrimEnd());
        }

        private void storeDataIntoArray()
        {
            this.data = new Dictionary<string, dynamic>();

            data["description"] = this.description.TrimStart().TrimEnd();
            data["id"] = id;

        }

        private void btnAddSaveState_Click(object sender, EventArgs e)
        {
            catchInformation();
            storeDataIntoArray();

            StateController controller = new StateController();
            data["user"] = Session.getInstance().session["identification"];
            controller.data = this.data;
            Dictionary<Object, dynamic> result = controller.insertStateFromMaintenance();
            MessageBox.Show(result["msg"]);
        }
    }
}
