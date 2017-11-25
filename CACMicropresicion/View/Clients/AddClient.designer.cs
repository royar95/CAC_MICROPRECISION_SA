namespace CACMicropresicion.View.Cients
{
    partial class AddClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClient));
            this.lblNewClient = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnAddClient = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtDescription = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.SuspendLayout();
            // 
            // lblNewClient
            // 
            this.lblNewClient.AutoSize = true;
            this.lblNewClient.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNewClient.Location = new System.Drawing.Point(73, 31);
            this.lblNewClient.Name = "lblNewClient";
            this.lblNewClient.Size = new System.Drawing.Size(297, 40);
            this.lblNewClient.TabIndex = 3;
            this.lblNewClient.Text = "Agregar Nuevo Cliente";
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
            this.btnAddClient.Location = new System.Drawing.Point(80, 210);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddClient.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAddClient.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddClient.selected = false;
            this.btnAddClient.Size = new System.Drawing.Size(229, 48);
            this.btnAddClient.TabIndex = 15;
            this.btnAddClient.Text = "Enviar Información";
            this.btnAddClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddClient.Textcolor = System.Drawing.Color.White;
            this.btnAddClient.TextFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(75, 106);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(104, 25);
            this.bunifuCustomLabel1.TabIndex = 17;
            this.bunifuCustomLabel1.Text = "Descripcion";
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
            this.txtDescription.Location = new System.Drawing.Point(80, 135);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(375, 34);
            this.txtDescription.TabIndex = 20;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.lblNewClient);
            this.Name = "AddClient";
            this.Size = new System.Drawing.Size(781, 373);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lblNewClient;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddClient;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtDescription;
    }
}
