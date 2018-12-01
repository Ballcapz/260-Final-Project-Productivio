using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductivityManager
{
    public partial class Productivio : MetroFramework.Forms.MetroForm
    {
        public Productivio()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            float fcpu = pCPU.NextValue();
            float fram = pRAM.NextValue();
            progressBarCPU.Value = (int)fcpu;
            progressBarRAM.Value = (int)fram;
            lblCPU.Text = string.Format("{0:0.00}%", fcpu);
            lblRAM.Text = string.Format("{0:0.00}%", fram);
        }

        private void Productivio_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void buttonTodo_Click(object sender, EventArgs e)
        {
            todolist1.BringToFront();
            // bring to front TodoList tab (userControl)
            // bottom: place to input task and + button
        }

        private void buttonMoney_Click(object sender, EventArgs e)
        {
            moneyFlow1.BringToFront();
            // make new user control that stores money flow with totals in each account
            // IN THAT TAB:: earmark a certain % of the money for travel, saving, school, etc...
            // bring to front on click
            // bottom bar a place to input money amount and +/-

        }

        private void dates_Click(object sender, EventArgs e)
        {
            // make new user control that lets me list important dates/due dates etc...
            // bring to front on click
            eventsPage1.BringToFront();
            // bottom: datepicker??? place to insert date/task going on that day and + button
        }
    }
}
