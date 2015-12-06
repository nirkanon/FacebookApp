using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace B15_Ex03_Nir_304855521_Hen_304841851
{
    public partial class FormFriends : Form
    {
        private User logged;
        private FriendsUtils m_FriendsUtils;

        public FormFriends()
        {
            InitializeComponent();
            m_FriendsUtils = new FriendsUtils();
            logged = LoggedUserSingleton.Instance.GetUser();
        }

        protected override void OnLoad(EventArgs e)
        {
            Thread thread = new Thread(this.fetchFriends);
            thread.Start();
        }

        private void fetchFriends()
        {
            var allFriends = m_FriendsUtils.GetFriendsList();

            if (!listBoxFriends.InvokeRequired)
            {
                // binding the data source of the binding source, to our data source:
                friendListBindingSource.DataSource = allFriends;
            }
            else
            {
                // In case of cross-thread operation, invoking the binding code on the listBox's thread:
                listBoxFriends.Invoke(new Action(() => friendListBindingSource.DataSource = allFriends));
            }
        }

        private void buttonSearchFriends_Click(object sender, EventArgs e)
        {
            string stringToSearch = textBoxSearchFriends.Text;
            int index = listBoxFriends.FindString(stringToSearch, -1);
            if (index != -1)
            {
                listBoxFriends.SetSelected(index, true);
            }
        }
    }
}
