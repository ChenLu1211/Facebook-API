using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace C20_Ex02_Shiraz_206093189_Chen_312608417
{
    public partial class FormGroups : Form
    {
        private User m_LoggedInUser;

        public FormGroups(User i_LoggedInUser = null)
        {
            m_LoggedInUser = i_LoggedInUser;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            fetchGroups();
        }

        private void fetchGroups()
        {
            try
            {
                groupBindingSource.DataSource = m_LoggedInUser.Groups;
                if (groupBindingSource.Count == 0)
                {
                    MessageBox.Show("Empty group list");
                }
            }
            catch (Exception)
            {
                listBoxGroups.Items.Add("Groups list - permission error !!!!");
            }
        }
    }
}
