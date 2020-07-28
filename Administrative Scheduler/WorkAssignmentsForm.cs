using System;
using System.Collections.Generic;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

//string coo administrativescheduler.database.windows.net,1433; Initial Catalog = administrativeServer; Persist Security Info=False;User ID = todd6822; Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;

namespace Administrative_Scheduler
{
  
    public partial class WorkAssignmentsForm : Form
    {
        SqlConnection conString = new SqlConnection("Data Source=administrativescheduler.database.windows.net,1433; Initial Catalog = administrativeServer; Persist Security Info=False;User ID = todd6822; Password=Ou812sir!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30");
        SqlDataAdapter Adapter1;
        SqlDataReader myReader = null;
        SqlCommand SQLCmd;
        DataTable DataTable1 = new DataTable();
        DataTable DataTable2 = new DataTable();
        DataTable DataTable3 = new DataTable();
        DataTable DataTable4 = new DataTable();
        AdminScheduleCallProceedure workLoadName = new AdminScheduleCallProceedure();

        string Parameter1Type = "";
        string Parameter2Type = "";
        string Parameter3Type = "";

        public WorkAssignmentsForm()
        {
            InitializeComponent();
        }

        private void listView1_Click(object sender, EventArgs e)
        {

        }

        private void workAssingmentsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cycleValueLabel_Click(object sender, EventArgs e)
        {

        }

        private void cycleTimeFrameLabel_Click(object sender, EventArgs e)
        {

        }

        private void cyclleValueTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cycleTimeFrameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void WorkAssignmentsForm_Load(object sender, EventArgs e)
        {
            

           DataTable1 =workLoadName.UseProceedure("findAllWorkloads");
            this.workLoadDataGridView.DataSource = DataTable1;


        }

        private void durationValueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Parameter1Type = durationValueListBox.SelectedItem.ToString();
        }

        private void timeFrameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Parameter2Type = timeFrameListBox.SelectedItem.ToString();
        }

        private void cycleTimeFrameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Parameter3Type = cycleTimeFrameListBox.SelectedItem.ToString();
        }

        private void conststrainEnterButton_Click(object sender, EventArgs e)
        {
            AdminScheduleCallProceedure newConstraint = new AdminScheduleCallProceedure();

            int durationValue = Convert.ToInt32(durationTextBox.Text);
            int cycleValueInt = Convert.ToInt32(cycleValueTextBox.Text);

            newConstraint.UseProceedure("createNewWorkLoadConstraint", "@constraintName", "@Relation", "@interval", "@intervalTimeFrame", "@CycleValue", "@CycleTimeFrame",
                constraintNameTextBox.Text, Parameter1Type, durationValue, Parameter2Type, cycleValueInt, Parameter3Type);

            MessageBox.Show("Constraint Created");

                                                                                       }

        private void createWorkAssignmentbutton_Click(object sender, EventArgs e)
        {


            AdminScheduleCallProceedure newWorkLoad = new AdminScheduleCallProceedure();
            newWorkLoad.UseProceedure("insertWorkLoad","@workLoadName", workLoadNameTextBox.Text);

            DataTable1.Clear();
            DataTable1 = workLoadName.UseProceedure("findAllWorkloads");
            this.workLoadDataGridView.DataSource = DataTable1;



        }

        private void constraintAssingmentsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            dataGridValues constraintGridClick = new dataGridValues();
            string valuefromElementNumber = constraintGridClick.returnElementString(sender, e, constraintAssingmentsGrid, DataTable3, 0);
            MessageBox.Show(valuefromElementNumber,"constraint Name");

            AdminScheduleCallProceedure assignConstraint = new AdminScheduleCallProceedure();

            assignConstraint.UseProceedure("assignConstraintsByName", "@workLoadName", "@constraintName", workLoadNameTextBox.Text, valuefromElementNumber);



        }

        private void workLoadDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridValues nameOfWorkload = new dataGridValues();
            AdminScheduleCallProceedure returnAllConstraintsForAWorkLoad = new AdminScheduleCallProceedure();
            AdminScheduleCallProceedure returnUnassinedConstratins = new AdminScheduleCallProceedure();
            dataGridValues findEntryNumber = new dataGridValues();
            string rowNumberForWorkLoad=findEntryNumber.returnElementString(sender, e, workLoadDataGridView, DataTable1, 0);
            MessageBox.Show(rowNumberForWorkLoad, "The workLoad name");

            DataTable2 = returnAllConstraintsForAWorkLoad.UseProceedure("returnAllConstraintsForAllWorkLoads", "@workLoadName", rowNumberForWorkLoad);

            DataTable3 = returnUnassinedConstratins.UseProceedure("returnUnassignedConstraints", "@workLoadName", rowNumberForWorkLoad);

            this.workLoadConstraintsList.DataSource = DataTable2;
            this.constraintAssingmentsGrid.DataSource = DataTable3;

            workLoadNameTextBox.Text = nameOfWorkload.returnElementString(sender, e, workLoadDataGridView, DataTable1, 0);
            



        }

        private void workLoadDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void workLoadConstraintsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AdminScheduleCallProceedure workLoadAndConstraint = new AdminScheduleCallProceedure();
            AdminScheduleCallProceedure removeConstraint = new AdminScheduleCallProceedure();
            DataTable1 = workLoadAndConstraint.UseProceedure("findAllWorkloads");
            this.workLoadDataGridView.DataSource = DataTable1;

            dataGridValues dataGridValueForConstraint = new dataGridValues();

            string constraintElementNumber = dataGridValueForConstraint.returnElementString(sender, e,workLoadConstraintsList, DataTable1, 0);

            MessageBox.Show(constraintElementNumber);

            removeConstraint.UseProceedure("unassignConstraintsByName", "@workLoadName", "@constraintName", workLoadNameTextBox.Text, constraintElementNumber);






        }

        private void constraintAssingmentsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void updateWorkAssignmentButton_Click(object sender, EventArgs e)
        {

            AdminScheduleCallProceedure loadUnasignedConstraints = new AdminScheduleCallProceedure();
            DataTable1 = loadUnasignedConstraints.UseProceedure("returnUnassignedConstraints","@workLoadName","");
            this.workLoadDataGridView.DataSource = DataTable1;
        }

        private void returnToScheduleScreenButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScheduleForm f1 = new ScheduleForm();
            f1.ShowDialog();
            this.Close();
        }
    }                                                               
}                                                                   
