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
    public partial class AddUserAccount : Form
    {
        public AddUserAccount()
        {
            InitializeComponent();
        }

        private void AddAccount_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LN5IMA1;Initial Catalog=hms_db;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO useraccounts_tbl (firstname, lastname, middlename, age, birthdate, address, contactno, username, password) VALUES('"+tbFname.Text+"', '"+tbLname.Text+ "', '" + tbMname.Text + "', '" + tbAge.Text + "', '" +dateBdate.Value.ToString("MM/dd/yyyy")+ "', '" + tbAddress.Text + "', '" + tbContact.Text + "', '" + tbUser.Text + "', '" + tbPass.Text + "')", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            this.Hide();
        }
    }
}
