namespace CACMicropresicion.View.Users
{
    partial class AddContactInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddContactInfo));
            this.lblContactInfo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.addContUserId = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.addContUserType = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.addContUserValue = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.addContInfoSendInfo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.addTxtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblContactInfo
            // 
            this.lblContactInfo.AutoSize = true;
            this.lblContactInfo.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblContactInfo.Location = new System.Drawing.Point(46, 34);
            this.lblContactInfo.Name = "lblContactInfo";
            this.lblContactInfo.Size = new System.Drawing.Size(321, 40);
            this.lblContactInfo.TabIndex = 16;
            this.lblContactInfo.Text = "Información de Contacto";
            // 
            // addContUserId
            // 
            this.addContUserId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addContUserId.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addContUserId.FormattingEnabled = true;
            this.addContUserId.Location = new System.Drawing.Point(53, 130);
            this.addContUserId.Name = "addContUserId";
            this.addContUserId.Size = new System.Drawing.Size(225, 25);
            this.addContUserId.TabIndex = 34;
            this.addContUserId.SelectedIndexChanged += new System.EventHandler(this.addContUserId_SelectedIndexChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(48, 102);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(68, 25);
            this.bunifuCustomLabel1.TabIndex = 33;
            this.bunifuCustomLabel1.Text = "Cédula";
            // 
            // addContUserType
            // 
            this.addContUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addContUserType.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addContUserType.FormattingEnabled = true;
            this.addContUserType.Location = new System.Drawing.Point(53, 205);
            this.addContUserType.Name = "addContUserType";
            this.addContUserType.Size = new System.Drawing.Size(225, 25);
            this.addContUserType.TabIndex = 37;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(48, 177);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(48, 25);
            this.bunifuCustomLabel6.TabIndex = 36;
            this.bunifuCustomLabel6.Text = "Tipo";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(48, 252);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(51, 25);
            this.bunifuCustomLabel2.TabIndex = 38;
            this.bunifuCustomLabel2.Text = "Valor";
            // 
            // addContUserValue
            // 
            this.addContUserValue.BorderColorFocused = System.Drawing.Color.Blue;
            this.addContUserValue.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addContUserValue.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.addContUserValue.BorderThickness = 3;
            this.addContUserValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addContUserValue.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.addContUserValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addContUserValue.isPassword = false;
            this.addContUserValue.Location = new System.Drawing.Point(53, 281);
            this.addContUserValue.Margin = new System.Windows.Forms.Padding(4);
            this.addContUserValue.Name = "addContUserValue";
            this.addContUserValue.Size = new System.Drawing.Size(478, 34);
            this.addContUserValue.TabIndex = 39;
            this.addContUserValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // addContInfoSendInfo
            // 
            this.addContInfoSendInfo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.addContInfoSendInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.addContInfoSendInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addContInfoSendInfo.BorderRadius = 0;
            this.addContInfoSendInfo.ButtonText = "Enviar Información";
            this.addContInfoSendInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addContInfoSendInfo.DisabledColor = System.Drawing.Color.Gray;
            this.addContInfoSendInfo.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addContInfoSendInfo.Iconcolor = System.Drawing.Color.Transparent;
            this.addContInfoSendInfo.Iconimage = ((System.Drawing.Image)(resources.GetObject("addContInfoSendInfo.Iconimage")));
            this.addContInfoSendInfo.Iconimage_right = null;
            this.addContInfoSendInfo.Iconimage_right_Selected = null;
            this.addContInfoSendInfo.Iconimage_Selected = null;
            this.addContInfoSendInfo.IconMarginLeft = 0;
            this.addContInfoSendInfo.IconMarginRight = 0;
            this.addContInfoSendInfo.IconRightVisible = true;
            this.addContInfoSendInfo.IconRightZoom = 0D;
            this.addContInfoSendInfo.IconVisible = false;
            this.addContInfoSendInfo.IconZoom = 90D;
            this.addContInfoSendInfo.IsTab = false;
            this.addContInfoSendInfo.Location = new System.Drawing.Point(53, 355);
            this.addContInfoSendInfo.Name = "addContInfoSendInfo";
            this.addContInfoSendInfo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.addContInfoSendInfo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.addContInfoSendInfo.OnHoverTextColor = System.Drawing.Color.White;
            this.addContInfoSendInfo.selected = false;
            this.addContInfoSendInfo.Size = new System.Drawing.Size(229, 48);
            this.addContInfoSendInfo.TabIndex = 40;
            this.addContInfoSendInfo.Text = "Enviar Información";
            this.addContInfoSendInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addContInfoSendInfo.Textcolor = System.Drawing.Color.White;
            this.addContInfoSendInfo.TextFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addContInfoSendInfo.Click += new System.EventHandler(this.addContInfoSendInfo_Click);
            // 
            // addTxtName
            // 
            this.addTxtName.Enabled = false;
            this.addTxtName.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTxtName.Location = new System.Drawing.Point(325, 130);
            this.addTxtName.Name = "addTxtName";
            this.addTxtName.Size = new System.Drawing.Size(389, 25);
            this.addTxtName.TabIndex = 47;
            // 
            // AddContactInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 477);
            this.Controls.Add(this.addTxtName);
            this.Controls.Add(this.addContInfoSendInfo);
            this.Controls.Add(this.addContUserValue);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.addContUserType);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.addContUserId);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.lblContactInfo);
            this.Name = "AddContactInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información de Contacto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lblContactInfo;
        private System.Windows.Forms.ComboBox addContUserId;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.ComboBox addContUserType;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox addContUserValue;
        private Bunifu.Framework.UI.BunifuFlatButton addContInfoSendInfo;
        private System.Windows.Forms.TextBox addTxtName;
    }
}