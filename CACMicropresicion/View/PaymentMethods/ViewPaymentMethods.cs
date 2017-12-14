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

namespace CACMicropresicion.View.PaymentMethods
{
    public partial class ViewPaymentMethods : UserControl
    {
        PaymentMethodController controller = new PaymentMethodController();
        public ViewPaymentMethods()
        {
            InitializeComponent();
            this.Location = new Point(235, 97);
            this.Anchor = AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top;
        }


        public void loadDataGrid(Object list)
        {
            this.dgViewPayments.DataSource = list;

            CurrencyManager cm = (CurrencyManager)BindingContext[dgViewPayments.DataSource];
            cm.SuspendBinding();

            dgViewPayments.RowHeadersVisible = false;
            dgViewPayments.Columns[0].Visible = false;

            changeHeadersText();
            setColumnsSize();
            setFontConf();
        }

        private void changeHeadersText()
        {
            this.dgViewPayments.Columns[0].HeaderText = "Codigo";
            this.dgViewPayments.Columns[1].HeaderText = "Descripcion";
            this.dgViewPayments.Columns[1].HeaderText = "Estado";
        }

        private void setColumnsSize()
        {
            this.dgViewPayments.Columns[0].Width = 80;
            this.dgViewPayments.Columns[1].Width = 350;
            this.dgViewPayments.Columns[1].Width = 180;
        }

        private void setFontConf()
        {
            foreach (DataGridViewColumn column in this.dgViewPayments.Columns)
            {
                column.DefaultCellStyle.Font = new Font("Segoe UI Light", 11);
                column.HeaderCell.Style.Font = new Font("Segoe UI Light", 12, FontStyle.Bold);
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            String searchValue = txtSearch.text.TrimStart().TrimEnd();
            this.dgViewPayments.CurrentCell = null;

            foreach (DataGridViewRow row in dgViewPayments.Rows)
            {
                row.Visible = true;

                if (!searchValue.Equals(String.Empty))
                {
                    if (!row.Cells[1].Value.ToString().Contains(searchValue))
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void dgViewPayments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.controller = new PaymentMethodController();
            int rowIndex = e.RowIndex;
            int IdPaymentMethod = -1;

            DataGridViewRow rowToModify = dgViewPayments.Rows[rowIndex];
            IdPaymentMethod = Int32.Parse(rowToModify.Cells[0].Value.ToString());

            Dictionary<Object, dynamic> result = controller.getPaymenthMethoById (IdPaymentMethod);

            if (result["code"] == Result.Failed)
            {
                MessageBox.Show(result["msg"]);
            }

            if (result["code"] == Result.Processed)
            {
                TipoPago paymentMethodToModify = result["content"];
                showPaymentMethodModifyControl(paymentMethodToModify);

            }
        }


        private void showPaymentMethodModifyControl (TipoPago paymentMethodToModify)
        {

            ModifyPaymentMethod control = new ModifyPaymentMethod();
            control.fillPaymentMethodInputs(paymentMethodToModify);
            Parent.Controls.Add(control);
            Parent.Controls.RemoveByKey("ViewPaymentMethods");
        }

    }
}
