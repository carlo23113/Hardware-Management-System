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

namespace Hardware_Management_System
{
    public partial class ManageAccounts : UserControl
    {
        public ManageAccounts()
        {
            InitializeComponent();
            userAccounts1.BringToFront();
        }

        private void ManageAccounts_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            userAccounts1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminAccounts1.BringToFront();
        }
    }
}
