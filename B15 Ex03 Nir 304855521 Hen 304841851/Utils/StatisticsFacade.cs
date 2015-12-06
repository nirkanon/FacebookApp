using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B15_Ex03_Nir_304855521_Hen_304841851
{
    public class StatisticsFacade
    {
        private PhotosUtils m_Photos;
        ////private FriendsUtils m_Friends;
        ////private CheckinsUtils m_Chekins;
        private EventsUtils m_Events;

        public StatisticsFacade()
        {
            m_Photos = new PhotosUtils();
            ////m_Friends = new FriendsUtils();
            ////m_Checkins = new CheckinsUtils();
            m_Events = new EventsUtils();
        }

        public Dictionary<string, int> GetData()
        {
            Dictionary<string, int> data = new Dictionary<string, int>();

            data.Add("Photos", m_Photos.Count());
            ////data.Add("Friends", m_Friends.Count());
            ////data.Add("Checkins", m_Checkins.Count());
            data.Add("Events", m_Events.Count());
            return data;
        }
    }
}
