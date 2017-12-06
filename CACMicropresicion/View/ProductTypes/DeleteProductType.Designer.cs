namespace CACMicropresicion.View.ProductTypes
{
    partial class DeleteProductType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteProductType));
            this.delDropProductType = new System.Windows.Forms.ComboBox();
            this.btnDeleteProductType = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblDeleteClient = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // delDropProductType
            // 
            this.delDropProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.delDropProductType.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delDropProductType.FormattingEnabled = true;
            this.delDropProductType.Location = new System.Drawing.Point(68, 175);
            this.delDropProductType.Name = "delDropProductType";
            this.delDropProductType.Size = new System.Drawing.Size(229, 25);
            this.delDropProductType.TabIndex = 66;
            // 
            // btnDeleteProductType
            // 
            this.btnDeleteProductType.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDeleteProductType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDeleteProductType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteProductType.BorderRadius = 0;
            this.btnDeleteProductType.ButtonText = "Eliminar Categoría de Producto";
            this.btnDeleteProductType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteProductType.DisabledColor = System.Drawing.Color.Gray;
            this.btnDeleteProductType.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProductType.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDeleteProductType.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDeleteProductType.Iconimage")));
            this.btnDeleteProductType.Iconimage_right = null;
            this.btnDeleteProductType.Iconimage_right_Selected = null;
            this.btnDeleteProductType.Iconimage_Selected = null;
            this.btnDeleteProductType.IconMarginLeft = 0;
            this.btnDeleteProductType.IconMarginRight = 0;
            this.btnDeleteProductType.IconRightVisible = true;
            this.btnDeleteProductType.IconRightZoom = 0D;
            this.btnDeleteProductType.IconVisible = false;
            this.btnDeleteProductType.IconZoom = 90D;
            this.btnDeleteProductType.IsTab = false;
            this.btnDeleteProductType.Location = new System.Drawing.Point(68, 241);
            this.btnDeleteProductType.Name = "btnDeleteProductType";
            this.btnDeleteProductType.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDeleteProductType.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDeleteProductType.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeleteProductType.selected = false;
            this.btnDeleteProductType.Size = new System.Drawing.Size(229, 48);
            this.btnDeleteProductType.TabIndex = 65;
            this.btnDeleteProductType.Text = "Eliminar Categoría de Producto";
            this.btnDeleteProductType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteProductType.Textcolor = System.Drawing.Color.White;
            this.btnDeleteProductType.TextFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProductType.Click += new System.EventHandler(this.btnDeleteProductType_Click);
            // 
            // lblDeleteClient
            // 
            this.lblDeleteClient.AutoSize = true;
            this.lblDeleteClient.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDeleteClient.Location = new System.Drawing.Point(61, 60);
            this.lblDeleteClient.Name = "lblDeleteClient";
            this.lblDeleteClient.Size = new System.Drawing.Size(398, 40);
            this.lblDeleteClient.TabIndex = 63;
            this.lblDeleteClient.Text = "Eliminar Categoría de Producto";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(63, 133);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(275, 25);
            this.bunifuCustomLabel2.TabIndex = 68;
            this.bunifuCustomLabel2.Text = "Seleccione la categoría a eliminar";
            // 
            // DeleteProductType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.delDropProductType);
            this.Controls.Add(this.btnDeleteProductType);
            this.Controls.Add(this.lblDeleteClient);
            this.Name = "DeleteProductType";
            this.Size = new System.Drawing.Size(673, 351);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox delDropProductType;
        private Bunifu.Framework.UI.BunifuFlatButton btnDeleteProductType;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDeleteClient;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
    }
}
