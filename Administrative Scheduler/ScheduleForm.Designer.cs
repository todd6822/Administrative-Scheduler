namespace Administrative_Scheduler
{
    partial class ScheduleForm
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
            this.stopMonthCalendar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.setUpWorkAssingmentsButton = new System.Windows.Forms.Button();
            this.filleCalendarButton = new System.Windows.Forms.Button();
            this.assignLeave = new System.Windows.Forms.Button();
            this.createOrModifyGroupMemeberButton = new System.Windows.Forms.Button();
            this.beginDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.workLoadDataGrid = new System.Windows.Forms.DataGridView();
            this.testTable = new System.Windows.Forms.DataGridView();
            this.beginDateTextBox = new System.Windows.Forms.TextBox();
            this.endDateTextBox = new System.Windows.Forms.TextBox();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.beginTimePicker = new System.Windows.Forms.DateTimePicker();
            this.testDataGridView = new System.Windows.Forms.DataGridView();
            this.scheduleDataGridView = new System.Windows.Forms.DataGridView();
            this.returnedConstraintinfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.workLoadDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnedConstraintinfo)).BeginInit();
            this.SuspendLayout();
            // 
            // stopMonthCalendar
            // 
            this.stopMonthCalendar.AutoSize = true;
            this.stopMonthCalendar.Location = new System.Drawing.Point(1164, 796);
            this.stopMonthCalendar.Name = "stopMonthCalendar";
            this.stopMonthCalendar.Size = new System.Drawing.Size(152, 13);
            this.stopMonthCalendar.TabIndex = 3;
            this.stopMonthCalendar.Text = "End Date For Current Calender";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(881, 796);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start Date For Current Calender";
            // 
            // setUpWorkAssingmentsButton
            // 
            this.setUpWorkAssingmentsButton.Location = new System.Drawing.Point(25, 970);
            this.setUpWorkAssingmentsButton.Name = "setUpWorkAssingmentsButton";
            this.setUpWorkAssingmentsButton.Size = new System.Drawing.Size(242, 72);
            this.setUpWorkAssingmentsButton.TabIndex = 5;
            this.setUpWorkAssingmentsButton.Text = "Set Up Work Assignments";
            this.setUpWorkAssingmentsButton.UseVisualStyleBackColor = true;
            // 
            // filleCalendarButton
            // 
            this.filleCalendarButton.Location = new System.Drawing.Point(1325, 1050);
            this.filleCalendarButton.Name = "filleCalendarButton";
            this.filleCalendarButton.Size = new System.Drawing.Size(204, 50);
            this.filleCalendarButton.TabIndex = 6;
            this.filleCalendarButton.Text = "Fill Calender";
            this.filleCalendarButton.UseVisualStyleBackColor = true;
            this.filleCalendarButton.Click += new System.EventHandler(this.filleCalendarButton_Click);
            this.filleCalendarButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.filleCalendarButton_MouseClick);
            // 
            // assignLeave
            // 
            this.assignLeave.Location = new System.Drawing.Point(25, 1073);
            this.assignLeave.Name = "assignLeave";
            this.assignLeave.Size = new System.Drawing.Size(242, 72);
            this.assignLeave.TabIndex = 7;
            this.assignLeave.Text = "Assign Leave";
            this.assignLeave.UseVisualStyleBackColor = true;
            // 
            // createOrModifyGroupMemeberButton
            // 
            this.createOrModifyGroupMemeberButton.Location = new System.Drawing.Point(25, 867);
            this.createOrModifyGroupMemeberButton.Name = "createOrModifyGroupMemeberButton";
            this.createOrModifyGroupMemeberButton.Size = new System.Drawing.Size(242, 72);
            this.createOrModifyGroupMemeberButton.TabIndex = 8;
            this.createOrModifyGroupMemeberButton.Text = "Create Or Modify Group Members";
            this.createOrModifyGroupMemeberButton.UseVisualStyleBackColor = true;
            // 
            // beginDatePicker
            // 
            this.beginDatePicker.CalendarFont = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginDatePicker.CustomFormat = "dd-mm-yy";
            this.beginDatePicker.Location = new System.Drawing.Point(846, 842);
            this.beginDatePicker.MinDate = new System.DateTime(2020, 6, 28, 0, 0, 0, 0);
            this.beginDatePicker.Name = "beginDatePicker";
            this.beginDatePicker.Size = new System.Drawing.Size(208, 20);
            this.beginDatePicker.TabIndex = 10;
            this.beginDatePicker.ValueChanged += new System.EventHandler(this.beginDatePicker_ValueChanged);
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.CalendarFont = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateTimePicker.CustomFormat = "dd-mm-yy";
            this.endDateTimePicker.Location = new System.Drawing.Point(1312, 842);
            this.endDateTimePicker.MinDate = new System.DateTime(2020, 6, 28, 0, 0, 0, 0);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(208, 20);
            this.endDateTimePicker.TabIndex = 11;
            this.endDateTimePicker.ValueChanged += new System.EventHandler(this.endDatePicker_ValueChanged);
            // 
            // workLoadDataGrid
            // 
            this.workLoadDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workLoadDataGrid.Location = new System.Drawing.Point(1101, 877);
            this.workLoadDataGrid.Name = "workLoadDataGrid";
            this.workLoadDataGrid.Size = new System.Drawing.Size(108, 223);
            this.workLoadDataGrid.TabIndex = 12;
            this.workLoadDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.workLoadDataGrid_CellClick);
            this.workLoadDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.workLoadDataGrid_CellContentClick);
            // 
            // testTable
            // 
            this.testTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testTable.Location = new System.Drawing.Point(702, 877);
            this.testTable.Name = "testTable";
            this.testTable.Size = new System.Drawing.Size(244, 223);
            this.testTable.TabIndex = 13;
            this.testTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.testTable_CellDoubleClick);
            // 
            // beginDateTextBox
            // 
            this.beginDateTextBox.Location = new System.Drawing.Point(846, 816);
            this.beginDateTextBox.Name = "beginDateTextBox";
            this.beginDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.beginDateTextBox.TabIndex = 14;
            // 
            // endDateTextBox
            // 
            this.endDateTextBox.Location = new System.Drawing.Point(1134, 812);
            this.endDateTextBox.Name = "endDateTextBox";
            this.endDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.endDateTextBox.TabIndex = 15;
            // 
            // endTimePicker
            // 
            this.endTimePicker.CustomFormat = "mm:dd";
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endTimePicker.Location = new System.Drawing.Point(1537, 842);
            this.endTimePicker.MinDate = new System.DateTime(2020, 6, 28, 0, 0, 0, 0);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.Size = new System.Drawing.Size(158, 20);
            this.endTimePicker.TabIndex = 24;
            this.endTimePicker.ValueChanged += new System.EventHandler(this.endTimePicker_ValueChanged);
            // 
            // beginTimePicker
            // 
            this.beginTimePicker.Cursor = System.Windows.Forms.Cursors.No;
            this.beginTimePicker.CustomFormat = "mm:dd";
            this.beginTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.beginTimePicker.Location = new System.Drawing.Point(1075, 842);
            this.beginTimePicker.MinDate = new System.DateTime(2020, 6, 28, 0, 0, 0, 0);
            this.beginTimePicker.Name = "beginTimePicker";
            this.beginTimePicker.Size = new System.Drawing.Size(159, 20);
            this.beginTimePicker.TabIndex = 23;
            this.beginTimePicker.ValueChanged += new System.EventHandler(this.beginTimePicker_ValueChanged);
            // 
            // testDataGridView
            // 
            this.testDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testDataGridView.Location = new System.Drawing.Point(369, 877);
            this.testDataGridView.Name = "testDataGridView";
            this.testDataGridView.Size = new System.Drawing.Size(244, 223);
            this.testDataGridView.TabIndex = 25;
            this.testDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.testDataGridView_CellClick);
            this.testDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.testDataGridView_CellContentClick);
            // 
            // scheduleDataGridView
            // 
            this.scheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduleDataGridView.Location = new System.Drawing.Point(120, 25);
            this.scheduleDataGridView.Name = "scheduleDataGridView";
            this.scheduleDataGridView.Size = new System.Drawing.Size(1588, 658);
            this.scheduleDataGridView.TabIndex = 26;
            // 
            // returnedConstraintinfo
            // 
            this.returnedConstraintinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.returnedConstraintinfo.Location = new System.Drawing.Point(83, 698);
            this.returnedConstraintinfo.Name = "returnedConstraintinfo";
            this.returnedConstraintinfo.Size = new System.Drawing.Size(729, 150);
            this.returnedConstraintinfo.TabIndex = 27;
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1890, 1192);
            this.Controls.Add(this.returnedConstraintinfo);
            this.Controls.Add(this.scheduleDataGridView);
            this.Controls.Add(this.testDataGridView);
            this.Controls.Add(this.endTimePicker);
            this.Controls.Add(this.beginTimePicker);
            this.Controls.Add(this.endDateTextBox);
            this.Controls.Add(this.beginDateTextBox);
            this.Controls.Add(this.testTable);
            this.Controls.Add(this.workLoadDataGrid);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.beginDatePicker);
            this.Controls.Add(this.createOrModifyGroupMemeberButton);
            this.Controls.Add(this.assignLeave);
            this.Controls.Add(this.filleCalendarButton);
            this.Controls.Add(this.setUpWorkAssingmentsButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stopMonthCalendar);
            this.Name = "ScheduleForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workLoadDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnedConstraintinfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label stopMonthCalendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button setUpWorkAssingmentsButton;
        private System.Windows.Forms.Button filleCalendarButton;
        private System.Windows.Forms.Button assignLeave;
        private System.Windows.Forms.Button createOrModifyGroupMemeberButton;
        private System.Windows.Forms.DateTimePicker beginDatePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.DataGridView workLoadDataGrid;
        private System.Windows.Forms.DataGridView testTable;
        private System.Windows.Forms.TextBox beginDateTextBox;
        private System.Windows.Forms.TextBox endDateTextBox;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.DateTimePicker beginTimePicker;
        private System.Windows.Forms.DataGridView testDataGridView;
        private System.Windows.Forms.DataGridView scheduleDataGridView;
        private System.Windows.Forms.DataGridView returnedConstraintinfo;
    }
}

