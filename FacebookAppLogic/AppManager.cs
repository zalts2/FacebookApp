using System;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class AppManager
    {
        private User m_LoggedInUser;
        public LoginResult m_loginResult;
        public UserData m_UserData;

        private readonly string r_AppID = "719299542009735";

        private readonly string[] r_Permissions =
        {
        // + first/last name.
        "user_gender", //The user_gender permission allows your app to read a person's gender as listed in their Facebook profile.
        "email",
        "user_birthday", //The user_birthday permission allows your app to read a person's birthday as listed in their Facebook profile.
        "user_link", //The user_link permission allows your app to access the Facebook profile URL of the person using your app.

        // objects - need to change to strings?
        "user_friends", //The user_friends permission allows your app to get a list of a person's friends using that app.
        //"user_likes", //The user_likes permission allows your app to read a list of all Facebook Pages that a user has liked.
        "user_posts", //The user_posts permission allows your app to access the posts that a user has made on their timeline.
        "user_location",  //The user_location permission allows your app to read the city name as listed in the location field of a person's Facebook profile.
        "user_hometown", //The user_hometown permission allows your app to read a person's hometown location from their Facebook profile.
        "user_videos", //The user_videos permission allows your app to read a list of videos uploaded by a person.
        "user_photos", //The user_photos permission allows your app to read the photos a person has been tagged /uploaded to Facebook.
        
        //"pages_manage_posts", // for POSTS
        "user_tagged_places", //???
        "public_profile", //???
        "user_events",  //??  
        };

  

        public bool loginToFacebook(out string o_Response)
        {
            o_Response = string.Empty;
            bool loggedIn = true;
            try
            {
                m_loginResult = FacebookService.Login(r_AppID, r_Permissions);
                m_LoggedInUser = m_loginResult.LoggedInUser;
            }
            catch (Exception e)
            {
                loggedIn = false;
                o_Response = m_loginResult.ErrorMessage;
            }
            try
            {
                updateInformation();
                loggedIn = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return loggedIn;
        }

        public void logoutfromFacebook()
        {
            FacebookService.Logout();
            m_LoggedInUser = null;
            m_loginResult = null;
            //should we all clear the information?
        }

        public bool postPhoto(string i_path)
        {
            m_LoggedInUser.PostPhoto(i_path,"nadav","nadav","private");
            return true;
        }
        private void updateInformation()
        {
            //used info
            m_UserData = new UserData();
            m_UserData.profilePicture = m_LoggedInUser.PictureNormalURL;
            m_UserData.firstName = m_LoggedInUser.FirstName;
            m_UserData.lastName = m_LoggedInUser.LastName;

            //unused info
            m_UserData.gender = (User.eGender)m_LoggedInUser.Gender;
            m_UserData.birthday = m_LoggedInUser.Birthday;
            m_UserData.relationshipStatus = (User.eRelationshipStatus)m_LoggedInUser.RelationshipStatus;
            m_UserData.email = m_LoggedInUser.Email;
            m_UserData.Friends = m_LoggedInUser.Friends;
            m_UserData.Posts = m_LoggedInUser.Posts;
            m_UserData.Location = m_LoggedInUser.Location;
            m_UserData.Hometown = m_LoggedInUser.Hometown;
            m_UserData.Link = m_LoggedInUser.Link;
            m_UserData.Videos = m_LoggedInUser.Videos;
            m_UserData.PhotosTaggedIn = m_LoggedInUser.PhotosTaggedIn;
            m_UserData.Groups = m_LoggedInUser.Groups;
            m_UserData.About = m_LoggedInUser.About;
            m_UserData.Events = m_LoggedInUser.Events;
            m_UserData.FavofriteTeams = m_LoggedInUser.FavofriteTeams;
            m_UserData.Albums = m_LoggedInUser.Albums;
            //m_UserData.FriendLists = m_LoggedInUser.FriendLists;
            //m_UserData.LikedPages = m_LoggedInUser.LikedPages;
        }
    }
}
