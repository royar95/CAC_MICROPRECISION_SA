namespace CACMicropresicion.View.PaymentMethods
{
    partial class ViewPaymentMethods
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
            this.dgViewPayments = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // dgViewPayments
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgViewPayments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgViewPayments.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgViewPayments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgViewPayments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgViewPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgViewPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewPayments.DoubleBuffered = true;
            this.dgViewPayments.EnableHeadersVisualStyles = false;
            this.dgViewPayments.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgViewPayments.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgViewPayments.Location = new System.Drawing.Point(0, 0);
            this.dgViewPayments.Name = "dgViewPayments";
            this.dgViewPayments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgViewPayments.Size = new System.Drawing.Size(707, 475);
            this.dgViewPayments.TabIndex = 1;
            // 
            // ViewPaymentMethods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgViewPayments);
            this.Name = "ViewPaymentMethods";
            this.Size = new System.Drawing.Size(707, 475);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewPayments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgViewPayments;
    }
}
