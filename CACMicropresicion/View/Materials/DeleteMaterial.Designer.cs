namespace CACMicropresicion.View.Materials
{
    partial class DeleteMaterial
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteMaterial));
            this.cmbMaterials = new System.Windows.Forms.ComboBox();
            this.lblNewUser = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnDeleteMaterial = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // cmbMaterials
            // 
            this.cmbMaterials.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterials.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaterials.FormattingEnabled = true;
            this.cmbMaterials.Location = new System.Drawing.Point(73, 96);
            this.cmbMaterials.Name = "cmbMaterials";
            this.cmbMaterials.Size = new System.Drawing.Size(225, 25);
            this.cmbMaterials.TabIndex = 46;
            // 
            // lblNewUser
            // 
            this.lblNewUser.AutoSize = true;
            this.lblNewUser.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNewUser.Location = new System.Drawing.Point(66, 33);
            this.lblNewUser.Name = "lblNewUser";
            this.lblNewUser.Size = new System.Drawing.Size(220, 40);
            this.lblNewUser.TabIndex = 45;
            this.lblNewUser.Text = "Eliminar Material";
            // 
            // btnDeleteMaterial
            // 
            this.btnDeleteMaterial.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDeleteMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDeleteMaterial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteMaterial.BorderRadius = 0;
            this.btnDeleteMaterial.ButtonText = "Eliminar Información";
            this.btnDeleteMaterial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteMaterial.DisabledColor = System.Drawing.Color.Gray;
            this.btnDeleteMaterial.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMaterial.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDeleteMaterial.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDeleteMaterial.Iconimage")));
            this.btnDeleteMaterial.Iconimage_right = null;
            this.btnDeleteMaterial.Iconimage_right_Selected = null;
            this.btnDeleteMaterial.Iconimage_Selected = null;
            this.btnDeleteMaterial.IconMarginLeft = 0;
            this.btnDeleteMaterial.IconMarginRight = 0;
            this.btnDeleteMaterial.IconRightVisible = true;
            this.btnDeleteMaterial.IconRightZoom = 0D;
            this.btnDeleteMaterial.IconVisible = false;
            this.btnDeleteMaterial.IconZoom = 90D;
            this.btnDeleteMaterial.IsTab = false;
            this.btnDeleteMaterial.Location = new System.Drawing.Point(73, 158);
            this.btnDeleteMaterial.Name = "btnDeleteMaterial";
            this.btnDeleteMaterial.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDeleteMaterial.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDeleteMaterial.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeleteMaterial.selected = false;
            this.btnDeleteMaterial.Size = new System.Drawing.Size(229, 48);
            this.btnDeleteMaterial.TabIndex = 47;
            this.btnDeleteMaterial.Text = "Eliminar Información";
            this.btnDeleteMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteMaterial.Textcolor = System.Drawing.Color.White;
            this.btnDeleteMaterial.TextFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMaterial.Click += new System.EventHandler(this.btnDeleteMaterial_Click);
            // 
            // DeleteMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDeleteMaterial);
            this.Controls.Add(this.cmbMaterials);
            this.Controls.Add(this.lblNewUser);
            this.Name = "DeleteMaterial";
            this.Size = new System.Drawing.Size(505, 286);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMaterials;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNewUser;
        private Bunifu.Framework.UI.BunifuFlatButton btnDeleteMaterial;
    }
}
