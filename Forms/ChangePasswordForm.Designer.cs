namespace hrAPP.Forms
{
    partial class ChangePasswordForm
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
            this.OldpasswordTextBox = new System.Windows.Forms.TextBox();
            this.NewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.NewPasswordLabel = new System.Windows.Forms.Label();
            this.OldPasswordLabel = new System.Windows.Forms.Label();
            this.NewPasswordConfirmTextBox = new System.Windows.Forms.TextBox();
            this.NewPasswordConfirmLabel = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OldpasswordTextBox
            // 
            this.OldpasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.OldpasswordTextBox.Location = new System.Drawing.Point(424, 12);
            this.OldpasswordTextBox.Name = "OldpasswordTextBox";
            this.OldpasswordTextBox.PasswordChar = '*';
            this.OldpasswordTextBox.Size = new System.Drawing.Size(166, 38);
            this.OldpasswordTextBox.TabIndex = 6;
            // 
            // NewPasswordTextBox
            // 
            this.NewPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.NewPasswordTextBox.Location = new System.Drawing.Point(424, 56);
            this.NewPasswordTextBox.MaxLength = 14;
            this.NewPasswordTextBox.Name = "NewPasswordTextBox";
            this.NewPasswordTextBox.PasswordChar = '*';
            this.NewPasswordTextBox.Size = new System.Drawing.Size(166, 38);
            this.NewPasswordTextBox.TabIndex = 7;
            // 
            // NewPasswordLabel
            // 
            this.NewPasswordLabel.AutoSize = true;
            this.NewPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.NewPasswordLabel.Location = new System.Drawing.Point(12, 56);
            this.NewPasswordLabel.Name = "NewPasswordLabel";
            this.NewPasswordLabel.Size = new System.Drawing.Size(188, 29);
            this.NewPasswordLabel.TabIndex = 5;
            this.NewPasswordLabel.Text = "New Password";
            // 
            // OldPasswordLabel
            // 
            this.OldPasswordLabel.AutoSize = true;
            this.OldPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.OldPasswordLabel.Location = new System.Drawing.Point(12, 12);
            this.OldPasswordLabel.Name = "OldPasswordLabel";
            this.OldPasswordLabel.Size = new System.Drawing.Size(177, 29);
            this.OldPasswordLabel.TabIndex = 4;
            this.OldPasswordLabel.Text = "Old Password";
            // 
            // NewPasswordConfirmTextBox
            // 
            this.NewPasswordConfirmTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.NewPasswordConfirmTextBox.Location = new System.Drawing.Point(424, 100);
            this.NewPasswordConfirmTextBox.MaxLength = 14;
            this.NewPasswordConfirmTextBox.Name = "NewPasswordConfirmTextBox";
            this.NewPasswordConfirmTextBox.PasswordChar = '*';
            this.NewPasswordConfirmTextBox.Size = new System.Drawing.Size(166, 38);
            this.NewPasswordConfirmTextBox.TabIndex = 9;
            // 
            // NewPasswordConfirmLabel
            // 
            this.NewPasswordConfirmLabel.AutoSize = true;
            this.NewPasswordConfirmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.NewPasswordConfirmLabel.Location = new System.Drawing.Point(12, 100);
            this.NewPasswordConfirmLabel.Name = "NewPasswordConfirmLabel";
            this.NewPasswordConfirmLabel.Size = new System.Drawing.Size(343, 29);
            this.NewPasswordConfirmLabel.TabIndex = 8;
            this.NewPasswordConfirmLabel.Text = "New Password Confirmation";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.ForeColor = System.Drawing.Color.Lime;
            this.ConfirmButton.Location = new System.Drawing.Point(12, 149);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(578, 49);
            this.ConfirmButton.TabIndex = 10;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.PassChangeSubmitButton_Click);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(619, 210);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.NewPasswordConfirmTextBox);
            this.Controls.Add(this.NewPasswordConfirmLabel);
            this.Controls.Add(this.OldpasswordTextBox);
            this.Controls.Add(this.NewPasswordTextBox);
            this.Controls.Add(this.NewPasswordLabel);
            this.Controls.Add(this.OldPasswordLabel);
            this.Name = "ChangePasswordForm";
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OldpasswordTextBox;
        private System.Windows.Forms.TextBox NewPasswordTextBox;
        private System.Windows.Forms.Label NewPasswordLabel;
        public System.Windows.Forms.Label OldPasswordLabel;
        private System.Windows.Forms.TextBox NewPasswordConfirmTextBox;
        private System.Windows.Forms.Label NewPasswordConfirmLabel;
        private System.Windows.Forms.Button ConfirmButton;
    }
}