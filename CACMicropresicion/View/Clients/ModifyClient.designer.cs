namespace CACMicropresicion.View.Cients
{
    partial class ModifyClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyClient));
            this.lblEditClient = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.modDropClientStatus = new System.Windows.Forms.ComboBox();
            this.modDropClientId = new System.Windows.Forms.ComboBox();
            this.modBtnSaveClientChanges = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // lblEditClient
            // 
            this.lblEditClient.AutoSize = true;
            this.lblEditClient.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEditClient.Location = new System.Drawing.Point(39, 15);
            this.lblEditClient.Name = "lblEditClient";
            this.lblEditClient.Size = new System.Drawing.Size(180, 40);
            this.lblEditClient.TabIndex = 20;
            this.lblEditClient.Text = "Editar Cliente";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(110, 163);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(457, 130);
            this.txtDescription.TabIndex = 22;
            this.txtDescription.Text = "";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(105, 125);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(104, 25);
            this.bunifuCustomLabel1.TabIndex = 23;
            this.bunifuCustomLabel1.Text = "Descripcion";
            // 
            // modDropClientStatus
            // 
            this.modDropClientStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modDropClientStatus.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modDropClientStatus.FormattingEnabled = true;
            this.modDropClientStatus.Location = new System.Drawing.Point(110, 338);
            this.modDropClientStatus.Name = "modDropClientStatus";
            this.modDropClientStatus.Size = new System.Drawing.Size(225, 25);
            this.modDropClientStatus.TabIndex = 38;
            // 
            // modDropClientId
            // 
            this.modDropClientId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modDropClientId.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modDropClientId.FormattingEnabled = true;
            this.modDropClientId.Location = new System.Drawing.Point(110, 80);
            this.modDropClientId.Name = "modDropClientId";
            this.modDropClientId.Size = new System.Drawing.Size(225, 25);
            this.modDropClientId.TabIndex = 39;
            this.modDropClientId.SelectedIndexChanged += new System.EventHandler(this.modDropClientId_SelectedIndexChanged);
            // 
            // modBtnSaveClientChanges
            // 
            this.modBtnSaveClientChanges.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.modBtnSaveClientChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.modBtnSaveClientChanges.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.modBtnSaveClientChanges.BorderRadius = 0;
            this.modBtnSaveClientChanges.ButtonText = "Guardar Cambios";
            this.modBtnSaveClientChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modBtnSaveClientChanges.DisabledColor = System.Drawing.Color.Gray;
            this.modBtnSaveClientChanges.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modBtnSaveClientChanges.Iconcolor = System.Drawing.Color.Transparent;
            this.modBtnSaveClientChanges.Iconimage = ((System.Drawing.Image)(resources.GetObject("modBtnSaveClientChanges.Iconimage")));
            this.modBtnSaveClientChanges.Iconimage_right = null;
            this.modBtnSaveClientChanges.Iconimage_right_Selected = null;
            this.modBtnSaveClientChanges.Iconimage_Selected = null;
            this.modBtnSaveClientChanges.IconMarginLeft = 0;
            this.modBtnSaveClientChanges.IconMarginRight = 0;
            this.modBtnSaveClientChanges.IconRightVisible = true;
            this.modBtnSaveClientChanges.IconRightZoom = 0D;
            this.modBtnSaveClientChanges.IconVisible = false;
            this.modBtnSaveClientChanges.IconZoom = 90D;
            this.modBtnSaveClientChanges.IsTab = false;
            this.modBtnSaveClientChanges.Location = new System.Drawing.Point(36, 386);
            this.modBtnSaveClientChanges.Name = "modBtnSaveClientChanges";
            this.modBtnSaveClientChanges.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.modBtnSaveClientChanges.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.modBtnSaveClientChanges.OnHoverTextColor = System.Drawing.Color.White;
            this.modBtnSaveClientChanges.selected = false;
            this.modBtnSaveClientChanges.Size = new System.Drawing.Size(229, 48);
            this.modBtnSaveClientChanges.TabIndex = 40;
            this.modBtnSaveClientChanges.Text = "Guardar Cambios";
            this.modBtnSaveClientChanges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.modBtnSaveClientChanges.Textcolor = System.Drawing.Color.White;
            this.modBtnSaveClientChanges.TextFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modBtnSaveClientChanges.Click += new System.EventHandler(this.modBtnSaveClientChanges_Click);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(105, 310);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(66, 25);
            this.bunifuCustomLabel7.TabIndex = 41;
            this.bunifuCustomLabel7.Text = "Estado";
            // 
            // ModifyClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.modBtnSaveClientChanges);
            this.Controls.Add(this.modDropClientId);
            this.Controls.Add(this.modDropClientStatus);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblEditClient);
            this.Name = "ModifyClient";
            this.Size = new System.Drawing.Size(650, 448);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lblEditClient;
        private System.Windows.Forms.RichTextBox txtDescription;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.ComboBox modDropClientStatus;
        private System.Windows.Forms.ComboBox modDropClientId;
        private Bunifu.Framework.UI.BunifuFlatButton modBtnSaveClientChanges;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
    }
}
