using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace C20_Ex02_Shiraz_206093189_Chen_312608417
{
    public partial class FormEvents : Form
    {
        public FormEvents()
        {
            InitializeComponent();
        }

        public void SetDataOnList(List<Event> i_ApprovedEvents)
        {
            eventBindingSource.DataSource = i_ApprovedEvents;
            this.ShowDialog();
        }
    }
}