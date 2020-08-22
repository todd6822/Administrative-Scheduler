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
using System.Data.SqlTypes;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Administrative_Scheduler
{


    public partial class ScheduleForm : Form
    {
        int numberOfWorkloads = 0;
        int numberOfSelectedWorkLoads = 0;
        int elementToAddWorkto = 0;
        string valuefromElementNumber = "";
        string[] strArray = new string[] { };
        SqlDateTime startTime=DateTime.Now;
        SqlDateTime endTime;
        DataTable table1;
        DataTable table2;
        DataTable table3;
        DateTime startDateTime = DateTime.Now;
        DateTime endDateTime;
        TimeSpan difference;
        int cellNUmber = 0;
        AdminScheduleCallProceedure workLoadName = new AdminScheduleCallProceedure();
        String workLoad;
        

        int numberOfConstraints=0;

        public ScheduleForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table1 = workLoadName.UseProceedure("findAllWorkloads");
            this.workLoadDataGrid.DataSource = table1; 
            endDateTime= startDateTime.AddDays(1);

            //dataGridView1.Rows[rowIndex].Cells[columnIndex].Value = value;
            testDataGridView.ColumnCount = 2;

            /*  var index = this.testDataGridView.Rows.Add();
             index = this.testDataGridView.Rows.Add();*/
            testDataGridView.Columns[0].Name  = " WorkLoad Name ";
            testDataGridView.Columns[1].Name = " Number Of Workers ";


        }

        private void startMonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void endMonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {

            startDateTime = beginDatePicker.Value.Date +
                   beginTimePicker.Value.TimeOfDay;
        }

        private void beginDatePicker_ValueChanged(object sender, EventArgs e)
        {
            startDateTime = beginDatePicker.Value.Date +
                    beginTimePicker.Value.TimeOfDay;// startTime = beginDatePicker.Value.Date;
                                                    // MessageBox.Show(startTime.ToString());
        }

        private void endDatePicker_ValueChanged(object sender, EventArgs e)
        {
            endDateTime = endDateTimePicker.Value.Date+
                endDateTimePicker.Value.TimeOfDay;
            MessageBox.Show(endTime.ToString());

        }

        private void workLoadDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            AdminScheduleCallProceedure returnWorkersWithWorkloadsAssinged  = new AdminScheduleCallProceedure();
            AdminScheduleCallProceedure unassignWorkLoad = new AdminScheduleCallProceedure();
            AdminScheduleCallProceedure findNumberOfConstraint = new AdminScheduleCallProceedure();


            numberOfWorkloads = table1.Rows.Count;
            Array.Resize(ref strArray, numberOfWorkloads);
            
           // MessageBox.Show(Convert.ToString(numberOfWorkloads), "Number of workloads");

            dataGridValues constraintGridClick = new dataGridValues();
             valuefromElementNumber = constraintGridClick.returnElementString(sender, e, workLoadDataGrid, table1, 0);
            workLoad = valuefromElementNumber;

            if ( elementToAddWorkto< numberOfWorkloads)
            {
                strArray[elementToAddWorkto] = valuefromElementNumber;
                elementToAddWorkto=elementToAddWorkto+1;
            }

            /*for (int y = 0; y < numberOfWorkloads; y++)
            {
                MessageBox.Show(strArray[y],"From Array");

            }*/

            table2 = returnWorkersWithWorkloadsAssinged.UseProceedure("returnLeaveAndWorkload", "@workLoad", "@scheduleDay", valuefromElementNumber,startDateTime);
            this.testTable.DataSource = table2;
           // MessageBox.Show(valuefromElementNumber,"WorkloadName");
             numberOfConstraints= findNumberOfConstraint.UseProceedureReturnInt2("ReturnNumberOfConstraints", "@workLoadName", valuefromElementNumber);
         //  MessageBox.Show(Convert.ToString(numberOfConstraints), " this workload has this many rules assoicated with it");

            var index = this.testDataGridView.Rows.Add();
            this.testDataGridView.Rows[numberOfSelectedWorkLoads].Cells[0].Value = valuefromElementNumber;
            this.testDataGridView.Rows[numberOfSelectedWorkLoads].Cells[1].Value = "1";

          
            numberOfSelectedWorkLoads++;
        }

        private void workLoadDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void beginTimePicker_ValueChanged(object sender, EventArgs e)
        { 
        }
        private void endTimePicker_ValueChanged(object sender, EventArgs e)
        {
            endDateTime = endDateTimePicker.Value.Date +
                endDateTimePicker.Value.TimeOfDay;
          //  MessageBox.Show(endTime.ToString());
        }
        private void filleCalendarButton_MouseClick(object sender, MouseEventArgs e)
        {
        }





        /*********************************************************************************************************************************************************/
        private void filleCalendarButton_Click(object sender, EventArgs e)
        {
            scheduleDataGridView.Rows.Clear();
            scheduleDataGridView.DataSource = null;
            string[] memberAssignmentArray = new string[] { };
            SortAlgorithm.sortConstraints scheduleSort = new SortAlgorithm.sortConstraints();
            linkedListClass myList = new linkedListClass();
            linkedListClass list2 = new linkedListClass();
            linkedListClass list3 = new linkedListClass();
            linkedListClass list4 = new linkedListClass();
            linkedListClass list5 = new linkedListClass();
            linkedListClass list6 = new linkedListClass();
            linkedListClass list7 = new linkedListClass();
            linkedListClass list8 = new linkedListClass();
            linkedListClass list9 = new linkedListClass();
            linkedListClass list10 = new linkedListClass();
            AdminScheduleCallProceedure findAvailableMembers = new AdminScheduleCallProceedure();
            SortAlgorithm.sortConstraints myNewSort = new SortAlgorithm.sortConstraints();
            SortAlgorithm.sortConstraints algorithim = new SortAlgorithm.sortConstraints();
            DateTime dayShown = startDateTime;
            string numberOfWorkersString = "";
            string workloadName = "";
            int numberOfWorkLoads = 0;
            int numberOfWorkers = 0;
            int listSize = 0;
            int myListSize;
            
            int arraySize;
            string valueFromDataGrid;
            
           // int nmumberOfWorkers;


            difference = endDateTime-startDateTime;

            int daysBetweenStartStop = Convert.ToInt32(difference.Days);

           // MessageBox.Show(Convert.ToString(daysBetweenStartStop));


            scheduleDataGridView.ColumnCount = daysBetweenStartStop;

            for (int y = 0; y< (daysBetweenStartStop); y++)
            {   int rowNumber = 0;
                scheduleDataGridView.Columns[y].Name = Convert.ToString(dayShown);
                dayShown = dayShown.AddDays(1);//add in here



                numberOfWorkers = Convert.ToInt32((string)testDataGridView.Rows[0].Cells[1].Value);
                workloadName = Convert.ToString(testDataGridView.Rows[0].Cells[0].Value);

                numberOfWorkLoads = testDataGridView.Rows.Count;
                table3 = findAvailableMembers.UseProceedure("returnMemberNotOnLeave", "@scheduleDay", dayShown);
                myList = scheduleSort.fillList(table3, workloadName);
               listSize= myList.countNodes();
               // myList.deleteNodesThatContain(0);
               
         //        MessageBox.Show(Convert.ToString(numberOfWorkers), " number of workers");

                
                myList.selectNodesForList(list2, workloadName, dayShown, numberOfWorkers, listSize, returnedConstraintinfo);



                 

                valueFromDataGrid = (string)testDataGridView.Rows[0].Cells[0].Value;

                //listSize = myList.countNodes();

                //  MessageBox.Show("reading list1");
                //list2.countNodes();




                int primaryListSize = myList.countNodes();
               
              
       //         MessageBox.Show(Convert.ToString(listSize), "My list beforestuff");

             //   myList.transferToNewList(numberOfWorkers, listSize, list2);

                listSize = myList.countNodes();
                
               
       //         MessageBox.Show(Convert.ToString(listSize),"My list Size after transfer");
                myList.transferToNewList(numberOfWorkers, listSize, list2);

                listSize = myList.countNodes();

                memberAssignmentArray = myList.CycleConstraint(workloadName, dayShown, listSize);


                
                listSize = myList.countNodes();
   //          ;


             

                arraySize = memberAssignmentArray.Length;





              
               int numberOfNodes= myList.countNodes();
                Array.Resize(ref memberAssignmentArray, listSize);

                

                numberOfWorkLoads = numberOfWorkLoads - 1;

                for (int x = 0; x < listSize; x++)
                {
                    var index = this.scheduleDataGridView.Rows.Add();
                    
                    
                    this.scheduleDataGridView.Rows[rowNumber].Cells[cellNUmber].Value = memberAssignmentArray[x];
                    rowNumber = rowNumber + 1;
                }


                myListSize = myList.countNodes();
//

                Array.Clear(memberAssignmentArray, 0, memberAssignmentArray.Length);
                if (numberOfWorkLoads > 1)

                {
                    Array.Clear(memberAssignmentArray, 0, memberAssignmentArray.Length);
                    workloadName = this.testDataGridView.Rows[1].Cells[0].Value.ToString();
                    numberOfWorkersString = this.testDataGridView.Rows[1].Cells[1].Value.ToString();
                    numberOfWorkers = Convert.ToInt32(numberOfWorkersString);

                    listSize = list2.countNodes();
                    list2.selectNodesForList(list3, workloadName, dayShown/*replace with dayShown when added to the while loop*/, numberOfWorkers, listSize, returnedConstraintinfo);

                    list2.transferToNewList(numberOfWorkers, listSize, list3);
                    listSize = list2.countNodes();
                    memberAssignmentArray = list2.CycleConstraint(workloadName, dayShown, listSize);
                    for (int x = 0; x < listSize; x++)
                    {
                        var index = this.scheduleDataGridView.Rows.Add();
                        this.scheduleDataGridView.Rows[rowNumber].Cells[cellNUmber].Value = memberAssignmentArray[x];
                        rowNumber = rowNumber + 1;
                    }
                }


                if (numberOfWorkLoads > 2)
                    
                {
                    Array.Clear(memberAssignmentArray, 0, memberAssignmentArray.Length);
                    workloadName = this.testDataGridView.Rows[2].Cells[0].Value.ToString();
                    numberOfWorkersString = this.testDataGridView.Rows[2].Cells[1].Value.ToString();
                    numberOfWorkers = Convert.ToInt32(numberOfWorkersString);
                    listSize = list3.countNodes();
                    list3.selectNodesForList(list4, workloadName,dayShown/*replace with dayShown when added to the while loop*/, numberOfWorkers, listSize, returnedConstraintinfo);
                    list3.transferToNewList(numberOfWorkers, listSize, list4);
                    listSize = list3.countNodes();
                    memberAssignmentArray = list3.CycleConstraint(workloadName, dayShown, listSize);
                    for (int x = 0; x < listSize; x++)
                    {
                        var index = this.scheduleDataGridView.Rows.Add();
                        this.scheduleDataGridView.Rows[rowNumber].Cells[cellNUmber].Value = memberAssignmentArray[x];
                        rowNumber = rowNumber + 1;
                    }

                }


                if (numberOfWorkLoads > 3)

                {
                    Array.Clear(memberAssignmentArray, 0, memberAssignmentArray.Length);
                    workloadName = this.testDataGridView.Rows[3].Cells[0].Value.ToString();
                    numberOfWorkersString = this.testDataGridView.Rows[3].Cells[1].Value.ToString();
                    numberOfWorkers = Convert.ToInt32(numberOfWorkersString);
                    listSize = list4.countNodes();
                    list4.selectNodesForList(list5, workloadName, dayShown/*replace with dayShown when added to the while loop*/, numberOfWorkers, listSize,returnedConstraintinfo);
                    memberAssignmentArray = list4.CycleConstraint(workloadName, dayShown, listSize);
                    for (int x = 0; x < numberOfWorkers; x++)
                    {
                        var index = this.scheduleDataGridView.Rows.Add();
                        this.scheduleDataGridView.Rows[rowNumber].Cells[cellNUmber].Value = memberAssignmentArray[x];
                        rowNumber = rowNumber + 1;
                    }

                }


                if (numberOfWorkLoads > 4)

                {
                    Array.Clear(memberAssignmentArray, 0, memberAssignmentArray.Length);
                    workloadName = this.testDataGridView.Rows[4].Cells[0].Value.ToString();
                    numberOfWorkersString = this.testDataGridView.Rows[4].Cells[1].Value.ToString();
                    numberOfWorkers = Convert.ToInt32(numberOfWorkersString);
                    listSize = list5.countNodes();
                    list5.selectNodesForList(list6, workloadName, dayShown/*replace with dayShown when added to the while loop*/, numberOfWorkers, listSize,returnedConstraintinfo);
                    memberAssignmentArray = list5.CycleConstraint(workloadName, dayShown, listSize);
                    for (int x = 0; x < numberOfWorkers; x++)
                    {
                        var index = this.scheduleDataGridView.Rows.Add();
                        this.scheduleDataGridView.Rows[rowNumber].Cells[cellNUmber].Value = memberAssignmentArray[x];
                        rowNumber = rowNumber + 1;
                    }

                }



                if (numberOfWorkLoads > 5)

                {
                    Array.Clear(memberAssignmentArray, 0, memberAssignmentArray.Length);
                    workloadName = this.testDataGridView.Rows[5].Cells[0].Value.ToString();
                    numberOfWorkersString = this.testDataGridView.Rows[5].Cells[1].Value.ToString();
                    numberOfWorkers = Convert.ToInt32(numberOfWorkersString);
                    listSize = list6.countNodes();
                    list6.selectNodesForList(list7, workloadName, dayShown/*replace with dayShown when added to the while loop*/, numberOfWorkers, listSize,returnedConstraintinfo);
                    memberAssignmentArray = list6.CycleConstraint(workloadName, dayShown, listSize);
                    for (int x = 0; x < numberOfWorkers; x++)
                    {
                        var index = this.scheduleDataGridView.Rows.Add();
                        this.scheduleDataGridView.Rows[rowNumber].Cells[cellNUmber].Value = memberAssignmentArray[x];
                        rowNumber = rowNumber + 1;
                    }

                }
                if (numberOfWorkLoads > 6)

                {
                    Array.Clear(memberAssignmentArray, 0, memberAssignmentArray.Length);
                    workloadName = this.testDataGridView.Rows[6].Cells[0].Value.ToString();
                    numberOfWorkersString = this.testDataGridView.Rows[6].Cells[1].Value.ToString();
                    numberOfWorkers = Convert.ToInt32(numberOfWorkersString);
                    listSize = list7.countNodes();
                    list7.selectNodesForList(list8, workloadName, dayShown/*replace with dayShown when added to the while loop*/, numberOfWorkers, listSize,returnedConstraintinfo);
                    memberAssignmentArray = list7.CycleConstraint(workloadName, dayShown, listSize);
                    for (int x = 0; x < numberOfWorkers; x++)
                    {
                        var index = this.scheduleDataGridView.Rows.Add();
                        this.scheduleDataGridView.Rows[rowNumber].Cells[cellNUmber].Value = memberAssignmentArray[x];
                        rowNumber = rowNumber + 1;
                    }

                }

                if (numberOfWorkLoads > 7)

                {
                    Array.Clear(memberAssignmentArray, 0, memberAssignmentArray.Length);
                    workloadName = this.testDataGridView.Rows[7].Cells[0].Value.ToString();
                    numberOfWorkersString = this.testDataGridView.Rows[7].Cells[1].Value.ToString();
                    numberOfWorkers = Convert.ToInt32(numberOfWorkersString);
                    listSize = list8.countNodes();
                    list8.selectNodesForList(list9, workloadName, dayShown/*replace with dayShown when added to the while loop*/, numberOfWorkers, listSize,returnedConstraintinfo);

                    memberAssignmentArray = list8.CycleConstraint(workloadName, dayShown, listSize);
                    for (int x = 0; x < numberOfWorkers; x++)
                    {
                        var index = this.scheduleDataGridView.Rows.Add();
                        this.scheduleDataGridView.Rows[rowNumber].Cells[cellNUmber].Value = memberAssignmentArray[x];
                        rowNumber = rowNumber + 1;
                    }
                }
                if (numberOfWorkLoads > 8)

                {
                    Array.Clear(memberAssignmentArray, 0, memberAssignmentArray.Length);
                    workloadName = this.testDataGridView.Rows[8].Cells[0].Value.ToString();
                    numberOfWorkersString = this.testDataGridView.Rows[8].Cells[1].Value.ToString();
                    numberOfWorkers = Convert.ToInt32(numberOfWorkersString);
                    listSize = list9.countNodes();
                    list9.selectNodesForList(list10, workloadName, dayShown/*replace with dayShown when added to the while loop*/, numberOfWorkers, listSize,returnedConstraintinfo);

                    memberAssignmentArray = list9.CycleConstraint(workloadName, dayShown, listSize);
                    for (int x = 0; x < numberOfWorkers; x++)
                    {
                        var index = this.scheduleDataGridView.Rows.Add();
                        this.scheduleDataGridView.Rows[rowNumber].Cells[cellNUmber].Value = memberAssignmentArray[x];
                        rowNumber = rowNumber + 1;
                    }
                           // myList = null;
                }cellNUmber = cellNUmber + 1;
            }


            // myList.transferToNewList(numberOfWorkers,myListSize, list2);




            


          

        }

        //TAKE THE LSIT, PUT IT THROUGH A METHOD THAT TAKES THE WORKLOAD AND UNITNUMBER/NAME AND COMBINES THEM INTO A STRING, RETURNS THE STRING, MAYBE IN AN ARRAY?

        private void testDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void testDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void testTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = testDataGridView.CurrentCell.RowIndex;
                testDataGridView.Rows.RemoveAt(row);
                if (numberOfSelectedWorkLoads > 0)
                {
                    numberOfSelectedWorkLoads = numberOfSelectedWorkLoads - 1;
                }
            }


            catch
            {


            }
        }
    }
}
