namespace CACMicropresicion.View.Sales
{
    partial class NewSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewSale));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new Bunifu.Framework.UI.BunifuTextbox();
            this.saveSale = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgSaleSummary = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProductsList = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.cmbSaleDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtTotal = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmbPaymentTypes = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblNewUser = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtSubtotal = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtTax = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtDiscount = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgSaleSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductsList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearch.Icon")));
            this.txtSearch.Location = new System.Drawing.Point(811, 101);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(197, 25);
            this.txtSearch.TabIndex = 63;
            this.txtSearch.text = "";
            this.txtSearch.OnTextChange += new System.EventHandler(this.txtSearch_OnTextChange);
            // 
            // saveSale
            // 
            this.saveSale.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.saveSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.saveSale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveSale.BorderRadius = 0;
            this.saveSale.ButtonText = "Registrar venta";
            this.saveSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveSale.DisabledColor = System.Drawing.Color.Gray;
            this.saveSale.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveSale.Iconcolor = System.Drawing.Color.Transparent;
            this.saveSale.Iconimage = ((System.Drawing.Image)(resources.GetObject("saveSale.Iconimage")));
            this.saveSale.Iconimage_right = null;
            this.saveSale.Iconimage_right_Selected = null;
            this.saveSale.Iconimage_Selected = null;
            this.saveSale.IconMarginLeft = 0;
            this.saveSale.IconMarginRight = 0;
            this.saveSale.IconRightVisible = true;
            this.saveSale.IconRightZoom = 0D;
            this.saveSale.IconVisible = false;
            this.saveSale.IconZoom = 90D;
            this.saveSale.IsTab = false;
            this.saveSale.Location = new System.Drawing.Point(54, 485);
            this.saveSale.Name = "saveSale";
            this.saveSale.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.saveSale.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.saveSale.OnHoverTextColor = System.Drawing.Color.White;
            this.saveSale.selected = false;
            this.saveSale.Size = new System.Drawing.Size(229, 48);
            this.saveSale.TabIndex = 62;
            this.saveSale.Text = "Registrar venta";
            this.saveSale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveSale.Textcolor = System.Drawing.Color.White;
            this.saveSale.TextFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveSale.Click += new System.EventHandler(this.saveSale_Click);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(493, 104);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(159, 25);
            this.bunifuCustomLabel5.TabIndex = 61;
            this.bunifuCustomLabel5.Text = "Lista de productos";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(49, 293);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(161, 25);
            this.bunifuCustomLabel4.TabIndex = 60;
            this.bunifuCustomLabel4.Text = "Resumen de venta";
            // 
            // dgSaleSummary
            // 
            this.dgSaleSummary.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgSaleSummary.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgSaleSummary.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgSaleSummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgSaleSummary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSaleSummary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgSaleSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSaleSummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.Description,
            this.Price,
            this.Quantity});
            this.dgSaleSummary.DoubleBuffered = true;
            this.dgSaleSummary.EnableHeadersVisualStyles = false;
            this.dgSaleSummary.HeaderBgColor = System.Drawing.Color.LightSteelBlue;
            this.dgSaleSummary.HeaderForeColor = System.Drawing.Color.Black;
            this.dgSaleSummary.Location = new System.Drawing.Point(54, 321);
            this.dgSaleSummary.Name = "dgSaleSummary";
            this.dgSaleSummary.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgSaleSummary.Size = new System.Drawing.Size(598, 144);
            this.dgSaleSummary.TabIndex = 59;
            this.dgSaleSummary.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSaleSummary_CellLeave);
            this.dgSaleSummary.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgSaleSummary_KeyDown);
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
            this.Description.Width = 300;
            // 
            // Price
            // 
            this.Price.HeaderText = "Precio";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 150;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Cantidad";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 150;
            // 
            // dgProductsList
            // 
            this.dgProductsList.AllowUserToAddRows = false;
            this.dgProductsList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgProductsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgProductsList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgProductsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgProductsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProductsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgProductsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductsList.DoubleBuffered = true;
            this.dgProductsList.EnableHeadersVisualStyles = false;
            this.dgProductsList.HeaderBgColor = System.Drawing.Color.LightSteelBlue;
            this.dgProductsList.HeaderForeColor = System.Drawing.Color.Black;
            this.dgProductsList.Location = new System.Drawing.Point(498, 132);
            this.dgProductsList.Name = "dgProductsList";
            this.dgProductsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgProductsList.Size = new System.Drawing.Size(510, 135);
            this.dgProductsList.TabIndex = 58;
            this.dgProductsList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductsList_CellDoubleClick);
            // 
            // cmbSaleDate
            // 
            this.cmbSaleDate.BackColor = System.Drawing.Color.SeaGreen;
            this.cmbSaleDate.BorderRadius = 0;
            this.cmbSaleDate.ForeColor = System.Drawing.Color.White;
            this.cmbSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cmbSaleDate.FormatCustom = null;
            this.cmbSaleDate.Location = new System.Drawing.Point(205, 171);
            this.cmbSaleDate.Name = "cmbSaleDate";
            this.cmbSaleDate.Size = new System.Drawing.Size(193, 26);
            this.cmbSaleDate.TabIndex = 57;
            this.cmbSaleDate.Value = new System.DateTime(2017, 11, 26, 18, 59, 14, 608);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(49, 171);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(133, 25);
            this.bunifuCustomLabel3.TabIndex = 56;
            this.bunifuCustomLabel3.Text = "Fecha de venta";
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
            this.txtTotal.Location = new System.Drawing.Point(805, 440);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(195, 34);
            this.txtTotal.TabIndex = 55;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(749, 449);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(49, 25);
            this.bunifuCustomLabel2.TabIndex = 54;
            this.bunifuCustomLabel2.Text = "Total";
            // 
            // cmbPaymentTypes
            // 
            this.cmbPaymentTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentTypes.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentTypes.FormattingEnabled = true;
            this.cmbPaymentTypes.Location = new System.Drawing.Point(205, 132);
            this.cmbPaymentTypes.Name = "cmbPaymentTypes";
            this.cmbPaymentTypes.Size = new System.Drawing.Size(193, 25);
            this.cmbPaymentTypes.TabIndex = 53;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(49, 132);
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
            this.lblNewUser.Location = new System.Drawing.Point(47, 36);
            this.lblNewUser.Name = "lblNewUser";
            this.lblNewUser.Size = new System.Drawing.Size(311, 40);
            this.lblNewUser.TabIndex = 51;
            this.lblNewUser.Text = "Registro de nueva venta";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtSubtotal.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSubtotal.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtSubtotal.BorderThickness = 3;
            this.txtSubtotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.txtSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSubtotal.isPassword = false;
            this.txtSubtotal.Location = new System.Drawing.Point(805, 398);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(195, 34);
            this.txtSubtotal.TabIndex = 65;
            this.txtSubtotal.Text = "0";
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(720, 407);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(78, 25);
            this.bunifuCustomLabel6.TabIndex = 64;
            this.bunifuCustomLabel6.Text = "Subtotal";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(711, 321);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(87, 25);
            this.bunifuCustomLabel7.TabIndex = 66;
            this.bunifuCustomLabel7.Text = "Impuesto";
            // 
            // txtTax
            // 
            this.txtTax.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtTax.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTax.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtTax.BorderThickness = 3;
            this.txtTax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTax.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.txtTax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTax.isPassword = false;
            this.txtTax.Location = new System.Drawing.Point(805, 312);
            this.txtTax.Margin = new System.Windows.Forms.Padding(4);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(105, 34);
            this.txtTax.TabIndex = 67;
            this.txtTax.Text = "0";
            this.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTax.OnValueChanged += new System.EventHandler(this.txtTax_OnValueChanged);
            this.txtTax.Enter += new System.EventHandler(this.txtTax_Enter);
            this.txtTax.Leave += new System.EventHandler(this.txtTax_Leave);
            // 
            // txtDiscount
            // 
            this.txtDiscount.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtDiscount.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDiscount.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtDiscount.BorderThickness = 3;
            this.txtDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.txtDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDiscount.isPassword = false;
            this.txtDiscount.Location = new System.Drawing.Point(805, 356);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(105, 34);
            this.txtDiscount.TabIndex = 69;
            this.txtDiscount.Text = "0";
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDiscount.OnValueChanged += new System.EventHandler(this.txtDiscount_OnValueChanged);
            this.txtDiscount.Enter += new System.EventHandler(this.txtDiscount_Enter);
            this.txtDiscount.Leave += new System.EventHandler(this.txtDiscount_Leave);
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(701, 365);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(97, 25);
            this.bunifuCustomLabel8.TabIndex = 68;
            this.bunifuCustomLabel8.Text = "Descuento";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(917, 321);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(27, 25);
            this.bunifuCustomLabel9.TabIndex = 70;
            this.bunifuCustomLabel9.Text = "%";
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(917, 365);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(27, 25);
            this.bunifuCustomLabel10.TabIndex = 71;
            this.bunifuCustomLabel10.Text = "%";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomer.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(205, 210);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(193, 25);
            this.cmbCustomer.TabIndex = 73;
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(49, 210);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(68, 25);
            this.bunifuCustomLabel11.TabIndex = 72;
            this.bunifuCustomLabel11.Text = "Cliente";
            // 
            // NewSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.bunifuCustomLabel11);
            this.Controls.Add(this.bunifuCustomLabel10);
            this.Controls.Add(this.bunifuCustomLabel9);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.bunifuCustomLabel8);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.saveSale);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.dgSaleSummary);
            this.Controls.Add(this.dgProductsList);
            this.Controls.Add(this.cmbSaleDate);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.cmbPaymentTypes);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.lblNewUser);
            this.Name = "NewSale";
            this.Size = new System.Drawing.Size(1073, 577);
            ((System.ComponentModel.ISupportInitialize)(this.dgSaleSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTextbox txtSearch;
        private Bunifu.Framework.UI.BunifuFlatButton saveSale;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgSaleSummary;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgProductsList;
        private Bunifu.Framework.UI.BunifuDatepicker cmbSaleDate;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTotal;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.ComboBox cmbPaymentTypes;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNewUser;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSubtotal;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTax;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtDiscount;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}
