using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace B15_Ex03_Nir_304855521_Hen_304841851
{
    public class EventsUtils
    {
        private User m_LoggedUser;

        public EventsUtils()
        {
            m_LoggedUser = LoggedUserSingleton.Instance.GetUser(); 
        }

        public FacebookObjectCollection<Event> GetEventsList()
        {
            return m_LoggedUser.Events;
        }

        public int Count()
        {
            return GetEventsList().Count();
        }
    }
}
