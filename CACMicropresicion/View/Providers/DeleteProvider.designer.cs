using System.Windows.Forms;

namespace CACMicropresicion.View.Cients
{
    partial class DeleteProvider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteProvider));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDeleteClient = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.delBtnDeleteProvider = new Bunifu.Framework.UI.BunifuFlatButton();
            this.delDropProviderId = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(78, 158);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(104, 25);
            this.bunifuCustomLabel1.TabIndex = 30;
            this.bunifuCustomLabel1.Text = "Descripcion";
            // 
            // lblDeleteClient
            // 
            this.lblDeleteClient.AutoSize = true;
            this.lblDeleteClient.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDeleteClient.Location = new System.Drawing.Point(76, 34);
            this.lblDeleteClient.Name = "lblDeleteClient";
            this.lblDeleteClient.Size = new System.Drawing.Size(248, 40);
            this.lblDeleteClient.TabIndex = 27;
            this.lblDeleteClient.Text = "Eliminar Proveedor";
            // 
            // delBtnDeleteProvider
            // 
            this.delBtnDeleteProvider.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.delBtnDeleteProvider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.delBtnDeleteProvider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delBtnDeleteProvider.BorderRadius = 0;
            this.delBtnDeleteProvider.ButtonText = "Eliminar Proveedor";
            this.delBtnDeleteProvider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delBtnDeleteProvider.DisabledColor = System.Drawing.Color.Gray;
            this.delBtnDeleteProvider.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBtnDeleteProvider.Iconcolor = System.Drawing.Color.Transparent;
            this.delBtnDeleteProvider.Iconimage = ((System.Drawing.Image)(resources.GetObject("delBtnDeleteProvider.Iconimage")));
            this.delBtnDeleteProvider.Iconimage_right = null;
            this.delBtnDeleteProvider.Iconimage_right_Selected = null;
            this.delBtnDeleteProvider.Iconimage_Selected = null;
            this.delBtnDeleteProvider.IconMarginLeft = 0;
            this.delBtnDeleteProvider.IconMarginRight = 0;
            this.delBtnDeleteProvider.IconRightVisible = true;
            this.delBtnDeleteProvider.IconRightZoom = 0D;
            this.delBtnDeleteProvider.IconVisible = false;
            this.delBtnDeleteProvider.IconZoom = 90D;
            this.delBtnDeleteProvider.IsTab = false;
            this.delBtnDeleteProvider.Location = new System.Drawing.Point(83, 252);
            this.delBtnDeleteProvider.Name = "delBtnDeleteProvider";
            this.delBtnDeleteProvider.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.delBtnDeleteProvider.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.delBtnDeleteProvider.OnHoverTextColor = System.Drawing.Color.White;
            this.delBtnDeleteProvider.selected = false;
            this.delBtnDeleteProvider.Size = new System.Drawing.Size(229, 48);
            this.delBtnDeleteProvider.TabIndex = 45;
            this.delBtnDeleteProvider.Text = "Eliminar Proveedor";
            this.delBtnDeleteProvider.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delBtnDeleteProvider.Textcolor = System.Drawing.Color.White;
            this.delBtnDeleteProvider.TextFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBtnDeleteProvider.Click += new System.EventHandler(this.delBtnDeleteClient_Click);
            // 
            // delDropProviderId
            // 
            this.delDropProviderId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.delDropProviderId.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delDropProviderId.FormattingEnabled = true;
            this.delDropProviderId.Location = new System.Drawing.Point(83, 109);
            this.delDropProviderId.Name = "delDropProviderId";
            this.delDropProviderId.Size = new System.Drawing.Size(229, 25);
            this.delDropProviderId.TabIndex = 46;
            this.delDropProviderId.SelectedIndexChanged += new System.EventHandler(this.delDropProviderId_SelectedIndexChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Enabled = false;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(83, 186);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(229, 25);
            this.txtDescription.TabIndex = 53;
            // 
            // DeleteProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.delDropProviderId);
            this.Controls.Add(this.delBtnDeleteProvider);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.lblDeleteClient);
            this.Name = "DeleteProvider";
            this.Size = new System.Drawing.Size(654, 432);
            this.Load += new System.EventHandler(this.DeleteProvider_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDeleteClient;
        private Bunifu.Framework.UI.BunifuFlatButton delBtnDeleteProvider;
        private ComboBox delDropProviderId;
        private TextBox txtDescription;
    }
}
