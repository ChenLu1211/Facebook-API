using System;
using System.Windows.Forms;
using System.Threading;
using FacebookWrapper.ObjectModel;

namespace C20_Ex02_Shiraz_206093189_Chen_312608417
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
            new Thread(fetchCheckins).Start();
        }

        private void fetchCheckins()
        {
            try
            {
                if (m_LoggedInUser.Checkins.Count == 0)
                {
                    listBoxCheckins.Invoke(new Action(() => listBoxCheckins.Items.Add("No Checkins to show.")));
                }
                else
                {
                    listBoxCheckins.Invoke(new Action(() => listBoxCheckins.DisplayMember = "Name"));

                    foreach (Checkin checkin in m_LoggedInUser.Checkins)
                    {
                        listBoxCheckins.Invoke(new Action(() => listBoxCheckins.Items.Add(checkin.Place)));
                    }
                }
            }
            catch (Exception)
            {
                listBoxCheckins.Invoke(new Action(() => listBoxCheckins.Items.Add("Checkins list - Permission error !!!!")));
            }
        }
    }
}