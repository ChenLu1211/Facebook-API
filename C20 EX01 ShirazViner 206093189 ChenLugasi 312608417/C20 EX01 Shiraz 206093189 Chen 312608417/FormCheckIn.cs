using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace C20_EX01_Shiraz_206093189_Chen_312608417
{
    public partial class FormCheckIn : Form
    {
        private User m_LoggedInUser;

        public FormCheckIn(User i_User = null)
        {
            m_LoggedInUser = i_User;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            fetchCheckins();
        }

        private void fetchCheckins()
        {
            try
            {
                if (m_LoggedInUser.Checkins.Count == 0)
                {
                    listBoxCheckins.Items.Add("No Checkins to show.");
                }
                else
                {
                    foreach(Checkin checkin in m_LoggedInUser.Checkins)
                    {
                        listBoxCheckins.Items.Add(checkin.Place.Name);
                    }
                }
            }
            catch (Exception)
            {
                listBoxCheckins.Items.Add("Checkins list - Permission error !!!!");
            }
        }
    }
}