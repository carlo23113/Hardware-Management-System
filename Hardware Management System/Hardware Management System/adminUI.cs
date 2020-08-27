using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hardware_Management_System
{
    public partial class adminUI : Form
    {
        public adminUI()
        {
            InitializeComponent();
            sidePanel.Height = btnHome.Height;
            sidePanel.Top = btnHome.Top;
            home1.BringToFront();
        }


        private void btnHome_Click_1(object sender, EventArgs e)
        {
            home1.BringToFront();
            sidePanel.Height = btnHome.Height;
            sidePanel.Top = btnHome.Top;
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            inventory1.BringToFront();
            sidePanel.Height = btnInventory.Height;
            sidePanel.Top = btnInventory.Top;
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            salesreport1.BringToFront();
            sidePanel.Height = btnSalesReport.Height;
            sidePanel.Top = btnSalesReport.Top;
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            manageAccounts1.BringToFront();
            sidePanel.Height = btnAccounts.Height;
            sidePanel.Top = btnAccounts.Top;
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            suppliers1.BringToFront();
            sidePanel.Height = btnSuppliers.Height;
            sidePanel.Top = btnSuppliers.Top;
        }

        private void btnDevInfo_Click(object sender, EventArgs e)
        {
            developersInfo1.BringToFront();
            sidePanel.Height = btnDevInfo.Height;
            sidePanel.Top = btnDevInfo.Top;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminlogin admin = new adminlogin();
            admin.Show();
        }
    }
}
