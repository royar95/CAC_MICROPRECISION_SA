namespace CACMicropresicion.View.Reports
{
    partial class CostOfGoodsSold
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CostOfGoodsSold));
            this.dgCosts = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtTotal = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnExport = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblUserName = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgCosts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCosts
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgCosts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgCosts.BackgroundColor = System.Drawing.Color.White;
            this.dgCosts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgCosts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCosts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgCosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCosts.DoubleBuffered = true;
            this.dgCosts.EnableHeadersVisualStyles = false;
            this.dgCosts.HeaderBgColor = System.Drawing.Color.LightSteelBlue;
            this.dgCosts.HeaderForeColor = System.Drawing.Color.Black;
            this.dgCosts.Location = new System.Drawing.Point(0, 0);
            this.dgCosts.Name = "dgCosts";
            this.dgCosts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgCosts.Size = new System.Drawing.Size(795, 477);
            this.dgCosts.TabIndex = 0;
            // 
            // txtTotal
            // 
            this.txtTotal.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtTotal.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotal.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtTotal.BorderThickness = 3;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotal.isPassword = false;
            this.txtTotal.Location = new System.Drawing.Point(151, 487);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(370, 48);
            this.txtTotal.TabIndex = 2;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExport
            // 
            this.btnExport.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExport.BorderRadius = 0;
            this.btnExport.ButtonText = "Exportar A Excel";
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.DisabledColor = System.Drawing.Color.Gray;
            this.btnExport.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExport.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnExport.Iconimage")));
            this.btnExport.Iconimage_right = null;
            this.btnExport.Iconimage_right_Selected = null;
            this.btnExport.Iconimage_Selected = null;
            this.btnExport.IconMarginLeft = 0;
            this.btnExport.IconMarginRight = 0;
            this.btnExport.IconRightVisible = true;
            this.btnExport.IconRightZoom = 0D;
            this.btnExport.IconVisible = true;
            this.btnExport.IconZoom = 90D;
            this.btnExport.IsTab = false;
            this.btnExport.Location = new System.Drawing.Point(576, 487);
            this.btnExport.Name = "btnExport";
            this.btnExport.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnExport.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnExport.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExport.selected = false;
            this.btnExport.Size = new System.Drawing.Size(172, 48);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Exportar A Excel";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Textcolor = System.Drawing.Color.White;
            this.btnExport.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUserName.Location = new System.Drawing.Point(46, 499);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(63, 25);
            this.lblUserName.TabIndex = 7;
            this.lblUserName.Text = "TOTAL";
            // 
            // CostOfGoodsSold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.dgCosts);
            this.Name = "CostOfGoodsSold";
            this.Size = new System.Drawing.Size(795, 547);
            ((System.ComponentModel.ISupportInitialize)(this.dgCosts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgCosts;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTotal;
        private Bunifu.Framework.UI.BunifuFlatButton btnExport;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUserName;
    }
}
