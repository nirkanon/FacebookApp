using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Diagnostics;
using System.Threading;
using FacebookWrapper.ObjectModel;

namespace B15_Ex03_Nir_304855521_Hen_304841851
{
    public partial class FormEvents : Form
    {
        private EventsUtils m_EventsUtils;

        public FormEvents()
        {
            InitializeComponent();
            m_EventsUtils = new EventsUtils();
        }

        protected override void OnLoad(EventArgs e)
        {
            Thread thread = new Thread(this.fetchEvents);
            thread.Start();
        }

        private void fetchEvents()
        {
            this.Invoke(new Action(() =>
             {
         FacebookObjectCollection<Event> events = m_EventsUtils.GetEventsList();
         comboBoxEvents.DisplayMember = "Name";
         foreach (FacebookWrapper.ObjectModel.Event evnt in events)
         {
             comboBoxEvents.Items.Add(evnt);
         }
             }));
        }

        private void comboBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            Event tempSelectedEvent = comboBoxEvents.SelectedItem as Event;
            LinkLabel.Link link = new LinkLabel.Link();
            linkLabel.Links.Clear();
            link.LinkData = tempSelectedEvent.LinkToFacebook;
            pictureBoxEventPhoto.Load(tempSelectedEvent.PictureLargeURL);
            textBoxEventDate.Text = tempSelectedEvent.StartTime.ToString();
            textBoxEventLocation.Text = tempSelectedEvent.Location;
            textBoxEventName.Text = tempSelectedEvent.Name;
            linkLabel.Links.Add(link);
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (comboBoxEvents.SelectedIndex != -1)
            {
                Process.Start(e.Link.LinkData as string);
            }
        }
    }
}
