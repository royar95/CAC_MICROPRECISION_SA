namespace CACMicropresicion.View.Users
{
    partial class DeleteUser
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteUser));
            this.delBtnDeleteUser = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblNewUser = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.delDropUserId = new System.Windows.Forms.ComboBox();
            this.delTxtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // delBtnDeleteUser
            // 
            this.delBtnDeleteUser.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.delBtnDeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.delBtnDeleteUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delBtnDeleteUser.BorderRadius = 0;
            this.delBtnDeleteUser.ButtonText = "Eliminar Usuario";
            this.delBtnDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delBtnDeleteUser.DisabledColor = System.Drawing.Color.Gray;
            this.delBtnDeleteUser.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBtnDeleteUser.Iconcolor = System.Drawing.Color.Transparent;
            this.delBtnDeleteUser.Iconimage = ((System.Drawing.Image)(resources.GetObject("delBtnDeleteUser.Iconimage")));
            this.delBtnDeleteUser.Iconimage_right = null;
            this.delBtnDeleteUser.Iconimage_right_Selected = null;
            this.delBtnDeleteUser.Iconimage_Selected = null;
            this.delBtnDeleteUser.IconMarginLeft = 0;
            this.delBtnDeleteUser.IconMarginRight = 0;
            this.delBtnDeleteUser.IconRightVisible = true;
            this.delBtnDeleteUser.IconRightZoom = 0D;
            this.delBtnDeleteUser.IconVisible = false;
            this.delBtnDeleteUser.IconZoom = 90D;
            this.delBtnDeleteUser.IsTab = false;
            this.delBtnDeleteUser.Location = new System.Drawing.Point(72, 188);
            this.delBtnDeleteUser.Name = "delBtnDeleteUser";
            this.delBtnDeleteUser.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.delBtnDeleteUser.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.delBtnDeleteUser.OnHoverTextColor = System.Drawing.Color.White;
            this.delBtnDeleteUser.selected = false;
            this.delBtnDeleteUser.Size = new System.Drawing.Size(229, 48);
            this.delBtnDeleteUser.TabIndex = 44;
            this.delBtnDeleteUser.Text = "Eliminar Usuario";
            this.delBtnDeleteUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delBtnDeleteUser.Textcolor = System.Drawing.Color.White;
            this.delBtnDeleteUser.TextFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBtnDeleteUser.Click += new System.EventHandler(this.delBtnDeleteUser_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(67, 94);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(68, 25);
            this.bunifuCustomLabel1.TabIndex = 34;
            this.bunifuCustomLabel1.Text = "Cédula";
            // 
            // lblNewUser
            // 
            this.lblNewUser.AutoSize = true;
            this.lblNewUser.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNewUser.Location = new System.Drawing.Point(65, 29);
            this.lblNewUser.Name = "lblNewUser";
            this.lblNewUser.Size = new System.Drawing.Size(214, 40);
            this.lblNewUser.TabIndex = 33;
            this.lblNewUser.Text = "Eliminar Usuario";
            // 
            // delDropUserId
            // 
            this.delDropUserId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.delDropUserId.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delDropUserId.FormattingEnabled = true;
            this.delDropUserId.Location = new System.Drawing.Point(72, 122);
            this.delDropUserId.Name = "delDropUserId";
            this.delDropUserId.Size = new System.Drawing.Size(229, 25);
            this.delDropUserId.TabIndex = 45;
            this.delDropUserId.SelectedIndexChanged += new System.EventHandler(this.delDropUserId_SelectedIndexChanged);
            // 
            // delTxtName
            // 
            this.delTxtName.Enabled = false;
            this.delTxtName.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delTxtName.Location = new System.Drawing.Point(349, 122);
            this.delTxtName.Name = "delTxtName";
            this.delTxtName.Size = new System.Drawing.Size(389, 25);
            this.delTxtName.TabIndex = 46;
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.delTxtName);
            this.Controls.Add(this.delDropUserId);
            this.Controls.Add(this.delBtnDeleteUser);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.lblNewUser);
            this.Name = "DeleteUser";
            this.Size = new System.Drawing.Size(856, 303);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton delBtnDeleteUser;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNewUser;
        private System.Windows.Forms.ComboBox delDropUserId;
        private System.Windows.Forms.TextBox delTxtName;
    }
}
