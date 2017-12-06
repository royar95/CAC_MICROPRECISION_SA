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

namespace CACMicropresicion.View.MaterialTypes
{
    public partial class ViewMaterialTypes : UserControl
    {

        private MaterialTypeController controller;

        public ViewMaterialTypes()
        {
            InitializeComponent();
            this.Location = new Point(235, 97);
            this.Anchor = AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top;
        }

        private void setColumnsSize()
        {
            this.dgViewMaterialTypes.Columns[0].Width = 80;
            this.dgViewMaterialTypes.Columns[1].Width = 350;
            this.dgViewMaterialTypes.Columns[2].Width = 180;
        }

        private void setFontConf()
        {
            foreach (DataGridViewColumn column in this.dgViewMaterialTypes.Columns)
            {
                column.DefaultCellStyle.Font = new Font("Segoe UI Light", 11);
                column.HeaderCell.Style.Font = new Font("Segoe UI Light", 12, FontStyle.Bold);
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        public void loadDataGrid(Object list)
        {
            this.dgViewMaterialTypes.DataSource = list;

            CurrencyManager cm = (CurrencyManager)BindingContext[dgViewMaterialTypes.DataSource];
            cm.SuspendBinding();

            dgViewMaterialTypes.RowHeadersVisible = false;
            dgViewMaterialTypes.Columns[0].Visible = false;

            setColumnsSize();
            setFontConf();
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            String searchValue = txtSearch.text.TrimStart().TrimEnd();
            this.dgViewMaterialTypes.CurrentCell = null;

            foreach (DataGridViewRow row in dgViewMaterialTypes.Rows)
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

        private void dgViewMaterialTypes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.controller = new MaterialTypeController();
            int rowIndex = e.RowIndex;
            int IdMaterialType = -1;

            DataGridViewRow rowToModify = dgViewMaterialTypes.Rows[rowIndex];
            IdMaterialType = Int32.Parse(rowToModify.Cells[0].Value.ToString());

            Dictionary<Object, dynamic> result = controller.getMaterialTypeById(IdMaterialType);

            if (result["code"] == Result.Failed)
            {
                MessageBox.Show(result["msg"]);
            }

            if (result["code"] == Result.Processed)
            {
                TipoMaterial materialTypeToModify = result["content"];
                showsMateriaTypeControl(materialTypeToModify);
            }
        }

        private void showsMateriaTypeControl(TipoMaterial materialTypeToModify)
        {

            ModifyMaterialType control = new ModifyMaterialType();
            control.fillInputs(materialTypeToModify);
            Parent.Controls.Add(control);
            Parent.Controls.RemoveByKey("ViewMaterialTypes");
        }

    }
}
