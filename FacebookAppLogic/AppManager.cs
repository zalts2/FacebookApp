using System;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class AppManager
    {
        private readonly string r_AppID = "719299542009735";

        private string[] m_Permissions = { "user_photos", "email", "user_likes" };
        private User m_LoggedInUser;

        internal AppManager()
        {

        }
        public bool LogInToFacebook()
        {
            bool loggedIn = false;
            try
            {
                LoginResult result = FacebookService.Login(r_AppID, m_Permissions);
                m_LoggedInUser = result.LoggedInUser;
            }
            catch (Exception)
            {

            }
            return loggedIn;
        }
        public User user
        {
            get
            {
                return this.m_LoggedInUser;
            }
        }



    }

}
