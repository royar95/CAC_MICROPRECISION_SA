namespace CACMicropresicion.View.MaterialTypes
{
    partial class DeleteMaterialType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteMaterialType));
            this.delDropMaterialType = new System.Windows.Forms.ComboBox();
            this.delBtnDeleteMaterialTypes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblDeleteClient = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // delDropMaterialType
            // 
            this.delDropMaterialType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.delDropMaterialType.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delDropMaterialType.FormattingEnabled = true;
            this.delDropMaterialType.Location = new System.Drawing.Point(78, 91);
            this.delDropMaterialType.Name = "delDropMaterialType";
            this.delDropMaterialType.Size = new System.Drawing.Size(229, 25);
            this.delDropMaterialType.TabIndex = 61;
            // 
            // delBtnDeleteMaterialTypes
            // 
            this.delBtnDeleteMaterialTypes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.delBtnDeleteMaterialTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.delBtnDeleteMaterialTypes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delBtnDeleteMaterialTypes.BorderRadius = 0;
            this.delBtnDeleteMaterialTypes.ButtonText = "Eliminar Información";
            this.delBtnDeleteMaterialTypes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delBtnDeleteMaterialTypes.DisabledColor = System.Drawing.Color.Gray;
            this.delBtnDeleteMaterialTypes.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBtnDeleteMaterialTypes.Iconcolor = System.Drawing.Color.Transparent;
            this.delBtnDeleteMaterialTypes.Iconimage = ((System.Drawing.Image)(resources.GetObject("delBtnDeleteMaterialTypes.Iconimage")));
            this.delBtnDeleteMaterialTypes.Iconimage_right = null;
            this.delBtnDeleteMaterialTypes.Iconimage_right_Selected = null;
            this.delBtnDeleteMaterialTypes.Iconimage_Selected = null;
            this.delBtnDeleteMaterialTypes.IconMarginLeft = 0;
            this.delBtnDeleteMaterialTypes.IconMarginRight = 0;
            this.delBtnDeleteMaterialTypes.IconRightVisible = true;
            this.delBtnDeleteMaterialTypes.IconRightZoom = 0D;
            this.delBtnDeleteMaterialTypes.IconVisible = false;
            this.delBtnDeleteMaterialTypes.IconZoom = 90D;
            this.delBtnDeleteMaterialTypes.IsTab = false;
            this.delBtnDeleteMaterialTypes.Location = new System.Drawing.Point(78, 151);
            this.delBtnDeleteMaterialTypes.Name = "delBtnDeleteMaterialTypes";
            this.delBtnDeleteMaterialTypes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.delBtnDeleteMaterialTypes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.delBtnDeleteMaterialTypes.OnHoverTextColor = System.Drawing.Color.White;
            this.delBtnDeleteMaterialTypes.selected = false;
            this.delBtnDeleteMaterialTypes.Size = new System.Drawing.Size(229, 48);
            this.delBtnDeleteMaterialTypes.TabIndex = 60;
            this.delBtnDeleteMaterialTypes.Text = "Eliminar Información";
            this.delBtnDeleteMaterialTypes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delBtnDeleteMaterialTypes.Textcolor = System.Drawing.Color.White;
            this.delBtnDeleteMaterialTypes.TextFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBtnDeleteMaterialTypes.Click += new System.EventHandler(this.delBtnDeleteMaterialTypes_Click);
            // 
            // lblDeleteClient
            // 
            this.lblDeleteClient.AutoSize = true;
            this.lblDeleteClient.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDeleteClient.Location = new System.Drawing.Point(71, 30);
            this.lblDeleteClient.Name = "lblDeleteClient";
            this.lblDeleteClient.Size = new System.Drawing.Size(320, 40);
            this.lblDeleteClient.TabIndex = 58;
            this.lblDeleteClient.Text = "Eliminar Tipo de Material";
            // 
            // DeleteMaterialType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.delDropMaterialType);
            this.Controls.Add(this.delBtnDeleteMaterialTypes);
            this.Controls.Add(this.lblDeleteClient);
            this.Name = "DeleteMaterialType";
            this.Size = new System.Drawing.Size(666, 255);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox delDropMaterialType;
        private Bunifu.Framework.UI.BunifuFlatButton delBtnDeleteMaterialTypes;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDeleteClient;
    }
}
