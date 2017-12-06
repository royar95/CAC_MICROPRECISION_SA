namespace CACMicropresicion.View.Products
{
    partial class DeleteProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteProduct));
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.delDropProduct = new System.Windows.Forms.ComboBox();
            this.btnDeleteProduct = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblDeleteProduct = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(64, 131);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(276, 25);
            this.bunifuCustomLabel2.TabIndex = 72;
            this.bunifuCustomLabel2.Text = "Seleccione el producto a eliminar";
            // 
            // delDropProduct
            // 
            this.delDropProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.delDropProduct.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delDropProduct.FormattingEnabled = true;
            this.delDropProduct.Location = new System.Drawing.Point(69, 173);
            this.delDropProduct.Name = "delDropProduct";
            this.delDropProduct.Size = new System.Drawing.Size(229, 25);
            this.delDropProduct.TabIndex = 71;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDeleteProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteProduct.BorderRadius = 0;
            this.btnDeleteProduct.ButtonText = "Eliminar Producto";
            this.btnDeleteProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteProduct.DisabledColor = System.Drawing.Color.Gray;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDeleteProduct.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDeleteProduct.Iconimage")));
            this.btnDeleteProduct.Iconimage_right = null;
            this.btnDeleteProduct.Iconimage_right_Selected = null;
            this.btnDeleteProduct.Iconimage_Selected = null;
            this.btnDeleteProduct.IconMarginLeft = 0;
            this.btnDeleteProduct.IconMarginRight = 0;
            this.btnDeleteProduct.IconRightVisible = true;
            this.btnDeleteProduct.IconRightZoom = 0D;
            this.btnDeleteProduct.IconVisible = false;
            this.btnDeleteProduct.IconZoom = 90D;
            this.btnDeleteProduct.IsTab = false;
            this.btnDeleteProduct.Location = new System.Drawing.Point(69, 245);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDeleteProduct.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDeleteProduct.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeleteProduct.selected = false;
            this.btnDeleteProduct.Size = new System.Drawing.Size(229, 48);
            this.btnDeleteProduct.TabIndex = 70;
            this.btnDeleteProduct.Text = "Eliminar Producto";
            this.btnDeleteProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteProduct.Textcolor = System.Drawing.Color.White;
            this.btnDeleteProduct.TextFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // lblDeleteProduct
            // 
            this.lblDeleteProduct.AutoSize = true;
            this.lblDeleteProduct.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDeleteProduct.Location = new System.Drawing.Point(62, 58);
            this.lblDeleteProduct.Name = "lblDeleteProduct";
            this.lblDeleteProduct.Size = new System.Drawing.Size(233, 40);
            this.lblDeleteProduct.TabIndex = 69;
            this.lblDeleteProduct.Text = "Eliminar Producto";
            // 
            // DeleteProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.delDropProduct);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.lblDeleteProduct);
            this.Name = "DeleteProduct";
            this.Size = new System.Drawing.Size(673, 369);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.ComboBox delDropProduct;
        private Bunifu.Framework.UI.BunifuFlatButton btnDeleteProduct;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDeleteProduct;
    }
}
