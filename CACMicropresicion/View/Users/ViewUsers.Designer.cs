namespace CACMicropresicion.View.Users
{
    partial class ViewUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewUsers));
            this.dgViewUsers = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnIdSearch = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgViewUsers
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgViewUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgViewUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgViewUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgViewUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgViewUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewUsers.DoubleBuffered = true;
            this.dgViewUsers.EnableHeadersVisualStyles = false;
            this.dgViewUsers.HeaderBgColor = System.Drawing.Color.LightSteelBlue;
            this.dgViewUsers.HeaderForeColor = System.Drawing.Color.Black;
            this.dgViewUsers.Location = new System.Drawing.Point(0, 68);
            this.dgViewUsers.Name = "dgViewUsers";
            this.dgViewUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgViewUsers.Size = new System.Drawing.Size(853, 458);
            this.dgViewUsers.TabIndex = 0;
            // 
            // btnIdSearch
            // 
            this.btnIdSearch.BackColor = System.Drawing.Color.White;
            this.btnIdSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIdSearch.BackgroundImage")));
            this.btnIdSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIdSearch.ForeColor = System.Drawing.Color.Black;
            this.btnIdSearch.Icon = ((System.Drawing.Image)(resources.GetObject("btnIdSearch.Icon")));
            this.btnIdSearch.Location = new System.Drawing.Point(110, 22);
            this.btnIdSearch.Name = "btnIdSearch";
            this.btnIdSearch.Size = new System.Drawing.Size(197, 25);
            this.btnIdSearch.TabIndex = 5;
            this.btnIdSearch.text = "";
            this.btnIdSearch.OnTextChange += new System.EventHandler(this.btnIdSearch_OnTextChange);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(36, 22);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(72, 25);
            this.bunifuCustomLabel1.TabIndex = 34;
            this.bunifuCustomLabel1.Text = "Cédula:";
            // 
            // ViewUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.btnIdSearch);
            this.Controls.Add(this.dgViewUsers);
            this.Name = "ViewUsers";
            this.Size = new System.Drawing.Size(853, 526);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgViewUsers;
        private Bunifu.Framework.UI.BunifuTextbox btnIdSearch;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}
