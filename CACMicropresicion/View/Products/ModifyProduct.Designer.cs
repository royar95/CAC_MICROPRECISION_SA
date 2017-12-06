namespace CACMicropresicion.View.Products
{
    partial class ModifyProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.modBtnProduct = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtStock = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtPrice = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtDescription = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblAddProduct = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.modProductType = new System.Windows.Forms.ComboBox();
            this.modDropProductStatus = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // modBtnProduct
            // 
            this.modBtnProduct.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.modBtnProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.modBtnProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.modBtnProduct.BorderRadius = 0;
            this.modBtnProduct.ButtonText = "Modificar producto";
            this.modBtnProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modBtnProduct.DisabledColor = System.Drawing.Color.Gray;
            this.modBtnProduct.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modBtnProduct.Iconcolor = System.Drawing.Color.Transparent;
            this.modBtnProduct.Iconimage = null;
            this.modBtnProduct.Iconimage_right = null;
            this.modBtnProduct.Iconimage_right_Selected = null;
            this.modBtnProduct.Iconimage_Selected = null;
            this.modBtnProduct.IconMarginLeft = 0;
            this.modBtnProduct.IconMarginRight = 0;
            this.modBtnProduct.IconRightVisible = true;
            this.modBtnProduct.IconRightZoom = 0D;
            this.modBtnProduct.IconVisible = false;
            this.modBtnProduct.IconZoom = 90D;
            this.modBtnProduct.IsTab = false;
            this.modBtnProduct.Location = new System.Drawing.Point(59, 358);
            this.modBtnProduct.Name = "modBtnProduct";
            this.modBtnProduct.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.modBtnProduct.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.modBtnProduct.OnHoverTextColor = System.Drawing.Color.White;
            this.modBtnProduct.selected = false;
            this.modBtnProduct.Size = new System.Drawing.Size(229, 48);
            this.modBtnProduct.TabIndex = 89;
            this.modBtnProduct.Text = "Modificar producto";
            this.modBtnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.modBtnProduct.Textcolor = System.Drawing.Color.White;
            this.modBtnProduct.TextFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modBtnProduct.Click += new System.EventHandler(this.modBtnProduct_Click);
            // 
            // txtStock
            // 
            this.txtStock.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtStock.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStock.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtStock.BorderThickness = 3;
            this.txtStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStock.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStock.isPassword = false;
            this.txtStock.Location = new System.Drawing.Point(373, 282);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(235, 36);
            this.txtStock.TabIndex = 88;
            this.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPrice
            // 
            this.txtPrice.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtPrice.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrice.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtPrice.BorderThickness = 3;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrice.isPassword = false;
            this.txtPrice.Location = new System.Drawing.Point(59, 282);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(229, 36);
            this.txtPrice.TabIndex = 87;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtDescription
            // 
            this.txtDescription.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtDescription.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescription.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtDescription.BorderThickness = 3;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescription.isPassword = false;
            this.txtDescription.Location = new System.Drawing.Point(59, 201);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(549, 36);
            this.txtDescription.TabIndex = 86;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(368, 253);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(193, 25);
            this.bunifuCustomLabel4.TabIndex = 85;
            this.bunifuCustomLabel4.Text = "Cantidad en inventario";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(54, 253);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(61, 25);
            this.bunifuCustomLabel3.TabIndex = 84;
            this.bunifuCustomLabel3.Text = "Precio";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(54, 172);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(104, 25);
            this.bunifuCustomLabel1.TabIndex = 83;
            this.bunifuCustomLabel1.Text = "Descripción";
            // 
            // lblAddProduct
            // 
            this.lblAddProduct.AutoSize = true;
            this.lblAddProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblAddProduct.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAddProduct.Location = new System.Drawing.Point(52, 28);
            this.lblAddProduct.Name = "lblAddProduct";
            this.lblAddProduct.Size = new System.Drawing.Size(249, 40);
            this.lblAddProduct.TabIndex = 80;
            this.lblAddProduct.Text = "Modificar Producto";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(54, 103);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(90, 25);
            this.bunifuCustomLabel5.TabIndex = 90;
            this.bunifuCustomLabel5.Text = "Categoría";
            // 
            // modProductType
            // 
            this.modProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modProductType.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modProductType.FormattingEnabled = true;
            this.modProductType.Location = new System.Drawing.Point(59, 131);
            this.modProductType.Name = "modProductType";
            this.modProductType.Size = new System.Drawing.Size(225, 25);
            this.modProductType.TabIndex = 91;
            // 
            // modDropProductStatus
            // 
            this.modDropProductStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modDropProductStatus.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modDropProductStatus.FormattingEnabled = true;
            this.modDropProductStatus.Location = new System.Drawing.Point(373, 131);
            this.modDropProductStatus.Name = "modDropProductStatus";
            this.modDropProductStatus.Size = new System.Drawing.Size(235, 25);
            this.modDropProductStatus.TabIndex = 93;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(368, 103);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(66, 25);
            this.bunifuCustomLabel7.TabIndex = 92;
            this.bunifuCustomLabel7.Text = "Estado";
            // 
            // ModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.modDropProductStatus);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.modProductType);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.modBtnProduct);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.lblAddProduct);
            this.Name = "ModifyProduct";
            this.Size = new System.Drawing.Size(673, 474);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton modBtnProduct;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtStock;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPrice;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtDescription;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblAddProduct;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.ComboBox modProductType;
        private System.Windows.Forms.ComboBox modDropProductStatus;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
    }
}
