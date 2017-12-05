namespace CACMicropresicion.View.Main
{
    partial class InOutOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InOutOptions));
            this.btnNew = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnList = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNew.BorderRadius = 0;
            this.btnNew.ButtonText = "Tramitar";
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.DisabledColor = System.Drawing.Color.Gray;
            this.btnNew.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNew.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNew.Iconimage")));
            this.btnNew.Iconimage_right = null;
            this.btnNew.Iconimage_right_Selected = null;
            this.btnNew.Iconimage_Selected = null;
            this.btnNew.IconMarginLeft = 0;
            this.btnNew.IconMarginRight = 0;
            this.btnNew.IconRightVisible = true;
            this.btnNew.IconRightZoom = 0D;
            this.btnNew.IconVisible = false;
            this.btnNew.IconZoom = 90D;
            this.btnNew.IsTab = false;
            this.btnNew.Location = new System.Drawing.Point(0, 0);
            this.btnNew.Name = "btnNew";
            this.btnNew.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnNew.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnNew.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNew.selected = false;
            this.btnNew.Size = new System.Drawing.Size(146, 51);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Tramitar";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNew.Textcolor = System.Drawing.Color.White;
            this.btnNew.TextFont = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnList
            // 
            this.btnList.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnList.BorderRadius = 0;
            this.btnList.ButtonText = "Lista";
            this.btnList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnList.DisabledColor = System.Drawing.Color.Gray;
            this.btnList.Iconcolor = System.Drawing.Color.Transparent;
            this.btnList.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnList.Iconimage")));
            this.btnList.Iconimage_right = null;
            this.btnList.Iconimage_right_Selected = null;
            this.btnList.Iconimage_Selected = null;
            this.btnList.IconMarginLeft = 0;
            this.btnList.IconMarginRight = 0;
            this.btnList.IconRightVisible = true;
            this.btnList.IconRightZoom = 0D;
            this.btnList.IconVisible = false;
            this.btnList.IconZoom = 90D;
            this.btnList.IsTab = false;
            this.btnList.Location = new System.Drawing.Point(143, 0);
            this.btnList.Name = "btnList";
            this.btnList.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnList.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnList.OnHoverTextColor = System.Drawing.Color.White;
            this.btnList.selected = false;
            this.btnList.Size = new System.Drawing.Size(146, 51);
            this.btnList.TabIndex = 2;
            this.btnList.Text = "Lista";
            this.btnList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnList.Textcolor = System.Drawing.Color.White;
            this.btnList.TextFont = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // InOutOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnNew);
            this.Name = "InOutOptions";
            this.Size = new System.Drawing.Size(550, 47);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnNew;
        private Bunifu.Framework.UI.BunifuFlatButton btnList;

    }
}
