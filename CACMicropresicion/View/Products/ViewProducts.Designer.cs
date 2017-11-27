namespace CACMicropresicion.View.Products
{
    partial class ViewProducts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtViewProducts = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dtViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dtViewProducts
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtViewProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtViewProducts.BackgroundColor = System.Drawing.Color.White;
            this.dtViewProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtViewProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtViewProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtViewProducts.DoubleBuffered = true;
            this.dtViewProducts.EnableHeadersVisualStyles = false;
            this.dtViewProducts.HeaderBgColor = System.Drawing.Color.LightSteelBlue;
            this.dtViewProducts.HeaderForeColor = System.Drawing.Color.Black;
            this.dtViewProducts.Location = new System.Drawing.Point(0, 0);
            this.dtViewProducts.Name = "dtViewProducts";
            this.dtViewProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtViewProducts.Size = new System.Drawing.Size(673, 474);
            this.dtViewProducts.TabIndex = 0;
            // 
            // ViewProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dtViewProducts);
            this.Name = "ViewProducts";
            this.Size = new System.Drawing.Size(673, 474);
            ((System.ComponentModel.ISupportInitialize)(this.dtViewProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dtViewProducts;
    }
}
