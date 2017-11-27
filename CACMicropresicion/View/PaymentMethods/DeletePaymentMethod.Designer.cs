namespace CACMicropresicion.View.PaymentMethods
{
    partial class DeletePaymentMethod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeletePaymentMethod));
            this.delDropPaymentId = new System.Windows.Forms.ComboBox();
            this.delBtnDeletePaymentMethod = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblDeleteClient = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // delDropPaymentId
            // 
            this.delDropPaymentId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.delDropPaymentId.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delDropPaymentId.FormattingEnabled = true;
            this.delDropPaymentId.Location = new System.Drawing.Point(74, 104);
            this.delDropPaymentId.Name = "delDropPaymentId";
            this.delDropPaymentId.Size = new System.Drawing.Size(229, 25);
            this.delDropPaymentId.TabIndex = 56;
            // 
            // delBtnDeletePaymentMethod
            // 
            this.delBtnDeletePaymentMethod.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.delBtnDeletePaymentMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.delBtnDeletePaymentMethod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delBtnDeletePaymentMethod.BorderRadius = 0;
            this.delBtnDeletePaymentMethod.ButtonText = "Eliminar Tipo de Pago";
            this.delBtnDeletePaymentMethod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delBtnDeletePaymentMethod.DisabledColor = System.Drawing.Color.Gray;
            this.delBtnDeletePaymentMethod.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBtnDeletePaymentMethod.Iconcolor = System.Drawing.Color.Transparent;
            this.delBtnDeletePaymentMethod.Iconimage = ((System.Drawing.Image)(resources.GetObject("delBtnDeletePaymentMethod.Iconimage")));
            this.delBtnDeletePaymentMethod.Iconimage_right = null;
            this.delBtnDeletePaymentMethod.Iconimage_right_Selected = null;
            this.delBtnDeletePaymentMethod.Iconimage_Selected = null;
            this.delBtnDeletePaymentMethod.IconMarginLeft = 0;
            this.delBtnDeletePaymentMethod.IconMarginRight = 0;
            this.delBtnDeletePaymentMethod.IconRightVisible = true;
            this.delBtnDeletePaymentMethod.IconRightZoom = 0D;
            this.delBtnDeletePaymentMethod.IconVisible = false;
            this.delBtnDeletePaymentMethod.IconZoom = 90D;
            this.delBtnDeletePaymentMethod.IsTab = false;
            this.delBtnDeletePaymentMethod.Location = new System.Drawing.Point(74, 175);
            this.delBtnDeletePaymentMethod.Name = "delBtnDeletePaymentMethod";
            this.delBtnDeletePaymentMethod.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.delBtnDeletePaymentMethod.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.delBtnDeletePaymentMethod.OnHoverTextColor = System.Drawing.Color.White;
            this.delBtnDeletePaymentMethod.selected = false;
            this.delBtnDeletePaymentMethod.Size = new System.Drawing.Size(229, 48);
            this.delBtnDeletePaymentMethod.TabIndex = 55;
            this.delBtnDeletePaymentMethod.Text = "Eliminar Tipo de Pago";
            this.delBtnDeletePaymentMethod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delBtnDeletePaymentMethod.Textcolor = System.Drawing.Color.White;
            this.delBtnDeletePaymentMethod.TextFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBtnDeletePaymentMethod.Click += new System.EventHandler(this.delBtnDeletePaymentMethod_Click);
            // 
            // lblDeleteClient
            // 
            this.lblDeleteClient.AutoSize = true;
            this.lblDeleteClient.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDeleteClient.Location = new System.Drawing.Point(67, 34);
            this.lblDeleteClient.Name = "lblDeleteClient";
            this.lblDeleteClient.Size = new System.Drawing.Size(283, 40);
            this.lblDeleteClient.TabIndex = 53;
            this.lblDeleteClient.Text = "Eliminar Tipo de Pago";
            // 
            // DeletePaymentMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.delDropPaymentId);
            this.Controls.Add(this.delBtnDeletePaymentMethod);
            this.Controls.Add(this.lblDeleteClient);
            this.Name = "DeletePaymentMethod";
            this.Size = new System.Drawing.Size(864, 291);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox delDropPaymentId;
        private Bunifu.Framework.UI.BunifuFlatButton delBtnDeletePaymentMethod;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDeleteClient;
    }
}
