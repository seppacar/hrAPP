using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace hrAPP.Forms
{
    partial class DatabaseSettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseSettingForm));
            this.DatabaseSettingBrowseButton = new System.Windows.Forms.Button();
            this.DatabaseSettingPathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DatabaseSettingSubmitButton = new System.Windows.Forms.Button();
            this.DatabaseSettingConnectionPictureBox = new System.Windows.Forms.PictureBox();
            this.DatabaseSettingConnectionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseSettingConnectionPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DatabaseSettingBrowseButton
            // 
            resources.ApplyResources(this.DatabaseSettingBrowseButton, "DatabaseSettingBrowseButton");
            this.DatabaseSettingBrowseButton.Name = "DatabaseSettingBrowseButton";
            this.DatabaseSettingBrowseButton.UseVisualStyleBackColor = true;
            this.DatabaseSettingBrowseButton.Click += new System.EventHandler(this.DatabaseSettingBrowseButton_Click);
            // 
            // DatabaseSettingPathTextBox
            // 
            resources.ApplyResources(this.DatabaseSettingPathTextBox, "DatabaseSettingPathTextBox");
            this.DatabaseSettingPathTextBox.Name = "DatabaseSettingPathTextBox";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // DatabaseSettingSubmitButton
            // 
            resources.ApplyResources(this.DatabaseSettingSubmitButton, "DatabaseSettingSubmitButton");
            this.DatabaseSettingSubmitButton.Name = "DatabaseSettingSubmitButton";
            this.DatabaseSettingSubmitButton.UseVisualStyleBackColor = true;
            this.DatabaseSettingSubmitButton.Click += new System.EventHandler(this.DatabaseSettingSubmitButton_Click);
            // 
            // DatabaseSettingConnectionPictureBox
            // 
            this.DatabaseSettingConnectionPictureBox.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.DatabaseSettingConnectionPictureBox, "DatabaseSettingConnectionPictureBox");
            this.DatabaseSettingConnectionPictureBox.Name = "DatabaseSettingConnectionPictureBox";
            this.DatabaseSettingConnectionPictureBox.TabStop = false;
            // 
            // DatabaseSettingConnectionLabel
            // 
            resources.ApplyResources(this.DatabaseSettingConnectionLabel, "DatabaseSettingConnectionLabel");
            this.DatabaseSettingConnectionLabel.Name = "DatabaseSettingConnectionLabel";
            // 
            // DatabaseSettingForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.Controls.Add(this.DatabaseSettingConnectionLabel);
            this.Controls.Add(this.DatabaseSettingConnectionPictureBox);
            this.Controls.Add(this.DatabaseSettingSubmitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DatabaseSettingPathTextBox);
            this.Controls.Add(this.DatabaseSettingBrowseButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DatabaseSettingForm";
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseSettingConnectionPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DatabaseSettingBrowseButton;
        private System.Windows.Forms.TextBox DatabaseSettingPathTextBox;
        private System.Windows.Forms.Label label1;
        private Button DatabaseSettingSubmitButton;
        private PictureBox DatabaseSettingConnectionPictureBox;
        private Label DatabaseSettingConnectionLabel;
    }
}