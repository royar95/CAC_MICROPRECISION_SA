namespace CACMicropresicion.View.Materials
{
    partial class MaterialsList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgMaterials = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dgMaterials)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMaterials
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgMaterials.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgMaterials.BackgroundColor = System.Drawing.Color.White;
            this.dgMaterials.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgMaterials.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMaterials.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMaterials.DoubleBuffered = true;
            this.dgMaterials.EnableHeadersVisualStyles = false;
            this.dgMaterials.HeaderBgColor = System.Drawing.Color.LightSteelBlue;
            this.dgMaterials.HeaderForeColor = System.Drawing.Color.Black;
            this.dgMaterials.Location = new System.Drawing.Point(0, 0);
            this.dgMaterials.Name = "dgMaterials";
            this.dgMaterials.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgMaterials.Size = new System.Drawing.Size(721, 497);
            this.dgMaterials.TabIndex = 0;
            // 
            // MaterialsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgMaterials);
            this.Name = "MaterialsList";
            this.Size = new System.Drawing.Size(721, 497);
            ((System.ComponentModel.ISupportInitialize)(this.dgMaterials)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgMaterials;
    }
}
