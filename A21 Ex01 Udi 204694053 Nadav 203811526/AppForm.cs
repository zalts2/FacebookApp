using System;
using System.Windows.Forms;
using FacebookAppLogic;

namespace FacebookUI
{
    public partial class AppForm : Form
    {
        private readonly AppUI r_AppUI;
        public AppForm(AppUI i_AppUI)
        {
            this.r_AppUI = i_AppUI;
            InitializeComponent();
            
        }

        private void SetFormForUser(UserData i_UserData)
        {
            Text = string.Format("Welcome {0}", i_UserData.firstName);
            LoadPictureBox(pictureBoxProfile, i_UserData.profilePicture);
        }
        private void AppForm_Load(object sender, EventArgs e)
        {
            SetFormForUser(r_AppUI.UserData);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            r_AppUI.logout();
        }

        internal static bool YesNoWindow(string i_Message, string i_Title)
        {
            bool userAccepet = false;
            DialogResult reply = MessageBox.Show(i_Message, i_Title, MessageBoxButtons.YesNo);

            if (reply == DialogResult.Yes)
            {
                userAccepet = true;
            }

            return userAccepet;
        }

        internal static void showErrorMessage(string i_Message, string i_Title)
        {
            MessageBox.Show(i_Message, i_Title);
        }

        private void pictureBoxProfile_Click(object sender, EventArgs e)
        {

        }

        private static void LoadPictureBox(PictureBox io_PictureBox, string i_location)
        {
            io_PictureBox.LoadAsync(i_location);
            io_PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonPostPhoto_Click(object sender, EventArgs e)
        {
            string path = string.Empty;
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image Files | *.jpg; *.jpeg; *.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    path = dlg.FileName;
                }
            }
            r_AppUI.postPhoto(path);
        }

        private void buttonMyAlbums_Click(object sender, EventArgs e)
        {

        }
    }
}
