using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookUI
{
    
    public partial class AppLoginForm : Form
    {
        private readonly AppUI r_AppUI;
        public AppLoginForm(AppUI i_AppUi)
        {
            this.r_AppUI = i_AppUi;
            InitializeComponent();
        }

        private void AppLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool loggedin = r_AppUI.login();
            if (loggedin)
            {
                Close();
            }
        }

        internal static void showErrorMessage(string i_Message, string i_caption)
        {
            MessageBox.Show(i_Message, i_caption, MessageBoxButtons.OK);
            ///logic with button and more..
        }

        internal static void showMessage(string i_Message)
        {
            MessageBox.Show(i_Message);
        }

        private void checkBoxRemeberMe_CheckedChanged(object sender, EventArgs e)
        {

        }

        internal bool RememberMe
        {
            get
            {
                return this.checkBoxRemeberMe.Checked;
            }
        }
    }
}
