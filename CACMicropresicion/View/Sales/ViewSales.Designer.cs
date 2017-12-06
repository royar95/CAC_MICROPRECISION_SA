namespace CACMicropresicion.View.Sales
{
    partial class ViewSales
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
            this.salesDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgSales = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dgSales)).BeginInit();
            this.SuspendLayout();
            // 
            // salesDate
            // 
            this.salesDate.BackColor = System.Drawing.Color.SeaGreen;
            this.salesDate.BorderRadius = 0;
            this.salesDate.ForeColor = System.Drawing.Color.White;
            this.salesDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.salesDate.FormatCustom = null;
            this.salesDate.Location = new System.Drawing.Point(198, 22);
            this.salesDate.Name = "salesDate";
            this.salesDate.Size = new System.Drawing.Size(166, 26);
            this.salesDate.TabIndex = 44;
            this.salesDate.Value = new System.DateTime(2017, 11, 26, 18, 59, 14, 608);
            this.salesDate.onValueChanged += new System.EventHandler(this.salesDate_onValueChanged);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(38, 22);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(137, 25);
            this.bunifuCustomLabel2.TabIndex = 43;
            this.bunifuCustomLabel2.Text = "Fecha de venta:";
            // 
            // dgSales
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgSales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgSales.BackgroundColor = System.Drawing.Color.White;
            this.dgSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgSales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSales.DoubleBuffered = true;
            this.dgSales.EnableHeadersVisualStyles = false;
            this.dgSales.HeaderBgColor = System.Drawing.Color.LightSteelBlue;
            this.dgSales.HeaderForeColor = System.Drawing.Color.Black;
            this.dgSales.Location = new System.Drawing.Point(0, 69);
            this.dgSales.Name = "dgSales";
            this.dgSales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgSales.Size = new System.Drawing.Size(1035, 401);
            this.dgSales.TabIndex = 42;
            this.dgSales.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSales_CellDoubleClick);
            // 
            // ViewSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.salesDate);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.dgSales);
            this.Name = "ViewSales";
            this.Size = new System.Drawing.Size(1035, 470);
            ((System.ComponentModel.ISupportInitialize)(this.dgSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDatepicker salesDate;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgSales;
    }
}
