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

namespace CACMicropresicion.View.Products
{
    public partial class ViewProducts : UserControl
    {
        private ProductController controller;
        public ViewProducts()
        {
            InitializeComponent();
            this.Location = new Point(235, 97);
        }

        public void loadDataGrid(Object list)
        {
            this.dtViewProducts.DataSource = list;
            CurrencyManager cm = (CurrencyManager)BindingContext[dtViewProducts.DataSource];
            cm.SuspendBinding();

            dtViewProducts.RowHeadersVisible = false;
            dtViewProducts.Columns[0].Visible = false;

            changeHeadersText();
            setColumnsSize();
            setFontConf();
        }

        private void changeHeadersText()
        {
            this.dtViewProducts.Columns[0].HeaderText = "Id de Producto";
            this.dtViewProducts.Columns[1].HeaderText = "Categoría";
            this.dtViewProducts.Columns[2].HeaderText = "Descripción";
            this.dtViewProducts.Columns[3].HeaderText = "Precio";
            this.dtViewProducts.Columns[4].HeaderText = "Cantidad";
            this.dtViewProducts.Columns[5].HeaderText = "Estado";
            

        }

        private void setColumnsSize()
        {
            this.dtViewProducts.Columns[0].Width = 130;
            this.dtViewProducts.Columns[1].Width = 135;
            this.dtViewProducts.Columns[2].Width = 300;
            this.dtViewProducts.Columns[3].Width = 135;
            this.dtViewProducts.Columns[4].Width = 135;
            this.dtViewProducts.Columns[5].Width = 135;
            

        }

        private void setFontConf()
        {
            foreach (DataGridViewColumn column in this.dtViewProducts.Columns)
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
            this.dtViewProducts.CurrentCell = null;

            foreach (DataGridViewRow row in dtViewProducts.Rows)
            {
                row.Visible = true;

                if (!searchValue.Equals(String.Empty))
                {
                    if (!row.Cells[2].Value.ToString().Contains(searchValue))
                    {
                        row.Visible = false;
                    }
                }
            }

        }

        private void dtViewProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.controller = new ProductController();
            int rowIndex = e.RowIndex;
            int IdProduct = -1;

            DataGridViewRow rowToModify = dtViewProducts.Rows[rowIndex];
            IdProduct = Int32.Parse(rowToModify.Cells[0].Value.ToString());

            Dictionary<Object, dynamic> result = controller.getProductById(IdProduct);

            if (result["code"] == Result.Failed)
            {
                MessageBox.Show(result["msg"]);
            }

            if (result["code"] == Result.Processed)
            {
                Producto productToModify = result["content"];
                showsProductModifyControl(productToModify);
            }



        }

        private void showsProductModifyControl(Producto productToModify)
        {

            ModifyProduct control = new ModifyProduct();
            control.fillProductInputs(productToModify);
            Parent.Controls.Add(control);
            Parent.Controls.RemoveByKey("ViewProducts");
        }
    }
}
