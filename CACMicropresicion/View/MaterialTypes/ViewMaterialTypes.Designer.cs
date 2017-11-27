namespace CACMicropresicion.View.MaterialTypes
{
    partial class ViewMaterialTypes
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
            this.dgViewMaterialTypes = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewMaterialTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgViewMaterialTypes
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgViewMaterialTypes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgViewMaterialTypes.BackgroundColor = System.Drawing.Color.White;
            this.dgViewMaterialTypes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgViewMaterialTypes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgViewMaterialTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgViewMaterialTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewMaterialTypes.DoubleBuffered = true;
            this.dgViewMaterialTypes.EnableHeadersVisualStyles = false;
            this.dgViewMaterialTypes.HeaderBgColor = System.Drawing.Color.LightSteelBlue;
            this.dgViewMaterialTypes.HeaderForeColor = System.Drawing.Color.Black;
            this.dgViewMaterialTypes.Location = new System.Drawing.Point(3, 3);
            this.dgViewMaterialTypes.Name = "dgViewMaterialTypes";
            this.dgViewMaterialTypes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgViewMaterialTypes.Size = new System.Drawing.Size(707, 525);
            this.dgViewMaterialTypes.TabIndex = 0;
            // 
            // ViewMaterialTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgViewMaterialTypes);
            this.Name = "ViewMaterialTypes";
            this.Size = new System.Drawing.Size(713, 531);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewMaterialTypes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgViewMaterialTypes;
    }
}
