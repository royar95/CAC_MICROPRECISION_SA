namespace CACMicropresicion.View.PaymentMethods
{
    partial class ModifyPaymentMethod
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
            this.modBtnSavePaymentChanges = new Bunifu.Framework.UI.BunifuFlatButton();
            this.modDropPaymentId = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblEditClient = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtDescription = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.SuspendLayout();
            // 
            // modBtnSavePaymentChanges
            // 
            this.modBtnSavePaymentChanges.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.modBtnSavePaymentChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.modBtnSavePaymentChanges.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.modBtnSavePaymentChanges.BorderRadius = 0;
            this.modBtnSavePaymentChanges.ButtonText = "Guardar Cambios";
            this.modBtnSavePaymentChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modBtnSavePaymentChanges.DisabledColor = System.Drawing.Color.Gray;
            this.modBtnSavePaymentChanges.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modBtnSavePaymentChanges.Iconcolor = System.Drawing.Color.Transparent;
            this.modBtnSavePaymentChanges.Iconimage = null;
            this.modBtnSavePaymentChanges.Iconimage_right = null;
            this.modBtnSavePaymentChanges.Iconimage_right_Selected = null;
            this.modBtnSavePaymentChanges.Iconimage_Selected = null;
            this.modBtnSavePaymentChanges.IconMarginLeft = 0;
            this.modBtnSavePaymentChanges.IconMarginRight = 0;
            this.modBtnSavePaymentChanges.IconRightVisible = true;
            this.modBtnSavePaymentChanges.IconRightZoom = 0D;
            this.modBtnSavePaymentChanges.IconVisible = false;
            this.modBtnSavePaymentChanges.IconZoom = 90D;
            this.modBtnSavePaymentChanges.IsTab = false;
            this.modBtnSavePaymentChanges.Location = new System.Drawing.Point(78, 279);
            this.modBtnSavePaymentChanges.Name = "modBtnSavePaymentChanges";
            this.modBtnSavePaymentChanges.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.modBtnSavePaymentChanges.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.modBtnSavePaymentChanges.OnHoverTextColor = System.Drawing.Color.White;
            this.modBtnSavePaymentChanges.selected = false;
            this.modBtnSavePaymentChanges.Size = new System.Drawing.Size(229, 48);
            this.modBtnSavePaymentChanges.TabIndex = 52;
            this.modBtnSavePaymentChanges.Text = "Guardar Cambios";
            this.modBtnSavePaymentChanges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.modBtnSavePaymentChanges.Textcolor = System.Drawing.Color.White;
            this.modBtnSavePaymentChanges.TextFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modBtnSavePaymentChanges.Click += new System.EventHandler(this.modBtnSavePaymentChanges_Click);
            // 
            // modDropPaymentId
            // 
            this.modDropPaymentId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modDropPaymentId.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modDropPaymentId.FormattingEnabled = true;
            this.modDropPaymentId.Location = new System.Drawing.Point(78, 105);
            this.modDropPaymentId.Name = "modDropPaymentId";
            this.modDropPaymentId.Size = new System.Drawing.Size(225, 25);
            this.modDropPaymentId.TabIndex = 51;
            this.modDropPaymentId.SelectedIndexChanged += new System.EventHandler(this.modDropPaymentId_SelectedIndexChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(73, 161);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(104, 25);
            this.bunifuCustomLabel1.TabIndex = 50;
            this.bunifuCustomLabel1.Text = "Descripcion";
            // 
            // lblEditClient
            // 
            this.lblEditClient.AutoSize = true;
            this.lblEditClient.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEditClient.Location = new System.Drawing.Point(71, 32);
            this.lblEditClient.Name = "lblEditClient";
            this.lblEditClient.Size = new System.Drawing.Size(256, 40);
            this.lblEditClient.TabIndex = 49;
            this.lblEditClient.Text = "Editar Tipo de Pago";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtDescription.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescription.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtDescription.BorderThickness = 3;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescription.isPassword = false;
            this.txtDescription.Location = new System.Drawing.Point(78, 190);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(229, 34);
            this.txtDescription.TabIndex = 53;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ModifyPaymentMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.modBtnSavePaymentChanges);
            this.Controls.Add(this.modDropPaymentId);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.lblEditClient);
            this.Name = "ModifyPaymentMethod";
            this.Size = new System.Drawing.Size(731, 419);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton modBtnSavePaymentChanges;
        private System.Windows.Forms.ComboBox modDropPaymentId;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEditClient;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtDescription;
    }
}
