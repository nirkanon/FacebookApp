using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace B15_Ex03_Nir_304855521_Hen_304841851
{
    public class FriendsUtils
    {
        private User m_LoggedUser;

        public FriendsUtils()
        {
            m_LoggedUser = LoggedUserSingleton.Instance.GetUser();
        }

        public FacebookObjectCollection<User> GetFriendsList()
        {
            return m_LoggedUser.Friends;
        }

        public FacebookObjectCollection<Group> GetFriendGroups(User i_Friend)
        {
            return i_Friend.Groups;
        }

        public int Count()
        {
            return GetFriendsList().Count();
        }

        public string GetFriendHometown(User i_Friend)
        {
            string hometown = ":(";
            if(i_Friend.Hometown != null)
            {
                hometown = i_Friend.Hometown.Name;
            }

            return hometown;
        }

        public string GetFriendBirthday(User i_Friend)
        {
            string birthday = ":(";
            if (!string.IsNullOrEmpty(i_Friend.Birthday))
            {
                birthday = i_Friend.Birthday;
            }

            return birthday;
        }

        public string GetFriendName(User i_Friend)
        {
            return i_Friend.Name;
        }

        public string GetFriendLastStatus(User i_Friend)
        {
            string status = "לא קיים סטטוס";
            if (i_Friend.Statuses.Count != 0)
            {
                status = i_Friend.Statuses[0].ToString();
            }

            return status;
        }

        public string GetFriendPicture(User i_Friend)
        {
            string picture = string.Empty;
            if (i_Friend.PictureLargeURL != null)
            {
                picture = i_Friend.PictureLargeURL;
            }

            return picture;
        }
    }
}
