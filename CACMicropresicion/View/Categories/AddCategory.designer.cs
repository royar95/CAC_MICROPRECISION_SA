namespace CACMicropresicion.View.Categories
{
    partial class AddCategory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCategory));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnActionAddCategory = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(19, 76);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(73, 21);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Nombre";
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.HintForeColor = System.Drawing.Color.Empty;
            this.txtName.HintText = "";
            this.txtName.isPassword = false;
            this.txtName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtName.LineThickness = 3;
            this.txtName.Location = new System.Drawing.Point(99, 64);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(379, 33);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnActionAddCategory
            // 
            this.btnActionAddCategory.ActiveBorderThickness = 1;
            this.btnActionAddCategory.ActiveCornerRadius = 20;
            this.btnActionAddCategory.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.btnActionAddCategory.ActiveForecolor = System.Drawing.Color.White;
            this.btnActionAddCategory.ActiveLineColor = System.Drawing.Color.DodgerBlue;
            this.btnActionAddCategory.BackColor = System.Drawing.SystemColors.Control;
            this.btnActionAddCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActionAddCategory.BackgroundImage")));
            this.btnActionAddCategory.ButtonText = "Agregar Categoría";
            this.btnActionAddCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActionAddCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActionAddCategory.ForeColor = System.Drawing.Color.Black;
            this.btnActionAddCategory.IdleBorderThickness = 1;
            this.btnActionAddCategory.IdleCornerRadius = 20;
            this.btnActionAddCategory.IdleFillColor = System.Drawing.Color.White;
            this.btnActionAddCategory.IdleForecolor = System.Drawing.Color.Black;
            this.btnActionAddCategory.IdleLineColor = System.Drawing.Color.Black;
            this.btnActionAddCategory.Location = new System.Drawing.Point(162, 216);
            this.btnActionAddCategory.Margin = new System.Windows.Forms.Padding(5);
            this.btnActionAddCategory.Name = "btnActionAddCategory";
            this.btnActionAddCategory.Size = new System.Drawing.Size(181, 41);
            this.btnActionAddCategory.TabIndex = 2;
            this.btnActionAddCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnActionAddCategory);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Name = "AddCategory";
            this.Size = new System.Drawing.Size(505, 298);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        private Bunifu.Framework.UI.BunifuThinButton2 btnActionAddCategory;
    }
}
