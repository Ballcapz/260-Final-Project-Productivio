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
    public partial class TodoItem : UserControl
    {
        public TodoItem()
        {
            InitializeComponent();
        }

        public TodoItem(string text)
        {
            InitializeComponent();
            lbl.Text = text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SqlConnection SQL = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\zjohnson\source\repos\ProductivityManager\ProductivityManager\PdtvioStorage.mdf;Integrated Security=True");
            using (SQL)
            {
                SQL.Open();
                SqlCommand command = new SqlCommand("DELETE FROM TarTab WHERE TargetText = '"+ lbl.Text +"' ", SQL);
                command.ExecuteNonQuery();

                this.BackColor = Color.Blue;
                lbl.Text = "Deleted";
            }
            
        }
    }
}
