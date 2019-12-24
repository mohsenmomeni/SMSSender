namespace SMS.Win
{
    partial class MainApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApplication));
            this.NumbersPathTxt = new System.Windows.Forms.TextBox();
            this.NumbersPathBtn = new System.Windows.Forms.Button();
            this.NumbersPathLbl = new System.Windows.Forms.Label();
            this.ResultGpx = new System.Windows.Forms.GroupBox();
            this.ResultDetailTxt = new System.Windows.Forms.TextBox();
            this.MessageGpx = new System.Windows.Forms.GroupBox();
            this.MessageTxt = new System.Windows.Forms.TextBox();
            this.DestLbl = new System.Windows.Forms.Label();
            this.ResultPathBtn = new System.Windows.Forms.Button();
            this.ResultPathTxt = new System.Windows.Forms.TextBox();
            this.CounterLbl = new System.Windows.Forms.Label();
            this.ConfigBtn = new System.Windows.Forms.Button();
            this.SendBtn = new System.Windows.Forms.Button();
            this.ResultGpx.SuspendLayout();
            this.MessageGpx.SuspendLayout();
            this.SuspendLayout();
            // 
            // NumbersPathTxt
            // 
            this.NumbersPathTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumbersPathTxt.Location = new System.Drawing.Point(96, 18);
            this.NumbersPathTxt.Name = "NumbersPathTxt";
            this.NumbersPathTxt.Size = new System.Drawing.Size(661, 22);
            this.NumbersPathTxt.TabIndex = 1;
            // 
            // NumbersPathBtn
            // 
            this.NumbersPathBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumbersPathBtn.Location = new System.Drawing.Point(763, 18);
            this.NumbersPathBtn.Name = "NumbersPathBtn";
            this.NumbersPathBtn.Size = new System.Drawing.Size(25, 23);
            this.NumbersPathBtn.TabIndex = 2;
            this.NumbersPathBtn.Text = "...";
            this.NumbersPathBtn.UseVisualStyleBackColor = true;
            this.NumbersPathBtn.Click += new System.EventHandler(this.NumbersPathBtn_Click);
            // 
            // NumbersPathLbl
            // 
            this.NumbersPathLbl.AutoSize = true;
            this.NumbersPathLbl.Location = new System.Drawing.Point(12, 21);
            this.NumbersPathLbl.Name = "NumbersPathLbl";
            this.NumbersPathLbl.Size = new System.Drawing.Size(80, 13);
            this.NumbersPathLbl.TabIndex = 0;
            this.NumbersPathLbl.Text = "CSV File Path :";
            // 
            // ResultGpx
            // 
            this.ResultGpx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultGpx.Controls.Add(this.ResultDetailTxt);
            this.ResultGpx.Location = new System.Drawing.Point(12, 247);
            this.ResultGpx.Name = "ResultGpx";
            this.ResultGpx.Size = new System.Drawing.Size(776, 150);
            this.ResultGpx.TabIndex = 7;
            this.ResultGpx.TabStop = false;
            this.ResultGpx.Text = "Result";
            // 
            // ResultDetailTxt
            // 
            this.ResultDetailTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultDetailTxt.Location = new System.Drawing.Point(15, 19);
            this.ResultDetailTxt.Multiline = true;
            this.ResultDetailTxt.Name = "ResultDetailTxt";
            this.ResultDetailTxt.Size = new System.Drawing.Size(746, 125);
            this.ResultDetailTxt.TabIndex = 0;
            // 
            // MessageGpx
            // 
            this.MessageGpx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageGpx.Controls.Add(this.MessageTxt);
            this.MessageGpx.Location = new System.Drawing.Point(12, 46);
            this.MessageGpx.Name = "MessageGpx";
            this.MessageGpx.Size = new System.Drawing.Size(776, 158);
            this.MessageGpx.TabIndex = 6;
            this.MessageGpx.TabStop = false;
            this.MessageGpx.Text = "Message";
            // 
            // MessageTxt
            // 
            this.MessageTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageTxt.Location = new System.Drawing.Point(14, 20);
            this.MessageTxt.Multiline = true;
            this.MessageTxt.Name = "MessageTxt";
            this.MessageTxt.Size = new System.Drawing.Size(747, 123);
            this.MessageTxt.TabIndex = 0;
            // 
            // DestLbl
            // 
            this.DestLbl.AutoSize = true;
            this.DestLbl.Location = new System.Drawing.Point(12, 222);
            this.DestLbl.Name = "DestLbl";
            this.DestLbl.Size = new System.Drawing.Size(71, 13);
            this.DestLbl.TabIndex = 3;
            this.DestLbl.Text = "Result Path :";
            // 
            // ResultPathBtn
            // 
            this.ResultPathBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultPathBtn.Location = new System.Drawing.Point(763, 219);
            this.ResultPathBtn.Name = "ResultPathBtn";
            this.ResultPathBtn.Size = new System.Drawing.Size(25, 23);
            this.ResultPathBtn.TabIndex = 5;
            this.ResultPathBtn.Text = "...";
            this.ResultPathBtn.UseVisualStyleBackColor = true;
            this.ResultPathBtn.Click += new System.EventHandler(this.ResultPathBtn_Click);
            // 
            // ResultPathTxt
            // 
            this.ResultPathTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultPathTxt.Location = new System.Drawing.Point(96, 219);
            this.ResultPathTxt.Name = "ResultPathTxt";
            this.ResultPathTxt.Size = new System.Drawing.Size(661, 22);
            this.ResultPathTxt.TabIndex = 4;
            // 
            // CounterLbl
            // 
            this.CounterLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CounterLbl.AutoSize = true;
            this.CounterLbl.Location = new System.Drawing.Point(131, 420);
            this.CounterLbl.Name = "CounterLbl";
            this.CounterLbl.Size = new System.Drawing.Size(13, 13);
            this.CounterLbl.TabIndex = 8;
            this.CounterLbl.Text = "0";
            // 
            // ConfigBtn
            // 
            this.ConfigBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ConfigBtn.Image = global::SMS.Win.Properties.Resources.iconfinder_construction_industry_building_03_4137140;
            this.ConfigBtn.Location = new System.Drawing.Point(12, 415);
            this.ConfigBtn.Name = "ConfigBtn";
            this.ConfigBtn.Size = new System.Drawing.Size(113, 23);
            this.ConfigBtn.TabIndex = 10;
            this.ConfigBtn.Text = "&Configuration";
            this.ConfigBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ConfigBtn.UseVisualStyleBackColor = true;
            this.ConfigBtn.Click += new System.EventHandler(this.ConfigBtn_Click);
            // 
            // SendBtn
            // 
            this.SendBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SendBtn.Image = global::SMS.Win.Properties.Resources.iconfinder_16_2959845;
            this.SendBtn.Location = new System.Drawing.Point(686, 415);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(102, 23);
            this.SendBtn.TabIndex = 9;
            this.SendBtn.Text = "&Send";
            this.SendBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // MainApplication
            // 
            this.AcceptButton = this.NumbersPathBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConfigBtn);
            this.Controls.Add(this.CounterLbl);
            this.Controls.Add(this.DestLbl);
            this.Controls.Add(this.ResultPathBtn);
            this.Controls.Add(this.ResultPathTxt);
            this.Controls.Add(this.MessageGpx);
            this.Controls.Add(this.ResultGpx);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.NumbersPathLbl);
            this.Controls.Add(this.NumbersPathBtn);
            this.Controls.Add(this.NumbersPathTxt);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainApplication";
            this.Text = "SMS Sender";
            this.ResultGpx.ResumeLayout(false);
            this.ResultGpx.PerformLayout();
            this.MessageGpx.ResumeLayout(false);
            this.MessageGpx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumbersPathTxt;
        private System.Windows.Forms.Button NumbersPathBtn;
        private System.Windows.Forms.Label NumbersPathLbl;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.GroupBox ResultGpx;
        private System.Windows.Forms.GroupBox MessageGpx;
        private System.Windows.Forms.TextBox MessageTxt;
        private System.Windows.Forms.Label DestLbl;
        private System.Windows.Forms.Button ResultPathBtn;
        private System.Windows.Forms.TextBox ResultPathTxt;
        private System.Windows.Forms.TextBox ResultDetailTxt;
        private System.Windows.Forms.Label CounterLbl;
        private System.Windows.Forms.Button ConfigBtn;
    }
}

