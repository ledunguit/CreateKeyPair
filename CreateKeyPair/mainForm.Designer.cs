
namespace CreateKeyPair
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.panelMain = new ns1.SiticonePanel();
            this.lblTitle = new ns1.SiticoneLabel();
            this.dragControl = new ns1.SiticoneDragControl(this.components);
            this.cbbKeySize = new ns1.SiticoneComboBox();
            this.lblKeySize = new ns1.SiticoneLabel();
            this.lblPrivateKey = new ns1.SiticoneLabel();
            this.lblPublicKey = new ns1.SiticoneLabel();
            this.btnGen = new ns1.SiticoneButton();
            this.btnSavePrivate = new ns1.SiticoneButton();
            this.btnSavePublic = new ns1.SiticoneButton();
            this.btnContact = new ns1.SiticoneButton();
            this.txtPrivateKey = new System.Windows.Forms.RichTextBox();
            this.txtPublicKey = new System.Windows.Forms.RichTextBox();
            this.btnClose = new ns1.SiticoneButton();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.panelMain.Controls.Add(this.txtPublicKey);
            this.panelMain.Controls.Add(this.txtPrivateKey);
            this.panelMain.Controls.Add(this.btnClose);
            this.panelMain.Controls.Add(this.btnContact);
            this.panelMain.Controls.Add(this.btnSavePublic);
            this.panelMain.Controls.Add(this.btnSavePrivate);
            this.panelMain.Controls.Add(this.btnGen);
            this.panelMain.Controls.Add(this.lblPublicKey);
            this.panelMain.Controls.Add(this.lblPrivateKey);
            this.panelMain.Controls.Add(this.lblKeySize);
            this.panelMain.Controls.Add(this.cbbKeySize);
            this.panelMain.Controls.Add(this.lblTitle);
            this.panelMain.Font = new System.Drawing.Font("Google Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panelMain.ForeColor = System.Drawing.Color.White;
            this.panelMain.Location = new System.Drawing.Point(2, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.ShadowDecoration.Parent = this.panelMain;
            this.panelMain.Size = new System.Drawing.Size(846, 376);
            this.panelMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Google Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(281, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(290, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Chương trình tạo cặp key RSA";
            // 
            // dragControl
            // 
            this.dragControl.TargetControl = this.panelMain;
            // 
            // cbbKeySize
            // 
            this.cbbKeySize.BackColor = System.Drawing.Color.Transparent;
            this.cbbKeySize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(63)))), ((int)(((byte)(52)))));
            this.cbbKeySize.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbKeySize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKeySize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.cbbKeySize.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(196)))), ((int)(((byte)(107)))));
            this.cbbKeySize.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbKeySize.ForeColor = System.Drawing.Color.White;
            this.cbbKeySize.FormattingEnabled = true;
            this.cbbKeySize.HoveredState.Parent = this.cbbKeySize;
            this.cbbKeySize.ItemHeight = 20;
            this.cbbKeySize.Items.AddRange(new object[] {
            "512",
            "1024",
            "2048"});
            this.cbbKeySize.ItemsAppearance.Parent = this.cbbKeySize;
            this.cbbKeySize.Location = new System.Drawing.Point(116, 53);
            this.cbbKeySize.MaxDropDownItems = 5;
            this.cbbKeySize.Name = "cbbKeySize";
            this.cbbKeySize.ShadowDecoration.Parent = this.cbbKeySize;
            this.cbbKeySize.Size = new System.Drawing.Size(140, 26);
            this.cbbKeySize.StartIndex = 2;
            this.cbbKeySize.TabIndex = 1;
            // 
            // lblKeySize
            // 
            this.lblKeySize.BackColor = System.Drawing.Color.Transparent;
            this.lblKeySize.Font = new System.Drawing.Font("Google Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblKeySize.Location = new System.Drawing.Point(55, 57);
            this.lblKeySize.Name = "lblKeySize";
            this.lblKeySize.Size = new System.Drawing.Size(46, 19);
            this.lblKeySize.TabIndex = 2;
            this.lblKeySize.Text = "Độ lớn:";
            // 
            // lblPrivateKey
            // 
            this.lblPrivateKey.BackColor = System.Drawing.Color.Transparent;
            this.lblPrivateKey.Font = new System.Drawing.Font("Google Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPrivateKey.ForeColor = System.Drawing.Color.White;
            this.lblPrivateKey.Location = new System.Drawing.Point(60, 98);
            this.lblPrivateKey.Name = "lblPrivateKey";
            this.lblPrivateKey.Size = new System.Drawing.Size(81, 19);
            this.lblPrivateKey.TabIndex = 2;
            this.lblPrivateKey.Text = "Private Key:";
            // 
            // lblPublicKey
            // 
            this.lblPublicKey.BackColor = System.Drawing.Color.Transparent;
            this.lblPublicKey.Font = new System.Drawing.Font("Google Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPublicKey.ForeColor = System.Drawing.Color.White;
            this.lblPublicKey.Location = new System.Drawing.Point(452, 98);
            this.lblPublicKey.Name = "lblPublicKey";
            this.lblPublicKey.Size = new System.Drawing.Size(73, 19);
            this.lblPublicKey.TabIndex = 2;
            this.lblPublicKey.Text = "Public Key:";
            // 
            // btnGen
            // 
            this.btnGen.CheckedState.Parent = this.btnGen;
            this.btnGen.CustomImages.Parent = this.btnGen;
            this.btnGen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(196)))), ((int)(((byte)(107)))));
            this.btnGen.Font = new System.Drawing.Font("Google Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnGen.ForeColor = System.Drawing.Color.White;
            this.btnGen.HoveredState.Parent = this.btnGen;
            this.btnGen.Location = new System.Drawing.Point(268, 53);
            this.btnGen.Name = "btnGen";
            this.btnGen.ShadowDecoration.Parent = this.btnGen;
            this.btnGen.Size = new System.Drawing.Size(98, 26);
            this.btnGen.TabIndex = 5;
            this.btnGen.Text = "Tạo cặp key";
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // btnSavePrivate
            // 
            this.btnSavePrivate.CheckedState.Parent = this.btnSavePrivate;
            this.btnSavePrivate.CustomImages.Parent = this.btnSavePrivate;
            this.btnSavePrivate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(63)))), ((int)(((byte)(52)))));
            this.btnSavePrivate.Font = new System.Drawing.Font("Google Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSavePrivate.ForeColor = System.Drawing.Color.White;
            this.btnSavePrivate.HoveredState.Parent = this.btnSavePrivate;
            this.btnSavePrivate.Location = new System.Drawing.Point(378, 53);
            this.btnSavePrivate.Name = "btnSavePrivate";
            this.btnSavePrivate.ShadowDecoration.Parent = this.btnSavePrivate;
            this.btnSavePrivate.Size = new System.Drawing.Size(98, 26);
            this.btnSavePrivate.TabIndex = 5;
            this.btnSavePrivate.Text = "Lưu private key";
            this.btnSavePrivate.Click += new System.EventHandler(this.btnSavePrivate_Click);
            // 
            // btnSavePublic
            // 
            this.btnSavePublic.CheckedState.Parent = this.btnSavePublic;
            this.btnSavePublic.CustomImages.Parent = this.btnSavePublic;
            this.btnSavePublic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(198)))));
            this.btnSavePublic.Font = new System.Drawing.Font("Google Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSavePublic.ForeColor = System.Drawing.Color.White;
            this.btnSavePublic.HoveredState.Parent = this.btnSavePublic;
            this.btnSavePublic.Location = new System.Drawing.Point(488, 53);
            this.btnSavePublic.Name = "btnSavePublic";
            this.btnSavePublic.ShadowDecoration.Parent = this.btnSavePublic;
            this.btnSavePublic.Size = new System.Drawing.Size(98, 26);
            this.btnSavePublic.TabIndex = 5;
            this.btnSavePublic.Text = "Lưu public key";
            this.btnSavePublic.Click += new System.EventHandler(this.btnSavePublic_Click);
            // 
            // btnContact
            // 
            this.btnContact.CheckedState.Parent = this.btnContact;
            this.btnContact.CustomImages.Parent = this.btnContact;
            this.btnContact.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(216)))), ((int)(((byte)(214)))));
            this.btnContact.Font = new System.Drawing.Font("Google Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnContact.ForeColor = System.Drawing.Color.White;
            this.btnContact.HoveredState.Parent = this.btnContact;
            this.btnContact.Location = new System.Drawing.Point(598, 53);
            this.btnContact.Name = "btnContact";
            this.btnContact.ShadowDecoration.Parent = this.btnContact;
            this.btnContact.Size = new System.Drawing.Size(98, 26);
            this.btnContact.TabIndex = 5;
            this.btnContact.Text = "Liên hệ mình";
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.txtPrivateKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrivateKey.Font = new System.Drawing.Font("Google Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrivateKey.ForeColor = System.Drawing.Color.White;
            this.txtPrivateKey.Location = new System.Drawing.Point(60, 123);
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtPrivateKey.Size = new System.Drawing.Size(349, 224);
            this.txtPrivateKey.TabIndex = 6;
            this.txtPrivateKey.Text = "";
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.txtPublicKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPublicKey.Font = new System.Drawing.Font("Google Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublicKey.ForeColor = System.Drawing.Color.White;
            this.txtPublicKey.Location = new System.Drawing.Point(452, 123);
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.Size = new System.Drawing.Size(349, 224);
            this.txtPublicKey.TabIndex = 6;
            this.txtPublicKey.Text = "";
            // 
            // btnClose
            // 
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(87)))));
            this.btnClose.Font = new System.Drawing.Font("Google Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoveredState.Parent = this.btnClose;
            this.btnClose.Location = new System.Drawing.Point(708, 53);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(98, 26);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Thoát";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(850, 380);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(850, 380);
            this.MinimumSize = new System.Drawing.Size(850, 380);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gen RSA Key By Le Dung";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.SiticonePanel panelMain;
        private ns1.SiticoneDragControl dragControl;
        private ns1.SiticoneLabel lblTitle;
        private ns1.SiticoneLabel lblKeySize;
        private ns1.SiticoneComboBox cbbKeySize;
        private ns1.SiticoneLabel lblPublicKey;
        private ns1.SiticoneLabel lblPrivateKey;
        private ns1.SiticoneButton btnGen;
        private ns1.SiticoneButton btnSavePublic;
        private ns1.SiticoneButton btnSavePrivate;
        private ns1.SiticoneButton btnContact;
        private System.Windows.Forms.RichTextBox txtPrivateKey;
        private System.Windows.Forms.RichTextBox txtPublicKey;
        private ns1.SiticoneButton btnClose;
    }
}

