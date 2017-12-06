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

namespace CACMicropresicion.View.ProductTypes
{
    public partial class ViewProductTypes : UserControl
    {
        private ProductTypeController controller;
        public ViewProductTypes()
        {
            InitializeComponent();
            this.Location = new Point(235, 97);
        }

        public void loadDataGrid(Object list)
        {
            this.dgViewProductTypes.DataSource = list;
            dgViewProductTypes.RowHeadersVisible = false;
            dgViewProductTypes.Columns[0].Visible = false;
            changeHeadersText();
            setColumnsSize();
            setFontConf();
        }

        private void changeHeadersText()
        {
            this.dgViewProductTypes.Columns[0].HeaderText = "Id de Categoría";
            this.dgViewProductTypes.Columns[1].HeaderText = "Descripción";
            this.dgViewProductTypes.Columns[2].HeaderText = "Estado";
            //this.dgViewProductTypes.Columns[3].HeaderText = "Eliminado";
            
        }

        private void setColumnsSize()
        {
            this.dgViewProductTypes.Columns[0].Width = 284;
            this.dgViewProductTypes.Columns[1].Width = 284;
            this.dgViewProductTypes.Columns[2].Width = 284;
            //this.dgViewProductTypes.Columns[3].Width = 150;
            
        }

        private void setFontConf()
        {
            foreach (DataGridViewColumn column in this.dgViewProductTypes.Columns)
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
            this.dgViewProductTypes.CurrentCell = null;

            foreach (DataGridViewRow row in dgViewProductTypes.Rows)
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

        private void dgViewProductTypes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.controller = new ProductTypeController();
            int rowIndex = e.RowIndex;
            int IdProductType = -1;

            DataGridViewRow rowToModify = dgViewProductTypes.Rows[rowIndex];
            IdProductType = Int32.Parse(rowToModify.Cells[0].Value.ToString());

            Dictionary<Object, dynamic> result = controller.getProductTypeById(IdProductType);

            if (result["code"] == Result.Failed)
            {
                MessageBox.Show(result["msg"]);
            }

            if (result["code"] == Result.Processed)
            {
                TipoProducto productTypeToModify = result["content"];
                showsProductTypeModifyControl(productTypeToModify);
            }



        }

        private void showsProductTypeModifyControl(TipoProducto productTypeToModify)
        {

            ModifyProductType control = new ModifyProductType();
            control.fillProductTypeInputs(productTypeToModify);
            Parent.Controls.Add(control);
            Parent.Controls.RemoveByKey("ViewProductTypes");
        }
    }
}
