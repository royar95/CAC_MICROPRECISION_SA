namespace CACMicropresicion.View.Reports
{
    partial class SalesRevenue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesRevenue));
            this.dgSalesRevenue = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtTotal = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblUserName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.button1 = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgSalesRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // dgSalesRevenue
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgSalesRevenue.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgSalesRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgSalesRevenue.BackgroundColor = System.Drawing.Color.White;
            this.dgSalesRevenue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgSalesRevenue.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSalesRevenue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgSalesRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSalesRevenue.DoubleBuffered = true;
            this.dgSalesRevenue.EnableHeadersVisualStyles = false;
            this.dgSalesRevenue.GridColor = System.Drawing.Color.White;
            this.dgSalesRevenue.HeaderBgColor = System.Drawing.Color.LightSteelBlue;
            this.dgSalesRevenue.HeaderForeColor = System.Drawing.Color.Black;
            this.dgSalesRevenue.Location = new System.Drawing.Point(0, 0);
            this.dgSalesRevenue.Name = "dgSalesRevenue";
            this.dgSalesRevenue.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgSalesRevenue.Size = new System.Drawing.Size(916, 466);
            this.dgSalesRevenue.TabIndex = 2;
            // 
            // txtTotal
            // 
            this.txtTotal.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtTotal.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotal.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtTotal.BorderThickness = 3;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotal.isPassword = false;
            this.txtTotal.Location = new System.Drawing.Point(219, 484);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(370, 48);
            this.txtTotal.TabIndex = 4;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUserName.Location = new System.Drawing.Point(122, 498);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(63, 25);
            this.lblUserName.TabIndex = 8;
            this.lblUserName.Text = "TOTAL";
            // 
            // button1
            // 
            this.button1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.BorderRadius = 0;
            this.button1.ButtonText = "Exportar A Excel";
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DisabledColor = System.Drawing.Color.Gray;
            this.button1.Iconcolor = System.Drawing.Color.Transparent;
            this.button1.Iconimage = ((System.Drawing.Image)(resources.GetObject("button1.Iconimage")));
            this.button1.Iconimage_right = null;
            this.button1.Iconimage_right_Selected = null;
            this.button1.Iconimage_Selected = null;
            this.button1.IconMarginLeft = 0;
            this.button1.IconMarginRight = 0;
            this.button1.IconRightVisible = true;
            this.button1.IconRightZoom = 0D;
            this.button1.IconVisible = true;
            this.button1.IconZoom = 90D;
            this.button1.IsTab = false;
            this.button1.Location = new System.Drawing.Point(645, 484);
            this.button1.Name = "button1";
            this.button1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.button1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.button1.OnHoverTextColor = System.Drawing.Color.White;
            this.button1.selected = false;
            this.button1.Size = new System.Drawing.Size(172, 48);
            this.button1.TabIndex = 9;
            this.button1.Text = "Exportar A Excel";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Textcolor = System.Drawing.Color.White;
            this.button1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // SalesRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.dgSalesRevenue);
            this.Name = "SalesRevenue";
            this.Size = new System.Drawing.Size(916, 548);
            ((System.ComponentModel.ISupportInitialize)(this.dgSalesRevenue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgSalesRevenue;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTotal;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUserName;
        private Bunifu.Framework.UI.BunifuFlatButton button1;
    }
}
