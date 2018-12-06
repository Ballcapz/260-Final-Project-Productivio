using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductivityManager
{
    public partial class EventItem : UserControl
    {
        public EventItem()
        {
            InitializeComponent();
        }

        public EventItem(string text, int type, DateTime date)
        {
            InitializeComponent();
            lblEvent.Text = text;
            // type 0 is schoo, 1 is work, 2 is life
            lblDate.Text = Convert.ToString(date);
        }
    }
}
