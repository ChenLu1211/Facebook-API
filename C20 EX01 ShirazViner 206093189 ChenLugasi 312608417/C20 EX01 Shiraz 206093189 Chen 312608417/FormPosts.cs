using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace C20_EX01_Shiraz_206093189_Chen_312608417
{
    public partial class FormPosts : Form
    {
        private User m_LoggedInUser;

        public FormPosts(User i_LoggedInUser = null)
        {
            m_LoggedInUser = i_LoggedInUser;
            InitializeComponent();
            fetchAllPosts();
        }

        private void fetchAllPosts()
        {
            try
            {
                listBoxPosts.Items.Clear();
                if (m_LoggedInUser.Posts.Count == 0)
                {
                    listBoxPosts.Items.Add("Sorry you don`t have any posts yet.");
                }
                else
                {
                    listBoxPosts.DisplayMember = "Message";
                    foreach (Post post in m_LoggedInUser.Posts)
                    {
                        listBoxPosts.Items.Add(post);
                    }
                }
            }
            catch (Exception)
            {
                listBoxPosts.Items.Add("Posts list - Permission error !!!!");
            }
        }
    }
}
