using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using Logic;

namespace C20_Ex02_Shiraz_206093189_Chen_312608417
{
    public partial class FormMatch : Form
    {
        private readonly FacadeMatch r_FacadeToFormMatch;
        private User m_LoggedInUser;

        public FormMatch(User i_LoggedInUser = null)
        {
            m_LoggedInUser = i_LoggedInUser;
            r_FacadeToFormMatch = new FacadeMatch(i_LoggedInUser);
            InitializeComponent();
        }

        private void fetchMatch(eGender i_PanelChoice)
        {
            int lineCounter = 0, top = 10, left = 40;
            List<User> allFriendsToMatch = r_FacadeToFormMatch.GetMatchFriendsList(i_PanelChoice);

            if (allFriendsToMatch.Count == 0)
            {
                MessageBox.Show("No friends in the selected gender");
            }
            else
            {
                foreach (User friend in allFriendsToMatch)
                {
                    Panel userPanel = PanelFactoryMethods.CreatePanel(i_PanelChoice, friend);
                    userPanel.Left = left;
                    userPanel.Top = top;
                    left = userPanel.Right + 30;
                    panelAllMatch.Controls.Add(userPanel);
                    lineCounter++;
                    if (lineCounter % 2 == 0)
                    {
                        left = 30;
                        top = userPanel.Bottom + 10;
                    }
                }
            }
        }

        private void buttonMen_Click(object sender, EventArgs e)
        {
            panelAllMatch.Controls.Clear();
            fetchMatch(eGender.PanelMen);
        }

        private void buttonWomen_Click(object sender, EventArgs e)
        {
            panelAllMatch.Controls.Clear();
            fetchMatch(eGender.PanelWomen);
        }

        private void buttonBisexual_Click(object sender, EventArgs e)
        {
            panelAllMatch.Controls.Clear();
            fetchMatch(eGender.PanelBsexual);
        }
    }
}