using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace B15_Ex03_Nir_304855521_Hen_304841851
{
    public partial class FormMain : Form
    {
        private User m_LoggedInUser;

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }

        private void fetchUserInfo()
        {
            labelName.Text = m_LoggedInUser.Name;
            if (m_LoggedInUser.PictureLargeURL != null)
            {
                pictureBoxProfilePicture.LoadAsync(m_LoggedInUser.PictureLargeURL);
            }
            else
            {
                pictureBoxProfilePicture.Image = pictureBoxProfilePicture.ErrorImage;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            checkBoxAutoLogin.Checked = ApplicationSettings.Instance.AutoLogin;
            m_LoggedInUser = LoggedUserSingleton.Instance.GetUser();
            m_LoggedInUser = LoggedUserSingleton.Instance.GetUser();
            fetchUserInfo();
        }

        private void buttonFriends_Click(object sender, EventArgs e)
        {
            FormFriends friendsForm = new FormFriends();
            friendsForm.Show();
        }

        private void buttonEventsForm_Click(object sender, EventArgs e)
        {
            FormEvents eventsForm = new FormEvents();
            eventsForm.Show();
        }

        private void buttonCheckins_Click(object sender, EventArgs e)
        {
            FormCheckins checkinsForm = new FormCheckins();
            checkinsForm.Show();
        }

        private void buttonPhotos_Click(object sender, EventArgs e)
        {
            FormPhotos photosForm = new FormPhotos();
            photosForm.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.checkBoxAutoLogin.Checked = ApplicationSettings.Instance.AutoLogin;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            ApplicationSettings.Instance.AutoLogin = this.checkBoxAutoLogin.Checked;
            ApplicationSettings.Instance.Save();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
        }

        private void textBoxStatusText_TextChanged(object sender, EventArgs e)
        {
            if(textBoxStatusText.Text.Length != 0)
            {
                buttonPostStatus.Enabled = true;
            }
            else
            {
                buttonPostStatus.Enabled = false;
            }
        }

        private void buttonPostStatus_Click(object sender, EventArgs e)
        {
            m_LoggedInUser.PostStatus(textBoxStatusText.Text);
            MessageBox.Show("Status Posted");
            textBoxStatusText.Clear();
        }

        private void btnStatisics_Click(object sender, EventArgs e)
        {
            FormStatistics statForm = new FormStatistics();
            statForm.Show();
        }

        private void btnStatuses_Click(object sender, EventArgs e)
        {
            FormStatuses statusesForm = new FormStatuses();
            statusesForm.Show();
        }
    }
}
