using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hardware_Management_System
{
    public partial class userlogin : Form
    {
        public userlogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LN5IMA1;Initial Catalog=hms_db;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from useraccounts_tbl where username='" +tbUser.Text+"' and password = '"+tbPass.Text +"'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                userUI user = new userUI();
                user.Show();
            }
            else { 
                MessageBox.Show("Invalid username or password");

        }

    }

        private void btnAdminlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminlogin f2 = new adminlogin();
            f2.Show();
        }
    }
}
