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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMaterialTypes));
            this.dgViewMaterialTypes = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtSearch = new Bunifu.Framework.UI.BunifuTextbox();
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
            this.dgViewMaterialTypes.Location = new System.Drawing.Point(0, 71);
            this.dgViewMaterialTypes.Name = "dgViewMaterialTypes";
            this.dgViewMaterialTypes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgViewMaterialTypes.Size = new System.Drawing.Size(707, 454);
            this.dgViewMaterialTypes.TabIndex = 0;
            this.dgViewMaterialTypes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgViewMaterialTypes_CellContentClick);
            this.dgViewMaterialTypes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgViewMaterialTypes_CellDoubleClick);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(41, 24);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(108, 25);
            this.bunifuCustomLabel1.TabIndex = 40;
            this.bunifuCustomLabel1.Text = "Descripción:";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearch.Icon")));
            this.txtSearch.Location = new System.Drawing.Point(155, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(197, 25);
            this.txtSearch.TabIndex = 39;
            this.txtSearch.text = "";
            this.txtSearch.OnTextChange += new System.EventHandler(this.txtSearch_OnTextChange);
            // 
            // ViewMaterialTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgViewMaterialTypes);
            this.Name = "ViewMaterialTypes";
            this.Size = new System.Drawing.Size(713, 531);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewMaterialTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgViewMaterialTypes;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuTextbox txtSearch;
    }
}
