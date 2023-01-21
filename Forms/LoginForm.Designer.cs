namespace hrAPP
{
    partial class LoginForm
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
            this.LoginUserNameLabel = new System.Windows.Forms.Label();
            this.LoginPasswordLabel = new System.Windows.Forms.Label();
            this.LoginPasswordTextbox = new System.Windows.Forms.TextBox();
            this.LoginUsernameTextbox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.LoginRememberCheckbox = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DatabaseSettingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginUserNameLabel
            // 
            this.LoginUserNameLabel.AutoSize = true;
            this.LoginUserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginUserNameLabel.Location = new System.Drawing.Point(12, 252);
            this.LoginUserNameLabel.Name = "LoginUserNameLabel";
            this.LoginUserNameLabel.Size = new System.Drawing.Size(229, 51);
            this.LoginUserNameLabel.TabIndex = 0;
            this.LoginUserNameLabel.Text = "Username";
            // 
            // LoginPasswordLabel
            // 
            this.LoginPasswordLabel.AutoSize = true;
            this.LoginPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold);
            this.LoginPasswordLabel.Location = new System.Drawing.Point(12, 321);
            this.LoginPasswordLabel.Name = "LoginPasswordLabel";
            this.LoginPasswordLabel.Size = new System.Drawing.Size(220, 51);
            this.LoginPasswordLabel.TabIndex = 1;
            this.LoginPasswordLabel.Text = "Password";
            // 
            // LoginPasswordTextbox
            // 
            this.LoginPasswordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.LoginPasswordTextbox.Location = new System.Drawing.Point(268, 333);
            this.LoginPasswordTextbox.MaxLength = 14;
            this.LoginPasswordTextbox.Name = "LoginPasswordTextbox";
            this.LoginPasswordTextbox.PasswordChar = '*';
            this.LoginPasswordTextbox.Size = new System.Drawing.Size(166, 38);
            this.LoginPasswordTextbox.TabIndex = 3;
            // 
            // LoginUsernameTextbox
            // 
            this.LoginUsernameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.LoginUsernameTextbox.Location = new System.Drawing.Point(268, 264);
            this.LoginUsernameTextbox.Name = "LoginUsernameTextbox";
            this.LoginUsernameTextbox.Size = new System.Drawing.Size(166, 38);
            this.LoginUsernameTextbox.TabIndex = 3;
            // 
            // LoginButton
            // 
            this.LoginButton.AutoSize = true;
            this.LoginButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(114, 426);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(200, 64);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginRememberCheckbox
            // 
            this.LoginRememberCheckbox.AutoSize = true;
            this.LoginRememberCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginRememberCheckbox.Location = new System.Drawing.Point(21, 385);
            this.LoginRememberCheckbox.Name = "LoginRememberCheckbox";
            this.LoginRememberCheckbox.Size = new System.Drawing.Size(207, 24);
            this.LoginRememberCheckbox.TabIndex = 7;
            this.LoginRememberCheckbox.Text = "Remember login details";
            this.LoginRememberCheckbox.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(83, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 99);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "hrAPP";
            // 
            // DatabaseSettingButton
            // 
            this.DatabaseSettingButton.BackColor = System.Drawing.Color.ForestGreen;
            this.DatabaseSettingButton.ForeColor = System.Drawing.Color.LightGray;
            this.DatabaseSettingButton.Location = new System.Drawing.Point(309, 2);
            this.DatabaseSettingButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DatabaseSettingButton.Name = "DatabaseSettingButton";
            this.DatabaseSettingButton.Size = new System.Drawing.Size(143, 39);
            this.DatabaseSettingButton.TabIndex = 10;
            this.DatabaseSettingButton.Text = "Choose Database";
            this.DatabaseSettingButton.UseVisualStyleBackColor = false;
            this.DatabaseSettingButton.Click += new System.EventHandler(this.DatabaseSettingButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(451, 517);
            this.Controls.Add(this.DatabaseSettingButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LoginRememberCheckbox);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.LoginUsernameTextbox);
            this.Controls.Add(this.LoginPasswordTextbox);
            this.Controls.Add(this.LoginPasswordLabel);
            this.Controls.Add(this.LoginUserNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hrAPP Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LoginPasswordLabel;
        public System.Windows.Forms.Label LoginUserNameLabel;
        private System.Windows.Forms.TextBox LoginPasswordTextbox;
        private System.Windows.Forms.TextBox LoginUsernameTextbox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.CheckBox LoginRememberCheckbox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button DatabaseSettingButton;
    }
}