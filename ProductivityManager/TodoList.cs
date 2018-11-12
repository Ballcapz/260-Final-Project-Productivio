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
    public partial class TodoList : UserControl
    {
        public TodoList()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TodoList_Load(object sender, EventArgs e)
        {

            // It needs to show the label, it is not currently
            
            label1.Show();
            label1.ForeColor = Color.Black;
        }
    }
}
