namespace LED_Controller
{
    partial class AboutForm
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
            this.lblApplication = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lnkGit = new System.Windows.Forms.LinkLabel();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblApplication
            // 
            this.lblApplication.AutoSize = true;
            this.lblApplication.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblApplication.Location = new System.Drawing.Point(12, 9);
            this.lblApplication.Name = "lblApplication";
            this.lblApplication.Size = new System.Drawing.Size(57, 18);
            this.lblApplication.TabIndex = 0;
            this.lblApplication.Text = "label1";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Verdana", 7F);
            this.lblVersion.Location = new System.Drawing.Point(12, 27);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(39, 12);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "label2";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.lblAuthor.Location = new System.Drawing.Point(11, 45);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(41, 13);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "label3";
            // 
            // lnkGit
            // 
            this.lnkGit.AutoSize = true;
            this.lnkGit.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.lnkGit.Location = new System.Drawing.Point(11, 81);
            this.lnkGit.Name = "lnkGit";
            this.lnkGit.Size = new System.Drawing.Size(64, 13);
            this.lnkGit.TabIndex = 3;
            this.lnkGit.TabStop = true;
            this.lnkGit.Text = "linkLabel1";
            this.lnkGit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGit_LinkClicked);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(247, 99);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(58, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 129);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lnkGit);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblApplication);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AboutForm";
            this.Text = "About LED Controller";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApplication;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.LinkLabel lnkGit;
        private System.Windows.Forms.Button btnOK;
    }
}