namespace SMS.Win
{
    partial class Configuration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuration));
            this.MainGpx = new System.Windows.Forms.GroupBox();
            this.OKBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.PassLbl = new System.Windows.Forms.Label();
            this.PhoneTxt = new System.Windows.Forms.TextBox();
            this.PhoneLbl = new System.Windows.Forms.Label();
            this.UrlTxt = new System.Windows.Forms.TextBox();
            this.UrlLbl = new System.Windows.Forms.Label();
            this.MainGpx.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainGpx
            // 
            this.MainGpx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainGpx.Controls.Add(this.UrlTxt);
            this.MainGpx.Controls.Add(this.UrlLbl);
            this.MainGpx.Controls.Add(this.PhoneTxt);
            this.MainGpx.Controls.Add(this.PhoneLbl);
            this.MainGpx.Controls.Add(this.PasswordTxt);
            this.MainGpx.Controls.Add(this.PassLbl);
            this.MainGpx.Controls.Add(this.UsernameTxt);
            this.MainGpx.Controls.Add(this.UsernameLbl);
            this.MainGpx.Location = new System.Drawing.Point(12, 13);
            this.MainGpx.Name = "MainGpx";
            this.MainGpx.Size = new System.Drawing.Size(436, 162);
            this.MainGpx.TabIndex = 0;
            this.MainGpx.TabStop = false;
            // 
            // OKBtn
            // 
            this.OKBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKBtn.Location = new System.Drawing.Point(298, 187);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(72, 23);
            this.OKBtn.TabIndex = 1;
            this.OKBtn.Text = "&OK";
            this.OKBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(376, 187);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(72, 23);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "&Cancel";
            this.CancelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Location = new System.Drawing.Point(6, 25);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(64, 13);
            this.UsernameLbl.TabIndex = 0;
            this.UsernameLbl.Text = "Username :";
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameTxt.Location = new System.Drawing.Point(107, 22);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(308, 22);
            this.UsernameTxt.TabIndex = 1;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordTxt.Location = new System.Drawing.Point(107, 55);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(308, 22);
            this.PasswordTxt.TabIndex = 3;
            // 
            // PassLbl
            // 
            this.PassLbl.AutoSize = true;
            this.PassLbl.Location = new System.Drawing.Point(6, 58);
            this.PassLbl.Name = "PassLbl";
            this.PassLbl.Size = new System.Drawing.Size(62, 13);
            this.PassLbl.TabIndex = 2;
            this.PassLbl.Text = "Password :";
            // 
            // PhoneTxt
            // 
            this.PhoneTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneTxt.Location = new System.Drawing.Point(107, 88);
            this.PhoneTxt.Name = "PhoneTxt";
            this.PhoneTxt.Size = new System.Drawing.Size(308, 22);
            this.PhoneTxt.TabIndex = 5;
            // 
            // PhoneLbl
            // 
            this.PhoneLbl.AutoSize = true;
            this.PhoneLbl.Location = new System.Drawing.Point(6, 91);
            this.PhoneLbl.Name = "PhoneLbl";
            this.PhoneLbl.Size = new System.Drawing.Size(89, 13);
            this.PhoneLbl.TabIndex = 4;
            this.PhoneLbl.Text = "Phone number :";
            // 
            // UrlTxt
            // 
            this.UrlTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UrlTxt.Location = new System.Drawing.Point(107, 121);
            this.UrlTxt.Name = "UrlTxt";
            this.UrlTxt.Size = new System.Drawing.Size(308, 22);
            this.UrlTxt.TabIndex = 7;
            // 
            // UrlLbl
            // 
            this.UrlLbl.AutoSize = true;
            this.UrlLbl.Location = new System.Drawing.Point(6, 124);
            this.UrlLbl.Name = "UrlLbl";
            this.UrlLbl.Size = new System.Drawing.Size(72, 13);
            this.UrlLbl.TabIndex = 6;
            this.UrlLbl.Text = "Url Address :";
            // 
            // Configuration
            // 
            this.AcceptButton = this.OKBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(460, 222);
            this.ControlBox = false;
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.MainGpx);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Configuration";
            this.Text = "Configuration";
            this.MainGpx.ResumeLayout(false);
            this.MainGpx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MainGpx;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.TextBox UrlTxt;
        private System.Windows.Forms.Label UrlLbl;
        private System.Windows.Forms.TextBox PhoneTxt;
        private System.Windows.Forms.Label PhoneLbl;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.Label PassLbl;
        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.Label UsernameLbl;
    }
}