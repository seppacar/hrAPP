namespace hrAPP.Forms
{
    partial class DashboardForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.BirthdaysLabel = new System.Windows.Forms.Label();
            this.BirthdaysListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmpByDeptChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TotalEmployeesLabel = new System.Windows.Forms.Label();
            this.TotalEmployeesTextBox = new System.Windows.Forms.TextBox();
            this.DateTimeLabel = new System.Windows.Forms.Label();
            this.OnLeaveListView = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OnLeaveLabel = new System.Windows.Forms.Label();
            this.EmpByPosChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ActiveEmployeesTextBox = new System.Windows.Forms.TextBox();
            this.ActiveEmployeesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmpByDeptChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpByPosChart)).BeginInit();
            this.SuspendLayout();
            // 
            // BirthdaysLabel
            // 
            this.BirthdaysLabel.AutoSize = true;
            this.BirthdaysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthdaysLabel.Location = new System.Drawing.Point(12, 330);
            this.BirthdaysLabel.Name = "BirthdaysLabel";
            this.BirthdaysLabel.Size = new System.Drawing.Size(260, 29);
            this.BirthdaysLabel.TabIndex = 13;
            this.BirthdaysLabel.Text = "🎂 Upcoming Birthdays";
            // 
            // BirthdaysListView
            // 
            this.BirthdaysListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader7,
            this.columnHeader6});
            this.BirthdaysListView.HideSelection = false;
            this.BirthdaysListView.Location = new System.Drawing.Point(15, 367);
            this.BirthdaysListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BirthdaysListView.MultiSelect = false;
            this.BirthdaysListView.Name = "BirthdaysListView";
            this.BirthdaysListView.Size = new System.Drawing.Size(556, 192);
            this.BirthdaysListView.TabIndex = 12;
            this.BirthdaysListView.UseCompatibleStateImageBehavior = false;
            this.BirthdaysListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Full Name";
            this.columnHeader2.Width = 105;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Birth Date";
            this.columnHeader3.Width = 112;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Days Left";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "New Age";
            // 
            // EmpByDeptChart
            // 
            chartArea1.Name = "ChartArea1";
            this.EmpByDeptChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.EmpByDeptChart.Legends.Add(legend1);
            this.EmpByDeptChart.Location = new System.Drawing.Point(955, 251);
            this.EmpByDeptChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmpByDeptChart.Name = "EmpByDeptChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "s1";
            this.EmpByDeptChart.Series.Add(series1);
            this.EmpByDeptChart.Size = new System.Drawing.Size(284, 277);
            this.EmpByDeptChart.TabIndex = 11;
            this.EmpByDeptChart.Text = "chart1";
            // 
            // TotalEmployeesLabel
            // 
            this.TotalEmployeesLabel.AutoSize = true;
            this.TotalEmployeesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalEmployeesLabel.Location = new System.Drawing.Point(931, 9);
            this.TotalEmployeesLabel.Name = "TotalEmployeesLabel";
            this.TotalEmployeesLabel.Size = new System.Drawing.Size(201, 29);
            this.TotalEmployeesLabel.TabIndex = 14;
            this.TotalEmployeesLabel.Text = "Total Employees:";
            // 
            // TotalEmployeesTextBox
            // 
            this.TotalEmployeesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TotalEmployeesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TotalEmployeesTextBox.Location = new System.Drawing.Point(1164, 12);
            this.TotalEmployeesTextBox.Name = "TotalEmployeesTextBox";
            this.TotalEmployeesTextBox.ReadOnly = true;
            this.TotalEmployeesTextBox.Size = new System.Drawing.Size(75, 31);
            this.TotalEmployeesTextBox.TabIndex = 16;
            // 
            // DateTimeLabel
            // 
            this.DateTimeLabel.AutoSize = true;
            this.DateTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimeLabel.Location = new System.Drawing.Point(1002, 530);
            this.DateTimeLabel.Name = "DateTimeLabel";
            this.DateTimeLabel.Size = new System.Drawing.Size(237, 29);
            this.DateTimeLabel.TabIndex = 17;
            this.DateTimeLabel.Text = "00/00/0000 00:00 PM";
            // 
            // OnLeaveListView
            // 
            this.OnLeaveListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.OnLeaveListView.HideSelection = false;
            this.OnLeaveListView.Location = new System.Drawing.Point(17, 136);
            this.OnLeaveListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OnLeaveListView.MultiSelect = false;
            this.OnLeaveListView.Name = "OnLeaveListView";
            this.OnLeaveListView.Size = new System.Drawing.Size(556, 192);
            this.OnLeaveListView.TabIndex = 18;
            this.OnLeaveListView.UseCompatibleStateImageBehavior = false;
            this.OnLeaveListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Full Name";
            this.columnHeader5.Width = 83;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Leave Start Date";
            this.columnHeader8.Width = 112;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "On Leave Until";
            this.columnHeader9.Width = 94;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Days Left";
            this.columnHeader10.Width = 130;
            // 
            // OnLeaveLabel
            // 
            this.OnLeaveLabel.AutoSize = true;
            this.OnLeaveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnLeaveLabel.Location = new System.Drawing.Point(12, 96);
            this.OnLeaveLabel.Name = "OnLeaveLabel";
            this.OnLeaveLabel.Size = new System.Drawing.Size(243, 29);
            this.OnLeaveLabel.TabIndex = 19;
            this.OnLeaveLabel.Text = "Employees On Leave";
            // 
            // EmpByPosChart
            // 
            chartArea2.Name = "ChartArea1";
            this.EmpByPosChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.EmpByPosChart.Legends.Add(legend2);
            this.EmpByPosChart.Location = new System.Drawing.Point(635, 251);
            this.EmpByPosChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmpByPosChart.Name = "EmpByPosChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "s1";
            this.EmpByPosChart.Series.Add(series2);
            this.EmpByPosChart.Size = new System.Drawing.Size(284, 277);
            this.EmpByPosChart.TabIndex = 20;
            this.EmpByPosChart.Text = "chart2";
            // 
            // ActiveEmployeesTextBox
            // 
            this.ActiveEmployeesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ActiveEmployeesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ActiveEmployeesTextBox.Location = new System.Drawing.Point(1164, 57);
            this.ActiveEmployeesTextBox.Name = "ActiveEmployeesTextBox";
            this.ActiveEmployeesTextBox.ReadOnly = true;
            this.ActiveEmployeesTextBox.Size = new System.Drawing.Size(75, 31);
            this.ActiveEmployeesTextBox.TabIndex = 22;
            // 
            // ActiveEmployeesLabel
            // 
            this.ActiveEmployeesLabel.AutoSize = true;
            this.ActiveEmployeesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActiveEmployeesLabel.Location = new System.Drawing.Point(931, 57);
            this.ActiveEmployeesLabel.Name = "ActiveEmployeesLabel";
            this.ActiveEmployeesLabel.Size = new System.Drawing.Size(210, 29);
            this.ActiveEmployeesLabel.TabIndex = 21;
            this.ActiveEmployeesLabel.Text = "Active Employees:";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 583);
            this.Controls.Add(this.ActiveEmployeesTextBox);
            this.Controls.Add(this.ActiveEmployeesLabel);
            this.Controls.Add(this.EmpByPosChart);
            this.Controls.Add(this.OnLeaveLabel);
            this.Controls.Add(this.OnLeaveListView);
            this.Controls.Add(this.DateTimeLabel);
            this.Controls.Add(this.TotalEmployeesTextBox);
            this.Controls.Add(this.TotalEmployeesLabel);
            this.Controls.Add(this.BirthdaysLabel);
            this.Controls.Add(this.BirthdaysListView);
            this.Controls.Add(this.EmpByDeptChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.EmpByDeptChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpByPosChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BirthdaysLabel;
        private System.Windows.Forms.ListView BirthdaysListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.DataVisualization.Charting.Chart EmpByDeptChart;
        private System.Windows.Forms.Label TotalEmployeesLabel;
        private System.Windows.Forms.TextBox TotalEmployeesTextBox;
        private System.Windows.Forms.Label DateTimeLabel;
        private System.Windows.Forms.ListView OnLeaveListView;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label OnLeaveLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart EmpByPosChart;
        private System.Windows.Forms.TextBox ActiveEmployeesTextBox;
        private System.Windows.Forms.Label ActiveEmployeesLabel;
    }
}