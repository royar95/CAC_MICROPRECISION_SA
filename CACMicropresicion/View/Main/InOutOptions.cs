using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CACMicropresicion.Controller;
using CACMicropresicion.Globals;
using CACMicropresicion.View.Purchases;
using CACMicropresicion.View.Sales;

namespace CACMicropresicion.View.Main
{
    public partial class InOutOptions : UserControl
    {

        private PurchaseController purchaseController;
        private SalesController salesController;

        public InOutOptions()
        {
            InitializeComponent();
            this.Location = new Point(235, 50);
        }

        public string Operation { get; set; }

        private void btnNew_Click(object sender, EventArgs e)
        {
            removeAllManagamentControls();

            

            switch (this.Operation) {
                case "Purchases":

                    this.purchaseController = new PurchaseController();
                    Dictionary<Object, dynamic> resultMaterials, resultPaymentTypes;
                    NewPurchase purchaseControl = new NewPurchase();

                    resultMaterials = purchaseController.getAllMaterials();
                    resultPaymentTypes = purchaseController.getAllPaymentTypes();

                    if (resultMaterials["code"] == Result.Failed ||
                        resultPaymentTypes["code"] == Result.Failed) {
                            MessageBox.Show(resultMaterials["msg"]);
                            break;
                    }

                    purchaseControl.populateMaterialList(resultMaterials["content"]);
                    purchaseControl.populatePaymentTypes(resultPaymentTypes["content"]);
                    Parent.Controls.Add(purchaseControl);

                    break;

                case "Sales":

                    this.salesController = new SalesController();
                    Dictionary<Object, dynamic> resultProducts, resultClients;
                    NewSale salesControl = new NewSale();

                    resultProducts = salesController.getAllProducts();
                    resultPaymentTypes = salesController.getAllPaymentTypes();
                    resultClients = salesController.getAllCustomers();

                    if (resultProducts["code"] == Result.Failed ||
                        resultPaymentTypes["code"] == Result.Failed ||
                        resultClients["code"] == Result.Failed)
                    {
                        MessageBox.Show(resultProducts["msg"]);
                        break;
                    }

                    salesControl.populateProducts(resultProducts["content"]);
                    salesControl.populatePaymentTypes(resultPaymentTypes["content"]);
                    salesControl.populateCustomerList(resultClients["content"]);
                    Parent.Controls.Add(salesControl);

                    break;
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            this.removeAllManagamentControls();
            this.purchaseController = new PurchaseController();

            switch (this.Operation) {
                case "Purchases":
                    ViewPurchases viewPurchaseControl = new ViewPurchases();
                    Parent.Controls.Add(viewPurchaseControl);
                    break;
                case "Sales":
                    ViewSales viewSalesControl = new ViewSales();
                    Parent.Controls.Add(viewSalesControl);
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
            Parent.Controls.RemoveByKey("ViewPurchases");
            Parent.Controls.RemoveByKey("ModifyPurchase");
            Parent.Controls.RemoveByKey("SalesRevenue");
            Parent.Controls.RemoveByKey("ReportOptions");
            Parent.Controls.RemoveByKey("SalesOptions");
            Parent.Controls.RemoveByKey("CostsOptions");
            Parent.Controls.RemoveByKey("CostOfGoodsSold");
            Parent.Controls.RemoveByKey("NewSale");
            Parent.Controls.RemoveByKey("ViewSales");
            Parent.Controls.RemoveByKey("ModifySale");

        }

    }
}
