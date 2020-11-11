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
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonPostPhoto = new System.Windows.Forms.Button();
            this.buttonPostStatus = new System.Windows.Forms.Button();
            this.buttonExtra1 = new System.Windows.Forms.Button();
            this.buttonExtra2 = new System.Windows.Forms.Button();
            this.buttonMyAlbums = new System.Windows.Forms.Button();
            this.listBoxMenu = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxProfile.Location = new System.Drawing.Point(21, 18);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(115, 104);
            this.pictureBoxProfile.TabIndex = 0;
            this.pictureBoxProfile.TabStop = false;
            this.pictureBoxProfile.Click += new System.EventHandler(this.pictureBoxProfile_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackgroundImage = global::FacebookUI.Properties.Resources.LOG_OUT_BUTTON;
            this.buttonLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLogout.Location = new System.Drawing.Point(721, 20);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(200, 44);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonPostPhoto
            // 
            this.buttonPostPhoto.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonPostPhoto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPostPhoto.Location = new System.Drawing.Point(22, 231);
            this.buttonPostPhoto.Name = "buttonPostPhoto";
            this.buttonPostPhoto.Size = new System.Drawing.Size(114, 42);
            this.buttonPostPhoto.TabIndex = 3;
            this.buttonPostPhoto.Text = "Post Photo";
            this.buttonPostPhoto.UseVisualStyleBackColor = false;
            this.buttonPostPhoto.Click += new System.EventHandler(this.buttonPostPhoto_Click);
            // 
            // buttonPostStatus
            // 
            this.buttonPostStatus.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonPostStatus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPostStatus.Location = new System.Drawing.Point(22, 301);
            this.buttonPostStatus.Name = "buttonPostStatus";
            this.buttonPostStatus.Size = new System.Drawing.Size(114, 42);
            this.buttonPostStatus.TabIndex = 4;
            this.buttonPostStatus.Text = "Post Status";
            this.buttonPostStatus.UseVisualStyleBackColor = false;
            // 
            // buttonExtra1
            // 
            this.buttonExtra1.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonExtra1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonExtra1.Location = new System.Drawing.Point(23, 375);
            this.buttonExtra1.Name = "buttonExtra1";
            this.buttonExtra1.Size = new System.Drawing.Size(114, 42);
            this.buttonExtra1.TabIndex = 5;
            this.buttonExtra1.Text = "Extra";
            this.buttonExtra1.UseVisualStyleBackColor = false;
            // 
            // buttonExtra2
            // 
            this.buttonExtra2.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonExtra2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonExtra2.Location = new System.Drawing.Point(22, 449);
            this.buttonExtra2.Name = "buttonExtra2";
            this.buttonExtra2.Size = new System.Drawing.Size(114, 42);
            this.buttonExtra2.TabIndex = 6;
            this.buttonExtra2.Text = "Extra 2";
            this.buttonExtra2.UseVisualStyleBackColor = false;
            // 
            // buttonMyAlbums
            // 
            this.buttonMyAlbums.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonMyAlbums.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMyAlbums.Location = new System.Drawing.Point(22, 161);
            this.buttonMyAlbums.Name = "buttonMyAlbums";
            this.buttonMyAlbums.Size = new System.Drawing.Size(114, 42);
            this.buttonMyAlbums.TabIndex = 7;
            this.buttonMyAlbums.Text = "My Albums";
            this.buttonMyAlbums.UseVisualStyleBackColor = false;
            this.buttonMyAlbums.Click += new System.EventHandler(this.buttonMyAlbums_Click);
            // 
            // listBoxMenu
            // 
            this.listBoxMenu.BackColor = System.Drawing.SystemColors.Menu;
            this.listBoxMenu.FormattingEnabled = true;
            this.listBoxMenu.Location = new System.Drawing.Point(184, 19);
            this.listBoxMenu.Name = "listBoxMenu";
            this.listBoxMenu.Size = new System.Drawing.Size(464, 472);
            this.listBoxMenu.TabIndex = 8;
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FacebookUI.Properties.Resources.FaceBookLoginCover;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(959, 527);
            this.Controls.Add(this.listBoxMenu);
            this.Controls.Add(this.buttonMyAlbums);
            this.Controls.Add(this.buttonExtra2);
            this.Controls.Add(this.buttonExtra1);
            this.Controls.Add(this.buttonPostStatus);
            this.Controls.Add(this.buttonPostPhoto);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.pictureBoxProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AppForm";
            this.Text = "AppForm";
            this.Load += new System.EventHandler(this.AppForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonPostPhoto;
        private System.Windows.Forms.Button buttonPostStatus;
        private System.Windows.Forms.Button buttonExtra1;
        private System.Windows.Forms.Button buttonExtra2;
        private System.Windows.Forms.Button buttonMyAlbums;
        private System.Windows.Forms.ListBox listBoxMenu;
    }
}