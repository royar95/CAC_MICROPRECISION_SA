namespace CACMicropresicion.View.Main
{
    partial class AuditoryControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuditoryControl));
            this.btnUsers = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLog = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // btnUsers
            // 
            this.btnUsers.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsers.BackColor = System.Drawing.Color.Teal;
            this.btnUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUsers.BorderRadius = 0;
            this.btnUsers.ButtonText = "Reportes";
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.DisabledColor = System.Drawing.Color.Gray;
            this.btnUsers.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUsers.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUsers.Iconimage")));
            this.btnUsers.Iconimage_right = null;
            this.btnUsers.Iconimage_right_Selected = null;
            this.btnUsers.Iconimage_Selected = null;
            this.btnUsers.IconMarginLeft = 0;
            this.btnUsers.IconMarginRight = 0;
            this.btnUsers.IconRightVisible = true;
            this.btnUsers.IconRightZoom = 0D;
            this.btnUsers.IconVisible = false;
            this.btnUsers.IconZoom = 90D;
            this.btnUsers.IsTab = false;
            this.btnUsers.Location = new System.Drawing.Point(0, 45);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Normalcolor = System.Drawing.Color.Teal;
            this.btnUsers.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnUsers.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUsers.selected = false;
            this.btnUsers.Size = new System.Drawing.Size(237, 48);
            this.btnUsers.TabIndex = 2;
            this.btnUsers.Text = "Reportes";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUsers.Textcolor = System.Drawing.Color.White;
            this.btnUsers.TextFont = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnLog
            // 
            this.btnLog.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLog.BackColor = System.Drawing.Color.Teal;
            this.btnLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLog.BorderRadius = 0;
            this.btnLog.ButtonText = "Bitácoras";
            this.btnLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLog.DisabledColor = System.Drawing.Color.Gray;
            this.btnLog.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLog.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLog.Iconimage")));
            this.btnLog.Iconimage_right = null;
            this.btnLog.Iconimage_right_Selected = null;
            this.btnLog.Iconimage_Selected = null;
            this.btnLog.IconMarginLeft = 0;
            this.btnLog.IconMarginRight = 0;
            this.btnLog.IconRightVisible = true;
            this.btnLog.IconRightZoom = 0D;
            this.btnLog.IconVisible = false;
            this.btnLog.IconZoom = 90D;
            this.btnLog.IsTab = false;
            this.btnLog.Location = new System.Drawing.Point(0, 0);
            this.btnLog.Name = "btnLog";
            this.btnLog.Normalcolor = System.Drawing.Color.Teal;
            this.btnLog.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnLog.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLog.selected = false;
            this.btnLog.Size = new System.Drawing.Size(237, 48);
            this.btnLog.TabIndex = 3;
            this.btnLog.Text = "Bitácoras";
            this.btnLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLog.Textcolor = System.Drawing.Color.White;
            this.btnLog.TextFont = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // AuditoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnUsers);
            this.Name = "AuditoryControl";
            this.Size = new System.Drawing.Size(237, 441);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnUsers;
        private Bunifu.Framework.UI.BunifuFlatButton btnLog;
    }
}
