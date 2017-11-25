namespace CACMicropresicion.View.Main
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.ControlsPanel = new System.Windows.Forms.Panel();
            this.SidePanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.CategoriesControl = new CACMicropresicion.View.Main.CategoriesControl();
            this.ControlsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlsPanel
            // 
            this.ControlsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlsPanel.BackColor = System.Drawing.Color.White;
            this.ControlsPanel.Controls.Add(this.SidePanel);
            this.ControlsPanel.Controls.Add(this.CategoriesControl);
            this.ControlsPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlsPanel.Name = "ControlsPanel";
            this.ControlsPanel.Size = new System.Drawing.Size(1079, 620);
            this.ControlsPanel.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SidePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SidePanel.BackgroundImage")));
            this.SidePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SidePanel.GradientBottomLeft = System.Drawing.Color.LightBlue;
            this.SidePanel.GradientBottomRight = System.Drawing.Color.LightBlue;
            this.SidePanel.GradientTopLeft = System.Drawing.Color.LightBlue;
            this.SidePanel.GradientTopRight = System.Drawing.Color.LightBlue;
            this.SidePanel.Location = new System.Drawing.Point(0, 50);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Quality = 10;
            this.SidePanel.Size = new System.Drawing.Size(237, 441);
            this.SidePanel.TabIndex = 3;
            this.SidePanel.Visible = false;
            // 
            // CategoriesControl
            // 
            this.CategoriesControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoriesControl.Location = new System.Drawing.Point(0, 0);
            this.CategoriesControl.Name = "CategoriesControl";
            this.CategoriesControl.Size = new System.Drawing.Size(1079, 50);
            this.CategoriesControl.TabIndex = 0;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1079, 620);
            this.Controls.Add(this.ControlsPanel);
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CAC Micropresicion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainView_FormClosed);
            this.ControlsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ControlsPanel;
        private CategoriesControl CategoriesControl;
        private Bunifu.Framework.UI.BunifuGradientPanel SidePanel;



    }
}