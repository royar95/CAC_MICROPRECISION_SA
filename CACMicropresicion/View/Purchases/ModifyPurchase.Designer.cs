namespace CACMicropresicion.View.Purchases
{
    partial class ModifyPurchase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyPurchase));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new Bunifu.Framework.UI.BunifuTextbox();
            this.modBtnSaveUserChanges = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgPurchaseSummary = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgMaterialsList = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.cmbPurchaseDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtTotal = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmbPaymentTypes = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblNewUser = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgPurchaseSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMaterialsList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearch.Icon")));
            this.txtSearch.Location = new System.Drawing.Point(802, 92);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(197, 25);
            this.txtSearch.TabIndex = 63;
            this.txtSearch.text = "";
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
            this.modBtnSaveUserChanges.Location = new System.Drawing.Point(45, 476);
            this.modBtnSaveUserChanges.Name = "modBtnSaveUserChanges";
            this.modBtnSaveUserChanges.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.modBtnSaveUserChanges.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.modBtnSaveUserChanges.OnHoverTextColor = System.Drawing.Color.White;
            this.modBtnSaveUserChanges.selected = false;
            this.modBtnSaveUserChanges.Size = new System.Drawing.Size(229, 48);
            this.modBtnSaveUserChanges.TabIndex = 62;
            this.modBtnSaveUserChanges.Text = "Registrar compra";
            this.modBtnSaveUserChanges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.modBtnSaveUserChanges.Textcolor = System.Drawing.Color.White;
            this.modBtnSaveUserChanges.TextFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(484, 95);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(159, 25);
            this.bunifuCustomLabel5.TabIndex = 61;
            this.bunifuCustomLabel5.Text = "Lista de materiales";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(40, 284);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(178, 25);
            this.bunifuCustomLabel4.TabIndex = 60;
            this.bunifuCustomLabel4.Text = "Resumen de compra";
            // 
            // dgPurchaseSummary
            // 
            this.dgPurchaseSummary.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgPurchaseSummary.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgPurchaseSummary.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgPurchaseSummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgPurchaseSummary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPurchaseSummary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgPurchaseSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPurchaseSummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.Description,
            this.Quantity});
            this.dgPurchaseSummary.DoubleBuffered = true;
            this.dgPurchaseSummary.EnableHeadersVisualStyles = false;
            this.dgPurchaseSummary.HeaderBgColor = System.Drawing.Color.LightSteelBlue;
            this.dgPurchaseSummary.HeaderForeColor = System.Drawing.Color.Black;
            this.dgPurchaseSummary.Location = new System.Drawing.Point(45, 312);
            this.dgPurchaseSummary.Name = "dgPurchaseSummary";
            this.dgPurchaseSummary.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgPurchaseSummary.Size = new System.Drawing.Size(549, 144);
            this.dgPurchaseSummary.TabIndex = 59;
            // 
            // code
            // 
            this.code.HeaderText = "Código";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Descripción";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 395;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Cantidad";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 150;
            // 
            // dgMaterialsList
            // 
            this.dgMaterialsList.AllowUserToAddRows = false;
            this.dgMaterialsList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgMaterialsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgMaterialsList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgMaterialsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgMaterialsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMaterialsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgMaterialsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMaterialsList.DoubleBuffered = true;
            this.dgMaterialsList.EnableHeadersVisualStyles = false;
            this.dgMaterialsList.HeaderBgColor = System.Drawing.Color.LightSteelBlue;
            this.dgMaterialsList.HeaderForeColor = System.Drawing.Color.Black;
            this.dgMaterialsList.Location = new System.Drawing.Point(489, 123);
            this.dgMaterialsList.Name = "dgMaterialsList";
            this.dgMaterialsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgMaterialsList.Size = new System.Drawing.Size(510, 135);
            this.dgMaterialsList.TabIndex = 58;
            // 
            // cmbPurchaseDate
            // 
            this.cmbPurchaseDate.BackColor = System.Drawing.Color.SeaGreen;
            this.cmbPurchaseDate.BorderRadius = 0;
            this.cmbPurchaseDate.ForeColor = System.Drawing.Color.White;
            this.cmbPurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cmbPurchaseDate.FormatCustom = null;
            this.cmbPurchaseDate.Location = new System.Drawing.Point(196, 151);
            this.cmbPurchaseDate.Name = "cmbPurchaseDate";
            this.cmbPurchaseDate.Size = new System.Drawing.Size(193, 26);
            this.cmbPurchaseDate.TabIndex = 57;
            this.cmbPurchaseDate.Value = new System.DateTime(2017, 11, 26, 18, 59, 14, 608);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(40, 151);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(150, 25);
            this.bunifuCustomLabel3.TabIndex = 56;
            this.bunifuCustomLabel3.Text = "Fecha de compra";
            // 
            // txtTotal
            // 
            this.txtTotal.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtTotal.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotal.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtTotal.BorderThickness = 3;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotal.isPassword = false;
            this.txtTotal.Location = new System.Drawing.Point(194, 199);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(195, 34);
            this.txtTotal.TabIndex = 55;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(40, 208);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(115, 25);
            this.bunifuCustomLabel2.TabIndex = 54;
            this.bunifuCustomLabel2.Text = "Total compra";
            // 
            // cmbPaymentTypes
            // 
            this.cmbPaymentTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentTypes.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentTypes.FormattingEnabled = true;
            this.cmbPaymentTypes.Location = new System.Drawing.Point(196, 95);
            this.cmbPaymentTypes.Name = "cmbPaymentTypes";
            this.cmbPaymentTypes.Size = new System.Drawing.Size(193, 25);
            this.cmbPaymentTypes.TabIndex = 53;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(40, 95);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(121, 25);
            this.bunifuCustomLabel1.TabIndex = 52;
            this.bunifuCustomLabel1.Text = "Tipo de pago";
            // 
            // lblNewUser
            // 
            this.lblNewUser.AutoSize = true;
            this.lblNewUser.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNewUser.Location = new System.Drawing.Point(38, 27);
            this.lblNewUser.Name = "lblNewUser";
            this.lblNewUser.Size = new System.Drawing.Size(311, 40);
            this.lblNewUser.TabIndex = 51;
            this.lblNewUser.Text = "Modificación de compra";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(802, 340);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(193, 25);
            this.cmbStatus.TabIndex = 65;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(797, 312);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(66, 25);
            this.bunifuCustomLabel6.TabIndex = 64;
            this.bunifuCustomLabel6.Text = "Estado";
            // 
            // ModifyPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.modBtnSaveUserChanges);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.dgPurchaseSummary);
            this.Controls.Add(this.dgMaterialsList);
            this.Controls.Add(this.cmbPurchaseDate);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.cmbPaymentTypes);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.lblNewUser);
            this.Name = "ModifyPurchase";
            this.Size = new System.Drawing.Size(1040, 573);
            ((System.ComponentModel.ISupportInitialize)(this.dgPurchaseSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMaterialsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTextbox txtSearch;
        private Bunifu.Framework.UI.BunifuFlatButton modBtnSaveUserChanges;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgPurchaseSummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgMaterialsList;
        private Bunifu.Framework.UI.BunifuDatepicker cmbPurchaseDate;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTotal;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.ComboBox cmbPaymentTypes;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNewUser;
        private System.Windows.Forms.ComboBox cmbStatus;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
    }
}
