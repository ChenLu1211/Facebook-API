using System;
using System.Windows.Forms;
using System.Threading;
using FacebookWrapper.ObjectModel;

namespace C20_Ex02_Shiraz_206093189_Chen_312608417
{
    public partial class FormAlbums : Form
    {
        private User m_LoggedInUser;

        public FormAlbums(User i_LoggesInUser = null)
        {
            m_LoggedInUser = i_LoggesInUser;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            new Thread(fetchAlbums).Start();
        }

        private void fetchAlbums()
        {
            try
            {
                listBoxAlbums.Invoke(new Action(() => listBoxAlbums.Items.Clear()));
                listBoxAlbums.Invoke(new Action(() => listBoxAlbums.DisplayMember = "Name"));
                if (m_LoggedInUser.Albums.Count == 0)
                {
                    listBoxAlbums.Invoke(new Action(() => listBoxAlbums.Items.Add("No Albums to retrieve.")));
                }
                else
                {
                    foreach (Album album in m_LoggedInUser.Albums)
                    {
                        listBoxAlbums.Invoke(new Action(() => listBoxAlbums.Items.Add(album)));
                    }
                }
            }
            catch (Exception)
            {
                listBoxAlbums.Invoke(new Action(() => listBoxAlbums.Items.Add("Permission error !!!!")));
            }
        }
    }
}