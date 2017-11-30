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
using CACMicropresicion.View.Users;
using CACMicropresicion.View.Cients;
using CACMicropresicion.View.States;
using CACMicropresicion.Globals;
using CACMicropresicion.View.PaymentMethods;
using CACMicropresicion.View.MaterialTypes;
using CACMicropresicion.View.Materials;
using CACMicropresicion.View.Products;
using CACMicropresicion.View.ProductTypes;

namespace CACMicropresicion.View.Main
{
    public partial class ManagamentOptions : UserControl
    {

        Dictionary<Object, dynamic> result;

        public ManagamentOptions()
        {
            InitializeComponent();
            this.Location = new Point(235, 50);
        }
        
        public string Mantenimiento { get; set; }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            removeAllManagamentControls();

            switch (this.Mantenimiento) {
                case "Users":
                    AddUser addUser = new AddUser();
                    Parent.Controls.Add(addUser);
                    break;
                case "Clients":
                    AddClient addClient = new AddClient();
                    Parent.Controls.Add(addClient);
                    break;

                case "States":
                    AddState addState = new AddState();
                    Parent.Controls.Add(addState);
                    break;

                case "PaymentMethods":
                    AddPaymentMethod deletePayment = new AddPaymentMethod();
                    Parent.Controls.Add(deletePayment);
                    break;

                case "MaterialTypes":
                    AddMaterialType addMaterialType = new AddMaterialType();
                    Parent.Controls.Add(addMaterialType);
                    break;
                case "Materials":
                    AddMaterial addMaterial = new AddMaterial();
                    Parent.Controls.Add(addMaterial);
                    break;
                case "ProductTypes":
                    AddProductType addProductType = new AddProductType();
                    Parent.Controls.Add(addProductType);
                    break;

                case "Products":
                    AddProduct addProduct = new AddProduct();
                    Parent.Controls.Add(addProduct);
                    break;

            }

        }

        public void btnModify_Click(object sender, EventArgs e)
        {
            removeAllManagamentControls();

            switch (this.Mantenimiento)
            {
                case "Users":
                    ModifyUser modifyUser = new ModifyUser();
                    Parent.Controls.Add(modifyUser);
                    break;
                case "Clients":
                    ModifyClient modifyClient = new ModifyClient();
                    Parent.Controls.Add(modifyClient);
                    break;

                case "States":
                    ModifyState modifyState = new ModifyState();
                    Parent.Controls.Add(modifyState);
                    break;

                case "PaymentMethods":
                    ModifyPaymentMethod modifyPaymentMethod = new ModifyPaymentMethod();
                    Parent.Controls.Add(modifyPaymentMethod);
                    break;

                case "MaterialTypes":
                    ModifyMaterialType modifyMaterialType = new ModifyMaterialType();
                    Parent.Controls.Add(modifyMaterialType);
                    break;
                case "Materials":
                    ModifyMaterial modifyMaterial = new ModifyMaterial();
                    Parent.Controls.Add(modifyMaterial);
                    break;
                case "ProductTypes":
                    ModifyProductType modifyProductType = new ModifyProductType();
                    Parent.Controls.Add(modifyProductType);
                    break;

                case "Products":
                    ModifyProduct modifyProduct = new ModifyProduct();
                    Parent.Controls.Add(modifyProduct);
                    break;

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            removeAllManagamentControls();

            switch (this.Mantenimiento)
            {
                case "Users":
                    DeleteUser deleteUser = new DeleteUser();
                    Parent.Controls.Add(deleteUser);
                    break;
                case "Clients":
                    DeleteClient deleteClient = new DeleteClient();
                    Parent.Controls.Add(deleteClient);
                    break;

                case "States":
                    DeleteState deleteState = new DeleteState();
                    Parent.Controls.Add(deleteState);
                    break;

                case "PaymentMethods":
                    DeletePaymentMethod deletePayment = new DeletePaymentMethod();
                    Parent.Controls.Add(deletePayment);
                    break;

                case "MaterialTypes":
                    DeleteMaterialType deleteMaterialType = new DeleteMaterialType();
                    Parent.Controls.Add(deleteMaterialType);
                    break;
                case "Materials":
                    DeleteMaterial deleteMaterial = new DeleteMaterial();
                    Parent.Controls.Add(deleteMaterial);
                    break;
                case "ProductTypes":
                    DeleteProductType deleteProductType = new DeleteProductType();
                    Parent.Controls.Add(deleteProductType);
                    break;

                case "Products":
                    DeleteProduct deleteProduct = new DeleteProduct();
                    Parent.Controls.Add(deleteProduct);
                    break;
            }
        }


        private void btnList_Click(object sender, EventArgs e)
        {
            removeAllManagamentControls();

            switch (this.Mantenimiento)
            {
                case "Users":
                    ViewUsers viewUser = new ViewUsers();
                    UserCtrl userCtrl = new UserCtrl();

                    viewUser.Height = Parent.Height;
                    viewUser.Width = Parent.Width;

                    this.result = userCtrl.getAllUsers();
                    if (this.result["code"] == Result.Failed)
                    {
                        MessageBox.Show(this.result["msg"]);
                        return;
                    }

                    if (this.result["code"] == Result.Processed)
                    {
                        viewUser.loadDataGrid(this.result["content"]);
                        Parent.Controls.Add(viewUser);
                    }
                    break;

                case "Clients":
                    ClientsList clientsList = new ClientsList();
                    ClientsController cont = new ClientsController();

                    clientsList.Height = Parent.Height;
                    clientsList.Width = Parent.Width;

                    this.result = cont.getAllClients();
                    if (this.result["code"] == Result.Failed)
                    {
                        MessageBox.Show(this.result["msg"]);
                        return;
                    }
                    if (this.result["code"] == Result.Processed)
                    {
                        clientsList.loadDataGrid(this.result["content"]);
                        Parent.Controls.Add(clientsList);
                    }
                    break;

                case "States":

                    ViewStates viewState = new ViewStates();
                    StateController controller = new StateController();

                    viewState.Height = Parent.Height;
                    viewState.Width = Parent.Width;

                    this.result = controller.getAllStates();
                    if (this.result["code"] == Result.Failed)
                    {
                        MessageBox.Show(this.result["msg"]);
                        return;
                    }

                    if (this.result["code"] == Result.Processed)
                    {
                        viewState.loadDataGrid(this.result["content"]);
                        Parent.Controls.Add(viewState);
                    }

                    break;

                case "PaymentMethods":

                    ViewPaymentMethods viewPayment = new ViewPaymentMethods();
                    PaymentMethodController cnt = new PaymentMethodController();

                    viewPayment.Height = Parent.Height;
                    viewPayment.Width = Parent.Width;

                    this.result = cnt.getAllPaymentMethods();
                    if (this.result["code"] == Result.Failed)
                    {
                        MessageBox.Show(this.result["msg"]);
                        return;
                    }

                    if (this.result["code"] == Result.Processed)
                    {
                        viewPayment.loadDataGrid(this.result["content"]);
                        Parent.Controls.Add(viewPayment);
                    }

                    break;

                case "MaterialTypes":

                    ViewMaterialTypes viewMaterials = new ViewMaterialTypes();
                    MaterialTypeController contr = new MaterialTypeController();

                    viewMaterials.Height = Parent.Height;
                    viewMaterials.Width = Parent.Width;

                    this.result = contr.getAllMaterialTypes();
                    if (this.result["code"] == Result.Failed)
                    {
                        MessageBox.Show(this.result["msg"]);
                        return;
                    }

                    if (this.result["code"] == Result.Processed)
                    {
                        viewMaterials.loadDataGrid(this.result["content"]);
                        Parent.Controls.Add(viewMaterials);
                    }

                    break;

                case "Materials":

                    MaterialsList listMaterials = new MaterialsList();
                    MaterialController ctrl = new MaterialController();

                    listMaterials.Height = Parent.Height;
                    listMaterials.Width = Parent.Width;

                    this.result = ctrl.getMaterialsToPopulate();
                    if (this.result["code"] == Result.Failed)
                    {
                        MessageBox.Show(this.result["msg"]);
                        return;
                    }

                    if (this.result["code"] == Result.Processed)
                    {
                        listMaterials.loadDataGrid(this.result["content"]);
                        Parent.Controls.Add(listMaterials);
                    }

                    break;
                case "ProductTypes":
                    ViewProductTypes viewProductTypes = new ViewProductTypes();
                    ProductTypeController contr2 = new ProductTypeController();

                    viewProductTypes.Height = Parent.Height;
                    viewProductTypes.Width = Parent.Width;

                    this.result = contr2.getAllProductTypes();
                    if (this.result["code"] == Result.Failed)
                    {
                        MessageBox.Show(this.result["msg"]);
                        return;
                    }

                    if (this.result["code"] == Result.Processed)
                    {

                        viewProductTypes.loadDataGrid(this.result["content"]);
                        Parent.Controls.Add(viewProductTypes);
                    }

                    break;

                case "Products":
                    ViewProducts viewProducts = new ViewProducts();
                    ProductController contr3 = new ProductController();

                    viewProducts.Height = Parent.Height;
                    viewProducts.Width = Parent.Width;

                    this.result = contr3.getAllProducts();
                    if (this.result["code"] == Result.Failed)
                    {
                        MessageBox.Show(this.result["msg"]);
                        return;
                    }

                    if (this.result["code"] == Result.Processed)
                    {

                        viewProducts.loadDataGrid(this.result["content"]);
                        Parent.Controls.Add(viewProducts);
                    }

                    break;

            }

        }

        private void removeAllManagamentControls()
        {

            Parent.Controls.RemoveByKey("AddUser");
            Parent.Controls.RemoveByKey("AddClient");
            Parent.Controls.RemoveByKey("AddState");
            Parent.Controls.RemoveByKey("ModifyUser");
            Parent.Controls.RemoveByKey("ModifyClient");
            Parent.Controls.RemoveByKey("ModifyState");
            Parent.Controls.RemoveByKey("DeleteUser");
            Parent.Controls.RemoveByKey("DeleteClient");
            Parent.Controls.RemoveByKey("DeleteState");
            Parent.Controls.RemoveByKey("ViewUsers");
            Parent.Controls.RemoveByKey("ClientsList");
            Parent.Controls.RemoveByKey("ViewStates");
            Parent.Controls.RemoveByKey("LogOptions");
            Parent.Controls.RemoveByKey("LogList");
            Parent.Controls.RemoveByKey("ViewPaymentMethods");
            Parent.Controls.RemoveByKey("ModifyPaymentMethod");
            Parent.Controls.RemoveByKey("DeletePaymentMethod");
            Parent.Controls.RemoveByKey("AddPaymentMethod");
            Parent.Controls.RemoveByKey("AddMaterialType");
            Parent.Controls.RemoveByKey("DeleteMaterialType");
            Parent.Controls.RemoveByKey("ModifyMaterialType");
            Parent.Controls.RemoveByKey("ViewMaterialTypes");
            Parent.Controls.RemoveByKey("AddMaterial");
            Parent.Controls.RemoveByKey("ModifyMaterial");
            Parent.Controls.RemoveByKey("DeleteMaterial");
            Parent.Controls.RemoveByKey("MaterialsList");
            Parent.Controls.RemoveByKey("AddProductType");
            Parent.Controls.RemoveByKey("DeleteProductType");
            Parent.Controls.RemoveByKey("ModifyProductType");
            Parent.Controls.RemoveByKey("ViewProductTypes");
            Parent.Controls.RemoveByKey("AddProduct");
            Parent.Controls.RemoveByKey("DeleteProduct");
            Parent.Controls.RemoveByKey("ModifyProduct");
            Parent.Controls.RemoveByKey("ViewProducts");
            Parent.Controls.RemoveByKey("AddProvider");
            Parent.Controls.RemoveByKey("EditProvider");
            Parent.Controls.RemoveByKey("DeleteProvider");
            Parent.Controls.RemoveByKey("ViewProviders");
            Parent.Controls.RemoveByKey("NewPurchase");
        }


    }
}
