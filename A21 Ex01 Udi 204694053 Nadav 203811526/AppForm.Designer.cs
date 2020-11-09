namespace FacebookUI
{
    partial class AppForm
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
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackgroundImage = global::FacebookUI.Properties.Resources.FacebookLoginButton;
            this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.buttonLogin.Location = new System.Drawing.Point(22, 12);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(195, 46);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxProfile.Enabled = false;
            this.pictureBoxProfile.Location = new System.Drawing.Point(22, 12);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(124, 96);
            this.pictureBoxProfile.TabIndex = 1;
            this.pictureBoxProfile.TabStop = false;
            this.pictureBoxProfile.Visible = false;
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FacebookUI.Properties.Resources.FaceBookLoginCover;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.buttonLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
    }
}