using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Threading;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace B15_Ex03_Nir_304855521_Hen_304841851
{
    public partial class FormCheckins : Form
    {
        private List<RatedCheckin> m_FacebookCheckinsList;
        private CheckinsUtils m_CheckinsUtils;
        private List<RatedCheckin> m_RatedChekinsList;

        public FormCheckins()
        {
            InitializeComponent();
            m_FacebookCheckinsList = new List<RatedCheckin>();
            m_CheckinsUtils = new CheckinsUtils();
            m_RatedChekinsList = new List<RatedCheckin>();
        }

        protected override void OnLoad(EventArgs e)
        {
            Thread thread = new Thread(this.fetchCheckins);
            thread.Start();
            comboBoxRating.DataSource = Enum.GetValues(typeof(RatedCheckin.eRating));
        }

        private void fetchCheckins()
        {
            ListViewItem tempItem;
            m_RatedChekinsList = m_CheckinsUtils.MergeCheckins();
            this.Invoke(new Action(() =>
                {
            if (m_RatedChekinsList.Count != 0)
            {
                foreach (RatedCheckin checkin in m_RatedChekinsList)
                {
                    tempItem = new ListViewItem(checkin.Id);
                    tempItem.SubItems.Add(checkin.Place);
                    tempItem.SubItems.Add(checkin.m_Rating.ToString());
                    listViewCheckins.Items.Add(tempItem);
                }
            }
            }));
        }

        private void buttonRate_Click(object sender, EventArgs e)
        {
            if (listViewCheckins.SelectedItems.Count == 1)
            {
                listViewCheckins.SelectedItems[0].SubItems[2].Text = comboBoxRating.SelectedItem.ToString();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            m_CheckinsUtils.WriteToXmlFile(listViewCheckins.Items);
        }
    }
}
