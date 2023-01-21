using System.Windows.Forms;

namespace hrAPP
{
    partial class Home
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
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.TalentManagementButton = new System.Windows.Forms.Button();
            this.UserManagementFormButton = new System.Windows.Forms.Button();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.EmployeeManagementFormButton = new System.Windows.Forms.Button();
            this.DashboardFormButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripUsername = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.NavigationPanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.Controls.Add(this.button1);
            this.NavigationPanel.Controls.Add(this.TalentManagementButton);
            this.NavigationPanel.Controls.Add(this.UserManagementFormButton);
            this.NavigationPanel.Controls.Add(this.ChangePasswordButton);
            this.NavigationPanel.Controls.Add(this.LogoutButton);
            this.NavigationPanel.Controls.Add(this.EmployeeManagementFormButton);
            this.NavigationPanel.Controls.Add(this.DashboardFormButton);
            this.NavigationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavigationPanel.Location = new System.Drawing.Point(0, 0);
            this.NavigationPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(1278, 106);
            this.NavigationPanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(1132, 61);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "Choose Database";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TalentManagementButton
            // 
            this.TalentManagementButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TalentManagementButton.Location = new System.Drawing.Point(289, 4);
            this.TalentManagementButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TalentManagementButton.Name = "TalentManagementButton";
            this.TalentManagementButton.Size = new System.Drawing.Size(140, 100);
            this.TalentManagementButton.TabIndex = 8;
            this.TalentManagementButton.Text = "Talent Management";
            this.TalentManagementButton.UseVisualStyleBackColor = false;
            this.TalentManagementButton.Click += new System.EventHandler(this.TalentManagementFormButton_Click);
            // 
            // UserManagementFormButton
            // 
            this.UserManagementFormButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UserManagementFormButton.Location = new System.Drawing.Point(892, 2);
            this.UserManagementFormButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserManagementFormButton.Name = "UserManagementFormButton";
            this.UserManagementFormButton.Size = new System.Drawing.Size(140, 100);
            this.UserManagementFormButton.TabIndex = 6;
            this.UserManagementFormButton.Text = "hrAPP User Management";
            this.UserManagementFormButton.UseVisualStyleBackColor = false;
            this.UserManagementFormButton.Click += new System.EventHandler(this.UserManagementFormButton_Click);
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.BackColor = System.Drawing.Color.DarkOrange;
            this.ChangePasswordButton.ForeColor = System.Drawing.Color.LightGray;
            this.ChangePasswordButton.Location = new System.Drawing.Point(1038, 2);
            this.ChangePasswordButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(143, 39);
            this.ChangePasswordButton.TabIndex = 5;
            this.ChangePasswordButton.Text = "Change Password";
            this.ChangePasswordButton.UseVisualStyleBackColor = false;
            this.ChangePasswordButton.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.Red;
            this.LogoutButton.ForeColor = System.Drawing.Color.LightGray;
            this.LogoutButton.Location = new System.Drawing.Point(1187, 2);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(88, 39);
            this.LogoutButton.TabIndex = 4;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // EmployeeManagementFormButton
            // 
            this.EmployeeManagementFormButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EmployeeManagementFormButton.Location = new System.Drawing.Point(143, 2);
            this.EmployeeManagementFormButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeManagementFormButton.Name = "EmployeeManagementFormButton";
            this.EmployeeManagementFormButton.Size = new System.Drawing.Size(140, 100);
            this.EmployeeManagementFormButton.TabIndex = 3;
            this.EmployeeManagementFormButton.Text = "Employee Management";
            this.EmployeeManagementFormButton.UseVisualStyleBackColor = false;
            this.EmployeeManagementFormButton.Click += new System.EventHandler(this.EmployeePanelButton_Click);
            // 
            // DashboardFormButton
            // 
            this.DashboardFormButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DashboardFormButton.Location = new System.Drawing.Point(12, 0);
            this.DashboardFormButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DashboardFormButton.Name = "DashboardFormButton";
            this.DashboardFormButton.Size = new System.Drawing.Size(125, 100);
            this.DashboardFormButton.TabIndex = 1;
            this.DashboardFormButton.Text = "Home";
            this.DashboardFormButton.UseVisualStyleBackColor = false;
            this.DashboardFormButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripUsername,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 691);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1278, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripUsername
            // 
            this.toolStripUsername.Name = "toolStripUsername";
            this.toolStripUsername.Size = new System.Drawing.Size(51, 20);
            this.toolStripUsername.Text = "HrAPP";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 20);
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 106);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1278, 585);
            this.MainPanel.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 717);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.NavigationPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.Text = "hrAPP";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.NavigationPanel.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel NavigationPanel;
        private System.Windows.Forms.Button EmployeeManagementFormButton;
        private System.Windows.Forms.Button DashboardFormButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Button ChangePasswordButton;
        private Button UserManagementFormButton;
        private Button TalentManagementButton;
        private Panel MainPanel;
        private Button button1;
        private ToolStripStatusLabel toolStripUsername;
        private ToolStripStatusLabel toolStripStatusLabel3;
    }
}
