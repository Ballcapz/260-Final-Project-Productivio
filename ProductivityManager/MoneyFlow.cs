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
        public MoneyFlow()
        {
            InitializeComponent();
        }

        public void addToSavings(double money)
        {
            string trimmed = (lblSavings.Text as string).Trim('$');

            double SumSavings = Convert.ToDouble(trimmed);
            SumSavings += money;
            lblSavings.Text = string.Format("${0:0,0.00}", SumSavings);

        }

        public void subtractFromSavings(double money)
        {
            string trimmed = (lblSavings.Text as string).Trim('$');

            double SubSavings = Convert.ToDouble(trimmed);
            SubSavings -= money;
            lblSavings.Text = string.Format("${0:0,0.00}", SubSavings);

            if (SubSavings <= 0)
            {
                MessageBox.Show("Your savings is overdrawn!!!");
            }
        }

        private void buttonAddSave_Click(object sender, EventArgs e)
        {
            double money = Convert.ToDouble(savingPMBox.Text);

            addToSavings(money);
        }

        private void buttonSubSave_Click(object sender, EventArgs e)
        {
            double money = Convert.ToDouble(savingPMBox.Text);

            subtractFromSavings(money);
            
        }
    }
}
