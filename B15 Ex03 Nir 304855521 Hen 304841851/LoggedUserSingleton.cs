using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace B15_Ex03_Nir_304855521_Hen_304841851
{
    public sealed class LoggedUserSingleton
    {
        private User m_LoggedInUser;

        private LoggedUserSingleton() 
        {
            LoginResult result;
            if (ApplicationSettings.Instance.AutoLogin)
            {
                result = FacebookService.Connect(ApplicationSettings.Instance.AccessToken);
                if (string.IsNullOrEmpty(result.ErrorMessage))
                {
                    m_LoggedInUser = result.LoggedInUser;
                }
            }
            else
            {
                ////1415881172049856 - Our code
                ////540432436034011 - Guy's code
                result = FacebookService.Login("540432436034011", "user_groups", "user_about_me", "user_friends", "user_events", "read_stream", "user_status", "user_posts", "user_photos", "publish_actions");

                if (!string.IsNullOrEmpty(result.AccessToken))
                {
                    m_LoggedInUser = result.LoggedInUser;
                    ApplicationSettings.Instance.AccessToken = result.AccessToken;
                }
            }
        }

        public User GetUser()
        {
            return m_LoggedInUser;
        }

        public static LoggedUserSingleton Instance
        {
            get { return NestedHolder.Instance; }
        }

        private class NestedHolder
        {
            internal static volatile LoggedUserSingleton Instance = new LoggedUserSingleton();
        }
    }
}
