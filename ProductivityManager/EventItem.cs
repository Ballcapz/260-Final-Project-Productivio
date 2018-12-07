using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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

        private void lblEvent_Click(object sender, EventArgs e)
        {
            SqlConnection SQL = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\zjohnson\source\repos\ProductivityManager\ProductivityManager\PdtvioStorage.mdf;Integrated Security=True");
            using (SQL)
            {
                SQL.Open();
                SqlCommand command = new SqlCommand("DELETE FROM EventsTab WHERE EventText = '" + lblEvent.Text + "' ", SQL);
                command.ExecuteNonQuery();

                this.BackColor = Color.PaleGreen;
                lblEvent.Text = "";
                lblDate.Text = "";
            }

        }
    }
}
