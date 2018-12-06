using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProductivityManager.AllEvents;

namespace ProductivityManager
{
    public partial class EventsPage : UserControl
    {
        public EventsPage()
        {
            InitializeComponent();
        }

        int possSchool = 10;
        int possWork = 10;
        int possLife = 10;

        private void buttonSchool_Click(object sender, EventArgs e)
        {
            SchoolEvent s = new SchoolEvent();
            s.EventDate = dateTimePicker1.Value.Date;
            s.EventName = textBoxGetEvent.Text;
            s.RoomEventIsIn = textBoxRoom.Text;
            s.TypeOfEvent = 0;
            MessageBox.Show("New School Event Added");

            

            EventItem item = new EventItem(s.EventName, s.TypeOfEvent, s.EventDate);
            schoolPanel.Controls.Add(item);
            item.Top = possSchool;
            possSchool = (item.Top + item.Height + 10);



            // clear all textboxes
            textBoxGetEvent.Text = "";
            textBoxLocation.Text = "";
            textBoxTime.Text = "";
            textBoxRoom.Text = "";
        }

        private void buttonWork_Click(object sender, EventArgs e)
        {
            WorkEvent w = new WorkEvent();
            w.EventDate = dateTimePicker1.Value.Date;
            w.EventName = textBoxGetEvent.Text;
            w.MeetingTime = Convert.ToDouble(textBoxTime.Text);
            w.TypeOfEvent = 1;
            MessageBox.Show("New work Event Added");

            EventItem item = new EventItem(w.EventName, w.TypeOfEvent, w.EventDate);
            workPanel.Controls.Add(item);
            item.Top = possWork;
            possWork = (item.Top + item.Height + 10);

            textBoxGetEvent.Text = "";
            textBoxLocation.Text = "";
            textBoxTime.Text = "";
            textBoxRoom.Text = "";
        }

        private void buttonLife_Click(object sender, EventArgs e)
        {
            LifeEvent l = new LifeEvent();
            l.EventDate = dateTimePicker1.Value.Date;
            l.EventName = textBoxGetEvent.Text;
            l.Location = textBoxLocation.Text;
            l.TypeOfEvent = 2;
            MessageBox.Show("New Life Event Added");

            EventItem item = new EventItem(l.EventName, l.TypeOfEvent, l.EventDate);
            lifePanel.Controls.Add(item);
            item.Top = possLife;
            possLife = (item.Top + item.Height + 10);


            textBoxGetEvent.Text = "";
            textBoxLocation.Text = "";
            textBoxTime.Text = "";
            textBoxRoom.Text = "";
        }

        private void EventsPage_Load(object sender, EventArgs e)
        {
            DateTime result = DateTime.Today.Subtract(TimeSpan.FromDays(1));
            dateTimePicker1.Value = result;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime result = dateTimePicker1.Value;
            
        }
    }
}
