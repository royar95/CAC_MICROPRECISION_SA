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


namespace CACMicropresicion.View.Providers
{
    public partial class ViewProviders : UserControl
    {

        private ProviderController controller;

        public ViewProviders()
        {
            InitializeComponent();
            this.Location = new Point(235, 97);
        }

        public void loadDataGrid (Object list)
        {

            this.dtViewProviders.DataSource = list;

            CurrencyManager cm = (CurrencyManager)BindingContext[dtViewProviders.DataSource];
            cm.SuspendBinding();
            dtViewProviders.RowHeadersVisible = false;
            dtViewProviders.Columns[0].Visible = false;
            setColumnsSize();
            setFontConf();
        }
        
    

    private void setColumnsSize () {
            this.dtViewProviders.Columns[0].Width = 100;
            this.dtViewProviders.Columns[1].Width = 120;
            this.dtViewProviders.Columns[2].Width = 250;
        }

        private void setFontConf() {
            foreach (DataGridViewColumn column in this.dtViewProviders.Columns)
            {
                column.DefaultCellStyle.Font = new Font("Segoe UI Light", 11);
                column.HeaderCell.Style.Font = new Font("Segoe UI Light", 12, FontStyle.Bold);
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void btnIdSearch_OnTextChange(object sender, EventArgs e)
        {
            String searchValue = txtSearch.text.TrimStart().TrimEnd();
            foreach (DataGridViewRow row in dtViewProviders.Rows)
            {
                row.Visible = true;
                if (!searchValue.Equals(""))
                {
                    if (!row.Cells[1].Value.ToString().Contains(searchValue))
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void dgViewUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.controller = new ProviderController();
            int rowIndex = e.RowIndex;
            int idProvider = -1;

            DataGridViewRow rowToModify = dtViewProviders.Rows[rowIndex];
            idProvider = Int32.Parse(rowToModify.Cells[0].Value.ToString());

            Dictionary<Object, dynamic> result = controller.getProviderById(idProvider);

            if (result["code"] == Result.Failed)
            {
                MessageBox.Show(result["msg"]);
            }

            if (result["code"] == Result.Processed)
            {
                Proveedor providerToModify = result["content"];

                showsUserModifyControl(providerToModify);

                
            }

        }

        private void showsUserModifyControl(Proveedor providerToModify)
        {

            EditProvider control = new EditProvider();
            control.fillProviderInputs(providerToModify);
            Parent.Controls.Add(control);
            Parent.Controls.RemoveByKey("ViewProviders");
        }

        private void ViewUsers_Load(object sender, EventArgs e)
        {

        }

        private void dtViewProviders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
