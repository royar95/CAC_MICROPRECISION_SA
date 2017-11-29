namespace CACMicropresicion.View.Sales
{
    partial class NewSale
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewSale));
            this.lblNewUser = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmbPaymentTypes = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtTotal = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmbSaleDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dgMaterialsList = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dgSaleSummary = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.modBtnSaveUserChanges = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtSearch = new Bunifu.Framework.UI.BunifuTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dgMaterialsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSaleSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNewUser
            // 
            this.lblNewUser.AutoSize = true;
            this.lblNewUser.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNewUser.Location = new System.Drawing.Point(43, 29);
            this.lblNewUser.Name = "lblNewUser";
            this.lblNewUser.Size = new System.Drawing.Size(337, 40);
            this.lblNewUser.TabIndex = 3;
            this.lblNewUser.Text = "Registro de nueva compra";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(45, 97);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(121, 25);
            this.bunifuCustomLabel1.TabIndex = 4;
            this.bunifuCustomLabel1.Text = "Tipo de pago";
            // 
            // cmbPaymentTypes
            // 
            this.cmbPaymentTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentTypes.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentTypes.FormattingEnabled = true;
            this.cmbPaymentTypes.Location = new System.Drawing.Point(201, 97);
            this.cmbPaymentTypes.Name = "cmbPaymentTypes";
            this.cmbPaymentTypes.Size = new System.Drawing.Size(193, 25);
            this.cmbPaymentTypes.TabIndex = 36;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(45, 210);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(115, 25);
            this.bunifuCustomLabel2.TabIndex = 37;
            this.bunifuCustomLabel2.Text = "Total compra";
            // 
            // txtTotal
            // 
            this.txtTotal.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtTotal.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotal.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtTotal.BorderThickness = 3;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotal.isPassword = false;
            this.txtTotal.Location = new System.Drawing.Point(199, 201);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(195, 34);
            this.txtTotal.TabIndex = 38;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(45, 153);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(150, 25);
            this.bunifuCustomLabel3.TabIndex = 39;
            this.bunifuCustomLabel3.Text = "Fecha de compra";
            // 
            // cmbSaleDate
            // 
            this.cmbSaleDate.BackColor = System.Drawing.Color.SeaGreen;
            this.cmbSaleDate.BorderRadius = 0;
            this.cmbSaleDate.ForeColor = System.Drawing.Color.White;
            this.cmbSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cmbSaleDate.FormatCustom = null;
            this.cmbSaleDate.Location = new System.Drawing.Point(201, 153);
            this.cmbSaleDate.Name = "cmbSaleDate";
            this.cmbSaleDate.Size = new System.Drawing.Size(193, 26);
            this.cmbSaleDate.TabIndex = 40;
            this.cmbSaleDate.Value = new System.DateTime(2017, 11, 26, 18, 59, 14, 608);
            // 
            // dgMaterialsList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgMaterialsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgMaterialsList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgMaterialsList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgMaterialsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMaterialsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgMaterialsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMaterialsList.DoubleBuffered = true;
            this.dgMaterialsList.EnableHeadersVisualStyles = false;
            this.dgMaterialsList.HeaderBgColor = System.Drawing.Color.LightSteelBlue;
            this.dgMaterialsList.HeaderForeColor = System.Drawing.Color.Black;
            this.dgMaterialsList.Location = new System.Drawing.Point(494, 125);
            this.dgMaterialsList.Name = "dgMaterialsList";
            this.dgMaterialsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgMaterialsList.Size = new System.Drawing.Size(510, 130);
            this.dgMaterialsList.TabIndex = 41;
            // 
            // dgSaleSummary
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgSaleSummary.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgSaleSummary.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgSaleSummary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgSaleSummary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSaleSummary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgSaleSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSaleSummary.DoubleBuffered = true;
            this.dgSaleSummary.EnableHeadersVisualStyles = false;
            this.dgSaleSummary.HeaderBgColor = System.Drawing.Color.LightSteelBlue;
            this.dgSaleSummary.HeaderForeColor = System.Drawing.Color.Black;
            this.dgSaleSummary.Location = new System.Drawing.Point(50, 314);
            this.dgSaleSummary.Name = "dgSaleSummary";
            this.dgSaleSummary.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgSaleSummary.Size = new System.Drawing.Size(956, 144);
            this.dgSaleSummary.TabIndex = 42;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(45, 286);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(178, 25);
            this.bunifuCustomLabel4.TabIndex = 43;
            this.bunifuCustomLabel4.Text = "Resumen de compra";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(489, 97);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(159, 25);
            this.bunifuCustomLabel5.TabIndex = 44;
            this.bunifuCustomLabel5.Text = "Lista de materiales";
            // 
            // modBtnSaveUserChanges
            // 
            this.modBtnSaveUserChanges.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.modBtnSaveUserChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.modBtnSaveUserChanges.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.modBtnSaveUserChanges.BorderRadius = 0;
            this.modBtnSaveUserChanges.ButtonText = "Registrar compra";
            this.modBtnSaveUserChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modBtnSaveUserChanges.DisabledColor = System.Drawing.Color.Gray;
            this.modBtnSaveUserChanges.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modBtnSaveUserChanges.Iconcolor = System.Drawing.Color.Transparent;
            this.modBtnSaveUserChanges.Iconimage = ((System.Drawing.Image)(resources.GetObject("modBtnSaveUserChanges.Iconimage")));
            this.modBtnSaveUserChanges.Iconimage_right = null;
            this.modBtnSaveUserChanges.Iconimage_right_Selected = null;
            this.modBtnSaveUserChanges.Iconimage_Selected = null;
            this.modBtnSaveUserChanges.IconMarginLeft = 0;
            this.modBtnSaveUserChanges.IconMarginRight = 0;
            this.modBtnSaveUserChanges.IconRightVisible = true;
            this.modBtnSaveUserChanges.IconRightZoom = 0D;
            this.modBtnSaveUserChanges.IconVisible = false;
            this.modBtnSaveUserChanges.IconZoom = 90D;
            this.modBtnSaveUserChanges.IsTab = false;
            this.modBtnSaveUserChanges.Location = new System.Drawing.Point(50, 478);
            this.modBtnSaveUserChanges.Name = "modBtnSaveUserChanges";
            this.modBtnSaveUserChanges.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.modBtnSaveUserChanges.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.modBtnSaveUserChanges.OnHoverTextColor = System.Drawing.Color.White;
            this.modBtnSaveUserChanges.selected = false;
            this.modBtnSaveUserChanges.Size = new System.Drawing.Size(229, 48);
            this.modBtnSaveUserChanges.TabIndex = 45;
            this.modBtnSaveUserChanges.Text = "Registrar compra";
            this.modBtnSaveUserChanges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.modBtnSaveUserChanges.Textcolor = System.Drawing.Color.White;
            this.modBtnSaveUserChanges.TextFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearch.Icon")));
            this.txtSearch.Location = new System.Drawing.Point(807, 94);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(197, 25);
            this.txtSearch.TabIndex = 50;
            this.txtSearch.text = "";
            // 
            // NewSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.modBtnSaveUserChanges);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.dgSaleSummary);
            this.Controls.Add(this.dgMaterialsList);
            this.Controls.Add(this.cmbSaleDate);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.cmbPaymentTypes);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.lblNewUser);
            this.Name = "NewSale";
            this.Size = new System.Drawing.Size(1055, 566);
            ((System.ComponentModel.ISupportInitialize)(this.dgMaterialsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSaleSummary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lblNewUser;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.ComboBox cmbPaymentTypes;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTotal;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuDatepicker cmbSaleDate;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgMaterialsList;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgSaleSummary;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuFlatButton modBtnSaveUserChanges;
        private Bunifu.Framework.UI.BunifuTextbox txtSearch;
    }
}
