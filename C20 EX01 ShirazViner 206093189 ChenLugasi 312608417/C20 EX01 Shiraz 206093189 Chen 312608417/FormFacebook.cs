using System.Threading;
using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace C20_EX01_Shiraz_206093189_Chen_312608417
{
    public partial class FormFacebook : Form
    {
        private User m_LoggedInUser;
        private AppSettings m_AppSettings;
        private FormFriends m_FormFriends;
        private FormAlbums m_FormAlbums;
        private FormMostLikely m_FormMostLikelyItems;
        private FormCheckIn m_FormCheckIn;
        private FormBirthDay m_FormBirthday;
        private FormLogin m_FormLogIn;
        private FormCorona m_FormCorona;
        private FormPosts m_FormPosts;
        private FormGroups m_FormGroups;
        private FormEvents m_FormEvents;

        public FormFacebook()
        {
            if(!checkIfUserExists())
            {
                initSetting();
            }

            m_AppSettings.SaveToFile();
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 200;
            FacebookWrapper.FacebookService.s_FbApiVersion = 2.8f;
        }

        private void initSetting()
        {
            m_AppSettings = new AppSettings();
            m_FormLogIn = new FormLogin();
            m_FormLogIn.ShowDialog();
            if (m_FormLogIn.DialogResult == DialogResult.Cancel)
            {
                MessageBox.Show("Sorry you must login to use our application bye bye.");
                Environment.Exit(0);
            }

            m_LoggedInUser = m_FormLogIn.LoggedInUser;
            if(m_LoggedInUser == null)
            {
                MessageBox.Show("Unseccess login, try again next time");
                Environment.Exit(0);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (m_FormLogIn != null)
            {
                m_AppSettings.RememberUser = m_FormLogIn.RememberMe;
                if (m_AppSettings.RememberUser)
                {
                    m_AppSettings.LastAccessToken = m_FormLogIn.FormLoginResult.AccessToken;
                }
            }

            m_AppSettings.SaveToFile();
        }

        private bool checkIfUserExists()
        {
            bool v_IfRememberUser = false;

            m_AppSettings = AppSettings.LoadFromFile();
            if (m_AppSettings.RememberUser && !string.IsNullOrEmpty(m_AppSettings.LastAccessToken))
            {
                v_IfRememberUser = true;
                m_LoggedInUser = FacebookService.Connect(m_AppSettings.LastAccessToken).LoggedInUser;
            }

            return v_IfRememberUser;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            new Thread(firstInitPart).Start();
            new Thread(secondInitPart).Start();
            new Thread(thirdInitPart).Start();
            fetchUserInfo();
        }

        private void fetchUserInfo()
        {
            labelName.Text = string.Concat(labelName.Text, m_LoggedInUser.Name);
            labelBirthday.Text = string.Concat(labelBirthday.Text, m_LoggedInUser.Birthday);
            labelGender.Text = string.Concat(labelGender.Text, m_LoggedInUser.Gender);
            pictureBoxProfilePic.LoadAsync(m_LoggedInUser.PictureNormalURL);
            labelLogInName.Text = string.Format("Hello, {0}", m_LoggedInUser.Name);
        }

        private void firstInitPart()
        {
            m_FormPosts = new FormPosts(m_LoggedInUser);
            m_FormFriends = new FormFriends(m_LoggedInUser);
            m_FormAlbums = new FormAlbums(m_LoggedInUser);
        }

        private void thirdInitPart()
        {
            m_FormCorona = new FormCorona(m_LoggedInUser);
            m_FormGroups = new FormGroups(m_LoggedInUser);
            m_FormEvents = new FormEvents(m_LoggedInUser);
        }

        private void secondInitPart()
        {
            m_FormMostLikelyItems = new FormMostLikely(m_LoggedInUser);
            m_FormCheckIn = new FormCheckIn(m_LoggedInUser);
            m_FormBirthday = new FormBirthDay(m_LoggedInUser);
        }

        private void pictureBoxFriends_Click(object sender, EventArgs e)
        {
            if (m_FormFriends != null)
            {
                m_FormFriends.ShowDialog();
            }
        }

        private void pictureBoxAlbums_Click(object sender, EventArgs e)
        {
            if (m_FormAlbums != null)
            {
                m_FormAlbums.ShowDialog();
            }
        }

        private void pictureBoxPost_Click(object sender, EventArgs e)
        {
            postStatus();
        }

        private void postStatus()
        {
            try
            {
                this.m_LoggedInUser.PostStatus(textBoxPost.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Posting Permission error !!!!");
                textBoxPost.Clear();
            }
        }

        private void pictureBoxUpload_Click(object sender, EventArgs e)
        {
            try
            {
                string pictureUrl;

                openFileUploadPicture.InitialDirectory = "c:\\";
                openFileUploadPicture.Filter = "*.png|*.jpg|*.jpeg|*.gif";
                openFileUploadPicture.ShowDialog();
                pictureUrl = openFileUploadPicture.FileName;
                m_LoggedInUser.PostPhoto(pictureUrl, textBoxPost.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Posting picture permission error !!!!");
            }
        }

        private void pictureBoxProfile_Click(object sender, EventArgs e)
        {
            if (m_FormMostLikelyItems != null)
            {
                m_FormMostLikelyItems.ShowDialog();
            }
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            FacebookService.Logout(new Action(onLogOut));
        }

        private void onLogOut()
        {
            m_AppSettings.LastAccessToken = null;
            m_AppSettings.RememberUser = false;
            m_AppSettings.SaveToFile();
            MessageBox.Show("Thank you for using our facebook, bye bye.");
            this.Close();
        }

        private void pictureBoxMyPosts_Click(object sender, EventArgs e)
        {
            if (m_FormPosts != null)
            {
                m_FormPosts.ShowDialog();
            }
        }

        private void pictureBoxGroups_Click(object sender, EventArgs e)
        {
            if (m_FormGroups != null)
            {
                m_FormGroups.ShowDialog();
            }
        }

        private void pictureBoxCheckin_Click(object sender, EventArgs e)
        {
            if (m_FormCheckIn != null)
            {
                m_FormCheckIn.ShowDialog();
            }
        }

        private void pictureBoxEvents_Click(object sender, EventArgs e)
        {
            if (m_FormEvents != null)
            {
                m_FormEvents.ShowDialog();
            }
        }

        private void pictureBoxCorona_Click(object sender, EventArgs e)
        {
            if (m_FormCorona != null)
            {
                m_FormCorona.ShowDialog();
            }
        }

        private void pictureBoxBirthday_Click(object sender, EventArgs e)
        {
            if (m_FormBirthday != null)
            {
                m_FormBirthday.ShowDialog();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
