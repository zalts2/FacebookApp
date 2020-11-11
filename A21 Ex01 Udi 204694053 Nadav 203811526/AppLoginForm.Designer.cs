namespace FacebookUI
{
    partial class AppLoginForm
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.checkBoxRemeberMe = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackgroundImage = global::FacebookUI.Properties.Resources.FacebookLoginButton;
            this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLogin.Location = new System.Drawing.Point(43, 46);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(256, 56);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // checkBoxRemeberMe
            // 
            this.checkBoxRemeberMe.AutoSize = true;
            this.checkBoxRemeberMe.BackgroundImage = global::FacebookUI.Properties.Resources.FaceBookLoginCover;
            this.checkBoxRemeberMe.Checked = true;
            this.checkBoxRemeberMe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRemeberMe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxRemeberMe.Location = new System.Drawing.Point(125, 122);
            this.checkBoxRemeberMe.Name = "checkBoxRemeberMe";
            this.checkBoxRemeberMe.Size = new System.Drawing.Size(86, 17);
            this.checkBoxRemeberMe.TabIndex = 1;
            this.checkBoxRemeberMe.Text = "Remeber me";
            this.checkBoxRemeberMe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxRemeberMe.UseVisualStyleBackColor = true;
            this.checkBoxRemeberMe.CheckedChanged += new System.EventHandler(this.checkBoxRemeberMe_CheckedChanged);
            // 
            // AppLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FacebookUI.Properties.Resources.FaceBookLoginCover;
            this.ClientSize = new System.Drawing.Size(349, 167);
            this.Controls.Add(this.checkBoxRemeberMe);
            this.Controls.Add(this.buttonLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AppLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.AppLoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.CheckBox checkBoxRemeberMe;


    }
}