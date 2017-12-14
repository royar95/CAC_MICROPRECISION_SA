namespace CACMicropresicion.View.Providers
{
    partial class EditProvider
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProvider));
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtDescription = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.modBtnSaveClientChanges = new Bunifu.Framework.UI.BunifuFlatButton();
            this.modDropProviderStatus = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblEditClient = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataMember = "Proveedor";
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
            this.txtDescription.Location = new System.Drawing.Point(70, 146);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(225, 34);
            this.txtDescription.TabIndex = 48;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(65, 194);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(66, 25);
            this.bunifuCustomLabel7.TabIndex = 47;
            this.bunifuCustomLabel7.Text = "Estado";
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
            this.modBtnSaveClientChanges.Location = new System.Drawing.Point(66, 289);
            this.modBtnSaveClientChanges.Name = "modBtnSaveClientChanges";
            this.modBtnSaveClientChanges.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.modBtnSaveClientChanges.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.modBtnSaveClientChanges.OnHoverTextColor = System.Drawing.Color.White;
            this.modBtnSaveClientChanges.selected = false;
            this.modBtnSaveClientChanges.Size = new System.Drawing.Size(229, 48);
            this.modBtnSaveClientChanges.TabIndex = 46;
            this.modBtnSaveClientChanges.Text = "Guardar Cambios";
            this.modBtnSaveClientChanges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.modBtnSaveClientChanges.Textcolor = System.Drawing.Color.White;
            this.modBtnSaveClientChanges.TextFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modBtnSaveClientChanges.Click += new System.EventHandler(this.modBtnSaveClientChanges_Click);
            // 
            // modDropProviderStatus
            // 
            this.modDropProviderStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modDropProviderStatus.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modDropProviderStatus.FormattingEnabled = true;
            this.modDropProviderStatus.Location = new System.Drawing.Point(70, 222);
            this.modDropProviderStatus.Name = "modDropProviderStatus";
            this.modDropProviderStatus.Size = new System.Drawing.Size(225, 25);
            this.modDropProviderStatus.TabIndex = 45;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(65, 117);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(104, 25);
            this.bunifuCustomLabel1.TabIndex = 44;
            this.bunifuCustomLabel1.Text = "Descripcion";
            // 
            // lblEditClient
            // 
            this.lblEditClient.AutoSize = true;
            this.lblEditClient.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEditClient.Location = new System.Drawing.Point(63, 43);
            this.lblEditClient.Name = "lblEditClient";
            this.lblEditClient.Size = new System.Drawing.Size(264, 40);
            this.lblEditClient.TabIndex = 43;
            this.lblEditClient.Text = "Modificar Proveedor";
            // 
            // EditProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.modBtnSaveClientChanges);
            this.Controls.Add(this.modDropProviderStatus);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.lblEditClient);
            this.Name = "EditProvider";
            this.Size = new System.Drawing.Size(682, 422);
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtDescription;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuFlatButton modBtnSaveClientChanges;
        private System.Windows.Forms.ComboBox modDropProviderStatus;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEditClient;
    }
}
