﻿using System.Drawing;
using FacebookWrapper.ObjectModel;

namespace C20_Ex02_Shiraz_206093189_Chen_312608417
{
    public class PanelBisexual : PanelToUser
    {
        public PanelBisexual(User i_User) : base(i_User)
        {
        }

        public override void SetColorsDesign()
        {
            this.BackColor = Color.DeepPink;
            UserName.ForeColor = Age.ForeColor = Color.PowderBlue;
        }
    }
}
