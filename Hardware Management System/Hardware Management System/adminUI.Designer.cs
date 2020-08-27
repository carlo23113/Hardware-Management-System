namespace Hardware_Management_System
{
    partial class adminUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDevInfo = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnAccounts = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnSalesReport = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.developersInfo1 = new Hardware_Management_System.DevelopersInfo();
            this.suppliers1 = new Hardware_Management_System.Suppliers();
            this.manageAccounts1 = new Hardware_Management_System.ManageAccounts();
            this.inventory1 = new Hardware_Management_System.Inventory();
            this.salesreport1 = new Hardware_Management_System.Salesreport();
            this.home1 = new Hardware_Management_System.Home();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 41);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "SUNGLAO CONSTRUCTION SUPPLY";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.btnDevInfo);
            this.panel2.Controls.Add(this.btnSuppliers);
            this.panel2.Controls.Add(this.btnAccounts);
            this.panel2.Controls.Add(this.btnInventory);
            this.panel2.Controls.Add(this.btnSalesReport);
            this.panel2.Controls.Add(this.sidePanel);
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 485);
            this.panel2.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout.Location = new System.Drawing.Point(12, 360);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(193, 60);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnDevInfo
            // 
            this.btnDevInfo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDevInfo.FlatAppearance.BorderSize = 0;
            this.btnDevInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDevInfo.Location = new System.Drawing.Point(12, 300);
            this.btnDevInfo.Name = "btnDevInfo";
            this.btnDevInfo.Size = new System.Drawing.Size(193, 60);
            this.btnDevInfo.TabIndex = 8;
            this.btnDevInfo.Text = "DEVELOPER INFO";
            this.btnDevInfo.UseVisualStyleBackColor = true;
            this.btnDevInfo.Click += new System.EventHandler(this.btnDevInfo_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSuppliers.FlatAppearance.BorderSize = 0;
            this.btnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuppliers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSuppliers.Location = new System.Drawing.Point(12, 240);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(193, 60);
            this.btnSuppliers.TabIndex = 7;
            this.btnSuppliers.Text = "SUPPLIERS";
            this.btnSuppliers.UseVisualStyleBackColor = true;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // btnAccounts
            // 
            this.btnAccounts.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAccounts.FlatAppearance.BorderSize = 0;
            this.btnAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccounts.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAccounts.Location = new System.Drawing.Point(12, 180);
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.Size = new System.Drawing.Size(193, 60);
            this.btnAccounts.TabIndex = 6;
            this.btnAccounts.Text = "MANAGE ACCOUNTS";
            this.btnAccounts.UseVisualStyleBackColor = true;
            this.btnAccounts.Click += new System.EventHandler(this.btnAccounts_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInventory.Location = new System.Drawing.Point(12, 120);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(193, 60);
            this.btnInventory.TabIndex = 5;
            this.btnInventory.Text = "INVENTORY";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalesReport.FlatAppearance.BorderSize = 0;
            this.btnSalesReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesReport.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalesReport.Location = new System.Drawing.Point(12, 60);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Size = new System.Drawing.Size(193, 60);
            this.btnSalesReport.TabIndex = 4;
            this.btnSalesReport.Text = "SALES REPORT";
            this.btnSalesReport.UseVisualStyleBackColor = true;
            this.btnSalesReport.Click += new System.EventHandler(this.btnSalesReport_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(10, 60);
            this.sidePanel.TabIndex = 3;
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHome.Location = new System.Drawing.Point(12, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(193, 60);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
            // 
            // developersInfo1
            // 
            this.developersInfo1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.developersInfo1.Location = new System.Drawing.Point(207, 41);
            this.developersInfo1.Name = "developersInfo1";
            this.developersInfo1.Size = new System.Drawing.Size(766, 483);
            this.developersInfo1.TabIndex = 7;
            // 
            // suppliers1
            // 
            this.suppliers1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.suppliers1.Location = new System.Drawing.Point(208, 41);
            this.suppliers1.Name = "suppliers1";
            this.suppliers1.Size = new System.Drawing.Size(766, 483);
            this.suppliers1.TabIndex = 6;
            // 
            // manageAccounts1
            // 
            this.manageAccounts1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.manageAccounts1.Location = new System.Drawing.Point(207, 41);
            this.manageAccounts1.Name = "manageAccounts1";
            this.manageAccounts1.Size = new System.Drawing.Size(766, 483);
            this.manageAccounts1.TabIndex = 5;
            // 
            // inventory1
            // 
            this.inventory1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inventory1.Location = new System.Drawing.Point(207, 41);
            this.inventory1.Name = "inventory1";
            this.inventory1.Size = new System.Drawing.Size(766, 483);
            this.inventory1.TabIndex = 4;
            // 
            // salesreport1
            // 
            this.salesreport1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salesreport1.Location = new System.Drawing.Point(207, 41);
            this.salesreport1.Name = "salesreport1";
            this.salesreport1.Size = new System.Drawing.Size(766, 483);
            this.salesreport1.TabIndex = 3;
            // 
            // home1
            // 
            this.home1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.home1.Location = new System.Drawing.Point(208, 41);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(766, 483);
            this.home1.TabIndex = 2;
            // 
            // adminUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 526);
            this.Controls.Add(this.developersInfo1);
            this.Controls.Add(this.suppliers1);
            this.Controls.Add(this.manageAccounts1);
            this.Controls.Add(this.inventory1);
            this.Controls.Add(this.salesreport1);
            this.Controls.Add(this.home1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "adminUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnDevInfo;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Button btnAccounts;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnSalesReport;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label1;
        private Home home1;
        private Salesreport salesreport1;
        private Inventory inventory1;
        private ManageAccounts manageAccounts1;
        private Suppliers suppliers1;
        private DevelopersInfo developersInfo1;
    }
}