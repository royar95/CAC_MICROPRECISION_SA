namespace CACMicropresicion.View.Reports
{
    partial class CostsOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CostsOptions));
            this.btnExtractCosts = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.endDateLog = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.startDateLog = new Bunifu.Framework.UI.BunifuDatepicker();
            this.SuspendLayout();
            // 
            // btnExtractCosts
            // 
            this.btnExtractCosts.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnExtractCosts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnExtractCosts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExtractCosts.BorderRadius = 0;
            this.btnExtractCosts.ButtonText = "Extraer Información";
            this.btnExtractCosts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExtractCosts.DisabledColor = System.Drawing.Color.Gray;
            this.btnExtractCosts.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExtractCosts.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnExtractCosts.Iconimage")));
            this.btnExtractCosts.Iconimage_right = null;
            this.btnExtractCosts.Iconimage_right_Selected = null;
            this.btnExtractCosts.Iconimage_Selected = null;
            this.btnExtractCosts.IconMarginLeft = 0;
            this.btnExtractCosts.IconMarginRight = 0;
            this.btnExtractCosts.IconRightVisible = true;
            this.btnExtractCosts.IconRightZoom = 0D;
            this.btnExtractCosts.IconVisible = false;
            this.btnExtractCosts.IconZoom = 90D;
            this.btnExtractCosts.IsTab = false;
            this.btnExtractCosts.Location = new System.Drawing.Point(610, 10);
            this.btnExtractCosts.Name = "btnExtractCosts";
            this.btnExtractCosts.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnExtractCosts.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnExtractCosts.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExtractCosts.selected = false;
            this.btnExtractCosts.Size = new System.Drawing.Size(153, 27);
            this.btnExtractCosts.TabIndex = 43;
            this.btnExtractCosts.Text = "Extraer Información";
            this.btnExtractCosts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExtractCosts.Textcolor = System.Drawing.Color.White;
            this.btnExtractCosts.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtractCosts.Click += new System.EventHandler(this.btnExtractCosts_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(319, 11);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(90, 25);
            this.bunifuCustomLabel2.TabIndex = 42;
            this.bunifuCustomLabel2.Text = "Fecha Fin:";
            // 
            // endDateLog
            // 
            this.endDateLog.BackColor = System.Drawing.Color.SeaGreen;
            this.endDateLog.BorderRadius = 0;
            this.endDateLog.ForeColor = System.Drawing.Color.White;
            this.endDateLog.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDateLog.FormatCustom = null;
            this.endDateLog.Location = new System.Drawing.Point(415, 10);
            this.endDateLog.Name = "endDateLog";
            this.endDateLog.Size = new System.Drawing.Size(166, 26);
            this.endDateLog.TabIndex = 41;
            this.endDateLog.Value = new System.DateTime(2017, 11, 26, 18, 59, 14, 608);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(14, 10);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(108, 25);
            this.bunifuCustomLabel1.TabIndex = 40;
            this.bunifuCustomLabel1.Text = "Fecha Inicio:";
            // 
            // startDateLog
            // 
            this.startDateLog.BackColor = System.Drawing.Color.SeaGreen;
            this.startDateLog.BorderRadius = 0;
            this.startDateLog.ForeColor = System.Drawing.Color.White;
            this.startDateLog.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDateLog.FormatCustom = null;
            this.startDateLog.Location = new System.Drawing.Point(128, 10);
            this.startDateLog.Name = "startDateLog";
            this.startDateLog.Size = new System.Drawing.Size(166, 26);
            this.startDateLog.TabIndex = 39;
            this.startDateLog.Value = new System.DateTime(2017, 11, 26, 19, 9, 17, 0);
            // 
            // CostsOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.btnExtractCosts);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.endDateLog);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.startDateLog);
            this.Name = "CostsOptions";
            this.Size = new System.Drawing.Size(910, 47);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnExtractCosts;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuDatepicker endDateLog;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDatepicker startDateLog;
    }
}
