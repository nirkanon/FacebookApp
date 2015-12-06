using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using FacebookWrapper.ObjectModel;

namespace B15_Ex03_Nir_304855521_Hen_304841851
{
    public class RatedCheckin
    {
        public enum eRating
        {
            None = 0,
            Bad = 1,
            Fine = 2,
            OK = 3,
            Good = 4,
            Great = 5
        }

        [XmlIgnoreAttribute]
        public Checkin CheckinData { get; set; }

        public eRating m_Rating;

        public string Id { get; set; }

        public string Place { get; set; }

        public RatedCheckin(Checkin i_Checkin, int i_Rate)
        {
            CheckinData = i_Checkin;
            m_Rating = (eRating)i_Rate;
            Id = i_Checkin.Id;
            Place = i_Checkin.Place.Name;
        }

        public RatedCheckin()
        {
        }
    }
}
