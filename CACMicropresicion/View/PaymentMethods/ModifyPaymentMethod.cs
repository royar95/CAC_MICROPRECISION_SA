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
            Dictionary<Object, dynamic> resultStatus = this.controller.getAllRegisterStatus();


            if (resultStatus["code"] == Result.Failed)
            {
                MessageBox.Show(resultStatus["msg"]);
                return;
            }

            if (resultStatus["code"] == Result.Processed)
            {
                this.loadStatusCombo(resultStatus["content"]);
            }

        }

        private void loadStatusCombo(Object list) {
            this.cmbStatus.DataSource = list;
            this.cmbStatus.ValueMember = "IdEstado";
            this.cmbStatus.DisplayMember = "Descripcion";
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
                IdEstado = ((Estado)this.cmbStatus.SelectedItem).IdEstado
            };


            data["user"] = Session.getInstance().session["identification"];
            controller.data = data;

            Dictionary<Object, dynamic> result = controller.modifyPaymentMethod(registeredPaymentMethod, modifiedPaymentMethod);

            if (result["code"] == Result.Processed)
            {
                this.loadDataGridView();
            }

            MessageBox.Show(result["msg"]);
        }

        private void loadDataGridView()
        {

            ViewPaymentMethods viewPayment = new ViewPaymentMethods();
            PaymentMethodController cnt = new PaymentMethodController();

            viewPayment.Height = Parent.Height;
            viewPayment.Width = Parent.Width;

            Dictionary<Object, dynamic> result = cnt.getAllPaymentMethods();
            if (result["code"] == Result.Failed)
            {
                MessageBox.Show(result["msg"]);
                return;
            }

            if (result["code"] == Result.Processed)
            {
                viewPayment.loadDataGrid(result["content"]);
                Parent.Controls.Add(viewPayment);
            }

            Parent.Controls.RemoveByKey("ModifyPaymentMethod");

        }

        public void fillPaymentMethodInputs (TipoPago paymentMethod) {
            this.registeredPaymentMethod = paymentMethod;
            this.txtDescription.Text = paymentMethod.Descripcion;
            this.cmbStatus.SelectedValue = paymentMethod.IdEstado;
        }

    }
}
