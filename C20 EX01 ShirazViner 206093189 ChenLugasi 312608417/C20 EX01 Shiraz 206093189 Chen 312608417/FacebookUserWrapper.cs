using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace C20_EX01_Shiraz_206093189_Chen_312608417
{
    public class FacebookUserWrapper
    {
        public User UserWrapper
        {
            get;
            set;
        }

        public int Counter
        {
            get;
            set;
        }

        public FacebookUserWrapper(User i_User)
        {
            UserWrapper = i_User;
            Counter = 0;
        }
    }
}
