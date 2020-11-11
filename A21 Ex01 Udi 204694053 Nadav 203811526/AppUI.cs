using FacebookAppLogic;

namespace FacebookUI
{
    public class AppUI
    {
        private readonly AppLoginForm r_LoginForm;
        private  readonly AppForm r_AppForm;
        private UserData m_UserData;
        internal readonly AppManager r_AppManager;
        private bool m_userLoggedIn;

        internal AppUI()
        { 
            r_AppManager = new AppManager();
            r_LoginForm = new AppLoginForm(this);
            r_AppForm = new AppForm(this);
            m_userLoggedIn = false;
        }

        internal void RunApp()
        {
            while (!m_userLoggedIn)
            {
                r_LoginForm.ShowDialog();
            }

            r_AppForm.ShowDialog();

        }

        internal bool login()
        {
            bool successfullLogin = r_AppManager.loginToFacebook(out string errorMessage);
            if (successfullLogin)
            {
                m_userLoggedIn = true;
                m_UserData = r_AppManager.m_UserData;
                if (r_LoginForm.RememberMe)
                {
                    // AppManager.saveToken();
                }
            }
            else
            {
                //should bring the error msg from m_loginResult somehow.
                AppForm.showErrorMessage(errorMessage, "Login Error");
            }
            return successfullLogin;
        }
        internal void logout()
        {
            bool exitApp = AppForm.YesNoWindow("Are you sure you want to exit the App?", "App Logout");
            if (exitApp)
            {
                r_AppManager.logoutfromFacebook();
                r_AppForm.Close();
            }
        }

        internal bool postPhoto(string i_path)
        {
            r_AppManager.postPhoto(i_path);

            return true; // change true / false according to success
        }

        internal UserData UserData
        {
            get
            {
                return this.m_UserData;
            }
        }

    }
}
