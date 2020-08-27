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
    public partial class adminlogin : Form
    {
        public adminlogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LN5IMA1;Initial Catalog=hms_db;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from adminaccounts_tbl where username='" + tbUser.Text + "' and password='" + tbPass.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                /* I have made a new page called home page. If the user is successfully authenticated then the form will be moved to the next form */
                this.Hide();
                adminUI admin = new adminUI();
                admin.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password");

            }
        }

        private void btnUserlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            userlogin f1 = new userlogin();
            f1.Show();
        }
    }
}
