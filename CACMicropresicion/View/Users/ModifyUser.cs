using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CACMicropresicion.View.Main;
using CACMicropresicion.Controller;
using CACMicropresicion.Model;
using CACMicropresicion.Globals;

namespace CACMicropresicion.View.Users
{
    public partial class ModifyUser : UserControl
    {

        private Usuario registeredUser;
        private UserCtrl userControl;

        public ModifyUser()
        {
            InitializeComponent();
            this.Location = new Point(235, 97);
            loadCombos();
        }

        public void loadCombos() {

            userControl = new UserCtrl();
            Dictionary<Object, dynamic> resultUsers = this.userControl.getDataToFillUsersCombo();
            Dictionary<Object, dynamic> resultStatus = this.userControl.getAllStatus();

            if (resultUsers["code"] == Result.Failed || resultStatus["code"] == Result.Failed)
            {
                MessageBox.Show(resultUsers["msg"]);
                return;
            }

            if (resultUsers["code"] == Result.Processed && resultStatus["code"] == Result.Processed)
            {
                loadTypesComboBox();
                loadStatusComboBox(resultStatus["content"]);
            }

        }

        public void loadTypesComboBox() {
            List<UserTypes> types = new List<UserTypes>();
            types.Add(new UserTypes(1, "Administrador"));
            types.Add(new UserTypes(2, "Operario"));
            this.modDropUserType.DataSource = types;
            this.modDropUserType.ValueMember = "value";
            this.modDropUserType.DisplayMember = "display";
        }

        public void loadStatusComboBox(Object data) {

            this.modDropUserStatus.DataSource = data;
            this.modDropUserStatus.ValueMember = "IdEstado";
            this.modDropUserStatus.DisplayMember = "Descripcion";

        }

        private void modBtnSaveUserChanges_Click(object sender, EventArgs e)
        {

            this.userControl = new UserCtrl();
            Dictionary<Object, dynamic> data = new Dictionary<Object, dynamic>();

            Usuario modifiedUser = new Usuario()
            {
                IdUsuario = registeredUser.IdUsuario,
                Cedula = registeredUser.Cedula,
                Tipo = ((UserTypes)modDropUserType.SelectedItem).value,
                NombreCompleto = modtxtName.Text.TrimStart().TrimEnd(),
                PrimerApellido = modtxtLastname1.Text.TrimStart().TrimEnd(),
                SegundoApellido = modtxtLastname2.Text.TrimStart().TrimEnd(),
                NombreUsuario = modtxtUserName.Text.TrimStart().TrimEnd(),
                Contrasena = modtxtPassword.Text.TrimStart().TrimEnd(),
                FechaAgrega = registeredUser.FechaAgrega,
                FechaElimina = registeredUser.FechaElimina,
                UsuarioAgrega = registeredUser.UsuarioAgrega,
                Eliminado = registeredUser.Eliminado,
                IdEstado = (int)modDropUserStatus.SelectedValue
            };
          
            
            data["user"] = Session.getInstance().session["identification"];
            userControl.data = data;

            Dictionary<Object, dynamic> result = userControl.modifyUser(registeredUser, modifiedUser);

            if (result["code"] == Result.Processed) {
                loadDataGridView();
            }

            MessageBox.Show(result["msg"]);
        }

        private void loadDataGridView () {

            ViewUsers viewUser = new ViewUsers();
            UserCtrl userCtrl = new UserCtrl();

            viewUser.Height = Parent.Height;
            viewUser.Width = Parent.Width;

            Dictionary<Object, dynamic> result = userCtrl.getAllUsers();

            if (result["code"] == Result.Failed)
            {
                MessageBox.Show(result["msg"]);
                return;
            }

            if (result["code"] == Result.Processed)
            {
                viewUser.loadDataGrid(result["content"]);
                Parent.Controls.Add(viewUser);
            }

            Parent.Controls.RemoveByKey("ModifyUser");

        }

        public void fillUserInputs(Usuario user) {

            this.registeredUser = user;
            modTxtIdentification.Text = this.registeredUser.Cedula;
            modtxtName.Text = this.registeredUser.NombreCompleto;
            modtxtLastname1.Text = this.registeredUser.PrimerApellido;
            modtxtLastname2.Text = this.registeredUser.SegundoApellido;
            modtxtUserName.Text = this.registeredUser.NombreUsuario;
            modtxtPassword.Text = this.registeredUser.Contrasena;

            //Indica el tipo de usuario
            if (this.registeredUser.Tipo == 1)
            {
                modDropUserType.SelectedIndex = 0;
            }
            if (this.registeredUser.Tipo == 2)
            {
                modDropUserType.SelectedIndex = 1;
            }

            //Indica el estado del usuario
            modDropUserStatus.SelectedValue = this.registeredUser.IdEstado;

        }
    }
}
