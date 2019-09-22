namespace LoginSocialNetwork
{
    partial class Form1
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
            this.pnlLoginUI = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblSocialNetwork = new System.Windows.Forms.Label();
            this.cbbSocialNetwork = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // pnlLoginUI
            // 
            this.pnlLoginUI.Location = new System.Drawing.Point(18, 75);
            this.pnlLoginUI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlLoginUI.Name = "pnlLoginUI";
            this.pnlLoginUI.Size = new System.Drawing.Size(536, 213);
            this.pnlLoginUI.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.Enabled = false;
            this.btnLogin.Location = new System.Drawing.Point(18, 308);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(536, 30);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblSocialNetwork
            // 
            this.lblSocialNetwork.AutoSize = true;
            this.lblSocialNetwork.Location = new System.Drawing.Point(14, 21);
            this.lblSocialNetwork.Name = "lblSocialNetwork";
            this.lblSocialNetwork.Size = new System.Drawing.Size(94, 20);
            this.lblSocialNetwork.TabIndex = 2;
            this.lblSocialNetwork.Text = "Mạng xã hội";
            // 
            // cbbSocialNetwork
            // 
            this.cbbSocialNetwork.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSocialNetwork.FormattingEnabled = true;
            this.cbbSocialNetwork.Items.AddRange(new object[] {
            "Facebook",
            "Twitter"});
            this.cbbSocialNetwork.Location = new System.Drawing.Point(128, 18);
            this.cbbSocialNetwork.Name = "cbbSocialNetwork";
            this.cbbSocialNetwork.Size = new System.Drawing.Size(426, 28);
            this.cbbSocialNetwork.TabIndex = 3;
            this.cbbSocialNetwork.SelectedIndexChanged += new System.EventHandler(this.cbbSocialNetwork_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 355);
            this.Controls.Add(this.cbbSocialNetwork);
            this.Controls.Add(this.lblSocialNetwork);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pnlLoginUI);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLoginUI;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblSocialNetwork;
        private System.Windows.Forms.ComboBox cbbSocialNetwork;
    }
}

