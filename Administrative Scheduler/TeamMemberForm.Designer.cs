namespace Administrative_Scheduler
{
    partial class unitManagementScreen
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
            this.teamMemberTable = new System.Windows.Forms.DataGridView();
            this.createNewTeamMemberButton = new System.Windows.Forms.Button();
            this.updateTeamMemberButton = new System.Windows.Forms.Button();
            this.beginDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.leaveEndsLabel = new System.Windows.Forms.Label();
            this.leaveBeginsLabel = new System.Windows.Forms.Label();
            this.updateTeamMemberLabel = new System.Windows.Forms.Label();
            this.createTeamMemberLabel = new System.Windows.Forms.Label();
            this.pseudonymTextBox = new System.Windows.Forms.RichTextBox();
            this.teammemberNameLabel = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.viewLeaveButton = new System.Windows.Forms.Button();
            this.updateLeave = new System.Windows.Forms.Button();
            this.deleteLeaveButton = new System.Windows.Forms.Button();
            this.createNewGroupMemberButton = new System.Windows.Forms.Button();
            this.updateExistingGroupMemberButton = new System.Windows.Forms.Button();
            this.workLoadTable = new System.Windows.Forms.DataGridView();
            this.missingWorkLoadView = new System.Windows.Forms.DataGridView();
            this.beginTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.leaveDataGridView = new System.Windows.Forms.DataGridView();
            this.leaveIDTextBox = new System.Windows.Forms.TextBox();
            this.workloadNumberTextBox = new System.Windows.Forms.RichTextBox();
            this.workloadNumberLabel = new System.Windows.Forms.Label();
            this.unassignedWorkloadsLabel = new System.Windows.Forms.Label();
            this.assignedWorkloadsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.returnToScheduleScreenButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.teamMemberTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workLoadTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.missingWorkLoadView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // teamMemberTable
            // 
            this.teamMemberTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teamMemberTable.Location = new System.Drawing.Point(684, 91);
            this.teamMemberTable.Name = "teamMemberTable";
            this.teamMemberTable.Size = new System.Drawing.Size(236, 249);
            this.teamMemberTable.TabIndex = 0;
            this.teamMemberTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.teamMemberTable_CellClick);
            this.teamMemberTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.teamMemberTable_CellContentClick);
            // 
            // createNewTeamMemberButton
            // 
            this.createNewTeamMemberButton.Location = new System.Drawing.Point(88, 282);
            this.createNewTeamMemberButton.Name = "createNewTeamMemberButton";
            this.createNewTeamMemberButton.Size = new System.Drawing.Size(167, 58);
            this.createNewTeamMemberButton.TabIndex = 1;
            this.createNewTeamMemberButton.Text = "Create ";
            this.createNewTeamMemberButton.UseVisualStyleBackColor = true;
            this.createNewTeamMemberButton.Click += new System.EventHandler(this.CreateNewTeamMemberButton_Click);
            // 
            // updateTeamMemberButton
            // 
            this.updateTeamMemberButton.Location = new System.Drawing.Point(427, 282);
            this.updateTeamMemberButton.Name = "updateTeamMemberButton";
            this.updateTeamMemberButton.Size = new System.Drawing.Size(167, 58);
            this.updateTeamMemberButton.TabIndex = 2;
            this.updateTeamMemberButton.Text = "Update";
            this.updateTeamMemberButton.UseVisualStyleBackColor = true;
            this.updateTeamMemberButton.Click += new System.EventHandler(this.updateTeamMemberButton_Click);
            // 
            // beginDatePicker
            // 
            this.beginDatePicker.CalendarFont = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginDatePicker.CustomFormat = "dd-mm-yy hh:mm";
            this.beginDatePicker.Location = new System.Drawing.Point(280, 674);
            this.beginDatePicker.MinDate = new System.DateTime(2020, 6, 28, 0, 0, 0, 0);
            this.beginDatePicker.Name = "beginDatePicker";
            this.beginDatePicker.Size = new System.Drawing.Size(208, 20);
            this.beginDatePicker.TabIndex = 3;
            this.beginDatePicker.ValueChanged += new System.EventHandler(this.beginDatePicker_ValueChanged);
            // 
            // endDatePicker
            // 
            this.endDatePicker.CustomFormat = "dd-mm-yy hh:mm";
            this.endDatePicker.Location = new System.Drawing.Point(280, 774);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(204, 20);
            this.endDatePicker.TabIndex = 4;
            this.endDatePicker.ValueChanged += new System.EventHandler(this.endDatePicker_ValueChanged);
            // 
            // leaveEndsLabel
            // 
            this.leaveEndsLabel.AutoSize = true;
            this.leaveEndsLabel.Location = new System.Drawing.Point(277, 737);
            this.leaveEndsLabel.Name = "leaveEndsLabel";
            this.leaveEndsLabel.Size = new System.Drawing.Size(64, 13);
            this.leaveEndsLabel.TabIndex = 5;
            this.leaveEndsLabel.Text = "Leave Ends";
            // 
            // leaveBeginsLabel
            // 
            this.leaveBeginsLabel.AutoSize = true;
            this.leaveBeginsLabel.Location = new System.Drawing.Point(277, 640);
            this.leaveBeginsLabel.Name = "leaveBeginsLabel";
            this.leaveBeginsLabel.Size = new System.Drawing.Size(72, 13);
            this.leaveBeginsLabel.TabIndex = 6;
            this.leaveBeginsLabel.Text = "Leave Begins";
            // 
            // updateTeamMemberLabel
            // 
            this.updateTeamMemberLabel.AutoSize = true;
            this.updateTeamMemberLabel.Location = new System.Drawing.Point(424, 80);
            this.updateTeamMemberLabel.Name = "updateTeamMemberLabel";
            this.updateTeamMemberLabel.Size = new System.Drawing.Size(166, 13);
            this.updateTeamMemberLabel.TabIndex = 7;
            this.updateTeamMemberLabel.Text = "Update an existing Team Member";
            // 
            // createTeamMemberLabel
            // 
            this.createTeamMemberLabel.AutoSize = true;
            this.createTeamMemberLabel.Location = new System.Drawing.Point(95, 80);
            this.createTeamMemberLabel.Name = "createTeamMemberLabel";
            this.createTeamMemberLabel.Size = new System.Drawing.Size(116, 13);
            this.createTeamMemberLabel.TabIndex = 8;
            this.createTeamMemberLabel.Text = "Create  a team member";
            // 
            // pseudonymTextBox
            // 
            this.pseudonymTextBox.Location = new System.Drawing.Point(249, 406);
            this.pseudonymTextBox.Name = "pseudonymTextBox";
            this.pseudonymTextBox.Size = new System.Drawing.Size(113, 32);
            this.pseudonymTextBox.TabIndex = 9;
            this.pseudonymTextBox.Text = "";
            // 
            // teammemberNameLabel
            // 
            this.teammemberNameLabel.AutoSize = true;
            this.teammemberNameLabel.Location = new System.Drawing.Point(246, 366);
            this.teammemberNameLabel.Name = "teammemberNameLabel";
            this.teammemberNameLabel.Size = new System.Drawing.Size(134, 13);
            this.teammemberNameLabel.TabIndex = 11;
            this.teammemberNameLabel.Text = "Team member psuedonym ";
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(341, 841);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(143, 69);
            this.enterButton.TabIndex = 12;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // viewLeaveButton
            // 
            this.viewLeaveButton.Location = new System.Drawing.Point(786, 625);
            this.viewLeaveButton.Name = "viewLeaveButton";
            this.viewLeaveButton.Size = new System.Drawing.Size(143, 69);
            this.viewLeaveButton.TabIndex = 13;
            this.viewLeaveButton.Text = "View Leave Schedule";
            this.viewLeaveButton.UseVisualStyleBackColor = true;
            this.viewLeaveButton.Click += new System.EventHandler(this.viewLeaveButton_Click);
            // 
            // updateLeave
            // 
            this.updateLeave.Location = new System.Drawing.Point(88, 640);
            this.updateLeave.Name = "updateLeave";
            this.updateLeave.Size = new System.Drawing.Size(167, 39);
            this.updateLeave.TabIndex = 14;
            this.updateLeave.Text = "Add  leave Period?";
            this.updateLeave.UseVisualStyleBackColor = true;
            this.updateLeave.Click += new System.EventHandler(this.updateLeave_Click);
            // 
            // deleteLeaveButton
            // 
            this.deleteLeaveButton.Location = new System.Drawing.Point(786, 755);
            this.deleteLeaveButton.Name = "deleteLeaveButton";
            this.deleteLeaveButton.Size = new System.Drawing.Size(167, 39);
            this.deleteLeaveButton.TabIndex = 15;
            this.deleteLeaveButton.Text = "Delete Leave Period?";
            this.deleteLeaveButton.UseVisualStyleBackColor = true;
            this.deleteLeaveButton.Click += new System.EventHandler(this.deleteLeavePeriod_Click);
            // 
            // createNewGroupMemberButton
            // 
            this.createNewGroupMemberButton.Location = new System.Drawing.Point(88, 119);
            this.createNewGroupMemberButton.Name = "createNewGroupMemberButton";
            this.createNewGroupMemberButton.Size = new System.Drawing.Size(167, 63);
            this.createNewGroupMemberButton.TabIndex = 17;
            this.createNewGroupMemberButton.Text = "Create New Group Member";
            this.createNewGroupMemberButton.UseVisualStyleBackColor = true;
            this.createNewGroupMemberButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateExistingGroupMemberButton
            // 
            this.updateExistingGroupMemberButton.Location = new System.Drawing.Point(427, 119);
            this.updateExistingGroupMemberButton.Name = "updateExistingGroupMemberButton";
            this.updateExistingGroupMemberButton.Size = new System.Drawing.Size(167, 63);
            this.updateExistingGroupMemberButton.TabIndex = 18;
            this.updateExistingGroupMemberButton.Text = "Update Existing Group Member";
            this.updateExistingGroupMemberButton.UseVisualStyleBackColor = true;
            this.updateExistingGroupMemberButton.Click += new System.EventHandler(this.updateExistingGroupMemberButton_Click);
            // 
            // workLoadTable
            // 
            this.workLoadTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workLoadTable.Location = new System.Drawing.Point(762, 425);
            this.workLoadTable.Name = "workLoadTable";
            this.workLoadTable.Size = new System.Drawing.Size(257, 187);
            this.workLoadTable.TabIndex = 19;
            this.workLoadTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.workLoadTable_CellClick);
            this.workLoadTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.workLoadTable_CellContentClick);
            // 
            // missingWorkLoadView
            // 
            this.missingWorkLoadView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.missingWorkLoadView.Location = new System.Drawing.Point(471, 425);
            this.missingWorkLoadView.Name = "missingWorkLoadView";
            this.missingWorkLoadView.Size = new System.Drawing.Size(251, 187);
            this.missingWorkLoadView.TabIndex = 20;
            this.missingWorkLoadView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.missingWorkLoadView_CellClick);
            this.missingWorkLoadView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.missingWorkLoadView_CellContentClick);
            // 
            // beginTimePicker
            // 
            this.beginTimePicker.Cursor = System.Windows.Forms.Cursors.No;
            this.beginTimePicker.CustomFormat = "mm:dd";
            this.beginTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.beginTimePicker.Location = new System.Drawing.Point(579, 674);
            this.beginTimePicker.MinDate = new System.DateTime(2020, 6, 28, 0, 0, 0, 0);
            this.beginTimePicker.Name = "beginTimePicker";
            this.beginTimePicker.Size = new System.Drawing.Size(159, 20);
            this.beginTimePicker.TabIndex = 21;
            this.beginTimePicker.ValueChanged += new System.EventHandler(this.beginTimePicker_ValueChanged);
            // 
            // endTimePicker
            // 
            this.endTimePicker.CustomFormat = "mm:dd";
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endTimePicker.Location = new System.Drawing.Point(579, 774);
            this.endTimePicker.MinDate = new System.DateTime(2020, 6, 28, 0, 0, 0, 0);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.Size = new System.Drawing.Size(158, 20);
            this.endTimePicker.TabIndex = 22;
            this.endTimePicker.ValueChanged += new System.EventHandler(this.endTimePicker_ValueChanged);
            // 
            // leaveDataGridView
            // 
            this.leaveDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.leaveDataGridView.Location = new System.Drawing.Point(1106, 625);
            this.leaveDataGridView.Name = "leaveDataGridView";
            this.leaveDataGridView.Size = new System.Drawing.Size(287, 169);
            this.leaveDataGridView.TabIndex = 23;
            this.leaveDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.leaveDataGridView_CellClick);
            this.leaveDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.leaveDataGridView_CellContentClick);
            // 
            // leaveIDTextBox
            // 
            this.leaveIDTextBox.Location = new System.Drawing.Point(978, 755);
            this.leaveIDTextBox.Name = "leaveIDTextBox";
            this.leaveIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.leaveIDTextBox.TabIndex = 24;
            // 
            // workloadNumberTextBox
            // 
            this.workloadNumberTextBox.Location = new System.Drawing.Point(249, 497);
            this.workloadNumberTextBox.Name = "workloadNumberTextBox";
            this.workloadNumberTextBox.Size = new System.Drawing.Size(113, 32);
            this.workloadNumberTextBox.TabIndex = 25;
            this.workloadNumberTextBox.Text = "";
            // 
            // workloadNumberLabel
            // 
            this.workloadNumberLabel.AutoSize = true;
            this.workloadNumberLabel.Location = new System.Drawing.Point(246, 467);
            this.workloadNumberLabel.Name = "workloadNumberLabel";
            this.workloadNumberLabel.Size = new System.Drawing.Size(93, 13);
            this.workloadNumberLabel.TabIndex = 26;
            this.workloadNumberLabel.Text = "Workload Number";
            // 
            // unassignedWorkloadsLabel
            // 
            this.unassignedWorkloadsLabel.AutoSize = true;
            this.unassignedWorkloadsLabel.Location = new System.Drawing.Point(400, 394);
            this.unassignedWorkloadsLabel.Name = "unassignedWorkloadsLabel";
            this.unassignedWorkloadsLabel.Size = new System.Drawing.Size(117, 13);
            this.unassignedWorkloadsLabel.TabIndex = 27;
            this.unassignedWorkloadsLabel.Text = "Unassigned Workloads";
            // 
            // assignedWorkloadsLabel
            // 
            this.assignedWorkloadsLabel.AutoSize = true;
            this.assignedWorkloadsLabel.Location = new System.Drawing.Point(786, 394);
            this.assignedWorkloadsLabel.Name = "assignedWorkloadsLabel";
            this.assignedWorkloadsLabel.Size = new System.Drawing.Size(104, 13);
            this.assignedWorkloadsLabel.TabIndex = 28;
            this.assignedWorkloadsLabel.Text = "Assigned Workloads";
            this.assignedWorkloadsLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 541);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 30;
            // 
            // returnToScheduleScreenButton
            // 
            this.returnToScheduleScreenButton.Location = new System.Drawing.Point(1032, 91);
            this.returnToScheduleScreenButton.Name = "returnToScheduleScreenButton";
            this.returnToScheduleScreenButton.Size = new System.Drawing.Size(176, 74);
            this.returnToScheduleScreenButton.TabIndex = 31;
            this.returnToScheduleScreenButton.Text = "Return To Schedule Screen";
            this.returnToScheduleScreenButton.UseVisualStyleBackColor = true;
            this.returnToScheduleScreenButton.Click += new System.EventHandler(this.returnToScheduleScreenButton_Click);
            // 
            // unitManagementScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 964);
            this.Controls.Add(this.returnToScheduleScreenButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.assignedWorkloadsLabel);
            this.Controls.Add(this.unassignedWorkloadsLabel);
            this.Controls.Add(this.workloadNumberLabel);
            this.Controls.Add(this.workloadNumberTextBox);
            this.Controls.Add(this.leaveIDTextBox);
            this.Controls.Add(this.leaveDataGridView);
            this.Controls.Add(this.endTimePicker);
            this.Controls.Add(this.beginTimePicker);
            this.Controls.Add(this.missingWorkLoadView);
            this.Controls.Add(this.workLoadTable);
            this.Controls.Add(this.updateExistingGroupMemberButton);
            this.Controls.Add(this.createNewGroupMemberButton);
            this.Controls.Add(this.deleteLeaveButton);
            this.Controls.Add(this.updateLeave);
            this.Controls.Add(this.viewLeaveButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.teammemberNameLabel);
            this.Controls.Add(this.pseudonymTextBox);
            this.Controls.Add(this.createTeamMemberLabel);
            this.Controls.Add(this.updateTeamMemberLabel);
            this.Controls.Add(this.leaveBeginsLabel);
            this.Controls.Add(this.leaveEndsLabel);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.beginDatePicker);
            this.Controls.Add(this.updateTeamMemberButton);
            this.Controls.Add(this.createNewTeamMemberButton);
            this.Controls.Add(this.teamMemberTable);
            this.Name = "unitManagementScreen";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.unitManagementScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teamMemberTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workLoadTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.missingWorkLoadView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView teamMemberTable;
        private System.Windows.Forms.Button createNewTeamMemberButton;
        private System.Windows.Forms.Button updateTeamMemberButton;
        private System.Windows.Forms.DateTimePicker beginDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Label leaveEndsLabel;
        private System.Windows.Forms.Label leaveBeginsLabel;
        private System.Windows.Forms.Label updateTeamMemberLabel;
        private System.Windows.Forms.Label createTeamMemberLabel;
        private System.Windows.Forms.RichTextBox pseudonymTextBox;
        private System.Windows.Forms.Label teammemberNameLabel;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button viewLeaveButton;
        private System.Windows.Forms.Button updateLeave;
        private System.Windows.Forms.Button deleteLeaveButton;
        private System.Windows.Forms.Button createNewGroupMemberButton;
        private System.Windows.Forms.Button updateExistingGroupMemberButton;
        private System.Windows.Forms.DataGridView workLoadTable;
        private System.Windows.Forms.DataGridView missingWorkLoadView;
        private System.Windows.Forms.DateTimePicker beginTimePicker;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.DataGridView leaveDataGridView;
        private System.Windows.Forms.TextBox leaveIDTextBox;
        private System.Windows.Forms.RichTextBox workloadNumberTextBox;
        private System.Windows.Forms.Label workloadNumberLabel;
        private System.Windows.Forms.Label unassignedWorkloadsLabel;
        private System.Windows.Forms.Label assignedWorkloadsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button returnToScheduleScreenButton;
    }
}