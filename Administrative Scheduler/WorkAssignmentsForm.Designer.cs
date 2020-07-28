namespace Administrative_Scheduler
{
    partial class WorkAssignmentsForm
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
            this.workLoadConstraintsList = new System.Windows.Forms.DataGridView();
            this.createWorkAssignmentbutton = new System.Windows.Forms.Button();
            this.updateWorkAssignmentButton = new System.Windows.Forms.Button();
            this.workLoadNameTextBox = new System.Windows.Forms.TextBox();
            this.workAssignmentlabel = new System.Windows.Forms.Label();
            this.constraintNameabel = new System.Windows.Forms.Label();
            this.conststrainEnterButton = new System.Windows.Forms.Button();
            this.addAnotherConstraintbutton = new System.Windows.Forms.Button();
            this.constraintTypeLabe = new System.Windows.Forms.Label();
            this.constraintValuelabel = new System.Windows.Forms.Label();
            this.timeFramLable = new System.Windows.Forms.Label();
            this.durationValueListBox = new System.Windows.Forms.ListBox();
            this.timeFrameListBox = new System.Windows.Forms.ListBox();
            this.constraintNameTextBox = new System.Windows.Forms.TextBox();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.cycleValueLabel = new System.Windows.Forms.Label();
            this.cycleValueTextBox = new System.Windows.Forms.TextBox();
            this.cycleTimeFrameLabel = new System.Windows.Forms.Label();
            this.cycleTimeFrameListBox = new System.Windows.Forms.ListBox();
            this.everyLabel = new System.Windows.Forms.Label();
            this.returnToScheduleScreenButton = new System.Windows.Forms.Button();
            this.constraintAssingmentsGrid = new System.Windows.Forms.DataGridView();
            this.workLoadDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.workLoadConstraintsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.constraintAssingmentsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workLoadDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // workLoadConstraintsList
            // 
            this.workLoadConstraintsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workLoadConstraintsList.Location = new System.Drawing.Point(410, 74);
            this.workLoadConstraintsList.Name = "workLoadConstraintsList";
            this.workLoadConstraintsList.Size = new System.Drawing.Size(902, 374);
            this.workLoadConstraintsList.TabIndex = 0;
            this.workLoadConstraintsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.workLoadConstraintsList_CellClick);
            this.workLoadConstraintsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.workAssingmentsGrid_CellContentClick);
            // 
            // createWorkAssignmentbutton
            // 
            this.createWorkAssignmentbutton.Location = new System.Drawing.Point(55, 516);
            this.createWorkAssignmentbutton.Name = "createWorkAssignmentbutton";
            this.createWorkAssignmentbutton.Size = new System.Drawing.Size(135, 49);
            this.createWorkAssignmentbutton.TabIndex = 2;
            this.createWorkAssignmentbutton.Text = "Create Work Assignment";
            this.createWorkAssignmentbutton.UseVisualStyleBackColor = true;
            this.createWorkAssignmentbutton.Click += new System.EventHandler(this.createWorkAssignmentbutton_Click);
            // 
            // updateWorkAssignmentButton
            // 
            this.updateWorkAssignmentButton.Location = new System.Drawing.Point(55, 609);
            this.updateWorkAssignmentButton.Name = "updateWorkAssignmentButton";
            this.updateWorkAssignmentButton.Size = new System.Drawing.Size(135, 49);
            this.updateWorkAssignmentButton.TabIndex = 4;
            this.updateWorkAssignmentButton.Text = "Update Work Assignment";
            this.updateWorkAssignmentButton.UseVisualStyleBackColor = true;
            this.updateWorkAssignmentButton.Click += new System.EventHandler(this.updateWorkAssignmentButton_Click);
            // 
            // workLoadNameTextBox
            // 
            this.workLoadNameTextBox.Location = new System.Drawing.Point(220, 545);
            this.workLoadNameTextBox.Name = "workLoadNameTextBox";
            this.workLoadNameTextBox.Size = new System.Drawing.Size(158, 20);
            this.workLoadNameTextBox.TabIndex = 9;
            // 
            // workAssignmentlabel
            // 
            this.workAssignmentlabel.AutoSize = true;
            this.workAssignmentlabel.Location = new System.Drawing.Point(233, 507);
            this.workAssignmentlabel.Name = "workAssignmentlabel";
            this.workAssignmentlabel.Size = new System.Drawing.Size(121, 13);
            this.workAssignmentlabel.TabIndex = 10;
            this.workAssignmentlabel.Text = "Work Assingment Name";
            // 
            // constraintNameabel
            // 
            this.constraintNameabel.AutoSize = true;
            this.constraintNameabel.Location = new System.Drawing.Point(73, 806);
            this.constraintNameabel.Name = "constraintNameabel";
            this.constraintNameabel.Size = new System.Drawing.Size(85, 13);
            this.constraintNameabel.TabIndex = 11;
            this.constraintNameabel.Text = "Constraint Name";
            // 
            // conststrainEnterButton
            // 
            this.conststrainEnterButton.Location = new System.Drawing.Point(80, 885);
            this.conststrainEnterButton.Name = "conststrainEnterButton";
            this.conststrainEnterButton.Size = new System.Drawing.Size(98, 47);
            this.conststrainEnterButton.TabIndex = 12;
            this.conststrainEnterButton.Text = "Enter";
            this.conststrainEnterButton.UseVisualStyleBackColor = true;
            this.conststrainEnterButton.Click += new System.EventHandler(this.conststrainEnterButton_Click);
            // 
            // addAnotherConstraintbutton
            // 
            this.addAnotherConstraintbutton.Location = new System.Drawing.Point(57, 691);
            this.addAnotherConstraintbutton.Name = "addAnotherConstraintbutton";
            this.addAnotherConstraintbutton.Size = new System.Drawing.Size(98, 47);
            this.addAnotherConstraintbutton.TabIndex = 13;
            this.addAnotherConstraintbutton.Text = "Add Another Constraint";
            this.addAnotherConstraintbutton.UseVisualStyleBackColor = true;
            // 
            // constraintTypeLabe
            // 
            this.constraintTypeLabe.AutoSize = true;
            this.constraintTypeLabe.Location = new System.Drawing.Point(205, 806);
            this.constraintTypeLabe.Name = "constraintTypeLabe";
            this.constraintTypeLabe.Size = new System.Drawing.Size(46, 13);
            this.constraintTypeLabe.TabIndex = 14;
            this.constraintTypeLabe.Text = "Relation";
            // 
            // constraintValuelabel
            // 
            this.constraintValuelabel.AutoSize = true;
            this.constraintValuelabel.Location = new System.Drawing.Point(335, 806);
            this.constraintValuelabel.Name = "constraintValuelabel";
            this.constraintValuelabel.Size = new System.Drawing.Size(85, 13);
            this.constraintValuelabel.TabIndex = 15;
            this.constraintValuelabel.Text = "Interval Duration";
            // 
            // timeFramLable
            // 
            this.timeFramLable.AutoSize = true;
            this.timeFramLable.Location = new System.Drawing.Point(462, 806);
            this.timeFramLable.Name = "timeFramLable";
            this.timeFramLable.Size = new System.Drawing.Size(100, 13);
            this.timeFramLable.TabIndex = 16;
            this.timeFramLable.Text = "Interval Time Frame";
            // 
            // durationValueListBox
            // 
            this.durationValueListBox.FormattingEnabled = true;
            this.durationValueListBox.Items.AddRange(new object[] {
            "More than",
            "No More Than",
            "Less Than",
            "At Least",
            "Exactly"});
            this.durationValueListBox.Location = new System.Drawing.Point(208, 835);
            this.durationValueListBox.Name = "durationValueListBox";
            this.durationValueListBox.Size = new System.Drawing.Size(104, 17);
            this.durationValueListBox.TabIndex = 18;
            this.durationValueListBox.SelectedIndexChanged += new System.EventHandler(this.durationValueListBox_SelectedIndexChanged);
            // 
            // timeFrameListBox
            // 
            this.timeFrameListBox.FormattingEnabled = true;
            this.timeFrameListBox.Items.AddRange(new object[] {
            "Days",
            "Hours"});
            this.timeFrameListBox.Location = new System.Drawing.Point(465, 835);
            this.timeFrameListBox.Name = "timeFrameListBox";
            this.timeFrameListBox.Size = new System.Drawing.Size(105, 17);
            this.timeFrameListBox.TabIndex = 19;
            this.timeFrameListBox.SelectedIndexChanged += new System.EventHandler(this.timeFrameListBox_SelectedIndexChanged);
            // 
            // constraintNameTextBox
            // 
            this.constraintNameTextBox.Location = new System.Drawing.Point(76, 835);
            this.constraintNameTextBox.Name = "constraintNameTextBox";
            this.constraintNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.constraintNameTextBox.TabIndex = 20;
            // 
            // durationTextBox
            // 
            this.durationTextBox.Location = new System.Drawing.Point(338, 835);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(100, 20);
            this.durationTextBox.TabIndex = 21;
            // 
            // cycleValueLabel
            // 
            this.cycleValueLabel.AutoSize = true;
            this.cycleValueLabel.Location = new System.Drawing.Point(718, 806);
            this.cycleValueLabel.Name = "cycleValueLabel";
            this.cycleValueLabel.Size = new System.Drawing.Size(63, 13);
            this.cycleValueLabel.TabIndex = 22;
            this.cycleValueLabel.Text = "Cycle Value";
            this.cycleValueLabel.Click += new System.EventHandler(this.cycleValueLabel_Click);
            // 
            // cycleValueTextBox
            // 
            this.cycleValueTextBox.Location = new System.Drawing.Point(721, 835);
            this.cycleValueTextBox.Name = "cycleValueTextBox";
            this.cycleValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.cycleValueTextBox.TabIndex = 23;
            this.cycleValueTextBox.TextChanged += new System.EventHandler(this.cyclleValueTextBox_TextChanged);
            // 
            // cycleTimeFrameLabel
            // 
            this.cycleTimeFrameLabel.AutoSize = true;
            this.cycleTimeFrameLabel.Location = new System.Drawing.Point(846, 806);
            this.cycleTimeFrameLabel.Name = "cycleTimeFrameLabel";
            this.cycleTimeFrameLabel.Size = new System.Drawing.Size(91, 13);
            this.cycleTimeFrameLabel.TabIndex = 24;
            this.cycleTimeFrameLabel.Text = "Cycle Time Frame";
            this.cycleTimeFrameLabel.Click += new System.EventHandler(this.cycleTimeFrameLabel_Click);
            // 
            // cycleTimeFrameListBox
            // 
            this.cycleTimeFrameListBox.FormattingEnabled = true;
            this.cycleTimeFrameListBox.Items.AddRange(new object[] {
            "Month/Months",
            "Day/Days",
            "Week/Weeks"});
            this.cycleTimeFrameListBox.Location = new System.Drawing.Point(849, 835);
            this.cycleTimeFrameListBox.Name = "cycleTimeFrameListBox";
            this.cycleTimeFrameListBox.Size = new System.Drawing.Size(120, 17);
            this.cycleTimeFrameListBox.TabIndex = 25;
            this.cycleTimeFrameListBox.SelectedIndexChanged += new System.EventHandler(this.cycleTimeFrameListBox_SelectedIndexChanged);
            // 
            // everyLabel
            // 
            this.everyLabel.AutoSize = true;
            this.everyLabel.Location = new System.Drawing.Point(617, 835);
            this.everyLabel.Name = "everyLabel";
            this.everyLabel.Size = new System.Drawing.Size(34, 13);
            this.everyLabel.TabIndex = 26;
            this.everyLabel.Text = "Every";
            // 
            // returnToScheduleScreenButton
            // 
            this.returnToScheduleScreenButton.Location = new System.Drawing.Point(575, 906);
            this.returnToScheduleScreenButton.Name = "returnToScheduleScreenButton";
            this.returnToScheduleScreenButton.Size = new System.Drawing.Size(117, 46);
            this.returnToScheduleScreenButton.TabIndex = 27;
            this.returnToScheduleScreenButton.Text = "Return To Schedule Screen";
            this.returnToScheduleScreenButton.UseVisualStyleBackColor = true;
            this.returnToScheduleScreenButton.Click += new System.EventHandler(this.returnToScheduleScreenButton_Click);
            // 
            // constraintAssingmentsGrid
            // 
            this.constraintAssingmentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.constraintAssingmentsGrid.Location = new System.Drawing.Point(440, 545);
            this.constraintAssingmentsGrid.Name = "constraintAssingmentsGrid";
            this.constraintAssingmentsGrid.Size = new System.Drawing.Size(872, 222);
            this.constraintAssingmentsGrid.TabIndex = 28;
            this.constraintAssingmentsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.constraintAssingmentsGrid_CellClick);
            this.constraintAssingmentsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.constraintAssingmentsGrid_CellContentClick);
            // 
            // workLoadDataGridView
            // 
            this.workLoadDataGridView.AllowUserToAddRows = false;
            this.workLoadDataGridView.AllowUserToDeleteRows = false;
            this.workLoadDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workLoadDataGridView.Location = new System.Drawing.Point(55, 74);
            this.workLoadDataGridView.Name = "workLoadDataGridView";
            this.workLoadDataGridView.Size = new System.Drawing.Size(252, 374);
            this.workLoadDataGridView.TabIndex = 30;
            this.workLoadDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.workLoadDataGridView_CellClick);
            this.workLoadDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.workLoadDataGridView_CellContentClick);
            // 
            // WorkAssignmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 964);
            this.Controls.Add(this.workLoadDataGridView);
            this.Controls.Add(this.constraintAssingmentsGrid);
            this.Controls.Add(this.returnToScheduleScreenButton);
            this.Controls.Add(this.everyLabel);
            this.Controls.Add(this.cycleTimeFrameListBox);
            this.Controls.Add(this.cycleTimeFrameLabel);
            this.Controls.Add(this.cycleValueTextBox);
            this.Controls.Add(this.cycleValueLabel);
            this.Controls.Add(this.durationTextBox);
            this.Controls.Add(this.constraintNameTextBox);
            this.Controls.Add(this.timeFrameListBox);
            this.Controls.Add(this.durationValueListBox);
            this.Controls.Add(this.timeFramLable);
            this.Controls.Add(this.constraintValuelabel);
            this.Controls.Add(this.constraintTypeLabe);
            this.Controls.Add(this.addAnotherConstraintbutton);
            this.Controls.Add(this.conststrainEnterButton);
            this.Controls.Add(this.constraintNameabel);
            this.Controls.Add(this.workAssignmentlabel);
            this.Controls.Add(this.workLoadNameTextBox);
            this.Controls.Add(this.updateWorkAssignmentButton);
            this.Controls.Add(this.createWorkAssignmentbutton);
            this.Controls.Add(this.workLoadConstraintsList);
            this.Name = "WorkAssignmentsForm";
            this.Text = "--";
            this.Load += new System.EventHandler(this.WorkAssignmentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workLoadConstraintsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.constraintAssingmentsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workLoadDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView workLoadConstraintsList;
        private System.Windows.Forms.Button createWorkAssignmentbutton;
        private System.Windows.Forms.Button updateWorkAssignmentButton;
        private System.Windows.Forms.TextBox workLoadNameTextBox;
        public System.Windows.Forms.Label workAssignmentlabel;
        public System.Windows.Forms.Label constraintNameabel;
        private System.Windows.Forms.Button conststrainEnterButton;
        private System.Windows.Forms.Button addAnotherConstraintbutton;
        public System.Windows.Forms.Label constraintTypeLabe;
        public System.Windows.Forms.Label constraintValuelabel;
        public System.Windows.Forms.Label timeFramLable;
        private System.Windows.Forms.ListBox durationValueListBox;
        private System.Windows.Forms.ListBox timeFrameListBox;
        private System.Windows.Forms.TextBox constraintNameTextBox;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.Label cycleValueLabel;
        private System.Windows.Forms.TextBox cycleValueTextBox;
        private System.Windows.Forms.Label cycleTimeFrameLabel;
        private System.Windows.Forms.ListBox cycleTimeFrameListBox;
        public System.Windows.Forms.Label everyLabel;
        private System.Windows.Forms.Button returnToScheduleScreenButton;
        private System.Windows.Forms.DataGridView constraintAssingmentsGrid;
        private System.Windows.Forms.DataGridView workLoadDataGridView;
    }
}