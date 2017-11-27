using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CACMicropresicion.Model;
using CACMicropresicion.Controller;
using CACMicropresicion.Globals;

namespace CACMicropresicion.View.PaymentMethods
{
    public partial class ModifyPaymentMethod : UserControl
    {
        private TipoPago registeredPaymentMethod;
        string description;
        PaymentMethodController controller;

        public ModifyPaymentMethod()
        {
            InitializeComponent();
            this.Location = new Point(235, 97);
            loadCombos();
        }

        public void loadCombos()
        {
            controller = new PaymentMethodController();
            Dictionary<Object, dynamic> resultPayment = this.controller.getDataToFillPaymentsCombo();


            if (resultPayment["code"] == Result.Failed)
            {
                MessageBox.Show(resultPayment["msg"]);
                return;
            }

            if (resultPayment["code"] == Result.Processed)
            {
                // loadTypesComboBox();
                loadPaymentComboBox(resultPayment["content"]);
            }

        }


        public void loadPaymentComboBox(Object data)
        {

            this.modDropPaymentId.DataSource = data;
            this.modDropPaymentId.ValueMember = "IdTipoPago";
            this.modDropPaymentId.DisplayMember = "Descripcion";

        }

        private void modDropPaymentId_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.registeredPaymentMethod = (TipoPago)this.modDropPaymentId.SelectedItem;
            txtDescription.Text = this.registeredPaymentMethod.Descripcion;
        }

        private void modBtnSavePaymentChanges_Click(object sender, EventArgs e)
        {
            this.controller = new PaymentMethodController();
            Dictionary<string, dynamic> data = new Dictionary<string, dynamic>();

            TipoPago modifiedPaymentMethod = new TipoPago()
            {
                IdTipoPago = registeredPaymentMethod.IdTipoPago,
                Descripcion = txtDescription.Text.TrimStart().TrimEnd(),
                FechaAgrega = registeredPaymentMethod.FechaAgrega,
                FechaElimina = registeredPaymentMethod.FechaElimina,
                UsuarioAgrega = registeredPaymentMethod.UsuarioAgrega,
                Eliminado = registeredPaymentMethod.Eliminado,
                IdEstado = registeredPaymentMethod.IdEstado
            };


            data["user"] = Session.getInstance().session["identification"];
            controller.data = data;

            Dictionary<Object, dynamic> result = controller.modifyPaymentMethod(registeredPaymentMethod, modifiedPaymentMethod);

            if (result["code"] == Result.Processed)
            {
                this.loadCombos();
            }

            MessageBox.Show(result["msg"]);
        }
    }
}
