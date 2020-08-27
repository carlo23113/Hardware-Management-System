namespace Hardware_Management_System
{
    partial class ManageAccounts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnAdmins = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userAccounts1 = new Hardware_Management_System.UserAccounts();
            this.adminAccounts1 = new Hardware_Management_System.AdminAccounts();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUsers
            // 
            this.btnUsers.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Location = new System.Drawing.Point(18, 0);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(120, 45);
            this.btnUsers.TabIndex = 2;
            this.btnUsers.Text = "USER ACCOUNTS";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdmins
            // 
            this.btnAdmins.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdmins.FlatAppearance.BorderSize = 0;
            this.btnAdmins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmins.Location = new System.Drawing.Point(140, 0);
            this.btnAdmins.Name = "btnAdmins";
            this.btnAdmins.Size = new System.Drawing.Size(120, 45);
            this.btnAdmins.TabIndex = 3;
            this.btnAdmins.Text = "ADMIN ACCOUNTS";
            this.btnAdmins.UseVisualStyleBackColor = true;
            this.btnAdmins.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnUsers);
            this.panel1.Controls.Add(this.btnAdmins);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 45);
            this.panel1.TabIndex = 4;
            // 
            // userAccounts1
            // 
            this.userAccounts1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userAccounts1.Location = new System.Drawing.Point(0, 45);
            this.userAccounts1.Name = "userAccounts1";
            this.userAccounts1.Size = new System.Drawing.Size(766, 438);
            this.userAccounts1.TabIndex = 5;
            // 
            // adminAccounts1
            // 
            this.adminAccounts1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adminAccounts1.Location = new System.Drawing.Point(0, 45);
            this.adminAccounts1.Name = "adminAccounts1";
            this.adminAccounts1.Size = new System.Drawing.Size(766, 438);
            this.adminAccounts1.TabIndex = 6;
            // 
            // ManageAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.adminAccounts1);
            this.Controls.Add(this.userAccounts1);
            this.Controls.Add(this.panel1);
            this.Name = "ManageAccounts";
            this.Size = new System.Drawing.Size(766, 483);
            this.Load += new System.EventHandler(this.ManageAccounts_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnAdmins;
        private System.Windows.Forms.Panel panel1;
        private UserAccounts userAccounts1;
        private AdminAccounts adminAccounts1;
    }
}
