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

namespace CACMicropresicion.View.Materials
{
    public partial class MaterialsList : UserControl
    {

        private MaterialController controller;

        public MaterialsList()
        {
            InitializeComponent();
            this.Location = new Point(235, 97);
            this.Anchor = AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top;
        }

        public void loadDataGrid(Object list)
        {
            this.dgMaterials.DataSource = list;

            CurrencyManager cm = (CurrencyManager)BindingContext[dgMaterials.DataSource];
            cm.SuspendBinding();

            dgMaterials.RowHeadersVisible = false;
            dgMaterials.Columns[0].Visible = false;

            setColumnsSize();
            setFontConf();
        }

        private void setColumnsSize()
        {
            this.dgMaterials.Columns[0].Width = 80;
            this.dgMaterials.Columns[1].Width = 350;
            this.dgMaterials.Columns[2].Width = 180;
        }

        private void setFontConf()
        {
            foreach (DataGridViewColumn column in this.dgMaterials.Columns)
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
            int valueLength = searchValue.Length;

            foreach (DataGridViewRow row in dgMaterials.Rows)
            {
                row.Visible = true;

                if (!searchValue.Equals(String.Empty))
                {
                    if (valueLength > row.Cells[1].Value.ToString().Length)
                    {
                        row.Visible = false;
                        continue;
                    }

                    string cellValue = row.Cells[1].Value.ToString().Substring(0, valueLength);

                    if (!cellValue.Equals(searchValue))
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void dgMaterials_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.controller = new MaterialController();
            int rowIndex = e.RowIndex;
            int IdMaterial = -1;

            DataGridViewRow rowToModify = dgMaterials.Rows[rowIndex];
            IdMaterial = Int32.Parse(rowToModify.Cells[0].Value.ToString());

            Dictionary<Object, dynamic> result = controller.getMaterialById(IdMaterial);

            if (result["code"] == Result.Failed)
            {
                MessageBox.Show(result["msg"]);
            }

            if (result["code"] == Result.Processed)
            {
                Material materialToModify = result["content"];
                showsMaterialModifyControl(materialToModify);
            }
        }

        private void showsMaterialModifyControl(Material materialToModify)
        {

            ModifyMaterial control = new ModifyMaterial();
            control.fillInputs(materialToModify);
            Parent.Controls.Add(control);
            Parent.Controls.RemoveByKey("MaterialsList");
        }

    }
}
