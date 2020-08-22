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
using Administrative_Scheduler.administrativeServerDataSetTableAdapters;

namespace Administrative_Scheduler
{
    public partial class unitManagementScreen : Form
    {//Server=tcp:administrativescheduler.database.windows.net,1433;Initial Catalog=administrativeServer;Persist Security Info=False;User ID=todd6822;Password=Ou812sir!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;

        SqlConnection connection1 = new SqlConnection("Server=tcp:administrativescheduler.database.windows.net,1433;Initial Catalog=administrativeServer;Persist Security Info=False;User ID=todd6822;Password=Ou812sir!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        //AdminScheduleCallProceedure myQuerrie = new AdminScheduleCallProceedure();
        
        SqlDataAdapter Adapter1;
        SqlDataReader MyReader = null;
        SqlCommand SQLCmd;
        DataTable DataTable1 = new DataTable();
        DataTable DataTable2 = new DataTable();
        DataTable DataTable3 = new DataTable();
        DataTable DataTable4 = new DataTable();
        DateTime startDateTime;
        DateTime endDateTime;
        string idValueFromDataGrid = "";
        string idValueFromDataGrid2="";
        string valueFromDataGrid;
        string valueFromDataGrid2;
        string valueFromDataGrid3;
        string rowNumberFromDatagridView = "";
        string memberNumberFromDataGrid = "";
        SqlDataAdapter Adapter2;
        SqlDataAdapter Adapter3;
        bool timeEntered=false;
        
        //  DataTable DataTable1 = new DataTable();
        //  DataTable DataTable2 = new DataTable();


        public unitManagementScreen()
        {
            InitializeComponent();
        }

        private void unitManagementScreen_Load(object sender, EventArgs e)
        {
           // missingWorkLoadView.ColumnCount = 3;
            workLoadTable.Visible = false;
            beginTimePicker.Format = DateTimePickerFormat.Time;
            beginTimePicker.ShowUpDown = true;
            endTimePicker.Format = DateTimePickerFormat.Time;
            endTimePicker.ShowUpDown = true;
            beginDatePicker.Visible = false;
            endDatePicker.Visible = false;
            beginTimePicker.Visible = false;
            endTimePicker.Visible = false;
            enterButton.Visible = false;
            workLoadTable.Visible = false;

            teamMemberTable.Visible = true;


            AdminScheduleCallProceedure myQuerrie = new AdminScheduleCallProceedure();
            DataTable1 = myQuerrie.UseProceedure("selectAllMembers");

            this.teamMemberTable.DataSource = DataTable1;


        }

        private void updateLeave_Click(object sender, EventArgs e)
        {
                                      
            beginDatePicker.Visible = true;
            endDatePicker.Visible =   false;
            beginTimePicker.Visible = false;
            endTimePicker.Visible =   false;
        }

       

        private void CreateNewTeamMemberButton_Click(object sender, EventArgs e)
        {



            AdminScheduleCallProceedure myQuerrie4 = new AdminScheduleCallProceedure();
             myQuerrie4.insertSQL("InsertMemberInfo", "@MemberPsuedoNym", pseudonymTextBox.Text);

            workLoadTable.Visible = false;
            workLoadTable.ColumnCount = 3;
            teamMemberTable.Visible = true;

            /*connection1.Open();
                SQLCmd = new SqlCommand("dbo.InsertMemberInfo", connection1);
                SQLCmd.CommandType = CommandType.StoredProcedure;
                SQLCmd.Parameters.AddWithValue("@MemberPsuedoNym", pseudonymTextBox.Text);
                SQLCmd.ExecuteNonQuery();

                MessageBox.Show("InsertedIntMemberTable");*/



            teamMemberTable.Refresh();

            


            AdminScheduleCallProceedure myQuerrie = new AdminScheduleCallProceedure();
            DataTable1 = myQuerrie.UseProceedure("selectAllMembers");

            this.teamMemberTable.DataSource = DataTable1;

            connection1.Close();
        }

        private void updateTeamMemberButton_Click(object sender, EventArgs e)
        {
            workLoadTable.Visible = true;
            teamMemberTable.Visible = false;
            AdminScheduleCallProceedure myQuerrie2 = new AdminScheduleCallProceedure();
            AdminScheduleCallProceedure myQuerrie3 = new AdminScheduleCallProceedure();

            DataTable2.Clear();
            DataTable2.AcceptChanges();
            DataTable3.Clear();
            DataTable3.AcceptChanges();
            teamMemberTable.ReadOnly = false;
            teamMemberTable.DataSource = null;
            teamMemberTable.Columns.Clear();
            teamMemberTable.Refresh();

            teamMemberTable.CancelEdit();
            teamMemberTable.Columns.Clear();
            teamMemberTable.DataSource = null;

            DataTable2= myQuerrie2.UseProceedure("returnMemberWorkloads","@memberName",pseudonymTextBox.Text);
         
            this.workLoadTable.DataSource = DataTable2;


            DataTable3 = myQuerrie3.UseProceedure("returnUnassignedWorkloads","@memberName",pseudonymTextBox.Text);
            this.missingWorkLoadView.DataSource = DataTable3;

            connection1.Close();

            int numberOfAvailableWorkLoads = ((workLoadTable.Rows.Count)-1);
            MessageBox.Show(numberOfAvailableWorkLoads.ToString(), "Number of possible workLoads");

            int numberOfAssignedWorkLoads = ((missingWorkLoadView.Rows.Count)-1);
            MessageBox.Show(numberOfAssignedWorkLoads.ToString(), " Number Of Assinged WorkLoads");

           

          /* for (int x=0; x <numberOfAvailableWorkLoads;x++)
            {
                MessageBox.Show(this.missingWorkLoadView.Rows[x].Cells[0].Value.ToString());
                for (int y=0; y< numberOfAssignedWorkLoads; y++)
                {

                    if ((workLoadTable.Rows[y].Cells[0].Value.ToString())!=(missingWorkLoadView.Rows[x].Cells[0].Value.ToString()))
                        {

                        missingWorkLoadView.Rows[y].Cells[1].Value = "unassinged";

                        }
                    else
                    {
                        missingWorkLoadView.Rows[y].Cells[1].Value = "assigned";
                        
                    }

                }


            }*/

        }

        private void teamMemberTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void teamMemberTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            dataGridValues inputValues = new dataGridValues();
            valueFromDataGrid = inputValues.returnElementString(sender, e, teamMemberTable, DataTable1,1);
            memberNumberFromDataGrid = inputValues.returnElementString(sender, e, teamMemberTable, DataTable1, 0);

            MessageBox.Show(valueFromDataGrid,"Member Psuedonym");
            MessageBox.Show(memberNumberFromDataGrid, "Member Number");

            pseudonymTextBox.Text = valueFromDataGrid;


            /*
            int rows = 0;
            for (rows = 0; rows < DataTable1.Rows.Count; rows++)
            {
               
                var row = DataTable1.Rows[rows];
            }

            MessageBox.Show(rows.ToString());

            if ((e.RowIndex >= 0) && (e.RowIndex < rows)) 
                    {

                
                idValueFromDataGrid = this.teamMemberTable.Columns[1].Name;
                valueFromDataGrid = teamMemberTable.Rows[e.RowIndex].Cells[idValueFromDataGrid].Value.ToString();
                pseudonymTextBox.Text = valueFromDataGrid;
                



                 } */
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void updateExistingGroupMemberButton_Click(object sender, EventArgs e)
        {
            workLoadTable.Visible = false;
            teamMemberTable.Visible = true;


            AdminScheduleCallProceedure myQuerrie = new AdminScheduleCallProceedure();
            DataTable1 = myQuerrie.UseProceedure("selectAllMembers");

            this.teamMemberTable.DataSource = DataTable1;
            /*
            connection1.Open();// this is going to return all of the members when the table refreshes.
            SQLCmd = new SqlCommand("selectAllMembers", connection1);
            SQLCmd.CommandType = CommandType.StoredProcedure;
            SQLCmd.ExecuteNonQuery();
            Adapter1 = new SqlDataAdapter(SQLCmd);
            Adapter1.Fill(DataTable1);
            this.teamMemberTable.DataSource = DataTable1;
            connection1.Close();*/

            
        }

        private void missingWorkLoadView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
        }

       

        private void beginDatePicker_ValueChanged(object sender, EventArgs e)
        {
            startDateTime = beginDatePicker.Value.Date +
                    beginTimePicker.Value.TimeOfDay;
            MessageBox.Show(startDateTime.ToString());
           // endDatePicker.Visible = true;
           beginTimePicker.Visible = true;
           // endTimePicker.Visible = true;
        }
             
        private void beginTimePicker_ValueChanged(object sender, EventArgs e)
        {
            startDateTime = beginDatePicker.Value.Date +
                    beginTimePicker.Value.TimeOfDay;
            MessageBox.Show(startDateTime.ToString());
            endDatePicker.Visible = true;
        }

        private void endDatePicker_ValueChanged(object sender, EventArgs e)
        {
            endDateTime = endDatePicker.Value.Date +
                    endTimePicker.Value.TimeOfDay;
            MessageBox.Show(endDateTime.ToString());
            endTimePicker.Visible = true;
        }

        private void endTimePicker_ValueChanged(object sender, EventArgs e)
        {
            endDateTime = endDatePicker.Value.Date +
                  endTimePicker.Value.TimeOfDay;
            MessageBox.Show(endDateTime.ToString());
            timeEntered = true;
            enterButton.Visible = true;

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            AdminScheduleCallProceedure insertDate = new AdminScheduleCallProceedure();

            insertDate.UseProceedure("insertLeave", "@memberPsuednym", "@startDate", "@endDate ", pseudonymTextBox.Text, startDateTime, endDateTime);
        }

       
        private void viewLeaveButton_Click(object sender, EventArgs e)
        {

                  AdminScheduleCallProceedure findLeaveIDNumber = new AdminScheduleCallProceedure();
                     DataTable4=  findLeaveIDNumber.UseProceedure("returnLeavePeriods", "@memberPsuedoNym", pseudonymTextBox.Text);
            this.leaveDataGridView.DataSource = DataTable4;
        } 
        private void leaveDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            
            dataGridValues newRowValue = new dataGridValues();
            rowNumberFromDatagridView= newRowValue.returnElementString(sender,e,leaveDataGridView,DataTable4,0) ;

            MessageBox.Show(rowNumberFromDatagridView,"Row Number Clicked");
            leaveIDTextBox.Text = rowNumberFromDatagridView;







        }
        private void deleteLeavePeriod_Click(object sender, EventArgs e)
        {
            int proceedureInputInt;
            proceedureInputInt = Convert.ToInt32(rowNumberFromDatagridView);
            AdminScheduleCallProceedure deleteLeaveEvent = new AdminScheduleCallProceedure();
            deleteLeaveEvent.deleteRow("deleteLeave", "@leavePeriodID", proceedureInputInt);


        }

        private void leaveDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void workLoadTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool parseCheckSuccessWorkLoadTable;
            bool parseCheckSuccessMemberNumber;
            dataGridValues inputValues3 = new dataGridValues();
            valueFromDataGrid3 = inputValues3.returnElementString(sender, e, workLoadTable, DataTable2, 0);
            MessageBox.Show(valueFromDataGrid3);

            ValueCheckClass parseCheck1 = new ValueCheckClass();
            parseCheckSuccessWorkLoadTable = parseCheck1.checkForInt(valueFromDataGrid3);

             
            parseCheckSuccessMemberNumber= parseCheck1.checkForInt(memberNumberFromDataGrid);

            if (parseCheckSuccessWorkLoadTable == true)
            {
                int unassignedWorkLoadNumber = Convert.ToInt32(valueFromDataGrid3);


                if (parseCheckSuccessMemberNumber == true)
                {
                    int memberNumberToUpdate = Convert.ToInt32(memberNumberFromDataGrid);
                    AdminScheduleCallProceedure unassignWorkLoad = new AdminScheduleCallProceedure();
                    unassignWorkLoad.UseProceedure("unassignWorkload", "@memberID", "@workLoadID", memberNumberToUpdate, unassignedWorkLoadNumber);
                }

            }


           

            

                
            

        }


        private void missingWorkLoadView_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            dataGridValues inputValues2 = new dataGridValues();

            valueFromDataGrid2 = inputValues2.returnElementString(sender, e, missingWorkLoadView, DataTable1, 0);
            MessageBox.Show(valueFromDataGrid2);


            AdminScheduleCallProceedure assignWorkLoad = new AdminScheduleCallProceedure();
            AdminScheduleCallProceedure assignConstraints = new AdminScheduleCallProceedure();


            int memberNumber = Convert.ToInt32(memberNumberFromDataGrid);
            int workLoadNumber = Convert.ToInt32(valueFromDataGrid2);
            int timerValue = 0;
            int timer2Value = 0;
            DateTime newDateTime = DateTime.Now.AddDays(-14);
            

            assignWorkLoad.UseProceedure("insertIntoWorkloadJunctionTable","@workLoadID","@memberID",workLoadNumber, memberNumber);

            assignConstraints.UseProceedure("createTimersForAllConstraintDurringWorkLoadAssignment", "@workLoadID", "@memberNumber", "@timerValue", "@timer2Value","@DateTime" ,workLoadNumber, memberNumber, timerValue, timer2Value,newDateTime);




            /*
          

            int rows = 0;
            for (rows = 0; rows < DataTable1.Rows.Count; rows++)
            {

                var row = DataTable1.Rows[rows];
            }


            if ((e.RowIndex >= 0) && (e.RowIndex < rows))
            {

                DataGridViewRow row = missingWorkLoadView.Rows [e.RowIndex];
                idValueFromDataGrid2 = row.Cells[0].Value.ToString();
                    MessageBox.Show(idValueFromDataGrid2);
                //idValueFromDataGrid2 =this.missingWorkLoadView.Columns[1].Name;
              //  valueFromDataGrid2 = missingWorkLoadView.Rows[e.RowIndex].Cells[idValueFromDataGrid2].Value.ToString();
            
             }*/





        }

        private void workLoadTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void returnToScheduleScreenButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            WorkAssignmentsForm f1 = new WorkAssignmentsForm();
            f1.ShowDialog();
            this.Close();
        }
    }
    }

