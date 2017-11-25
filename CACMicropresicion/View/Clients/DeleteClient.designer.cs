using System.Windows.Forms;

namespace CACMicropresicion.View.Cients
{
    partial class DeleteClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteClient));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.lblDeleteClient = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.delBtnDeleteClient = new Bunifu.Framework.UI.BunifuFlatButton();
            this.delDropClientId = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(67, 123);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(104, 25);
            this.bunifuCustomLabel1.TabIndex = 30;
            this.bunifuCustomLabel1.Text = "Descripcion";
            // 
            // txtDescription
            // 
            this.txtDescription.Enabled = false;
            this.txtDescription.Location = new System.Drawing.Point(72, 161);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(457, 130);
            this.txtDescription.TabIndex = 29;
            this.txtDescription.Text = "";
            // 
            // lblDeleteClient
            // 
            this.lblDeleteClient.AutoSize = true;
            this.lblDeleteClient.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDeleteClient.Location = new System.Drawing.Point(46, 22);
            this.lblDeleteClient.Name = "lblDeleteClient";
            this.lblDeleteClient.Size = new System.Drawing.Size(207, 40);
            this.lblDeleteClient.TabIndex = 27;
            this.lblDeleteClient.Text = "Eliminar Cliente";
            // 
            // delBtnDeleteClient
            // 
            this.delBtnDeleteClient.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.delBtnDeleteClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.delBtnDeleteClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delBtnDeleteClient.BorderRadius = 0;
            this.delBtnDeleteClient.ButtonText = "Eliminar Cliente";
            this.delBtnDeleteClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delBtnDeleteClient.DisabledColor = System.Drawing.Color.Gray;
            this.delBtnDeleteClient.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBtnDeleteClient.Iconcolor = System.Drawing.Color.Transparent;
            this.delBtnDeleteClient.Iconimage = ((System.Drawing.Image)(resources.GetObject("delBtnDeleteClient.Iconimage")));
            this.delBtnDeleteClient.Iconimage_right = null;
            this.delBtnDeleteClient.Iconimage_right_Selected = null;
            this.delBtnDeleteClient.Iconimage_Selected = null;
            this.delBtnDeleteClient.IconMarginLeft = 0;
            this.delBtnDeleteClient.IconMarginRight = 0;
            this.delBtnDeleteClient.IconRightVisible = true;
            this.delBtnDeleteClient.IconRightZoom = 0D;
            this.delBtnDeleteClient.IconVisible = false;
            this.delBtnDeleteClient.IconZoom = 90D;
            this.delBtnDeleteClient.IsTab = false;
            this.delBtnDeleteClient.Location = new System.Drawing.Point(216, 360);
            this.delBtnDeleteClient.Name = "delBtnDeleteClient";
            this.delBtnDeleteClient.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.delBtnDeleteClient.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.delBtnDeleteClient.OnHoverTextColor = System.Drawing.Color.White;
            this.delBtnDeleteClient.selected = false;
            this.delBtnDeleteClient.Size = new System.Drawing.Size(229, 48);
            this.delBtnDeleteClient.TabIndex = 45;
            this.delBtnDeleteClient.Text = "Eliminar Cliente";
            this.delBtnDeleteClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delBtnDeleteClient.Textcolor = System.Drawing.Color.White;
            this.delBtnDeleteClient.TextFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBtnDeleteClient.Click += new System.EventHandler(this.delBtnDeleteClient_Click);
            // 
            // delDropClientId
            // 
            this.delDropClientId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.delDropClientId.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delDropClientId.FormattingEnabled = true;
            this.delDropClientId.Location = new System.Drawing.Point(72, 78);
            this.delDropClientId.Name = "delDropClientId";
            this.delDropClientId.Size = new System.Drawing.Size(229, 25);
            this.delDropClientId.TabIndex = 46;
            this.delDropClientId.SelectedIndexChanged += new System.EventHandler(this.delDropClientId_SelectedIndexChanged);
            // 
            // DeleteClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.delDropClientId);
            this.Controls.Add(this.delBtnDeleteClient);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDeleteClient);
            this.Name = "DeleteClient";
            this.Size = new System.Drawing.Size(654, 432);
            this.Load += new System.EventHandler(this.DeleteClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.RichTextBox txtDescription;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDeleteClient;
        private Bunifu.Framework.UI.BunifuFlatButton delBtnDeleteClient;
        private ComboBox delDropClientId;
    }
}
