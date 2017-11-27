namespace CACMicropresicion.View.Main
{
    partial class LogOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogOptions));
            this.startDateLog = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.endDateLog = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.userIdLog = new System.Windows.Forms.ComboBox();
            this.btnExtractLog = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // startDateLog
            // 
            this.startDateLog.BackColor = System.Drawing.Color.SeaGreen;
            this.startDateLog.BorderRadius = 0;
            this.startDateLog.ForeColor = System.Drawing.Color.White;
            this.startDateLog.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDateLog.FormatCustom = null;
            this.startDateLog.Location = new System.Drawing.Point(126, 11);
            this.startDateLog.Name = "startDateLog";
            this.startDateLog.Size = new System.Drawing.Size(166, 26);
            this.startDateLog.TabIndex = 0;
            this.startDateLog.Value = new System.DateTime(2017, 11, 26, 19, 9, 17, 0);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 11);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(108, 25);
            this.bunifuCustomLabel1.TabIndex = 4;
            this.bunifuCustomLabel1.Text = "Fecha Inicio:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(317, 12);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(90, 25);
            this.bunifuCustomLabel2.TabIndex = 6;
            this.bunifuCustomLabel2.Text = "Fecha Fin:";
            // 
            // endDateLog
            // 
            this.endDateLog.BackColor = System.Drawing.Color.SeaGreen;
            this.endDateLog.BorderRadius = 0;
            this.endDateLog.ForeColor = System.Drawing.Color.White;
            this.endDateLog.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDateLog.FormatCustom = null;
            this.endDateLog.Location = new System.Drawing.Point(413, 11);
            this.endDateLog.Name = "endDateLog";
            this.endDateLog.Size = new System.Drawing.Size(166, 26);
            this.endDateLog.TabIndex = 5;
            this.endDateLog.Value = new System.DateTime(2017, 11, 26, 18, 59, 14, 608);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(623, 13);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(75, 25);
            this.bunifuCustomLabel3.TabIndex = 7;
            this.bunifuCustomLabel3.Text = "Usuario:";
            // 
            // userIdLog
            // 
            this.userIdLog.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userIdLog.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdLog.FormattingEnabled = true;
            this.userIdLog.Location = new System.Drawing.Point(704, 12);
            this.userIdLog.Name = "userIdLog";
            this.userIdLog.Size = new System.Drawing.Size(178, 25);
            this.userIdLog.TabIndex = 33;
            // 
            // btnExtractLog
            // 
            this.btnExtractLog.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnExtractLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnExtractLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExtractLog.BorderRadius = 0;
            this.btnExtractLog.ButtonText = "Extraer Información";
            this.btnExtractLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExtractLog.DisabledColor = System.Drawing.Color.Gray;
            this.btnExtractLog.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExtractLog.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnExtractLog.Iconimage")));
            this.btnExtractLog.Iconimage_right = null;
            this.btnExtractLog.Iconimage_right_Selected = null;
            this.btnExtractLog.Iconimage_Selected = null;
            this.btnExtractLog.IconMarginLeft = 0;
            this.btnExtractLog.IconMarginRight = 0;
            this.btnExtractLog.IconRightVisible = true;
            this.btnExtractLog.IconRightZoom = 0D;
            this.btnExtractLog.IconVisible = false;
            this.btnExtractLog.IconZoom = 90D;
            this.btnExtractLog.IsTab = false;
            this.btnExtractLog.Location = new System.Drawing.Point(926, 11);
            this.btnExtractLog.Name = "btnExtractLog";
            this.btnExtractLog.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnExtractLog.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnExtractLog.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExtractLog.selected = false;
            this.btnExtractLog.Size = new System.Drawing.Size(153, 27);
            this.btnExtractLog.TabIndex = 34;
            this.btnExtractLog.Text = "Extraer Información";
            this.btnExtractLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExtractLog.Textcolor = System.Drawing.Color.White;
            this.btnExtractLog.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtractLog.Click += new System.EventHandler(this.btnExtractLog_Click);
            // 
            // LogOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.btnExtractLog);
            this.Controls.Add(this.userIdLog);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.endDateLog);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.startDateLog);
            this.Name = "LogOptions";
            this.Size = new System.Drawing.Size(1104, 47);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDatepicker startDateLog;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuDatepicker endDateLog;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.ComboBox userIdLog;
        private Bunifu.Framework.UI.BunifuFlatButton btnExtractLog;
    }
}
