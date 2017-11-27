namespace CACMicropresicion.View.ProductTypes
{
    partial class AddProductType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductType));
            this.lblNewPaymentMethod = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnAddProductType = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtDescription = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // lblNewPaymentMethod
            // 
            this.lblNewPaymentMethod.AutoSize = true;
            this.lblNewPaymentMethod.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPaymentMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNewPaymentMethod.Location = new System.Drawing.Point(108, 48);
            this.lblNewPaymentMethod.Name = "lblNewPaymentMethod";
            this.lblNewPaymentMethod.Size = new System.Drawing.Size(486, 40);
            this.lblNewPaymentMethod.TabIndex = 27;
            this.lblNewPaymentMethod.Text = "Agregar Nueva Categoría de Producto";
            // 
            // btnAddProductType
            // 
            this.btnAddProductType.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddProductType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddProductType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddProductType.BorderRadius = 0;
            this.btnAddProductType.ButtonText = "Enviar Información";
            this.btnAddProductType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProductType.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddProductType.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProductType.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddProductType.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddProductType.Iconimage")));
            this.btnAddProductType.Iconimage_right = null;
            this.btnAddProductType.Iconimage_right_Selected = null;
            this.btnAddProductType.Iconimage_Selected = null;
            this.btnAddProductType.IconMarginLeft = 0;
            this.btnAddProductType.IconMarginRight = 0;
            this.btnAddProductType.IconRightVisible = true;
            this.btnAddProductType.IconRightZoom = 0D;
            this.btnAddProductType.IconVisible = false;
            this.btnAddProductType.IconZoom = 90D;
            this.btnAddProductType.IsTab = false;
            this.btnAddProductType.Location = new System.Drawing.Point(203, 269);
            this.btnAddProductType.Name = "btnAddProductType";
            this.btnAddProductType.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddProductType.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAddProductType.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddProductType.selected = false;
            this.btnAddProductType.Size = new System.Drawing.Size(229, 48);
            this.btnAddProductType.TabIndex = 32;
            this.btnAddProductType.Text = "Enviar Información";
            this.btnAddProductType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddProductType.Textcolor = System.Drawing.Color.White;
            this.btnAddProductType.TextFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProductType.Click += new System.EventHandler(this.btnAddProductType_Click);
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
            this.txtDescription.Location = new System.Drawing.Point(115, 170);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(370, 44);
            this.txtDescription.TabIndex = 31;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(110, 119);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(104, 25);
            this.bunifuCustomLabel1.TabIndex = 30;
            this.bunifuCustomLabel1.Text = "Descripción";
            // 
            // AddProductType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddProductType);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.lblNewPaymentMethod);
            this.Name = "AddProductType";
            this.Size = new System.Drawing.Size(673, 474);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lblNewPaymentMethod;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddProductType;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtDescription;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}
