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
    public partial class MoneyFlow : UserControl
    {
        #region constructor
        public MoneyFlow()
        {
            InitializeComponent();
            GetValues();
            // set the total value
            string trim1 = (lblChecking.Text as string).Trim('$');
            string trim2 = (lblSavings.Text as string).Trim('$');
            double TotalMoney = (Convert.ToDouble(trim1)) + (Convert.ToDouble(trim2));
            lblTotal.Text = string.Format("${0:0,0.00}", TotalMoney);
        }
        #endregion

        #region AddAndSubtractFromAccounts
        public void addToSavings(double money)
        {
            // Update the savings account value
            string trimmed = (lblSavings.Text as string).Trim('$');
            double SumSavings = Convert.ToDouble(trimmed);
            SumSavings += money;
            lblSavings.Text = string.Format("${0:0,0.00}", SumSavings);

            // Update the total value too
            string trimmed2 = (lblTotal.Text as string).Trim('$');
            double NewTotal = Convert.ToDouble(trimmed2);
            NewTotal += money;
            lblTotal.Text = string.Format("${0:0,0.00}", NewTotal);


        }

        public void subtractFromSavings(double money)
        {
            // update the savings account val
            string trimmed = (lblSavings.Text as string).Trim('$');
            double SubSavings = Convert.ToDouble(trimmed);
            SubSavings -= money;
            lblSavings.Text = string.Format("${0:0,0.00}", SubSavings);
            // update the total val too
            string trimmed2 = (lblTotal.Text as string).Trim('$');
            double NewTotal = Convert.ToDouble(trimmed2);
            NewTotal -= money;
            lblTotal.Text = string.Format("${0:0,0.00}", NewTotal);

            if (SubSavings <= 0)
            {
                MessageBox.Show("Your savings is overdrawn!!!");
            }
        }

        public void addToChecking(double money)
        {
            // update the checking account val
            string trimmed = (lblChecking.Text as string).Trim('$');
            double SumChecking = Convert.ToDouble(trimmed);
            SumChecking += money;
            lblChecking.Text = string.Format("${0:0,0.00}", SumChecking);
            
            // update the total val too
            string trimmed2 = (lblTotal.Text as string).Trim('$');
            double NewTotal = Convert.ToDouble(trimmed2);
            NewTotal += money;
            lblTotal.Text = string.Format("${0:0,0.00}", NewTotal);
        }

        public void subtractFromChecking(double money)
        {
            // update the checking account val
            string trimmed = (lblChecking.Text as string).Trim('$');
            double SubChecking = Convert.ToDouble(trimmed);
            SubChecking -= money;
            lblChecking.Text = string.Format("${0:0,0.00}", SubChecking);
            
            //update the total money amount too
            string trimmed2 = (lblTotal.Text as string).Trim('$');
            double NewTotal = Convert.ToDouble(trimmed2);
            NewTotal -= money;
            lblTotal.Text = string.Format("${0:0,0.00}", NewTotal);

            if (SubChecking <= 0)
            {
                MessageBox.Show("Your checking account is overdrawn!!!");
            }
        }

       

        #endregion

        #region ButtonClicks
        private void buttonAddSave_Click(object sender, EventArgs e)
        {
            double money = Convert.ToDouble(savingPMBox.Text);

            addToSavings(money);
            AddSavingToDB(lblSavings.Text.TrimStart('$'));
            AddCheckingToDB(lblChecking.Text.TrimStart('$'));
            AddTotalToDB(lblTotal.Text.TrimStart('$'));
            savingPMBox.Text = "";
        }

        private void buttonSubSave_Click(object sender, EventArgs e)
        {
            double money = Convert.ToDouble(savingPMBox.Text);

            subtractFromSavings(money);
            AddSavingToDB(lblSavings.Text.TrimStart('$'));
            AddCheckingToDB(lblChecking.Text.TrimStart('$'));
            AddTotalToDB(lblTotal.Text.TrimStart('$'));
            savingPMBox.Text = "";


        }

        private void buttonAddCheck_Click(object sender, EventArgs e)
        {
            double money = Convert.ToDouble(checkingPMBox.Text);

            addToChecking(money);
            AddSavingToDB(lblSavings.Text.TrimStart('$'));
            AddCheckingToDB(lblChecking.Text.TrimStart('$'));
            AddTotalToDB(lblTotal.Text.TrimStart('$'));
            checkingPMBox.Text = "";
        }

        private void buttonSubCheck_Click(object sender, EventArgs e)
        {
            double money = Convert.ToDouble(checkingPMBox.Text);

            subtractFromChecking(money);
            AddSavingToDB(lblSavings.Text.TrimStart('$'));
            AddCheckingToDB(lblChecking.Text.TrimStart('$'));
            AddTotalToDB(lblTotal.Text.TrimStart('$'));
            checkingPMBox.Text = "";

        }

        private void buttonToCheck_Click(object sender, EventArgs e)
        {
            // Transfer val in savingTransfer to checking account
            double money = Convert.ToDouble(savingTransfer.Text);
            addToChecking(money);
            subtractFromSavings(money);
            AddSavingToDB(lblSavings.Text.TrimStart('$'));
            AddCheckingToDB(lblChecking.Text.TrimStart('$'));
            AddTotalToDB(lblTotal.Text.TrimStart('$'));
            savingTransfer.Text = "";
        }

        private void buttonToSave_Click(object sender, EventArgs e)
        {
            // Transfer val in checkingTransfer to checking account
            double money = Convert.ToDouble(checkingTransfer.Text);
            addToSavings(money);
            subtractFromChecking(money);
            AddSavingToDB(lblSavings.Text.TrimStart('$'));
            AddCheckingToDB(lblChecking.Text.TrimStart('$'));
            AddTotalToDB(lblTotal.Text.TrimStart('$'));
            checkingTransfer.Text = "";
        }

        #endregion

        #region Set Labels
        public void setSavings(string money)
        {
            double m = Convert.ToDouble(money);

            lblSavings.Text = string.Format("${0:0,0.00}", m);
        }

        public void setChecking(string money)
        {
            double m = Convert.ToDouble(money);

            lblChecking.Text = string.Format("${0:0,0.00}", m);
        }

        public void setTotal(string money)
        {
            double m = Convert.ToDouble(money);

            lblTotal.Text = string.Format("${0:0,0.00}", m);
        }

        #endregion
        #region Database Get and Set
        void GetValues()
        {
            SqlConnection SQL = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\zjohnson\source\repos\ProductivityManager\ProductivityManager\PdtvioStorage.mdf;Integrated Security=True");
            using (SQL)
            {
                SQL.Open();
                SqlCommand commandSave = new SqlCommand("SELECT Saving FROM MoneyTab WHERE Id = 1", SQL);
                SqlCommand commandCheck = new SqlCommand("SELECT Checking FROM MoneyTab WHERE Id = 2", SQL);
                SqlCommand commandTotal = new SqlCommand("SELECT Total FROM MoneyTab WHERE Id = 3", SQL);

                using (SqlDataReader reader = commandSave.ExecuteReader())
                {
                    
                    while (reader.Read())
                    {
                        setSavings("" + reader["Saving"]);
                        
                    }
                }
                using (SqlDataReader reader = commandCheck.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        setChecking("" + reader["Checking"]);

                    }
                }
                using (SqlDataReader reader = commandTotal.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        setTotal("" + reader["Total"]);

                    }
                }

            }
        }


        public void AddSavingToDB(string insert)
        {
            SqlConnection SQL = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\zjohnson\source\repos\ProductivityManager\ProductivityManager\PdtvioStorage.mdf;Integrated Security=True");

            using (SQL)
            {
                SQL.Open();
                SqlCommand commandSec = new SqlCommand("UPDATE MoneyTab SET Saving = @s WHERE Id = @i", SQL);
                commandSec.Parameters.AddWithValue("@s", insert);
                commandSec.Parameters.AddWithValue("@i", 1);
                commandSec.ExecuteNonQuery();
            }

        }

        public void AddCheckingToDB(string insert)
        {
            SqlConnection SQL = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\zjohnson\source\repos\ProductivityManager\ProductivityManager\PdtvioStorage.mdf;Integrated Security=True");

            using (SQL)
            {
                SQL.Open();
                SqlCommand commandSec = new SqlCommand("UPDATE MoneyTab SET Checking = @c WHERE Id = @i", SQL);
                commandSec.Parameters.AddWithValue("@c", insert);
                commandSec.Parameters.AddWithValue("@i", 2);
                commandSec.ExecuteNonQuery();
            }

        }

        public void AddTotalToDB(string insert)
        {
            SqlConnection SQL = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\zjohnson\source\repos\ProductivityManager\ProductivityManager\PdtvioStorage.mdf;Integrated Security=True");

            using (SQL)
            {
                SQL.Open();
                SqlCommand commandSec = new SqlCommand("UPDATE MoneyTab SET Total = @t WHERE Id = @i", SQL);
                commandSec.Parameters.AddWithValue("@t", insert);
                commandSec.Parameters.AddWithValue("@i", 3);
                commandSec.ExecuteNonQuery();
            }

        }
        #endregion
    }
}
