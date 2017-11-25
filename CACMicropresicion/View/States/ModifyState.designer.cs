namespace CACMicropresicion.View.States
{
    partial class ModifyState
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyState));
            this.modBtnSaveStateChanges = new Bunifu.Framework.UI.BunifuFlatButton();
            this.modDropStateId = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.lblEditState = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // modBtnSaveStateChanges
            // 
            this.modBtnSaveStateChanges.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.modBtnSaveStateChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.modBtnSaveStateChanges.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.modBtnSaveStateChanges.BorderRadius = 0;
            this.modBtnSaveStateChanges.ButtonText = "Guardar Cambios";
            this.modBtnSaveStateChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modBtnSaveStateChanges.DisabledColor = System.Drawing.Color.Gray;
            this.modBtnSaveStateChanges.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modBtnSaveStateChanges.Iconcolor = System.Drawing.Color.Transparent;
            this.modBtnSaveStateChanges.Iconimage = ((System.Drawing.Image)(resources.GetObject("modBtnSaveStateChanges.Iconimage")));
            this.modBtnSaveStateChanges.Iconimage_right = null;
            this.modBtnSaveStateChanges.Iconimage_right_Selected = null;
            this.modBtnSaveStateChanges.Iconimage_Selected = null;
            this.modBtnSaveStateChanges.IconMarginLeft = 0;
            this.modBtnSaveStateChanges.IconMarginRight = 0;
            this.modBtnSaveStateChanges.IconRightVisible = true;
            this.modBtnSaveStateChanges.IconRightZoom = 0D;
            this.modBtnSaveStateChanges.IconVisible = false;
            this.modBtnSaveStateChanges.IconZoom = 90D;
            this.modBtnSaveStateChanges.IsTab = false;
            this.modBtnSaveStateChanges.Location = new System.Drawing.Point(171, 345);
            this.modBtnSaveStateChanges.Name = "modBtnSaveStateChanges";
            this.modBtnSaveStateChanges.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.modBtnSaveStateChanges.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.modBtnSaveStateChanges.OnHoverTextColor = System.Drawing.Color.White;
            this.modBtnSaveStateChanges.selected = false;
            this.modBtnSaveStateChanges.Size = new System.Drawing.Size(229, 48);
            this.modBtnSaveStateChanges.TabIndex = 47;
            this.modBtnSaveStateChanges.Text = "Guardar Cambios";
            this.modBtnSaveStateChanges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.modBtnSaveStateChanges.Textcolor = System.Drawing.Color.White;
            this.modBtnSaveStateChanges.TextFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modBtnSaveStateChanges.Click += new System.EventHandler(this.modBtnSaveStateChanges_Click);
            // 
            // modDropStateId
            // 
            this.modDropStateId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modDropStateId.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modDropStateId.FormattingEnabled = true;
            this.modDropStateId.Location = new System.Drawing.Point(114, 68);
            this.modDropStateId.Name = "modDropStateId";
            this.modDropStateId.Size = new System.Drawing.Size(225, 25);
            this.modDropStateId.TabIndex = 46;
            this.modDropStateId.SelectedIndexChanged += new System.EventHandler(this.modDropStateId_SelectedIndexChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(109, 113);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(104, 25);
            this.bunifuCustomLabel1.TabIndex = 44;
            this.bunifuCustomLabel1.Text = "Descripcion";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(114, 151);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(457, 130);
            this.txtDescription.TabIndex = 43;
            this.txtDescription.Text = "";
            // 
            // lblEditState
            // 
            this.lblEditState.AutoSize = true;
            this.lblEditState.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEditState.Location = new System.Drawing.Point(43, 3);
            this.lblEditState.Name = "lblEditState";
            this.lblEditState.Size = new System.Drawing.Size(176, 40);
            this.lblEditState.TabIndex = 42;
            this.lblEditState.Text = "Editar Estado";
            // 
            // ModifyState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.modBtnSaveStateChanges);
            this.Controls.Add(this.modDropStateId);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblEditState);
            this.Name = "ModifyState";
            this.Size = new System.Drawing.Size(611, 424);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton modBtnSaveStateChanges;
        private System.Windows.Forms.ComboBox modDropStateId;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.RichTextBox txtDescription;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEditState;
    }
}
