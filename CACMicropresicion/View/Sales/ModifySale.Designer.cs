namespace CACMicropresicion.View.Sales
{
    partial class ModifySale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifySale));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtDiscount = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtTax = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtSubtotal = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtSearch = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgSaleSummary = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.IdSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProductsList = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtTotal = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmbPaymentTypes = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblNewUser = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbSaleDate = new System.Windows.Forms.DateTimePicker();
            this.saveChanges = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPrintBill = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgSaleSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductsList)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomer.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(200, 189);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(193, 25);
            this.cmbCustomer.TabIndex = 95;
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(912, 361);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(27, 25);
            this.bunifuCustomLabel10.TabIndex = 94;
            this.bunifuCustomLabel10.Text = "%";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(912, 317);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(27, 25);
            this.bunifuCustomLabel9.TabIndex = 93;
            this.bunifuCustomLabel9.Text = "%";
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
            this.txtDiscount.Location = new System.Drawing.Point(800, 352);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(105, 34);
            this.txtDiscount.TabIndex = 92;
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
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(696, 361);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(97, 25);
            this.bunifuCustomLabel8.TabIndex = 91;
            this.bunifuCustomLabel8.Text = "Descuento";
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
            this.txtTax.Location = new System.Drawing.Point(800, 308);
            this.txtTax.Margin = new System.Windows.Forms.Padding(4);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(105, 34);
            this.txtTax.TabIndex = 90;
            this.txtTax.Text = "0";
            this.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTax.OnValueChanged += new System.EventHandler(this.txtTax_OnValueChanged);
            this.txtTax.Enter += new System.EventHandler(this.txtTax_Enter);
            this.txtTax.Leave += new System.EventHandler(this.txtTax_Leave);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(706, 317);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(87, 25);
            this.bunifuCustomLabel7.TabIndex = 89;
            this.bunifuCustomLabel7.Text = "Impuesto";
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
            this.txtSubtotal.Location = new System.Drawing.Point(800, 394);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(195, 34);
            this.txtSubtotal.TabIndex = 88;
            this.txtSubtotal.Text = "0";
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(715, 403);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(78, 25);
            this.bunifuCustomLabel6.TabIndex = 87;
            this.bunifuCustomLabel6.Text = "Subtotal";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearch.Icon")));
            this.txtSearch.Location = new System.Drawing.Point(806, 97);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(197, 25);
            this.txtSearch.TabIndex = 86;
            this.txtSearch.text = "";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(488, 100);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(159, 25);
            this.bunifuCustomLabel5.TabIndex = 84;
            this.bunifuCustomLabel5.Text = "Lista de productos";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(44, 289);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(161, 25);
            this.bunifuCustomLabel4.TabIndex = 83;
            this.bunifuCustomLabel4.Text = "Resumen de venta";
            // 
            // dgSaleSummary
            // 
            this.dgSaleSummary.AllowUserToAddRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgSaleSummary.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgSaleSummary.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgSaleSummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgSaleSummary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSaleSummary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgSaleSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSaleSummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdSale,
            this.IdProduct,
            this.Description,
            this.Price,
            this.Quantity});
            this.dgSaleSummary.DoubleBuffered = true;
            this.dgSaleSummary.EnableHeadersVisualStyles = false;
            this.dgSaleSummary.HeaderBgColor = System.Drawing.Color.LightSteelBlue;
            this.dgSaleSummary.HeaderForeColor = System.Drawing.Color.Black;
            this.dgSaleSummary.Location = new System.Drawing.Point(49, 317);
            this.dgSaleSummary.Name = "dgSaleSummary";
            this.dgSaleSummary.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgSaleSummary.Size = new System.Drawing.Size(598, 144);
            this.dgSaleSummary.TabIndex = 82;
            this.dgSaleSummary.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSaleSummary_CellLeave);
            this.dgSaleSummary.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgSaleSummary_KeyDown);
            // 
            // IdSale
            // 
            this.IdSale.HeaderText = "Id Venta";
            this.IdSale.Name = "IdSale";
            this.IdSale.ReadOnly = true;
            this.IdSale.Visible = false;
            // 
            // IdProduct
            // 
            this.IdProduct.HeaderText = "Id Producto";
            this.IdProduct.Name = "IdProduct";
            this.IdProduct.ReadOnly = true;
            this.IdProduct.Visible = false;
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
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgProductsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgProductsList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgProductsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgProductsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProductsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgProductsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductsList.DoubleBuffered = true;
            this.dgProductsList.EnableHeadersVisualStyles = false;
            this.dgProductsList.HeaderBgColor = System.Drawing.Color.LightSteelBlue;
            this.dgProductsList.HeaderForeColor = System.Drawing.Color.Black;
            this.dgProductsList.Location = new System.Drawing.Point(493, 128);
            this.dgProductsList.Name = "dgProductsList";
            this.dgProductsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgProductsList.Size = new System.Drawing.Size(510, 135);
            this.dgProductsList.TabIndex = 81;
            this.dgProductsList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductsList_CellDoubleClick);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(44, 150);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(133, 25);
            this.bunifuCustomLabel3.TabIndex = 79;
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
            this.txtTotal.Location = new System.Drawing.Point(800, 436);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(195, 34);
            this.txtTotal.TabIndex = 78;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(744, 445);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(49, 25);
            this.bunifuCustomLabel2.TabIndex = 77;
            this.bunifuCustomLabel2.Text = "Total";
            // 
            // cmbPaymentTypes
            // 
            this.cmbPaymentTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentTypes.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentTypes.FormattingEnabled = true;
            this.cmbPaymentTypes.Location = new System.Drawing.Point(200, 111);
            this.cmbPaymentTypes.Name = "cmbPaymentTypes";
            this.cmbPaymentTypes.Size = new System.Drawing.Size(193, 25);
            this.cmbPaymentTypes.TabIndex = 76;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(44, 111);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(121, 25);
            this.bunifuCustomLabel1.TabIndex = 75;
            this.bunifuCustomLabel1.Text = "Tipo de pago";
            // 
            // lblNewUser
            // 
            this.lblNewUser.AutoSize = true;
            this.lblNewUser.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNewUser.Location = new System.Drawing.Point(42, 32);
            this.lblNewUser.Name = "lblNewUser";
            this.lblNewUser.Size = new System.Drawing.Size(285, 40);
            this.lblNewUser.TabIndex = 74;
            this.lblNewUser.Text = "Modificación de venta";
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(44, 189);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(68, 25);
            this.bunifuCustomLabel11.TabIndex = 96;
            this.bunifuCustomLabel11.Text = "Cliente";
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(44, 227);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(66, 25);
            this.bunifuCustomLabel12.TabIndex = 97;
            this.bunifuCustomLabel12.Text = "Estado";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(200, 227);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(193, 25);
            this.cmbStatus.TabIndex = 98;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // cmbSaleDate
            // 
            this.cmbSaleDate.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSaleDate.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.cmbSaleDate.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.cmbSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cmbSaleDate.Location = new System.Drawing.Point(200, 150);
            this.cmbSaleDate.Name = "cmbSaleDate";
            this.cmbSaleDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbSaleDate.Size = new System.Drawing.Size(193, 25);
            this.cmbSaleDate.TabIndex = 99;
            // 
            // saveChanges
            // 
            this.saveChanges.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.saveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.saveChanges.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveChanges.BorderRadius = 0;
            this.saveChanges.ButtonText = "Guardar cambios";
            this.saveChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveChanges.DisabledColor = System.Drawing.Color.Gray;
            this.saveChanges.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChanges.Iconcolor = System.Drawing.Color.Transparent;
            this.saveChanges.Iconimage = ((System.Drawing.Image)(resources.GetObject("saveChanges.Iconimage")));
            this.saveChanges.Iconimage_right = null;
            this.saveChanges.Iconimage_right_Selected = null;
            this.saveChanges.Iconimage_Selected = null;
            this.saveChanges.IconMarginLeft = 0;
            this.saveChanges.IconMarginRight = 0;
            this.saveChanges.IconRightVisible = true;
            this.saveChanges.IconRightZoom = 0D;
            this.saveChanges.IconVisible = false;
            this.saveChanges.IconZoom = 90D;
            this.saveChanges.IsTab = false;
            this.saveChanges.Location = new System.Drawing.Point(49, 485);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.saveChanges.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.saveChanges.OnHoverTextColor = System.Drawing.Color.White;
            this.saveChanges.selected = false;
            this.saveChanges.Size = new System.Drawing.Size(229, 48);
            this.saveChanges.TabIndex = 100;
            this.saveChanges.Text = "Guardar cambios";
            this.saveChanges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveChanges.Textcolor = System.Drawing.Color.White;
            this.saveChanges.TextFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChanges.Click += new System.EventHandler(this.saveChanges_Click);
            // 
            // btnPrintBill
            // 
            this.btnPrintBill.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPrintBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPrintBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrintBill.BorderRadius = 0;
            this.btnPrintBill.ButtonText = "Imprimir factura";
            this.btnPrintBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintBill.DisabledColor = System.Drawing.Color.Gray;
            this.btnPrintBill.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintBill.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPrintBill.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPrintBill.Iconimage")));
            this.btnPrintBill.Iconimage_right = null;
            this.btnPrintBill.Iconimage_right_Selected = null;
            this.btnPrintBill.Iconimage_Selected = null;
            this.btnPrintBill.IconMarginLeft = 0;
            this.btnPrintBill.IconMarginRight = 0;
            this.btnPrintBill.IconRightVisible = true;
            this.btnPrintBill.IconRightZoom = 0D;
            this.btnPrintBill.IconVisible = false;
            this.btnPrintBill.IconZoom = 90D;
            this.btnPrintBill.IsTab = false;
            this.btnPrintBill.Location = new System.Drawing.Point(315, 485);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPrintBill.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnPrintBill.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPrintBill.selected = false;
            this.btnPrintBill.Size = new System.Drawing.Size(229, 48);
            this.btnPrintBill.TabIndex = 101;
            this.btnPrintBill.Text = "Imprimir factura";
            this.btnPrintBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrintBill.Textcolor = System.Drawing.Color.White;
            this.btnPrintBill.TextFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintBill.Click += new System.EventHandler(this.btnPrintBill_Click);
            // 
            // ModifySale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnPrintBill);
            this.Controls.Add(this.saveChanges);
            this.Controls.Add(this.cmbSaleDate);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.bunifuCustomLabel12);
            this.Controls.Add(this.bunifuCustomLabel11);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.bunifuCustomLabel10);
            this.Controls.Add(this.bunifuCustomLabel9);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.bunifuCustomLabel8);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.dgSaleSummary);
            this.Controls.Add(this.dgProductsList);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.cmbPaymentTypes);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.lblNewUser);
            this.Name = "ModifySale";
            this.Size = new System.Drawing.Size(1073, 577);
            ((System.ComponentModel.ISupportInitialize)(this.dgSaleSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCustomer;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtDiscount;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTax;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSubtotal;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuTextbox txtSearch;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgSaleSummary;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgProductsList;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTotal;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.ComboBox cmbPaymentTypes;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNewUser;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DateTimePicker cmbSaleDate;
        private Bunifu.Framework.UI.BunifuFlatButton saveChanges;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrintBill;
    }
}
