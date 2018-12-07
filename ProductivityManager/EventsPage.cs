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
using System.Data.SqlClient;

namespace ProductivityManager
{
    public partial class EventsPage : UserControl
    {
        #region Constructor
        public EventsPage()
        {
            InitializeComponent();
            GetEvents();        // to read from the database
            
        }
        #endregion



        #region AddItem Buttons
        // ints to track positioning
        int possSchool = 5;
        int possWork = 5;
        int possLife = 5;
        private void buttonSchool_Click(object sender, EventArgs e)
        {
            SchoolEvent s = new SchoolEvent();
            // if the date is before today terminate the adding of events
            s.EventDate = dateTimePicker1.Value.Date;
            DateTime today = DateTime.Today;
            int result = DateTime.Compare(s.EventDate, today);
            if (result < 0)
            {
                MessageBox.Show("Please Enter a date after today");
                return;
            }


            if (string.IsNullOrWhiteSpace(textBoxGetEvent.Text) )
            {
                MessageBox.Show("Need an Event Name");
                return;
            }
            s.EventName = textBoxGetEvent.Text;
            if (string.IsNullOrWhiteSpace(textBoxRoom.Text))
            {
                s.RoomEventIsIn = "NA";
            }
            else
            {
                s.RoomEventIsIn = textBoxRoom.Text;
            }
            s.TypeOfEvent = 0;

            addItem(s.EventName, s.TypeOfEvent, s.EventDate, s.RoomEventIsIn);
            AddToDB(s.EventName, s.TypeOfEvent, s.EventDate, s.RoomEventIsIn);

            // Alert user to new event
            MessageBox.Show("New School Event Added on " + s.EventDate + " in room " + s.RoomEventIsIn);


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
            DateTime today = DateTime.Today;
            int result = DateTime.Compare(w.EventDate, today);
            if (result < 0)
            {
                MessageBox.Show("Please Enter a date after today");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxGetEvent.Text))
            {
                MessageBox.Show("Need an Event Name");
                return;
            }
            w.EventName = textBoxGetEvent.Text;
            try
            {
                w.MeetingTime = Convert.ToDouble(textBoxTime.Text);
            }
            catch (Exception h)
            {
                MessageBox.Show("Please provide number only for the meeting time ");
                return;
            }
            w.TypeOfEvent = 1;

            addItem(w.EventName, w.TypeOfEvent, w.EventDate, w.MeetingTime.ToString());
            AddToDB(w.EventName, w.TypeOfEvent, w.EventDate, w.MeetingTime.ToString());

            // alert user to new event added
            MessageBox.Show("New Work Event Added on " + w.EventDate + " at " + w.MeetingTime + " o'clock.");


            // clear all textboxes
            textBoxGetEvent.Text = "";
            textBoxLocation.Text = "";
            textBoxTime.Text = "";
            textBoxRoom.Text = "";
        }

        private void buttonLife_Click(object sender, EventArgs e)
        {
            LifeEvent l = new LifeEvent();

            l.EventDate = dateTimePicker1.Value.Date;
            DateTime today = DateTime.Today;
            int result = DateTime.Compare(l.EventDate, today);
            if (result < 0)
            {
                MessageBox.Show("Please Enter a date after today");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxGetEvent.Text))
            {
                MessageBox.Show("Need an Event Name");
                return;
            }
            l.EventName = textBoxGetEvent.Text;
            if (string.IsNullOrWhiteSpace(textBoxGetEvent.Text))
            {
                l.Location = "NO";
            }
            else
            {
                l.Location = textBoxLocation.Text;
            }
            l.TypeOfEvent = 2;

            addItem(l.EventName, l.TypeOfEvent, l.EventDate, l.Location);
            AddToDB(l.EventName, l.TypeOfEvent, l.EventDate, l.Location);

            // alert user to new event addes
            MessageBox.Show("New Life Event Added on " + l.EventDate + " at " + l.Location);


            //clear all textboxes
            textBoxGetEvent.Text = "";
            textBoxLocation.Text = "";
            textBoxTime.Text = "";
            textBoxRoom.Text = "";
        }

        public void addItem(string name, int i, DateTime t, string other)
        {

            DateTime today = DateTime.Today;
            int result = DateTime.Compare(t, today);
            if ( result < 0)
            {
                SqlConnection SQL = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\zjohnson\source\repos\ProductivityManager\ProductivityManager\PdtvioStorage.mdf;Integrated Security=True");
                using (SQL)
                {
                    SQL.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM EventsTab WHERE EventText = '" + name + "' ", SQL);
                    command.ExecuteNonQuery();
                }


                return;     // check if the date has already passed

            }



            EventItem item = new EventItem(name, i, t);

            if (i == 0)
            {
                schoolPanel.Controls.Add(item);
                item.Top = possSchool;
                possSchool = (item.Top + item.Height + 5);

            }
            else if (i == 1)
            {
                // work
                workPanel.Controls.Add(item);
                item.Top = possWork;
                possWork = (item.Top + item.Height + 5);

            }
            else if (i == 2)
            {
                // life
                lifePanel.Controls.Add(item);
                item.Top = possLife;
                possLife = (item.Top + item.Height + 5);
            }



        }

        #endregion

        #region DBGet and Set


        void GetEvents()
        {
            SqlConnection SQL = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\zjohnson\source\repos\ProductivityManager\ProductivityManager\PdtvioStorage.mdf;Integrated Security=True");
            using (SQL)
            {
                SQL.Open();
                SqlCommand commandSchool = new SqlCommand("SELECT * FROM EventsTab WHERE EventID = 0", SQL);
                SqlCommand commandWork = new SqlCommand("SELECT * FROM EventsTab WHERE EventID = 1", SQL);
                SqlCommand commandLife = new SqlCommand("SELECT * FROM EventsTab WHERE EventID = 2", SQL);

                using (SqlDataReader reader = commandSchool.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        addItem("" + reader["EventText"], (int)reader["EventID"], (DateTime)reader["EventDate"], (string)reader["EventOther"]);

                    }
                }
                using (SqlDataReader reader = commandWork.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        addItem("" + reader["EventText"], (int)reader["EventID"], (DateTime)reader["EventDate"], (string)reader["EventOther"]);


                    }
                }
                using (SqlDataReader reader = commandLife.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        addItem("" + reader["EventText"], (int)reader["EventID"], (DateTime)reader["EventDate"], (string)reader["EventOther"]);


                    }
                }

            }
        }


        public void AddToDB(string insert, int type, DateTime date, string other)
        {
            SqlConnection SQL = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\zjohnson\source\repos\ProductivityManager\ProductivityManager\PdtvioStorage.mdf;Integrated Security=True");


            using (SQL)
            {
                try
                {
                    SQL.Open();
                    SqlCommand commandSec = new SqlCommand("INSERT INTO EventsTab (EventText, EventID, EventDate, EventOther) VALUES ('" + insert + "', '" + type + "', '" + date + "', '" + other + "' )", SQL);
                    commandSec.ExecuteNonQuery();
                }
                catch (Exception h)
                {
                    MessageBox.Show("That event is already added");
                    return;
                }
                
            }

        }

        


        #endregion

        #region OnPageLoad
        private void EventsPage_Load(object sender, EventArgs e)
        {
            DateTime result = DateTime.Today.Add(TimeSpan.FromDays(1));
            dateTimePicker1.Value = result;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime result = dateTimePicker1.Value;
            
        }

        #endregion
    }
}
