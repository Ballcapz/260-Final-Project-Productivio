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
    public partial class MoneyFlow : UserControl
    {
        #region constructor
        public MoneyFlow()
        {
            InitializeComponent();
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
            savingPMBox.Text = "";
        }

        private void buttonSubSave_Click(object sender, EventArgs e)
        {
            double money = Convert.ToDouble(savingPMBox.Text);

            subtractFromSavings(money);
            savingPMBox.Text = "";


        }

        private void buttonAddCheck_Click(object sender, EventArgs e)
        {
            double money = Convert.ToDouble(checkingPMBox.Text);

            addToChecking(money);
            checkingPMBox.Text = "";
        }

        private void buttonSubCheck_Click(object sender, EventArgs e)
        {
            double money = Convert.ToDouble(checkingPMBox.Text);

            subtractFromChecking(money);
            checkingPMBox.Text = "";

        }

        private void buttonToCheck_Click(object sender, EventArgs e)
        {
            // Transfer val in savingTransfer to checking account
            double money = Convert.ToDouble(savingTransfer.Text);
            addToChecking(money);
            subtractFromSavings(money);
            savingTransfer.Text = "";
        }

        private void buttonToSave_Click(object sender, EventArgs e)
        {
            // Transfer val in checkingTransfer to checking account
            double money = Convert.ToDouble(checkingTransfer.Text);
            addToSavings(money);
            subtractFromChecking(money);
            checkingTransfer.Text = "";
        }

        #endregion


    }
}
