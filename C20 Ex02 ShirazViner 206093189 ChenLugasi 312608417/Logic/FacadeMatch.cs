using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace Logic
{
    public class FacadeMatch
    {
        private User m_LoggedInUser;
        private List<User> m_UserFriens;
        private List<User> m_MatchList;
        private ProxyFriends m_ProxyData;

        public List<User> GetMatchFriendsList(eGender i_PanelChoice)
        {
            m_UserFriens = m_ProxyData.GetUserListByGender(i_PanelChoice);
            findMatches();
            return m_MatchList;
        }

        public FacadeMatch(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
            m_MatchList = new List<User>();
            m_ProxyData = new ProxyFriends(m_LoggedInUser);
        }

        private void findMatches()
        {
            eZodiac userZodiac;
            eZodiac friendZodiac;

            try
            {
                userZodiac = ZodiacData.GetZodiac(m_LoggedInUser.Birthday);

                foreach (User friendToMatch in m_UserFriens)
                {
                    friendZodiac = ZodiacData.GetZodiac(friendToMatch.Birthday);

                    if(friendZodiac == userZodiac || (userZodiac != eZodiac.Pisces && friendZodiac == userZodiac + 1)
                                                  || (userZodiac != eZodiac.Aries && friendZodiac == userZodiac - 1))
                    {
                        m_MatchList.Add(friendToMatch);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry, No matches found.");
            }
        }
    }
}