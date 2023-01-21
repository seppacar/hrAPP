using System.Windows.Forms;

namespace hrAPP.Forms
{
    partial class EmployeeManagementForm
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
            this.components = new System.ComponentModel.Container();
            this.EmployeeDataPanel = new System.Windows.Forms.Panel();
            this.DepartmentsComboBox = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ImageSelectButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.SalaryTbox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PhoneTbox = new System.Windows.Forms.TextBox();
            this.MailTbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.fNameTbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.RemoveEmployeeButton = new System.Windows.Forms.Button();
            this.UpdateEmployeeButton = new System.Windows.Forms.Button();
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.EmployeesListView = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Department = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.EmployeeDataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeDataPanel
            // 
            this.EmployeeDataPanel.Controls.Add(this.EmployeesListView);
            this.EmployeeDataPanel.Controls.Add(this.DepartmentsComboBox);
            this.EmployeeDataPanel.Controls.Add(this.comboBox1);
            this.EmployeeDataPanel.Controls.Add(this.ImageSelectButton);
            this.EmployeeDataPanel.Controls.Add(this.pictureBox1);
            this.EmployeeDataPanel.Controls.Add(this.dateTimePicker2);
            this.EmployeeDataPanel.Controls.Add(this.dateTimePicker1);
            this.EmployeeDataPanel.Controls.Add(this.label9);
            this.EmployeeDataPanel.Controls.Add(this.SalaryTbox);
            this.EmployeeDataPanel.Controls.Add(this.label13);
            this.EmployeeDataPanel.Controls.Add(this.label12);
            this.EmployeeDataPanel.Controls.Add(this.label10);
            this.EmployeeDataPanel.Controls.Add(this.label8);
            this.EmployeeDataPanel.Controls.Add(this.PhoneTbox);
            this.EmployeeDataPanel.Controls.Add(this.MailTbox);
            this.EmployeeDataPanel.Controls.Add(this.label7);
            this.EmployeeDataPanel.Controls.Add(this.fNameTbox);
            this.EmployeeDataPanel.Controls.Add(this.label5);
            this.EmployeeDataPanel.Controls.Add(this.label3);
            this.EmployeeDataPanel.Controls.Add(this.label2);
            this.EmployeeDataPanel.Controls.Add(this.label1);
            this.EmployeeDataPanel.Controls.Add(this.ClearButton);
            this.EmployeeDataPanel.Controls.Add(this.RemoveEmployeeButton);
            this.EmployeeDataPanel.Controls.Add(this.UpdateEmployeeButton);
            this.EmployeeDataPanel.Controls.Add(this.AddEmployeeButton);
            this.EmployeeDataPanel.Location = new System.Drawing.Point(0, 1);
            this.EmployeeDataPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeDataPanel.Name = "EmployeeDataPanel";
            this.EmployeeDataPanel.Size = new System.Drawing.Size(1251, 583);
            this.EmployeeDataPanel.TabIndex = 2;
            this.EmployeeDataPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.EmployeeDataPanel_Paint);
            // 
            // DepartmentsComboBox
            // 
            this.DepartmentsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepartmentsComboBox.FormattingEnabled = true;
            this.DepartmentsComboBox.Location = new System.Drawing.Point(942, 352);
            this.DepartmentsComboBox.Name = "DepartmentsComboBox";
            this.DepartmentsComboBox.Size = new System.Drawing.Size(161, 24);
            this.DepartmentsComboBox.TabIndex = 36;
            this.DepartmentsComboBox.SelectedIndexChanged += new System.EventHandler(this.DepartmentsComboBox_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(942, 392);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 24);
            this.comboBox1.TabIndex = 35;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ImageSelectButton
            // 
            this.ImageSelectButton.Location = new System.Drawing.Point(914, 125);
            this.ImageSelectButton.Name = "ImageSelectButton";
            this.ImageSelectButton.Size = new System.Drawing.Size(119, 32);
            this.ImageSelectButton.TabIndex = 34;
            this.ImageSelectButton.Text = "Upload Image";
            this.ImageSelectButton.UseVisualStyleBackColor = true;
            this.ImageSelectButton.Click += new System.EventHandler(this.ImageSelectButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(794, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(942, 434);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(161, 22);
            this.dateTimePicker2.TabIndex = 32;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(942, 318);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(161, 22);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(790, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Birth Date";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // SalaryTbox
            // 
            this.SalaryTbox.Location = new System.Drawing.Point(942, 474);
            this.SalaryTbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SalaryTbox.Name = "SalaryTbox";
            this.SalaryTbox.Size = new System.Drawing.Size(161, 22);
            this.SalaryTbox.TabIndex = 25;
            this.SalaryTbox.TextChanged += new System.EventHandler(this.SalaryTbox_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(790, 474);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "Salary";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(790, 396);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Position";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(790, 436);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Hire Date";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(790, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Department";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // PhoneTbox
            // 
            this.PhoneTbox.Location = new System.Drawing.Point(942, 279);
            this.PhoneTbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PhoneTbox.Name = "PhoneTbox";
            this.PhoneTbox.Size = new System.Drawing.Size(161, 22);
            this.PhoneTbox.TabIndex = 15;
            this.PhoneTbox.TextChanged += new System.EventHandler(this.PhoneTbox_TextChanged);
            // 
            // MailTbox
            // 
            this.MailTbox.Location = new System.Drawing.Point(942, 239);
            this.MailTbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MailTbox.Name = "MailTbox";
            this.MailTbox.Size = new System.Drawing.Size(161, 22);
            this.MailTbox.TabIndex = 14;
            this.MailTbox.TextChanged += new System.EventHandler(this.MailTbox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(910, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Employee Information";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // fNameTbox
            // 
            this.fNameTbox.Location = new System.Drawing.Point(942, 199);
            this.fNameTbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fNameTbox.Name = "fNameTbox";
            this.fNameTbox.Size = new System.Drawing.Size(161, 22);
            this.fNameTbox.TabIndex = 12;
            this.fNameTbox.TextChanged += new System.EventHandler(this.fNameTbox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(504, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 10;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(790, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Phone Number";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(790, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Email";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(790, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Full Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(1139, 446);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(100, 50);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear Fields";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // RemoveEmployeeButton
            // 
            this.RemoveEmployeeButton.Location = new System.Drawing.Point(1136, 306);
            this.RemoveEmployeeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveEmployeeButton.Name = "RemoveEmployeeButton";
            this.RemoveEmployeeButton.Size = new System.Drawing.Size(100, 50);
            this.RemoveEmployeeButton.TabIndex = 4;
            this.RemoveEmployeeButton.Text = "Remove Employee";
            this.RemoveEmployeeButton.UseVisualStyleBackColor = true;
            this.RemoveEmployeeButton.Click += new System.EventHandler(this.RemoveEmployeeButton_Click);
            // 
            // UpdateEmployeeButton
            // 
            this.UpdateEmployeeButton.Location = new System.Drawing.Point(1136, 250);
            this.UpdateEmployeeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateEmployeeButton.Name = "UpdateEmployeeButton";
            this.UpdateEmployeeButton.Size = new System.Drawing.Size(100, 50);
            this.UpdateEmployeeButton.TabIndex = 3;
            this.UpdateEmployeeButton.Text = "Update Employee";
            this.UpdateEmployeeButton.UseVisualStyleBackColor = true;
            this.UpdateEmployeeButton.Click += new System.EventHandler(this.UpdateEmployeeButton_Click);
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Location = new System.Drawing.Point(1136, 194);
            this.AddEmployeeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(100, 50);
            this.AddEmployeeButton.TabIndex = 2;
            this.AddEmployeeButton.Text = "Add Employee";
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // EmployeesListView
            // 
            this.EmployeesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.FirstName,
            this.LastName,
            this.Position,
            this.Department});
            this.EmployeesListView.HideSelection = false;
            this.EmployeesListView.Location = new System.Drawing.Point(12, 25);
            this.EmployeesListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeesListView.MultiSelect = false;
            this.EmployeesListView.Name = "EmployeesListView";
            this.EmployeesListView.Size = new System.Drawing.Size(740, 546);
            this.EmployeesListView.TabIndex = 0;
            this.EmployeesListView.UseCompatibleStateImageBehavior = false;
            this.EmployeesListView.View = System.Windows.Forms.View.Details;
            this.EmployeesListView.SelectedIndexChanged += new System.EventHandler(this.EmployeesListView_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // FirstName
            // 
            this.FirstName.Text = "First Name";
            this.FirstName.Width = 105;
            // 
            // LastName
            // 
            this.LastName.Text = "Last Name";
            this.LastName.Width = 112;
            // 
            // Position
            // 
            this.Position.Text = "Position";
            this.Position.Width = 113;
            // 
            // Department
            // 
            this.Department.Text = "Department";
            this.Department.Width = 176;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EmployeeManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 583);
            this.Controls.Add(this.EmployeeDataPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeManagementForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.EmployeeManagementForm_Load);
            this.EmployeeDataPanel.ResumeLayout(false);
            this.EmployeeDataPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel EmployeeDataPanel;
        private System.Windows.Forms.Button ImageSelectButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SalaryTbox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PhoneTbox;
        private System.Windows.Forms.TextBox MailTbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox fNameTbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button RemoveEmployeeButton;
        private System.Windows.Forms.Button UpdateEmployeeButton;
        private System.Windows.Forms.Button AddEmployeeButton;
        private System.Windows.Forms.ListView EmployeesListView;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader Position;
        private System.Windows.Forms.ColumnHeader Department;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox comboBox1;
        private ComboBox DepartmentsComboBox;
    }
}