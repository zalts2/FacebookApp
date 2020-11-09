using FacebookAppLogic;

namespace FacebookUI
{
    public class AppUI
    {
        private AppForm r_LoginForm;
        private readonly AppManager r_AppManager = new AppManager();

        internal AppUI()
        {
            r_LoginForm = new AppForm(this);
        }

        internal void RunApp()
        {
            this.r_LoginForm.ShowDialog();
        }

        internal bool login()
        {
            bool successfullLogin = r_AppManager.LogInToFacebook();
            if (successfullLogin)
            {

            }
            else
            {

            }
            return successfullLogin;
        }
    }
}
