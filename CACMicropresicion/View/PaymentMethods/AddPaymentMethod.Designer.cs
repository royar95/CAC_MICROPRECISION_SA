namespace CACMicropresicion.View.PaymentMethods
{
    partial class AddPaymentMethod
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPaymentMethod));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnAddPaymentMethod = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblNewPaymentMethod = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtDescription = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(67, 102);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(104, 25);
            this.bunifuCustomLabel1.TabIndex = 25;
            this.bunifuCustomLabel1.Text = "Descripcion";
            // 
            // btnAddPaymentMethod
            // 
            this.btnAddPaymentMethod.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddPaymentMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddPaymentMethod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddPaymentMethod.BorderRadius = 0;
            this.btnAddPaymentMethod.ButtonText = "Enviar Información";
            this.btnAddPaymentMethod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPaymentMethod.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddPaymentMethod.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPaymentMethod.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddPaymentMethod.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddPaymentMethod.Iconimage")));
            this.btnAddPaymentMethod.Iconimage_right = null;
            this.btnAddPaymentMethod.Iconimage_right_Selected = null;
            this.btnAddPaymentMethod.Iconimage_Selected = null;
            this.btnAddPaymentMethod.IconMarginLeft = 0;
            this.btnAddPaymentMethod.IconMarginRight = 0;
            this.btnAddPaymentMethod.IconRightVisible = true;
            this.btnAddPaymentMethod.IconRightZoom = 0D;
            this.btnAddPaymentMethod.IconVisible = false;
            this.btnAddPaymentMethod.IconZoom = 90D;
            this.btnAddPaymentMethod.IsTab = false;
            this.btnAddPaymentMethod.Location = new System.Drawing.Point(72, 214);
            this.btnAddPaymentMethod.Name = "btnAddPaymentMethod";
            this.btnAddPaymentMethod.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddPaymentMethod.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAddPaymentMethod.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddPaymentMethod.selected = false;
            this.btnAddPaymentMethod.Size = new System.Drawing.Size(229, 48);
            this.btnAddPaymentMethod.TabIndex = 23;
            this.btnAddPaymentMethod.Text = "Enviar Información";
            this.btnAddPaymentMethod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddPaymentMethod.Textcolor = System.Drawing.Color.White;
            this.btnAddPaymentMethod.TextFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPaymentMethod.Click += new System.EventHandler(this.btnAddPaymentMethod_Click);
            // 
            // lblNewPaymentMethod
            // 
            this.lblNewPaymentMethod.AutoSize = true;
            this.lblNewPaymentMethod.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPaymentMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNewPaymentMethod.Location = new System.Drawing.Point(65, 32);
            this.lblNewPaymentMethod.Name = "lblNewPaymentMethod";
            this.lblNewPaymentMethod.Size = new System.Drawing.Size(284, 40);
            this.lblNewPaymentMethod.TabIndex = 22;
            this.lblNewPaymentMethod.Text = "Agregar Tipo de Pago";
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
            this.txtDescription.Location = new System.Drawing.Point(72, 131);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(229, 34);
            this.txtDescription.TabIndex = 26;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // AddPaymentMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.btnAddPaymentMethod);
            this.Controls.Add(this.lblNewPaymentMethod);
            this.Name = "AddPaymentMethod";
            this.Size = new System.Drawing.Size(701, 327);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddPaymentMethod;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNewPaymentMethod;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtDescription;
    }
}
