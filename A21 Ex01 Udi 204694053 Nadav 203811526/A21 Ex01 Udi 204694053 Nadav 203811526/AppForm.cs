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
    public partial class AppForm : Form
    {
        private readonly AppUI r_AppUI; 
        public AppForm(AppUI i_AppUI)
        {
            r_AppUI = i_AppUI;
            InitializeComponent();

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool loggedin = r_AppUI.login();
            if (loggedin)
            {
                buttonLogin.Visible = false;
                buttonLogin.Enabled = false;
            }

        }
    }
}
