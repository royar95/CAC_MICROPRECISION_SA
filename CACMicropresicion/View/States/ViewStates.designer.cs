namespace CACMicropresicion.View.States
{
    partial class ViewStates
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
            this.dgViewStates = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewStates)).BeginInit();
            this.SuspendLayout();
            // 
            // dgViewStates
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgViewStates.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgViewStates.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgViewStates.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgViewStates.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgViewStates.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgViewStates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewStates.DoubleBuffered = true;
            this.dgViewStates.EnableHeadersVisualStyles = false;
            this.dgViewStates.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgViewStates.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgViewStates.Location = new System.Drawing.Point(3, 0);
            this.dgViewStates.Name = "dgViewStates";
            this.dgViewStates.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgViewStates.Size = new System.Drawing.Size(784, 483);
            this.dgViewStates.TabIndex = 0;
            // 
            // ViewStates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgViewStates);
            this.Name = "ViewStates";
            this.Size = new System.Drawing.Size(787, 483);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewStates)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgViewStates;
    }
}
