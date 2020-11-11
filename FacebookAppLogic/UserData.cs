using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class UserData
    {

        public string profilePicture { get; internal set; }
        public string firstName { get; internal set; }
        public string lastName { get; internal set; }
        public User.eGender gender { get; internal set; }
        public string birthday { get; internal set; }
        public User.eRelationshipStatus relationshipStatus { get; internal set; }
        public string email { get; internal set; }
        public string Link { get; set; }
        public string About { get; set; }


        //
        public FacebookObjectCollection<User> Friends { get; set; }
        //internal FacebookObjectCollection<FriendList> FriendLists { get; set; }
        //internal FacebookObjectCollection<Page> LikedPages { get; set; }
        public FacebookObjectCollection<Post> Posts { get; set; }
        public City Location { get; set; }
        public City Hometown { get; set; }
        public FacebookObjectCollection<Video> Videos { get; set; }
        public FacebookObjectCollection<Photo> PhotosTaggedIn { get; set; }
        public FacebookObjectCollection<Group> Groups { get; set; }
        public FacebookObjectCollection<Event> Events { get; set; }
        public FacebookObjectCollection<Album> Albums { get; set; }
        public Page[] FavofriteTeams { get; set; }



    }
}
