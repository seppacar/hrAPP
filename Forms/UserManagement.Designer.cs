namespace hrAPP.Forms
{
    partial class UserManagement
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
            this.UsersListView = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PositionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RemoveUserButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.LoginPasswordLabel = new System.Windows.Forms.Label();
            this.LoginUserNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordConfirmTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.EmployeeIdComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UsersListView
            // 
            this.UsersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.FullName,
            this.Username,
            this.PositionColumn});
            this.UsersListView.HideSelection = false;
            this.UsersListView.Location = new System.Drawing.Point(12, 47);
            this.UsersListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsersListView.MultiSelect = false;
            this.UsersListView.Name = "UsersListView";
            this.UsersListView.Size = new System.Drawing.Size(499, 518);
            this.UsersListView.TabIndex = 1;
            this.UsersListView.UseCompatibleStateImageBehavior = false;
            this.UsersListView.View = System.Windows.Forms.View.Details;
            this.UsersListView.SelectedIndexChanged += new System.EventHandler(this.UsersListView_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // FullName
            // 
            this.FullName.Text = "Full Name";
            this.FullName.Width = 105;
            // 
            // Username
            // 
            this.Username.Text = "Username";
            this.Username.Width = 112;
            // 
            // PositionColumn
            // 
            this.PositionColumn.Text = "Position";
            this.PositionColumn.Width = 118;
            // 
            // RemoveUserButton
            // 
            this.RemoveUserButton.BackColor = System.Drawing.Color.Red;
            this.RemoveUserButton.ForeColor = System.Drawing.Color.LightGray;
            this.RemoveUserButton.Location = new System.Drawing.Point(517, 47);
            this.RemoveUserButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveUserButton.Name = "RemoveUserButton";
            this.RemoveUserButton.Size = new System.Drawing.Size(267, 58);
            this.RemoveUserButton.TabIndex = 5;
            this.RemoveUserButton.Text = "Remove Selected User";
            this.RemoveUserButton.UseVisualStyleBackColor = false;
            this.RemoveUserButton.Click += new System.EventHandler(this.RemoveUserButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "hrAPP Users";
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.UsernameTextbox.Location = new System.Drawing.Point(962, 296);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(166, 38);
            this.UsernameTextbox.TabIndex = 17;
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.PasswordTextbox.Location = new System.Drawing.Point(962, 340);
            this.PasswordTextbox.MaxLength = 14;
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PasswordChar = '*';
            this.PasswordTextbox.Size = new System.Drawing.Size(166, 38);
            this.PasswordTextbox.TabIndex = 18;
            // 
            // LoginPasswordLabel
            // 
            this.LoginPasswordLabel.AutoSize = true;
            this.LoginPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPasswordLabel.Location = new System.Drawing.Point(640, 346);
            this.LoginPasswordLabel.Name = "LoginPasswordLabel";
            this.LoginPasswordLabel.Size = new System.Drawing.Size(138, 32);
            this.LoginPasswordLabel.TabIndex = 16;
            this.LoginPasswordLabel.Text = "Password";
            // 
            // LoginUserNameLabel
            // 
            this.LoginUserNameLabel.AutoSize = true;
            this.LoginUserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginUserNameLabel.Location = new System.Drawing.Point(737, 160);
            this.LoginUserNameLabel.Name = "LoginUserNameLabel";
            this.LoginUserNameLabel.Size = new System.Drawing.Size(310, 51);
            this.LoginUserNameLabel.TabIndex = 15;
            this.LoginUserNameLabel.Text = "Add New User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(640, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 32);
            this.label1.TabIndex = 19;
            this.label1.Text = "Username";
            // 
            // PasswordConfirmTextbox
            // 
            this.PasswordConfirmTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.PasswordConfirmTextbox.Location = new System.Drawing.Point(962, 384);
            this.PasswordConfirmTextbox.MaxLength = 14;
            this.PasswordConfirmTextbox.Name = "PasswordConfirmTextbox";
            this.PasswordConfirmTextbox.PasswordChar = '*';
            this.PasswordConfirmTextbox.Size = new System.Drawing.Size(166, 38);
            this.PasswordConfirmTextbox.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(640, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 32);
            this.label2.TabIndex = 20;
            this.label2.Text = "Password Confirmation";
            // 
            // AddUserButton
            // 
            this.AddUserButton.BackColor = System.Drawing.Color.ForestGreen;
            this.AddUserButton.ForeColor = System.Drawing.Color.LightGray;
            this.AddUserButton.Location = new System.Drawing.Point(743, 504);
            this.AddUserButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(304, 56);
            this.AddUserButton.TabIndex = 22;
            this.AddUserButton.Text = "Add User";
            this.AddUserButton.UseVisualStyleBackColor = false;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // EmployeeIdComboBox
            // 
            this.EmployeeIdComboBox.FormattingEnabled = true;
            this.EmployeeIdComboBox.Location = new System.Drawing.Point(962, 266);
            this.EmployeeIdComboBox.Name = "EmployeeIdComboBox";
            this.EmployeeIdComboBox.Size = new System.Drawing.Size(166, 24);
            this.EmployeeIdComboBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(640, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 32);
            this.label3.TabIndex = 24;
            this.label3.Text = "Employee Id";
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 583);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmployeeIdComboBox);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.PasswordConfirmTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsernameTextbox);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.LoginPasswordLabel);
            this.Controls.Add(this.LoginUserNameLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RemoveUserButton);
            this.Controls.Add(this.UsersListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserManagement";
            this.Text = "UserManagementForm";
            this.Load += new System.EventHandler(this.UserManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView UsersListView;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader FullName;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.Button RemoveUserButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader PositionColumn;
        private System.Windows.Forms.TextBox UsernameTextbox;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.Label LoginPasswordLabel;
        public System.Windows.Forms.Label LoginUserNameLabel;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordConfirmTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.ComboBox EmployeeIdComboBox;
        public System.Windows.Forms.Label label3;
    }
}