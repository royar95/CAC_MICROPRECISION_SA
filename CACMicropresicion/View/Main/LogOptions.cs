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
using CACMicropresicion.Model;
using CACMicropresicion.View.Log;

namespace CACMicropresicion.View.Main
{
    public partial class LogOptions : UserControl
    {

        private UserCtrl controller;
        private Dictionary<Object, dynamic> data;

        public LogOptions()
        {
            InitializeComponent();
            this.Location = new Point(237, 50);
        }

        public void loadCombos()
        {

            controller = new UserCtrl();
            Dictionary<Object, dynamic> resultUsers = this.controller.getDataToFillUsersCombo();

            if (resultUsers["code"] == Result.Failed)
            {
                MessageBox.Show(resultUsers["msg"]);
                return;
            }

            if (resultUsers["code"] == Result.Processed)
            {
                loadUsersComboBox(resultUsers["content"]);
            }

        }

        public void loadUsersComboBox(Object data)
        {

            this.userIdLog.DataSource = data;
            this.userIdLog.ValueMember = "Cedula";
            this.userIdLog.DisplayMember = "NombreCompleto";

        }

        private void btnExtractLog_Click(object sender, EventArgs e)
        {
            Parent.Controls.RemoveByKey("LogList");
            catchData();
        }

        private void catchData() {

            this.data = new Dictionary<object, dynamic>();
            LogController controller = new LogController();
            LogList control = new LogList();

            this.data["startDate"] = startDateLog.Value.Date.AddHours(00).AddMinutes(00).AddSeconds(00);
            this.data["endDate"] = endDateLog.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
            this.data["userId"] = userIdLog.SelectedValue;

            controller.data = this.data;
            Dictionary<Object, dynamic> result = controller.getLogs();

            if (result["code"] == Result.Failed) {
                MessageBox.Show(result["msg"]);
            }

            if (result["code"] == Result.Processed) {
                control.loadDataGrid(result["content"]);
                Parent.Controls.Add(control);
            }

        }

    }
}
