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

namespace CACMicropresicion.View.ProductTypes
{
    public partial class ModifyProductType : UserControl
    {

        private TipoProducto registeredProductType;
        string description;
        ProductTypeController controller;
        public ModifyProductType()
        {
            InitializeComponent();
            this.Location = new Point(235, 97);
            loadCombos();
        }

        public void loadCombos()
        {
            controller = new ProductTypeController();
            Dictionary<Object, dynamic> resultProductType = this.controller.getDataToFillProductTypesCombo();

            if (resultProductType["code"] == Result.Failed)
            {
                MessageBox.Show(resultProductType["msg"]);
                return;
            }
            if (resultProductType["code"] == Result.Processed)
            {
                //loadPaymentComboBox(resultProductType["content"]);
                this.modDropProductType.DataSource = resultProductType["content"];
                this.modDropProductType.ValueMember = "IdTipoProducto";
                this.modDropProductType.DisplayMember = "Descripcion";
            }
        }

        private void fillDescriptionField()
        {
            this.registeredProductType = (TipoProducto)this.modDropProductType.SelectedItem;
            txtDescription.Text = this.registeredProductType.Descripcion;

        }

        private void modDropProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillDescriptionField();
        }

        private void modBtnProductType_Click(object sender, EventArgs e)
        {
            this.controller = new ProductTypeController();
            Dictionary<string, dynamic> data = new Dictionary<string, dynamic>();
            Console.WriteLine("Id: " + registeredProductType.IdTipoProducto + " Fecha agrega: " + registeredProductType.FechaAgrega);
            TipoProducto modifiedProductType = new TipoProducto()
            {
                IdTipoProducto = registeredProductType.IdTipoProducto,
                Descripcion = txtDescription.Text.TrimStart().TrimEnd(),
                FechaAgrega = registeredProductType.FechaAgrega,
                FechaElimina = registeredProductType.FechaElimina,
                UsuarioAgrega = registeredProductType.UsuarioAgrega,
                Eliminado = registeredProductType.Eliminado,
                IdEstado = registeredProductType.IdEstado
            };

            data["user"] = Session.getInstance().session["identification"];
            controller.data = data;

            Console.WriteLine("Modificado " + modifiedProductType.FechaAgrega + " Id" + modifiedProductType.IdTipoProducto);

            Dictionary<Object, dynamic> result = controller.modifyProductType(registeredProductType, modifiedProductType);

            if (result["code"] == Result.Processed)
            {
                this.loadCombos();
            }
            MessageBox.Show(result["msg"]);
        }
    }
}

