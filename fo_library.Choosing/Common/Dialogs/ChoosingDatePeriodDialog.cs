using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fo_library.Choosing.Common
{
    public partial class ChoosingDatePeriodDialog : Form
    {
        public ChoosingDatePeriodDialog()
        {
            InitializeComponent();
            StartPeriod = monthCalendar1.SelectionStart;
            EndPeriod = monthCalendar1.SelectionEnd;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            StartPeriod = e.Start;
            EndPeriod = e.End;
        }



        public DateTime StartPeriod
        {
            get;
            private set;
        }

        public DateTime EndPeriod
        {
            get;
            private set;
        }

    }
}
