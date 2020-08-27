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
    public partial class UserAccounts : UserControl
    {

        string connectionString = @"Data Source=DESKTOP-LN5IMA1;Initial Catalog=hms_db;Integrated Security=True";

        public UserAccounts()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserAccounts_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select ID, concat(firstname,' ',middlename,' ',lastname) as fullname, age, birthdate, address, contactno, username, password from useraccounts_tbl", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dt.Columns[0].ColumnName = "ID";
                dt.Columns[1].ColumnName = "Fullname";
                dt.Columns[2].ColumnName = "Age";
                dt.Columns[3].ColumnName = "Birthdate";
                dt.Columns[4].ColumnName = "Address";
                dt.Columns[5].ColumnName = "Contact No.";
                dt.Columns[6].ColumnName = "Username";
                dt.Columns[7].ColumnName = "Password";

                dgvUsers.DataSource = dt;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUserAccount user = new AddUserAccount();
            user.Show();
        }
    }
}
