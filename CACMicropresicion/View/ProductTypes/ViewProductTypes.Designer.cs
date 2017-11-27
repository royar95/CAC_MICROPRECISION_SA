namespace CACMicropresicion.View.ProductTypes
{
    partial class ViewProductTypes
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
            this.dgViewProductTypes = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewProductTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgViewProductTypes
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgViewProductTypes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgViewProductTypes.BackgroundColor = System.Drawing.Color.White;
            this.dgViewProductTypes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgViewProductTypes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgViewProductTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgViewProductTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewProductTypes.DoubleBuffered = true;
            this.dgViewProductTypes.EnableHeadersVisualStyles = false;
            this.dgViewProductTypes.HeaderBgColor = System.Drawing.Color.LightSteelBlue;
            this.dgViewProductTypes.HeaderForeColor = System.Drawing.Color.Black;
            this.dgViewProductTypes.Location = new System.Drawing.Point(0, 0);
            this.dgViewProductTypes.Name = "dgViewProductTypes";
            this.dgViewProductTypes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgViewProductTypes.Size = new System.Drawing.Size(673, 474);
            this.dgViewProductTypes.TabIndex = 0;
            // 
            // ViewProductTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgViewProductTypes);
            this.Name = "ViewProductTypes";
            this.Size = new System.Drawing.Size(673, 474);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewProductTypes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgViewProductTypes;
    }
}
