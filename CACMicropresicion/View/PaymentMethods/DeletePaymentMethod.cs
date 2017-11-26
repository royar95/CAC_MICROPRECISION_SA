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
using CACMicropresicion.Model;
using CACMicropresicion.Globals;

namespace CACMicropresicion.View.PaymentMethods
{
    public partial class DeletePaymentMethod : UserControl
    {
        private PaymentMethodController controller;
        private TipoPago registeredPaymentMethod;

        public DeletePaymentMethod()
        {
            InitializeComponent();
            this.Location = new Point(235, 94);
            loadCombos();
        }



        public void loadCombos()
        {

            controller = new PaymentMethodController();
            Dictionary<Object, dynamic> resultPaymentMethod = this.controller.getDataToFillPaymentsCombo();

            if (resultPaymentMethod["code"] == Result.Failed)
            {
                MessageBox.Show(resultPaymentMethod["msg"]);
                return;
            }

            if (resultPaymentMethod["code"] == Result.Processed)
            {
                loadPaymentMethodsComboBox(resultPaymentMethod["content"]);
            }
        }

        public void loadPaymentMethodsComboBox(Object data)
        {
            this.delDropPaymentId.DataSource = data;
            this.delDropPaymentId.ValueMember = "IdTipoPago";
            this.delDropPaymentId.DisplayMember = "Descripcion";

        }

        private void delBtnDeletePaymentMethod_Click(object sender, EventArgs e)
        {
            this.controller = new PaymentMethodController();
            Dictionary<string, dynamic> data = new Dictionary<string, dynamic>();

            this.registeredPaymentMethod = (TipoPago)delDropPaymentId.SelectedItem;
            data["id"] = registeredPaymentMethod.IdTipoPago;
            //  data["user"] = Session.getInstance().session["identification"];
            data["user"] = "userTest";
            controller.data = data;

            Dictionary<Object, dynamic> result = controller.deletePaymentMethod(registeredPaymentMethod);

            if (result["code"] == Result.Processed)
            {
                this.loadCombos();
            }

            MessageBox.Show(result["msg"]);
        }
    }
}
