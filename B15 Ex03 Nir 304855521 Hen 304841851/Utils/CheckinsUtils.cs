using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using FacebookWrapper.ObjectModel;

namespace B15_Ex03_Nir_304855521_Hen_304841851
{
    public class CheckinsUtils
    {
        private User m_LoggedUser;

        private Checkin GetCheckin(float i_Id)
        {
            Checkin tempCheckin = new Checkin();

            foreach(Checkin checkin in m_LoggedUser.Checkins)
            {
                if (i_Id == float.Parse(checkin.Id))
                {
                    tempCheckin = checkin;
                }
            }

            return tempCheckin;
        }
   
        public void WriteToXmlFile(System.Windows.Forms.ListView.ListViewItemCollection i_List, bool i_Append = false) 
        {
            List<RatedCheckin> checkinsList = new List<RatedCheckin>();
            foreach (ListViewItem item in i_List)
            {
                checkinsList.Add(new RatedCheckin(GetCheckin(float.Parse(item.Text)), (int)Enum.Parse(typeof(RatedCheckin.eRating), item.SubItems[2].Text)));
            }

            TextWriter writer = null;
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<RatedCheckin>));
                writer = new StreamWriter(Application.ExecutablePath + ".ratedcheckins.xml", i_Append);
                serializer.Serialize(writer, checkinsList);
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
        }

        public static List<RatedCheckin> ReadFromXmlFile()
        {
            TextReader reader = null;
            string file = Application.ExecutablePath + ".ratedcheckins.xml";
            try
            {
                if (!File.Exists(file))
                {
                    File.Create(file);
                }

                    var serializer = new XmlSerializer(typeof(List<RatedCheckin>));
                    reader = new StreamReader(file);
                    return (List<RatedCheckin>)serializer.Deserialize(reader);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        public int Count()
        {
            return GetCheckins().Count();
        }

        public CheckinsUtils()
        {
            m_LoggedUser = LoggedUserSingleton.Instance.GetUser();
        }

        public FacebookObjectCollection<Checkin> GetCheckins()
        {
            return m_LoggedUser.Checkins;
        }

        public List<RatedCheckin> MergeCheckins()
        {
            string file = Application.ExecutablePath + ".ratedcheckins.xml";
            List<RatedCheckin> ratedChekinsList = null; ////XML Checkins
            List<RatedCheckin> facebookRatedCheckins = new List<RatedCheckin>(); ////Facebook downloaded checkins with rates
            FacebookObjectCollection<Checkin> facebookCheckins = this.GetCheckins(); ////Facebook downloaded checkins
            int itemsCount = 0;
            bool duplicate = true;
            if(!File.Exists(file))
            {
                File.Create(file);
                ratedChekinsList = new List<RatedCheckin>();
                itemsCount = 0;
            }
            else
            {
                ratedChekinsList = ReadFromXmlFile();
                itemsCount = ratedChekinsList.Count;
            }

            foreach (Checkin checkin in facebookCheckins)
            {
                facebookRatedCheckins.Add(new RatedCheckin(checkin, 0));
            }

            if (itemsCount == 0)
            {
                foreach (RatedCheckin facebookCheckin in facebookRatedCheckins)
                {
                    ratedChekinsList.Add(facebookCheckin);
                }
            }
            else
            {
                foreach (RatedCheckin facebookCheckin in facebookRatedCheckins)
                {
                    for (int i = 0; i < itemsCount; i++)
                    {
                        if (ratedChekinsList[i].Id.Equals(facebookCheckin.Id))
                        {
                            duplicate = true;
                            break;
                        }

                        if (duplicate == false)
                        {
                            ratedChekinsList.Add(facebookCheckin);
                        }

                        duplicate = true;
                    }
                }
            }

            return ratedChekinsList;
        }
    }
}
