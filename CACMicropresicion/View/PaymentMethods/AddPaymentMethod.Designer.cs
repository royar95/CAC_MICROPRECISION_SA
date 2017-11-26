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
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.btnAddClient = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblNewPaymentMethod = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(154, 88);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(104, 25);
            this.bunifuCustomLabel1.TabIndex = 25;
            this.bunifuCustomLabel1.Text = "Descripcion";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(159, 126);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(457, 130);
            this.txtDescription.TabIndex = 24;
            this.txtDescription.Text = "";
            // 
            // btnAddClient
            // 
            this.btnAddClient.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddClient.BorderRadius = 0;
            this.btnAddClient.ButtonText = "Enviar Información";
            this.btnAddClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddClient.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddClient.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddClient.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddClient.Iconimage")));
            this.btnAddClient.Iconimage_right = null;
            this.btnAddClient.Iconimage_right_Selected = null;
            this.btnAddClient.Iconimage_Selected = null;
            this.btnAddClient.IconMarginLeft = 0;
            this.btnAddClient.IconMarginRight = 0;
            this.btnAddClient.IconRightVisible = true;
            this.btnAddClient.IconRightZoom = 0D;
            this.btnAddClient.IconVisible = false;
            this.btnAddClient.IconZoom = 90D;
            this.btnAddClient.IsTab = false;
            this.btnAddClient.Location = new System.Drawing.Point(289, 374);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddClient.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAddClient.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddClient.selected = false;
            this.btnAddClient.Size = new System.Drawing.Size(229, 48);
            this.btnAddClient.TabIndex = 23;
            this.btnAddClient.Text = "Enviar Información";
            this.btnAddClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddClient.Textcolor = System.Drawing.Color.White;
            this.btnAddClient.TextFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblNewPaymentMethod
            // 
            this.lblNewPaymentMethod.AutoSize = true;
            this.lblNewPaymentMethod.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPaymentMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNewPaymentMethod.Location = new System.Drawing.Point(133, 33);
            this.lblNewPaymentMethod.Name = "lblNewPaymentMethod";
            this.lblNewPaymentMethod.Size = new System.Drawing.Size(373, 40);
            this.lblNewPaymentMethod.TabIndex = 22;
            this.lblNewPaymentMethod.Text = "Agregar Nuevo Tipo de Pago";
            // 
            // AddPaymentMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.lblNewPaymentMethod);
            this.Name = "AddPaymentMethod";
            this.Size = new System.Drawing.Size(749, 455);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.RichTextBox txtDescription;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddClient;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNewPaymentMethod;
    }
}
