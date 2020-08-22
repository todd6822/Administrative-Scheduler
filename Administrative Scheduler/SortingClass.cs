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
using System.Security.Policy;
using System.Data.SqlTypes;
using Administrative_Scheduler;
using System.Runtime.CompilerServices;

public class SortAlgorithm
{
    public class sortConstraints
    {
        //DataTable memberDataTable = new DataTable();
        AdminScheduleCallProceedure useSQL = new AdminScheduleCallProceedure();
        linkedListClass myLinkedList = new linkedListClass();
        DataTable d1;
        DataTable d2;
        DataTable d3;


        public DataTable sortDataTable(DataTable dataTable, DateTime startDateTime, DateTime stopDateTime, string[] inputArray, int arraySize)

        {


            DateTime startPlus12hours = startDateTime;
            //startPlus12hours.AddHours(12);
            string memberNameString;
            int numberOfRows = 0;
            DataGridViewRow thisRow;
            AdminScheduleCallProceedure findLeaveIDNumber = new AdminScheduleCallProceedure();
            AdminScheduleCallProceedure retrieveAllTimerWorkloadMemberData = new AdminScheduleCallProceedure();
            AdminScheduleCallProceedure constraintsTable = new AdminScheduleCallProceedure();


            while (startDateTime < stopDateTime)
            {

                d1 = findLeaveIDNumber.UseProceedure("returnMemberNotOnLeave", "@scheduleDay", startDateTime);
                numberOfRows = d1.Rows.Count;

                d2 = retrieveAllTimerWorkloadMemberData.UseProceedure("returnAllValuesFomMemberWorkLoadTimerView");


              //  MessageBox.Show(Convert.ToString(startDateTime),"Time being evaluated");

                for (int x = 0; x < (arraySize - 1); x++)
                {

                    d3 = constraintsTable.UseProceedure("returnConstraintsByWorkloadName", "@workLoadName", inputArray[x]);


                    int numberOfConstraints = d3.Rows.Count;

                    for (int y = 0; y < numberOfConstraints; y++)
                    {



                    }






                }



              //  MessageBox.Show(Convert.ToString(numberOfRows), "This is the number of rows");

                /* for (int x=0;x<numberOfRows;x++)

                 {

                     memberNameString  = (String)d1.Rows[x][0];

                     MessageBox.Show(memberNameString);



                 }*/

               //fillList(d1,0, 0, 0, 0,0,DateTime.Now);

                startDateTime = startDateTime.AddDays(1);
            //    MessageBox.Show(Convert.ToString(startDateTime), "Start Date");
             //   MessageBox.Show(Convert.ToString(stopDateTime), "Stop Date");
            }


            return dataTable;
        }

        public linkedListClass fillList  (DataTable inputDataTable/*memberNotOnLeaveTable*/,string workLoadName)            //(DataTable inputDataTable,int constraintNumber, int stringInput, int inputColumn2, int counterInput, int counter2Input, DateTime inputDateTime)

        {

            DateTime newDateTime = DateTime.Today.AddDays(-14);
            
            //stored proceedure that returns the rows for constraints in a workload
            int numberOfRows = inputDataTable.Rows.Count;

            DataTable workConstraint = new DataTable();

            if ((workLoadName==null)|| (workLoadName==""))
            {


                return null;
            }

           workConstraint = useSQL.UseProceedure("SelectTopConstraintNumberFromConstaintWorkLoadView", "@workLoadName", workLoadName);

            int constraintNumberInput = (int)workConstraint.Rows[0][0];



         //  useSQL.UseProceedureReturnInt2("returnTopConstraintNumberFromConstaintWorkLoadView", ",);


          //  MessageBox.Show(Convert.ToString(constraintNumberInput)," The constraint number is: ");
            
            int memberNumber=0;
            int timer1value=0;
            int timer2Value=0; 
            int counter1=0;
            int counter2=0;
            string name=" ";
           DateTime inputDate=DateTime.Today;
            string dateString = "";
            int increment = 0;
            DataRow row;
            DataRow row2;
            
           

            DataTable counterDateTable;


            linkedListClass outputList = new linkedListClass();

            AdminScheduleCallProceedure counterDateProceedure =new AdminScheduleCallProceedure();



            //
            ////
            for (int x = 1; x < (numberOfRows); x++)
            {


                row = inputDataTable.Rows[x];
                name = row["Member_Name"].ToString();
                memberNumber = Convert.ToInt32(row["Member_ID"]);
              //  counter1 = Convert.ToInt32(row["Timer_Value"]);
             //   counter2 = Convert.ToInt32(row["Timer_2_Value"]);
            //    inputDate = Convert.ToDateTime(row["Date_Of_Last"]);

               
               /*
                name = (String)inputDataTable.Rows[x][1];
                memberNumber = (int)inputDataTable.Rows[x][2];
                /*counterDateTable = counterDateProceedure.UseProceedure("selectTimerValuesAndDateFromView", "@memberNumber", "@constraintNumber", memberNumber, constraintNumberInput);// this will be used later
                
                counter1 = (int)counterDateTable.Rows[0][0];
                counter2 = (int)counterDateTable.Rows[0][1];
                inputDate=(DateTime)counterDateTable.Rows[0][2];*/

                increment = increment + 1;

                


                outputList.insertBack(constraintNumberInput,memberNumber,counter1,counter2,name,inputDate) ;//the value retunred from the view need to be entered into this thingy
               // counterDateTable.Clear();
            }

            // outputList.readAllValues();
            //outputList.insertBack()*/
            return outputList;


        }

        public linkedListClass sortingSwitch(linkedListClass inputList, linkedListClass outPutList, String relation, int timer1, int duration, string timeFrame, DateTime DateBeingAddressed, int counter1Value, int counter2Value, DateTime tickDate)

        {


            //linkedListClass outPutList = new linkedListClass();

            //DateTime myDate = //DateTime.Now;


          //  MessageBox.Show(Convert.ToString(timeFrame), " Time");

            outPutList.insertBack(1, 2, 2, 2, "dude", DateBeingAddressed);


            /*
             More than
             No More Than
             Less Than
             At Least
             Exactly
             
             */
            /*
            Month/Months
            Day/Days
            Week/Weeks
             
             */
           

           /* 

            int nodeNUmber = outPutList.countNodes();

            inputList.transferNodesWithCountersBetweenValues(, outPutList);

            inputList.transferNodesWithGreaterThanCounter(, outPutList);

            MessageBox.Show(relation, "relation is");
            if (relation == "More than")


                if (relation == "No More than")

                   if (timeFrame == "Day/Days")
                   {
                        if ()

                   }
                   if (timeFrame == "Week/Weeks")
                   { 


                   }
                   if (timeFrame=="Month/Months")
                   {
                


                   }    

                   // >


               else if (relation=="Less Than")



                    if (timeFrame == "Day/Days")
                    {

                    }
                   if (timeFrame == "Week/Weeks")
                    {


                     }
                     if (timeFrame == "Month/Months")
                     {



                     }
                     //   <

              else  if (relation=="At Least")


                    if (timeFrame == "Day/Days")
                    {

                    }
                  else  if (timeFrame == "Week/Weeks")
                    {


                    }
                 else   if (timeFrame == "Month/Months")
                    {



                    }


                     // >=

            if (relation=="Exactly")

                if (timeFrame == "Day/Days")
                {

                }
                else if (timeFrame == "Week/Weeks")
                {


                }
                else if (timeFrame == "Month/Months")
                {



                }*/
            //   ==




            //inputList.transferNodesWithLessThanCounter(, outPutList);




           // MessageBox.Show(Convert.ToString (nodeNUmber),"Number of nodes in output list");

            return outPutList;

        }


     /*   public linkedListClass selectNodesForList(linkedListClass inputList, string nameOfProceedure, DataGrid inputDataGrid, string workLoadName)
        {

            linkedListClass.Node temp = null;
            temp = inputList.Head

            workLoadName = "G Line";//for testing
            string relations = "";// greater than, lesser than ect
            int timer1 = 0;       //this many timer
            //per
            int duration = 0;  //this manmy time increments
            string timeFrame = "";//per week/month

            AdminScheduleCallProceedure findNumberOfConstraint = new AdminScheduleCallProceedure();

            int numberOfCOnstraints= findNumberOfConstraint.UseProceedureReturnInt2("ReturnNumberOfConstraints", "@workLoadName", workLoadName);


            DataTable sortingDatatable = new DataTable();


           // sortingDatatable=
         
            int numberOfNodes = inputList.countNodes();

            for (int x=0; x<numberOfNodes;x++)
            {
              if 

            }

            // select from dataTable tabel row# (where the timer is) where the name of the workflow = A and the namne of the constraint = b

            return inputDataGrid;
        }*/
    }
}
// two take a dataset and convert it to a linked list

//Finds highest value in for a timer and then move that to a new linked list for the number of itterations input

