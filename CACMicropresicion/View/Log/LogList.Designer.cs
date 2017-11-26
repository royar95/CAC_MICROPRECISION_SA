namespace CACMicropresicion.View.Log
{
    partial class LogList
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
            this.dbLogs = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dbLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // dbLogs
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dbLogs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dbLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dbLogs.BackgroundColor = System.Drawing.Color.White;
            this.dbLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dbLogs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dbLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbLogs.DoubleBuffered = true;
            this.dbLogs.EnableHeadersVisualStyles = false;
            this.dbLogs.HeaderBgColor = System.Drawing.Color.LightSteelBlue;
            this.dbLogs.HeaderForeColor = System.Drawing.Color.Black;
            this.dbLogs.Location = new System.Drawing.Point(0, 0);
            this.dbLogs.Name = "dbLogs";
            this.dbLogs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dbLogs.Size = new System.Drawing.Size(1026, 575);
            this.dbLogs.TabIndex = 0;
            // 
            // LogList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dbLogs);
            this.Name = "LogList";
            this.Size = new System.Drawing.Size(1026, 575);
            ((System.ComponentModel.ISupportInitialize)(this.dbLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dbLogs;
    }
}
