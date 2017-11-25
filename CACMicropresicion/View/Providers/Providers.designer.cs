namespace CACMicropresicion.View.Providers
{
    partial class Providers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Providers));
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnEditProvider = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnViewProviders = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAddProvider = new Bunifu.Framework.UI.BunifuThinButton2();
            this.addProvider = new CACMicropresicion.View.Providers.AddProvider();
            this.viewProviders = new CACMicropresicion.View.Providers.ViewProviders();
            this.editProvider = new CACMicropresicion.View.Providers.EditProvider();
            this.SidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.SidePanel.Controls.Add(this.btnEditProvider);
            this.SidePanel.Controls.Add(this.btnViewProviders);
            this.SidePanel.Controls.Add(this.btnAddProvider);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(209, 481);
            this.SidePanel.TabIndex = 0;
            // 
            // btnEditProvider
            // 
            this.btnEditProvider.ActiveBorderThickness = 1;
            this.btnEditProvider.ActiveCornerRadius = 20;
            this.btnEditProvider.ActiveFillColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnEditProvider.ActiveForecolor = System.Drawing.Color.White;
            this.btnEditProvider.ActiveLineColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnEditProvider.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditProvider.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditProvider.BackgroundImage")));
            this.btnEditProvider.ButtonText = "Editar Proveedor";
            this.btnEditProvider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditProvider.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProvider.ForeColor = System.Drawing.Color.Black;
            this.btnEditProvider.IdleBorderThickness = 1;
            this.btnEditProvider.IdleCornerRadius = 20;
            this.btnEditProvider.IdleFillColor = System.Drawing.Color.White;
            this.btnEditProvider.IdleForecolor = System.Drawing.Color.Black;
            this.btnEditProvider.IdleLineColor = System.Drawing.Color.Black;
            this.btnEditProvider.Location = new System.Drawing.Point(14, 301);
            this.btnEditProvider.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditProvider.Name = "btnEditProvider";
            this.btnEditProvider.Size = new System.Drawing.Size(181, 41);
            this.btnEditProvider.TabIndex = 2;
            this.btnEditProvider.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditProvider.Click += new System.EventHandler(this.btnEditProvider_Click);
            // 
            // btnViewProviders
            // 
            this.btnViewProviders.ActiveBorderThickness = 1;
            this.btnViewProviders.ActiveCornerRadius = 20;
            this.btnViewProviders.ActiveFillColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnViewProviders.ActiveForecolor = System.Drawing.Color.White;
            this.btnViewProviders.ActiveLineColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnViewProviders.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnViewProviders.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewProviders.BackgroundImage")));
            this.btnViewProviders.ButtonText = "Lista de Proveedores";
            this.btnViewProviders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewProviders.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProviders.ForeColor = System.Drawing.Color.Black;
            this.btnViewProviders.IdleBorderThickness = 1;
            this.btnViewProviders.IdleCornerRadius = 20;
            this.btnViewProviders.IdleFillColor = System.Drawing.Color.White;
            this.btnViewProviders.IdleForecolor = System.Drawing.Color.Black;
            this.btnViewProviders.IdleLineColor = System.Drawing.Color.Black;
            this.btnViewProviders.Location = new System.Drawing.Point(14, 226);
            this.btnViewProviders.Margin = new System.Windows.Forms.Padding(5);
            this.btnViewProviders.Name = "btnViewProviders";
            this.btnViewProviders.Size = new System.Drawing.Size(181, 41);
            this.btnViewProviders.TabIndex = 1;
            this.btnViewProviders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnViewProviders.Click += new System.EventHandler(this.btnViewProviders_Click);
            // 
            // btnAddProvider
            // 
            this.btnAddProvider.ActiveBorderThickness = 1;
            this.btnAddProvider.ActiveCornerRadius = 20;
            this.btnAddProvider.ActiveFillColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAddProvider.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddProvider.ActiveLineColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAddProvider.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddProvider.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddProvider.BackgroundImage")));
            this.btnAddProvider.ButtonText = "Agregar Proveedor";
            this.btnAddProvider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProvider.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProvider.ForeColor = System.Drawing.Color.Black;
            this.btnAddProvider.IdleBorderThickness = 1;
            this.btnAddProvider.IdleCornerRadius = 20;
            this.btnAddProvider.IdleFillColor = System.Drawing.Color.White;
            this.btnAddProvider.IdleForecolor = System.Drawing.Color.Black;
            this.btnAddProvider.IdleLineColor = System.Drawing.Color.Black;
            this.btnAddProvider.Location = new System.Drawing.Point(14, 146);
            this.btnAddProvider.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddProvider.Name = "btnAddProvider";
            this.btnAddProvider.Size = new System.Drawing.Size(181, 41);
            this.btnAddProvider.TabIndex = 0;
            this.btnAddProvider.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddProvider.Click += new System.EventHandler(this.btnAddProvider_Click);
            // 
            // addProvider
            // 
            this.addProvider.Location = new System.Drawing.Point(215, 12);
            this.addProvider.Name = "addProvider";
            this.addProvider.Size = new System.Drawing.Size(682, 441);
            this.addProvider.TabIndex = 1;
            // 
            // viewProviders
            // 
            this.viewProviders.Location = new System.Drawing.Point(215, 12);
            this.viewProviders.Name = "viewProviders";
            this.viewProviders.Size = new System.Drawing.Size(647, 469);
            this.viewProviders.TabIndex = 2;
            // 
            // editProvider
            // 
            this.editProvider.Location = new System.Drawing.Point(215, 9);
            this.editProvider.Name = "editProvider";
            this.editProvider.Size = new System.Drawing.Size(670, 460);
            this.editProvider.TabIndex = 3;
            // 
            // Providers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(897, 481);
            this.Controls.Add(this.editProvider);
            this.Controls.Add(this.viewProviders);
            this.Controls.Add(this.addProvider);
            this.Controls.Add(this.SidePanel);
            this.Name = "Providers";
            this.Text = "Proveedores";
            this.SidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidePanel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEditProvider;
        private Bunifu.Framework.UI.BunifuThinButton2 btnViewProviders;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddProvider;
        private AddProvider addProvider;
        private ViewProviders viewProviders;
        private EditProvider editProvider;
    }
}