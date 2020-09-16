using System;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace C20_Ex02_Shiraz_206093189_Chen_312608417
{
    public partial class FormPosts : Form
    {
        private User m_LoggedInUser;

        public FormPosts(User i_LoggedInUser = null)
        {
            m_LoggedInUser = i_LoggedInUser;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            new Thread(fetchAllPosts).Start();
        }

        private void fetchAllPosts()
        {
            try
            {
                listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Clear()));
                if (m_LoggedInUser.Posts.Count == 0)
                {
                    listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add("Sorry you don`t have any posts yet.")));
                }
                else
                {
                    listBoxPosts.Invoke(new Action(() => listBoxPosts.DisplayMember = "Message"));
                    foreach (Post post in m_LoggedInUser.Posts)
                    {
                        listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post)));
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Posts list - Permission error !!!!");
            }
        }
    }
}