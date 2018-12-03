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
    public partial class Todolist : UserControl
    {
        public Todolist()
        {
            InitializeComponent();
            GetTargets();
            
        }

        int poss = 10;

        public void addItem(string text)
        {
            TodoItem item = new TodoItem(text);
            panelTodo.Controls.Add(item);
            item.Top = poss;
            poss = (item.Top + item.Height + 10);

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string tarName = todoListEntryBox.Text;
            addItem(tarName);
            AddTargets(tarName);
            todoListEntryBox.Text = "";
        }



        void GetTargets()
        {
            SqlConnection SQL = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\zjohnson\source\repos\ProductivityManager\ProductivityManager\PdtvioStorage.mdf;Integrated Security=True");
            using (SQL)
            {
                SQL.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM TarTab WHERE TargetID = 1", SQL);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        addItem("" + reader["TargetText"]);
                    }
                }
            }
        }


        public void AddTargets(string insert)
        {
            SqlConnection SQL = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\zjohnson\source\repos\ProductivityManager\ProductivityManager\PdtvioStorage.mdf;Integrated Security=True");

            using (SQL)
            {
                SQL.Open();
                SqlCommand commandSec = new SqlCommand("INSERT INTO TarTab (TargetText, TargetID) VALUES ('"+ insert +"', '1')", SQL);
                commandSec.ExecuteNonQuery();
            }

        }








    }
}
