namespace CACMicropresicion.View.States
{
    partial class DeleteState
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteState));
            this.delDropStateId = new System.Windows.Forms.ComboBox();
            this.delBtnDeleteState = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDeleteStatus = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // delDropStateId
            // 
            this.delDropStateId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.delDropStateId.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delDropStateId.FormattingEnabled = true;
            this.delDropStateId.Location = new System.Drawing.Point(66, 143);
            this.delDropStateId.Name = "delDropStateId";
            this.delDropStateId.Size = new System.Drawing.Size(229, 25);
            this.delDropStateId.TabIndex = 51;
            this.delDropStateId.SelectedIndexChanged += new System.EventHandler(this.delDropStateId_SelectedIndexChanged);
            // 
            // delBtnDeleteState
            // 
            this.delBtnDeleteState.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.delBtnDeleteState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.delBtnDeleteState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delBtnDeleteState.BorderRadius = 0;
            this.delBtnDeleteState.ButtonText = "Eliminar Estado";
            this.delBtnDeleteState.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delBtnDeleteState.DisabledColor = System.Drawing.Color.Gray;
            this.delBtnDeleteState.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBtnDeleteState.Iconcolor = System.Drawing.Color.Transparent;
            this.delBtnDeleteState.Iconimage = ((System.Drawing.Image)(resources.GetObject("delBtnDeleteState.Iconimage")));
            this.delBtnDeleteState.Iconimage_right = null;
            this.delBtnDeleteState.Iconimage_right_Selected = null;
            this.delBtnDeleteState.Iconimage_Selected = null;
            this.delBtnDeleteState.IconMarginLeft = 0;
            this.delBtnDeleteState.IconMarginRight = 0;
            this.delBtnDeleteState.IconRightVisible = true;
            this.delBtnDeleteState.IconRightZoom = 0D;
            this.delBtnDeleteState.IconVisible = false;
            this.delBtnDeleteState.IconZoom = 90D;
            this.delBtnDeleteState.IsTab = false;
            this.delBtnDeleteState.Location = new System.Drawing.Point(66, 251);
            this.delBtnDeleteState.Name = "delBtnDeleteState";
            this.delBtnDeleteState.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.delBtnDeleteState.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.delBtnDeleteState.OnHoverTextColor = System.Drawing.Color.White;
            this.delBtnDeleteState.selected = false;
            this.delBtnDeleteState.Size = new System.Drawing.Size(229, 48);
            this.delBtnDeleteState.TabIndex = 50;
            this.delBtnDeleteState.Text = "Eliminar Estado";
            this.delBtnDeleteState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delBtnDeleteState.Textcolor = System.Drawing.Color.White;
            this.delBtnDeleteState.TextFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBtnDeleteState.Click += new System.EventHandler(this.delBtnDeleteState_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(61, 115);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(72, 25);
            this.bunifuCustomLabel1.TabIndex = 49;
            this.bunifuCustomLabel1.Text = "Código";
            // 
            // lblDeleteStatus
            // 
            this.lblDeleteStatus.AutoSize = true;
            this.lblDeleteStatus.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDeleteStatus.Location = new System.Drawing.Point(59, 33);
            this.lblDeleteStatus.Name = "lblDeleteStatus";
            this.lblDeleteStatus.Size = new System.Drawing.Size(203, 40);
            this.lblDeleteStatus.TabIndex = 47;
            this.lblDeleteStatus.Text = "Eliminar Estado";
            // 
            // txtDescription
            // 
            this.txtDescription.Enabled = false;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(66, 189);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(389, 25);
            this.txtDescription.TabIndex = 52;
            // 
            // DeleteState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.delDropStateId);
            this.Controls.Add(this.delBtnDeleteState);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.lblDeleteStatus);
            this.Name = "DeleteState";
            this.Size = new System.Drawing.Size(650, 383);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox delDropStateId;
        private Bunifu.Framework.UI.BunifuFlatButton delBtnDeleteState;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDeleteStatus;
        private System.Windows.Forms.TextBox txtDescription;
    }
}
