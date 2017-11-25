namespace CACMicropresicion.View.Products
{
    partial class Products
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnEditProduct = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnViewProducts = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAddProduct = new Bunifu.Framework.UI.BunifuThinButton2();
            this.addProduct = new CACMicropresicion.View.Products.AddProduct();
            this.viewProducts = new CACMicropresicion.View.Products.ViewProducts();
            this.editProduct = new CACMicropresicion.View.Products.EditProduct();
            this.SidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.SidePanel.Controls.Add(this.btnEditProduct);
            this.SidePanel.Controls.Add(this.btnViewProducts);
            this.SidePanel.Controls.Add(this.btnAddProduct);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(196, 418);
            this.SidePanel.TabIndex = 0;
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.ActiveBorderThickness = 1;
            this.btnEditProduct.ActiveCornerRadius = 20;
            this.btnEditProduct.ActiveFillColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnEditProduct.ActiveForecolor = System.Drawing.Color.White;
            this.btnEditProduct.ActiveLineColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnEditProduct.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditProduct.BackgroundImage")));
            this.btnEditProduct.ButtonText = "Editar Producto";
            this.btnEditProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditProduct.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProduct.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnEditProduct.IdleBorderThickness = 1;
            this.btnEditProduct.IdleCornerRadius = 20;
            this.btnEditProduct.IdleFillColor = System.Drawing.Color.White;
            this.btnEditProduct.IdleForecolor = System.Drawing.Color.Black;
            this.btnEditProduct.IdleLineColor = System.Drawing.Color.Black;
            this.btnEditProduct.Location = new System.Drawing.Point(10, 263);
            this.btnEditProduct.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(181, 41);
            this.btnEditProduct.TabIndex = 2;
            this.btnEditProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnViewProducts
            // 
            this.btnViewProducts.ActiveBorderThickness = 1;
            this.btnViewProducts.ActiveCornerRadius = 20;
            this.btnViewProducts.ActiveFillColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnViewProducts.ActiveForecolor = System.Drawing.Color.White;
            this.btnViewProducts.ActiveLineColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnViewProducts.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnViewProducts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewProducts.BackgroundImage")));
            this.btnViewProducts.ButtonText = "Ver Productos";
            this.btnViewProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewProducts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProducts.ForeColor = System.Drawing.Color.Black;
            this.btnViewProducts.IdleBorderThickness = 1;
            this.btnViewProducts.IdleCornerRadius = 20;
            this.btnViewProducts.IdleFillColor = System.Drawing.Color.White;
            this.btnViewProducts.IdleForecolor = System.Drawing.Color.Black;
            this.btnViewProducts.IdleLineColor = System.Drawing.Color.Black;
            this.btnViewProducts.Location = new System.Drawing.Point(10, 177);
            this.btnViewProducts.Margin = new System.Windows.Forms.Padding(5);
            this.btnViewProducts.Name = "btnViewProducts";
            this.btnViewProducts.Size = new System.Drawing.Size(181, 41);
            this.btnViewProducts.TabIndex = 1;
            this.btnViewProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnViewProducts.Click += new System.EventHandler(this.btnViewProducts_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.ActiveBorderThickness = 1;
            this.btnAddProduct.ActiveCornerRadius = 20;
            this.btnAddProduct.ActiveFillColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAddProduct.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddProduct.ActiveLineColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAddProduct.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.BackgroundImage")));
            this.btnAddProduct.ButtonText = "Agregar Producto";
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.Black;
            this.btnAddProduct.IdleBorderThickness = 1;
            this.btnAddProduct.IdleCornerRadius = 20;
            this.btnAddProduct.IdleFillColor = System.Drawing.Color.White;
            this.btnAddProduct.IdleForecolor = System.Drawing.Color.Black;
            this.btnAddProduct.IdleLineColor = System.Drawing.Color.Black;
            this.btnAddProduct.Location = new System.Drawing.Point(10, 95);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(181, 41);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // addProduct
            // 
            this.addProduct.Location = new System.Drawing.Point(214, 30);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(532, 349);
            this.addProduct.TabIndex = 1;
            // 
            // viewProducts
            // 
            this.viewProducts.Location = new System.Drawing.Point(214, 30);
            this.viewProducts.Name = "viewProducts";
            this.viewProducts.Size = new System.Drawing.Size(532, 349);
            this.viewProducts.TabIndex = 2;
            // 
            // editProduct
            // 
            this.editProduct.Location = new System.Drawing.Point(214, 30);
            this.editProduct.Name = "editProduct";
            this.editProduct.Size = new System.Drawing.Size(532, 376);
            this.editProduct.TabIndex = 3;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(769, 418);
            this.Controls.Add(this.editProduct);
            this.Controls.Add(this.viewProducts);
            this.Controls.Add(this.addProduct);
            this.Controls.Add(this.SidePanel);
            this.Name = "Products";
            this.Text = "Productos";
            this.SidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidePanel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddProduct;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEditProduct;
        private Bunifu.Framework.UI.BunifuThinButton2 btnViewProducts;
        private AddProduct addProduct;
        private ViewProducts viewProducts;
        private EditProduct editProduct;
    }
}