namespace CACMicropresicion.View.Main
{
    partial class MenuProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuProducts));
            this.btnPurchases = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.SuspendLayout();
            // 
            // btnPurchases
            // 
            this.btnPurchases.BackColor = System.Drawing.Color.White;
            this.btnPurchases.color = System.Drawing.Color.White;
            this.btnPurchases.colorActive = System.Drawing.Color.LightSkyBlue;
            this.btnPurchases.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPurchases.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnPurchases.ForeColor = System.Drawing.Color.Black;
            this.btnPurchases.Image = ((System.Drawing.Image)(resources.GetObject("btnPurchases.Image")));
            this.btnPurchases.ImagePosition = 20;
            this.btnPurchases.ImageZoom = 50;
            this.btnPurchases.LabelPosition = 41;
            this.btnPurchases.LabelText = "Productos";
            this.btnPurchases.Location = new System.Drawing.Point(126, 112);
            this.btnPurchases.Margin = new System.Windows.Forms.Padding(6);
            this.btnPurchases.Name = "btnPurchases";
            this.btnPurchases.Size = new System.Drawing.Size(128, 129);
            this.btnPurchases.TabIndex = 6;
            this.btnPurchases.Click += new System.EventHandler(this.btnPurchases_Click);
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.White;
            this.bunifuTileButton1.color = System.Drawing.Color.White;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.LightSkyBlue;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.Black;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 20;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 41;
            this.bunifuTileButton1.LabelText = "Categorías";
            this.bunifuTileButton1.Location = new System.Drawing.Point(369, 112);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(128, 129);
            this.bunifuTileButton1.TabIndex = 7;
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // MenuProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(631, 351);
            this.Controls.Add(this.bunifuTileButton1);
            this.Controls.Add(this.btnPurchases);
            this.Name = "MenuProducts";
            this.Text = "Menu de Productos";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton btnPurchases;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
    }
}