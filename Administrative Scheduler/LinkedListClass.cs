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

    public class linkedListClass
    {
        Node head;

        public class Node
        {

            internal int constraintNumber;
            internal int counterValue;
            internal int counter2Value;
            internal int memberNumber;
            internal DateTime lastTickDateTime = DateTime.Now;
            internal string memberName;
            internal Node next;
            internal Node prev;
            public Node(int inputConstraintNumber, int inputMember, int inputCounter, int inputCounter2, string inputName, DateTime lastTickInput)
            {

                constraintNumber = inputConstraintNumber;
                lastTickDateTime = lastTickInput;
                memberName = inputName;
                counterValue = inputCounter;
                counter2Value = inputCounter2;
                memberNumber = inputMember;
                next = null;
                prev = null;
            }
        }



        internal void insertBack(int constraintNumber, int memberNumber, int timerVale, int timer2Value, string name, DateTime inputDateTime)

        {
            Node newNode = new Node(constraintNumber, memberNumber, timerVale, timer2Value, name, inputDateTime);

            newNode.next = head;
            newNode.prev = null;

            if (head != null)
            {

                head.prev = newNode;

            }
            head = newNode;


        }
        internal Node GetLastNode()
        {
            Node temp = head;
            while (temp.next != null)
            {

                temp = temp.next;
            }
            return temp;


        }
        /*internal void deleteNMode()

        {

            Node temp=head;

            if (head==null)
            {

                return;
            }
            else 
            {
                head = head;
                head = temp;
                head.prev = null;
               

            }

            if (head == temp)
            { 
            
            
            }


        }*/

        internal void deleteNodeByKeye(int valueToFind)
        {
            Node temp = head;

            if (temp != null && temp.counterValue == valueToFind)
            {

                head = temp.next;
                head.prev = null;
                return;

            }
            while (temp != null && temp.counterValue != valueToFind)
            {

                temp = temp.next;
            }
            if (temp == null)
            {

                return;

            }
            if (temp.next != null)

            {
                temp.next.prev = temp.prev;

            }

            if (temp.prev != null)

            {

                temp.prev.next = temp.next;
            }

        }

        internal void deleteNodesThatContain(int valueToFind)
        {
            Node temp = head;
            if (temp == null)
            {
                return;
            }
            while (temp != null)
            {
                if (head == temp && head != null && head.memberNumber == valueToFind)
                {
                    head = temp.next;
                    head.prev = null;
                }
                if (temp == null)
                {
                    return;
                }
                if (temp.next != null && temp.memberNumber == valueToFind)
                {
                    temp.next.prev = temp.prev;
                }
                if (temp.prev != null && temp.memberNumber == valueToFind)
                {
                    temp.prev.next = temp.next;
                }
                temp = temp.next;
            }
            return;
        }
        internal void deleteNodesWithGreaterThanCounter(int minValue)
        {
            Node temp = head;
            if (temp == null)
            {
                return;
            }
            while (temp != null)
            {
                if (head == temp && head != null && head.counterValue > minValue)
                {
                    head = temp.next;
                    head.prev = null;
                }
                if (temp == null)
                {
                    return;
                }
                if (temp.next != null && temp.counterValue > minValue)
                {
                    temp.next.prev = temp.prev;
                }
                if (temp.prev != null && temp.counterValue > minValue)
                {
                    temp.prev.next = temp.next;
                }
                temp = temp.next;
            }
            return;

        }
        internal void deleteNodesWithLessThanCounter(int maxValue)
        {
            Node temp = head;
            if (temp == null)
            {
                return;
            }
            while (temp != null)
            {
                if (head == temp && head != null && head.counterValue < maxValue)
                {
                    head = temp.next;
                    head.prev = null;
                }
                if (temp == null)
                {
                    return;
                }
                if (temp.next != null && temp.counterValue < maxValue)
                {
                    temp.next.prev = temp.prev;
                }
                if (temp.prev != null && temp.counterValue < maxValue)
                {
                    temp.prev.next = temp.next;
                }
                temp = temp.next;
            } return;
        }
        internal void deleteNodesWithCountersBetweenValues(int fromValue, int toValue)
        {
            Node temp = head;
            if (temp == null)
            {
                return;
            }
            while (temp != null)
            {
                if (head == temp && head != null && (head.counterValue >= fromValue && head.counterValue <= toValue))
                {
                    head = temp.next;
                    head.prev = null;
                }
                if (temp == null)
                {
                    return;
                }
                if (temp.next != null && (head.counterValue >= fromValue && head.counterValue <= toValue))
                {
                    temp.next.prev = temp.prev;
                }
                if (temp.prev != null && (head.counterValue >= fromValue && head.counterValue <= toValue))
                {
                    temp.prev.next = temp.next;
                }
                temp = temp.next;
            }
            return;
        }


        /* 
        MessageBox.Show("starting delete loop");

        int x = 0;
       Node temp = head;
        Node temp2 = head;
        if (head==null)
        {

            return;

        }

        while (temp != null&&head!=null)
        {

          //MessageBox.Show(Convert.ToString(temp.counterValue), "String Value of temp.counter");
            //MessageBox.Show(Convert.ToString(x), " loop cycles ");

            if (head.counterValue == fromValue)
            {
                temp = head;
                head = head.next;
                head.prev = null;
                //   temp.next = null;
                temp = head;
                //head.next = null;


            }

             else if (temp==null)
            {

                return;
            }


            else if (temp.counterValue != (fromValue))
            {

                temp=temp.next;


               // linkedList.head.prev = temp.prev.prev;


            }



            else if (temp.counterValue == fromValue)
            {
                temp2 = temp;
                temp = temp.next;
                if (temp2.prev == null)
                {
                    temp.prev = null;

                }

                else
                {
                    temp.prev = temp2.prev;
                }
                //temp.next = temp.next.next;


            }
            x = x + 1;
        }return;*/

        internal void readAllValues()
        {





            MessageBox.Show("reading values");

            Node temp = head;
            while (temp != null)
            {
                MessageBox.Show(Convert.ToString(temp.constraintNumber));
                MessageBox.Show(Convert.ToString(temp.counterValue), " The Counter Value is: ");
                MessageBox.Show(Convert.ToString(temp.counter2Value), " The Counter 2 Value is: ");
                MessageBox.Show(Convert.ToString(temp.memberNumber), "The member entry number is");
                MessageBox.Show(Convert.ToString(temp.lastTickDateTime), " Last Date Time Tick");
                MessageBox.Show(temp.memberName, "The member name is");




                temp = temp.next;





            }



            //MessageBox.Show(Convert.ToString(temp.counterValue), " The Counter Value is: ");
            //MessageBox.Show(Convert.ToString(temp.memberNumber), " The member Value is: ");






        }
        internal int countNodes()
        {


            int numberOfNodes = 0;


         //   MessageBox.Show("countingNodes");

            Node temp = head;
            while (temp != null)
            {
                /* MessageBox.Show(Convert.ToString(temp.counterValue), " The Counter Value is: ");
                 MessageBox.Show(Convert.ToString(temp.counter2Value), " The Counter 2 Value is: ");
                 MessageBox.Show(Convert.ToString(temp.memberNumber), "The member entry number is");
                 MessageBox.Show(Convert.ToString(temp.lastTickDateTime), " Last Date Time Tick");
                 MessageBox.Show(temp.memberName, "The member name is");*/


                numberOfNodes = numberOfNodes + 1;

                temp = temp.next;





            }
          //  MessageBox.Show(Convert.ToString(numberOfNodes), " Number of Nodes in list");
            return numberOfNodes;

            //MessageBox.Show(Convert.ToString(temp.counterValue), " The Counter Value is: ");
            //MessageBox.Show(Convert.ToString(temp.memberNumber), " The member Value is: ");






        }




        /* internal void transferNodesThatContain(int valueToFind, linkedListClass inputList)
         {


             Node temp = head;



             if (temp == null)
             {
                 return ;
             }
             while (temp != null)
             {
                 if ((head == temp) && (head != null) && (head.counterValue == valueToFind))
                 {
                     int memNumber=head.memberNumber;
                     int counter=head.counterValue;
                     string name=head.memberName;

                     inputList.insertBack(memNumber, counter, name);
                     head = temp.next;
                     temp = head;
                     temp.prev = null;
                 }
                 if (temp == null)
                 {
                     return ;
                 }
                 if (temp.counterValue==valueToFind)
                 {

                     inputList.insertBack(temp.memberNumber, temp.counterValue, temp.memberName);
                 }
                 if (temp.next != null && temp.counterValue == valueToFind)
                 {

                     temp.next.prev = temp.prev;
                 }
                 if (temp.prev != null && temp.counterValue == valueToFind)
                 {
                     temp.prev.next = temp.next;
                 }
                 temp = temp.next;
             }
             return ;*/

        internal void transferNodesThatContain(int valueToFind, linkedListClass inputList, int maxNumber)//this transfers the node to a new list if the input value is a certain value
        {
            Node temp = head;
            int numberOfWorkers = 0;
            Node temp2 = inputList.head;



            if (temp == null)
            {
                return;
            }
            while (temp != null)
            {
                if ((temp.counterValue == valueToFind) || (numberOfWorkers == maxNumber))

                {
                    inputList.insertBack(temp.constraintNumber, temp.memberNumber, temp.counterValue, temp.counter2Value, temp.memberName, temp.lastTickDateTime);


                    //MessageBox.Show("transfering");

                }
                if (head == temp && head != null && head.counterValue == valueToFind)
                {

                    head = temp.next;

                    head = temp;
                    temp.prev = null;
                    head.prev = null;
                    numberOfWorkers = numberOfWorkers + 1;
                }
                if (temp == null)
                {
                    return;
                }


                if (temp.next != null && temp.counterValue == valueToFind)
                {
                    temp.next.prev = temp.prev;
                }
                if (temp.prev != null && temp.counterValue == valueToFind)
                {
                    temp.prev.next = temp.next;
                }
                numberOfWorkers = numberOfWorkers + 1;
                temp = temp.next;

            }
            return;
        }
        internal linkedListClass transferNodesWithGreaterThanCounter(int minValue, linkedListClass inputList, int maxNumber)// this transferes a node to a new lsit if it's more than the selected value
        {
            Node temp = head;
            int numberOfWorkers = 0;
            if (temp == null)
            {
                return inputList;
            }
            while (temp != null)
            {
                if ((temp.counterValue > minValue) || (numberOfWorkers >= maxNumber))
                {

                    inputList.insertBack(temp.constraintNumber, temp.memberNumber, temp.counterValue, temp.counter2Value, temp.memberName, temp.lastTickDateTime);
                }
                if (temp == null || head == null)
                {
                    return inputList;

                }

                else if ((head != null) && (head == temp) && (head != null) || (head.counterValue > minValue))
                {


                    head = temp.next;
                    temp = head;
                    //head.prev = null;
                    numberOfWorkers = numberOfWorkers + 1;
                }
                if (temp == null)
                {
                    return inputList;
                }

                if (temp.next != null && temp.counterValue > minValue)
                {
                    temp.next.prev = temp.prev;
                }
                if (temp.prev != null && temp.counterValue > minValue)
                {
                    temp.prev.next = temp.next;
                }
                temp = temp.next;
                numberOfWorkers = numberOfWorkers + 1;
            }
            return inputList;

        }
        internal void transferNodesWithLessThanCounter(int maxValue, linkedListClass inputList, int maxNumber)// this transfers node to another list of it's value is less than the selected value
        {
            int numberOfWorkers = 0;
            Node temp = head;
            if (temp == null)
            {
                return;
            }
            while (temp != null)
            {
                if ((temp.counterValue < maxValue) || (numberOfWorkers >= maxNumber))
                {

                    inputList.insertBack(temp.constraintNumber, temp.memberNumber, temp.counterValue, temp.counter2Value, temp.memberName, temp.lastTickDateTime);
                }
                if (head == temp && head != null && head.counterValue < maxValue)
                {

                    head = temp.next;
                    temp = head;
                    temp.prev = null;
                    numberOfWorkers = numberOfWorkers + 1;
                }
                if (temp == null)
                {
                    return;
                }

                if (temp.next != null && temp.counterValue < maxValue)
                {
                    temp.next.prev = temp.prev;
                }
                if (temp.prev != null && temp.counterValue < maxValue)
                {
                    temp.prev.next = temp.next;
                }
                temp = temp.next;
                numberOfWorkers = numberOfWorkers + 1;
            }
            return;
        }
        internal void transferNodesWithCountersBetweenValues(int fromValue, int toValue, linkedListClass inputList, int maxNumber)// this class transfers a node to another list if the input values is between the min and max value
        {
            int numberOfWorkers = 0;
            Node temp = head;
            Node temp2 = inputList.head;

            if (temp == null)
            {
                return;
            }
            while (temp != null)
            {

                if ((temp.counterValue >= fromValue && temp.counterValue <= toValue) || (numberOfWorkers >= maxNumber))
                {

                    inputList.insertBack(temp.constraintNumber, temp.memberNumber, temp.counterValue, temp.counter2Value, temp.memberName, temp.lastTickDateTime);
                }
                if (head == temp && head != null && (head.counterValue >= fromValue && head.counterValue <= toValue))
                {
                    head = temp.next;
                    temp = head;
                    temp.prev = null;
                    numberOfWorkers = numberOfWorkers + 1;
                }
                if (temp == null)
                {
                    return;
                }

                if (temp.next != null && (temp.counterValue >= fromValue && temp.counterValue <= toValue))
                {
                    temp.next.prev = temp.prev;
                }
                if (temp.prev != null && (temp.counterValue >= fromValue && temp.counterValue <= toValue))
                {
                    temp.prev.next = temp.next;
                }
                temp = temp.next;
                numberOfWorkers = numberOfWorkers + 1;
            }
            return;
        }
        internal void transferToNewList (int inputNumber,int listSize, linkedListClass inputList)
            {

            Node temp;
            int iterations=0;
            int numbertoCycle = inputNumber-listSize;

            temp = head;
                while(((numbertoCycle)>iterations))
            {


                if (head==null||temp==null)

                {
                    return;

                }
               
                
                inputList.insertBack(temp.constraintNumber, temp.memberNumber, temp.counterValue, temp.counter2Value, temp.memberName, temp.lastTickDateTime);




                head = temp;

                temp = temp.next;
                head = temp;


                if (head == null || temp == null)

                {
                    return;

                }
                head.prev = null;
                if (temp.prev == null||temp==null)

                {  return; 
                
                
                }

                else
                {

                    temp.prev = null;
                }
                
              
                
                   
                    iterations = iterations + 1;

                MessageBox.Show("pushed");
            }return;

            }
        internal void transferLastToNewList(int inputNumber, int listSize, linkedListClass inputList)
        {

            Node temp;
            temp = head;
            int iterations = 0;
            int numbertoCycle = listSize - inputNumber;


            if (head == null || temp == null)

            {
                return;

            }
            while (temp.next!=null)
            {

                temp = temp.next;
            }


            
            while (((listSize - inputNumber) > iterations))
            {


                if (head == null || temp == null)

                {
                    return;

                }


                inputList.insertBack(temp.constraintNumber, temp.memberNumber, temp.counterValue, temp.counter2Value, temp.memberName, temp.lastTickDateTime);




                head = temp;

                temp = temp.next;
                head = temp;


                if (head == null || temp == null)

                {
                    return;

                }
                head.prev = null;
                if (temp.prev == null||temp==null)

                {  return; 
                
                
                }

                else
                {

                    temp.prev = null;
                }




                iterations = iterations + 1;

                // MessageBox.Show("pushed");
            }
            return;

        }







        public void incrementEntireListTimer1(linkedListClass inputList)// this adds a counter to every node in a list that is added to this

            {
            Node temp = inputList.head;
            while (temp != null)
            {

                temp.counterValue = temp.counterValue + 1;

                temp = temp.next;

            }
             
             }

        public void decrementEntireListTimer1(linkedListClass inputList)// this subtracts a counter to every node in a list that is added to this

        {
            Node temp = inputList.head;
            while (temp != null)
            {

                if (temp.counterValue > 0)
                {
                    temp.counterValue = temp.counterValue - 1;
                }

                else
                {
                    temp.counterValue = 0;

                }

                temp = temp.next;

            }

        }
        public void timer1toZero(linkedListClass inputList)// this sets a counter to zero in every node in a list that is added to this

        {
            Node temp =inputList.head;
            while (temp != null)
            {

                temp.counterValue = 0;

                temp = temp.next;

            }

        }
        public void incrementEntireListTimer2(linkedListClass inputList)// this adds a counter to every node in a list that is added to this

        {
            Node temp = inputList.head;
            while (temp != null)
            {

                temp.counterValue = temp.counterValue + 1;

                temp = temp.next;

            }

        }

        public void decrementEntireListTimer2(linkedListClass inputList)// this subtracts a counter to every node in a list that is added to this

        {
            Node temp = inputList.head;
            while (temp != null)
            {

                if (temp.counterValue > 0)
                {
                    temp.counterValue = temp.counterValue+  1;
                }

                else
                {
                    temp.counterValue = 0;

                }

                temp = temp.next;

            }

        }
        public void timer2toZero(linkedListClass inputList)// this sets a counter to 0 in every node in a list

        {
            Node temp = inputList.head;
            while (temp != null)
            {

                temp.counterValue = 0;

                temp = temp.next;

            }

        }

        public string[] CycleConstraint( string workLoadName, DateTime calenderTime, int sizeOfList) // the workload name and number of constraints come from the Schedule Form Screen workLoadDataGrid_CellClick variable numberOfConstraints// this sets a counter to 0 in every node in a list

        {
            Node temp = head;
            DataTable counterDateTable = new DataTable();//fills with the timers and last use date froim the timer table
            AdminScheduleCallProceedure findNumberOfConstraint = new AdminScheduleCallProceedure();
            AdminScheduleCallProceedure counterDateProceedure = new AdminScheduleCallProceedure();
            AdminScheduleCallProceedure fillTable = new AdminScheduleCallProceedure();
            AdminScheduleCallProceedure fillConstraint = new AdminScheduleCallProceedure();
            DataTable sortingDatatable;



            sortingDatatable = fillTable.UseProceedure("returnConstraintsByWorkloadNameWithRowNUmber", "@workLoadName", workLoadName);
            int constraintsRetunred = findNumberOfConstraint.UseProceedureReturnInt2("ReturnNumberOfConstraints", "@workLoadName", workLoadName);


            int rownumber = 0;
            int elementNumberForArray = 0;
            int constraintId = 0;
            string relations = "";// greater than, lesser than ect
            int timer1 = 0;
            //this many timer
            //per
         //   int duration = 0;  //this manmy time increments
            string timeFrame = "";//per week/month
            DateTime myDateTime = DateTime.Now;

            DataRow row;
            DataRow counterRow;

            string[] strArray = new string[] { };
            Array.Resize(ref strArray, sizeOfList+1);



            while (temp != null)// ok so for this we need to create a stored proceedure that updates the appropriate constraint timer, based on the selection of the switch statment.   
            {
            


                int numberOfCOnstraints = constraintsRetunred;


                while (numberOfCOnstraints >= 1)
                {

                    int memberNumberupdate = temp.memberNumber;
                  int counter1Value = temp.counterValue;
               //   MessageBox.Show(Convert.ToString(memberNumberupdate), "Member Number this is where it starts");
                //  MessageBox.Show(Convert.ToString(counter1Value), "Timer 1 Value tick 1"); 

                    
                      int rowNumer = numberOfCOnstraints - 1;
                      row = sortingDatatable.Rows[rowNumer];
                      rownumber = Convert.ToInt32(row["rowNum"]);
                      relations = Convert.ToString(row["Relation"]);
                      timer1 = Convert.ToInt32(row["timer1"]);
                      int duration = Convert.ToInt32(row["Duration"]);
                      timeFrame = Convert.ToString(row["Time_Frame"]);
                      //myDateTime = Convert.ToDateTime(timeFrame);
                      /*
                      //   MessageBox.Show(Convert.ToString(rownumber),"Row Number");
                      constraintId = Convert.ToInt32(row["Constraint_ID"]);
                      counterDateTable = counterDateProceedure.UseProceedure("selectTimerValuesAndDateFromView", "@memberNumber", "@constraintNumber", temp.memberNumber, constraintId);// this will be 
                      temp.constraintNumber = constraintId;
                      counterRow = counterDateTable.Rows[0];////was 0
                      temp.counterValue = Convert.ToInt32(counterRow["Timer_Value"]);
                      temp.counter2Value = Convert.ToInt32(counterRow["Timer_2_Value"]);
                      temp.lastTickDateTime = Convert.ToDateTime(counterRow["Date_Of_Last_Tick"]);
                      myDateTime = temp.lastTickDateTime;*/
//                    MessageBox.Show("Push 1");


                    if (relations == "More than")
                    {


                        timer1 = timer1 + 1;
                        temp.lastTickDateTime = calenderTime;



                    }
                    else if (relations == "Not More Than")
                    {
                        if (timeFrame == "Day/Days")
                        {    //is equal to or greater than so many timer is so many days
                            if ((temp.counterValue > timer1) && (temp.lastTickDateTime > calenderTime.AddDays(-duration)))
                            {

                                temp.counterValue = temp.counterValue + 1;
                                temp.lastTickDateTime = calenderTime;


                            }

                            else if ((temp.counterValue <= timer1) && (temp.lastTickDateTime > calenderTime.AddDays(-duration)))

                            {


                                temp.counterValue = temp.counterValue + 1;




                            }
                            else if ((temp.counterValue <= timer1) && (temp.lastTickDateTime < calenderTime.AddDays(-duration)))
                            {
                                temp.counterValue = 1;
                                temp.lastTickDateTime = calenderTime;

                 //               MessageBox.Show("Set to one tick 1");
                 //               MessageBox.Show(temp.memberName);



                            }

                            else//  ((temp.counterValue > timer1) && (temp.lastTickDateTime < calenderTime.AddDays(-duration)))

                            {

                                temp.counterValue = 1;
                                temp.lastTickDateTime = calenderTime;
                //                MessageBox.Show("Set to one tick 2");
               //                 MessageBox.Show(temp.memberName);



                            }
                        }
                        else if (timeFrame == "Month/Months")
                        {
                            if ((temp.counterValue > timer1) && (temp.lastTickDateTime > calenderTime.AddDays((-duration) * 30)))
                            {

                                temp.counterValue = temp.counterValue + 1;
                                temp.lastTickDateTime = calenderTime;

                            }
                            else if ((temp.counterValue <= timer1) && (temp.lastTickDateTime > calenderTime.AddDays((-duration) * 30)))
                            {

                                temp.counterValue = temp.counterValue+1;

                            }
                            else if ((temp.counterValue <= timer1) && (temp.lastTickDateTime < calenderTime.AddDays((-duration) * 30)))
                            {

                              //  temp.counterValue = 1; MessageBox.Show("Set to one tick 3");
                  //              MessageBox.Show(temp.memberName);

                                temp.lastTickDateTime = calenderTime;

                            }
                            else//  ((temp.counterValue > timer1) && (temp.lastTickDateTime < calenderTime.AddDays((-duration) * 30)))
                            {

                                temp.counterValue = temp.counterValue + 1;
                                temp.lastTickDateTime = calenderTime;

                            }
                        }
                        else if (timeFrame == "Week/Weeks")
                        {
                            if ((temp.counterValue >= timer1) && (temp.lastTickDateTime > calenderTime.AddDays((-duration) * 7)))
                            {

                       //         MessageBox.Show("Set to one tick 4");
                         //       MessageBox.Show(temp.memberName);

                                temp.counterValue = 1;
                                temp.lastTickDateTime = calenderTime;

                            }
                            else if ((temp.counterValue >= timer1) && (temp.lastTickDateTime < calenderTime.AddDays((-duration * 7))))
                            {
                                //MessageBox.Show("Set to one tick 4.5");
                   //             MessageBox.Show(temp.memberName);

                                temp.counterValue = 1;
                                temp.lastTickDateTime = calenderTime;

                                

                            }
                            else if ((temp.counterValue <= timer1) && (temp.lastTickDateTime > calenderTime.AddDays((-duration) * 7)))
                            {

                                temp.counterValue =temp.counterValue+1;
                                //temp.lastTickDateTime = calenderTime;

                            }
                            else// ((temp.counterValue >= timer1) || (temp.lastTickDateTime > calenderTime.AddDays((-duration) * 7)))
                            {

                                temp.counterValue = temp.counterValue+1;
                                temp.lastTickDateTime = calenderTime;

                            }



                        }

                      memberNumberupdate = temp.memberNumber;
                       counter1Value = temp.counterValue;
               //         MessageBox.Show(Convert.ToString(memberNumberupdate), "Member Number");
                 //       MessageBox.Show(Convert.ToString(counter1Value), "Timer 1 Value tick 2");

                    }
                    else if (relations == "Less Than")

                    {


                        if (timeFrame == "Day/Days")
                        {    //is equal to or greater than so many timer is so many days
                            if ((temp.counterValue >= timer1) && (temp.lastTickDateTime > calenderTime.AddDays(-duration)))
                            {

                                temp.counterValue = temp.counterValue + 1;
                                temp.lastTickDateTime = calenderTime;


                            }

                            else if ((temp.counterValue < timer1) && (temp.lastTickDateTime > calenderTime.AddDays(-duration)))

                            {


                                temp.counterValue = temp.counterValue + 1;




                            }
                            else if ((temp.counterValue < timer1) && (temp.lastTickDateTime < calenderTime.AddDays(-duration)))
                            {

                         //       MessageBox.Show("Set to one tick 5");
                        //        MessageBox.Show(temp.memberName);

                                temp.counterValue = 1;
                                temp.lastTickDateTime = calenderTime;



                            }

                            else//  ((temp.counterValue > timer1) && (temp.lastTickDateTime < calenderTime.AddDays(-duration)))

                            {
                      //          MessageBox.Show("Set to one tick 5.5");
                        //        MessageBox.Show(temp.memberName);


                                temp.counterValue = 1;
                                temp.lastTickDateTime = calenderTime;


                            }
                        }
                        else if (timeFrame == "Month/Months")
                        {
                            if ((temp.counterValue >= timer1) && (temp.lastTickDateTime > calenderTime.AddDays((-duration) * 30)))
                            {

                                temp.counterValue = temp.counterValue + 1;
                                temp.lastTickDateTime = calenderTime;

                            }
                            else if ((temp.counterValue < timer1) && (temp.lastTickDateTime > calenderTime.AddDays((-duration) * 30)))
                            {

                                temp.counterValue = temp.counterValue + 1;

                            }
                            else if ((temp.counterValue < timer1) && (temp.lastTickDateTime < calenderTime.AddDays((-duration) * 30)))
                            {
                     //           MessageBox.Show("Set to one tick 6");
                    //            MessageBox.Show(temp.memberName);
//
                                temp.counterValue = 1;
                                temp.lastTickDateTime = calenderTime;

                            }
                            else//  ((temp.counterValue > timer1) && (temp.lastTickDateTime < calenderTime.AddDays((-duration) * 30)))
                            {

                                temp.counterValue = 1;
                                temp.lastTickDateTime = calenderTime;

                            }
                        }
                        else if (timeFrame == "Week/Weeks")
                        {
                            if ((temp.counterValue >= timer1) || (temp.lastTickDateTime > calenderTime.AddDays((-duration) * 7)))
                            {
                                temp.counterValue = temp.counterValue + 1;
                                temp.lastTickDateTime = calenderTime;


                            }
                            else if ((temp.counterValue < timer1) || (temp.lastTickDateTime > calenderTime.AddDays((-duration) * 7)))
                            {

                                temp.counterValue = temp.counterValue + 1;

                            }
                            else if ((temp.counterValue < timer1) || (temp.lastTickDateTime > calenderTime.AddDays((-duration) * 7)))
                            {

                                temp.counterValue = 1;
                                temp.lastTickDateTime = calenderTime;


                            }
                            else// ((temp.counterValue >= timer1) || (temp.lastTickDateTime > calenderTime.AddDays((-duraton) * 7)))
                            {
                        //        MessageBox.Show("Set to one tick 7");
                         //       MessageBox.Show(temp.memberName);


                                temp.counterValue = 1;
                                temp.lastTickDateTime = calenderTime;

                            }



                        } memberNumberupdate = temp.memberNumber;
                    counter1Value = temp.counterValue;
             //       MessageBox.Show(Convert.ToString(memberNumberupdate), "Member Number");
            //        MessageBox.Show(Convert.ToString(counter1Value), "Timer 1 Value tick 3");

                    }

             //       MessageBox.Show()
                    

                   

                    else if (relations == "At Least")

                    {

                 //       MessageBox.Show("Set to one tick 1");
                   ///     MessageBox.Show(temp.memberName);

                        if (timeFrame == "Day/Days")
                        {    //is equal to or greater than so many timer is so many days
                            if ((temp.lastTickDateTime > calenderTime.AddDays(-duration)))
                            {

                                temp.counterValue = temp.counterValue + 1;
                                // temp.lastTickDateTime = calenderTime;


                            }

                            /*  else if ((temp.counterValue > timer1) && (temp.lastTickDateTime > calenderTime.AddDays(-timer1)))

                              {


                                  temp.counterValue = temp.counterValue + 1;




                              }
                             else if ((temp.counterValue <= timer1) && (temp.lastTickDateTime < calenderTime.AddDays(-timer1)))
                              {
                                  temp.counterValue = 1;
                                  temp.lastTickDateTime = calenderTime;



                              }*/

                            else//  ((temp.counterValue > timer1) && (temp.lastTickDateTime < calenderTime.AddDays(-timer1)))

                            {

                                temp.counterValue = 1;
                                temp.lastTickDateTime = calenderTime;


                            }
                        }
                        else if (timeFrame == "Month/Months")
                        {
                            if ((temp.lastTickDateTime > calenderTime.AddDays((-duration) * 30)))
                            {

                                temp.counterValue = temp.counterValue + 1;


                            }
                            /* else if ((temp.counterValue < timer1) && (temp.lastTickDateTime > calenderTime.AddDays((-timer1) * 30)))
                             {

                                 temp.counterValue = temp.counterValue + 1;

                             }
                             else if ((temp.counterValue < timer1) && (temp.lastTickDateTime < calenderTime.AddDays((-timer1) * 30)))
                             {

                                 temp.counterValue = 1;
                                 temp.lastTickDateTime = calenderTime;

                             }*/
                            else//  ((temp.counterValue > timer1) && (temp.lastTickDateTime < calenderTime.AddDays((-timer1) * 30)))
                            {

                                temp.counterValue = 1;
                                temp.lastTickDateTime = calenderTime;

                            }
                        }
                        else if (timeFrame == "Week/Weeks")
                        {
                            if ((temp.lastTickDateTime > calenderTime.AddDays((-duration) * 7)))
                            {

                                temp.lastTickDateTime = calenderTime;


                            }
                            /*   else if ((temp.counterValue < timer1) || (temp.lastTickDateTime > calenderTime.AddDays((-timer1) * 7)))
                               {

                                   temp.counterValue = temp.counterValue + 1;

                               }
                               else if ((temp.counterValue < timer1) || (temp.lastTickDateTime > calenderTime.AddDays((-timer1) * 7)))
                               {

                                   temp.counter2Value = 1;
                                   temp.lastTickDateTime = calenderTime;

                               }*/
                            else// ((temp.counterValue >= timer1) || (temp.lastTickDateTime > calenderTime.AddDays((-timer1) * 7)))
                            {

                                temp.counterValue = 1;
                                temp.lastTickDateTime = calenderTime;

                            }



                        }memberNumberupdate = temp.memberNumber;
                    counter1Value = temp.counterValue;
           //         MessageBox.Show(Convert.ToString(memberNumberupdate), "Member Number");
            //        MessageBox.Show(Convert.ToString(counter1Value), "Timer 1 Value tick 4");

                    }

                




                     

                   
                    else if (relations == "Exactly")
                    {
                        if (timeFrame == "Day/Days")
                        {
                            if ((temp.counterValue < timer1) && ((temp.lastTickDateTime > calenderTime.AddDays(-duration))))
                            {

                                temp.counterValue = temp.counterValue + 1;


                                // transferNodesThatContain(timer1, inputList, numberOfWokers);

                            }
                            else if ((temp.lastTickDateTime < calenderTime.AddDays(-duration)))
                            {

                                temp.counterValue = 1;
                                temp.lastTickDateTime = calenderTime;


                                // transferNodesThatContain(timer1, inputList, numberOfWokers);

                            }
                            else if ((temp.counterValue == timer1) && ((temp.lastTickDateTime > calenderTime.AddDays(-duration))))
                            {

                                temp.counterValue = 1;
                                temp.lastTickDateTime = calenderTime;


                                // transferNodesThatContain(timer1, inputList, numberOfWokers);

                            }
                            else
                            {
                                temp.lastTickDateTime = calenderTime;
                                temp.counterValue = temp.counterValue + 1;


                                // transferNodesThatContain(timer1, inputList, numberOfWokers);

                            }
                        }
                        else if (timeFrame == "Week/Weeks")
                        {
                            if ((temp.counterValue < timer1) && ((temp.lastTickDateTime > calenderTime.AddDays(-duration * 7))))
                            {

                                temp.counterValue = temp.counterValue + 1;


                                // transferNodesThatContain(timer1, inputList, numberOfWokers);

                            }
                            else if ((temp.lastTickDateTime < calenderTime.AddDays(-timer1* 7)))
                            {

                                temp.counterValue = 1;
                                temp.lastTickDateTime = calenderTime;


                                // transferNodesThatContain(timer1, inputList, numberOfWokers);

                            }
                            else if ((temp.counterValue == timer1) && ((temp.lastTickDateTime > calenderTime.AddDays(-duration * 7))))
                            {

                                temp.counterValue = 1;
                                temp.lastTickDateTime = calenderTime;


                                // transferNodesThatContain(timer1, inputList, numberOfWokers);

                            }
                            else
                            {
                                temp.lastTickDateTime = calenderTime;
                                temp.counterValue = temp.counterValue + 1;


                                // transferNodesThatContain(timer1, inputList, numberOfWokers);



                            }
                        }
                        else if (timeFrame == "Month/Months")
                        {
                            if ((temp.counterValue < timer1) && ((temp.lastTickDateTime > calenderTime.AddDays(-duration* 30))))
                            {

                                temp.counterValue = temp.counterValue + 1;
                                temp.lastTickDateTime = calenderTime;

                                // transferNodesThatContain(timer1, inputList, numberOfWokers);

                            }
                            else if ((temp.lastTickDateTime < calenderTime.AddDays(-timer1 * 30)))
                            {

                                temp.counterValue = 1;
                                temp.lastTickDateTime = calenderTime;


                                // transferNodesThatContain(timer1, inputList, numberOfWokers);

                            }
                            else if ((temp.counterValue == timer1) && ((temp.lastTickDateTime > calenderTime.AddDays(-duration * 30))))
                            {

                                temp.counterValue = temp.counterValue+1;
                                temp.lastTickDateTime = calenderTime;


                                // transferNodesThatContain(timer1, inputList, numberOfWokers);

                            }
                            else
                            {
                                temp.lastTickDateTime = calenderTime;
                                temp.counterValue = 1;


                                // transferNodesThatContain(timer1, inputList, numberOfWokers);



                            }
                        }
                    }
                    else
                    {

                        temp.lastTickDateTime = calenderTime;
                        temp.counterValue = temp.counterValue + 1;


                    }




                    
                   memberNumberupdate = temp.memberNumber;
                   counter1Value = temp.counterValue;
              //      MessageBox.Show(Convert.ToString(memberNumberupdate), "Updateing Member Number++++++++++++++++++++++++++++");
                //    MessageBox.Show(Convert.ToString(temp.constraintNumber), "constraint number+++++++++++++++++++++++++++++++");
                  //  MessageBox.Show(Convert.ToString(counter1Value), "updateing Timer 1 Value tick 5+++++++++++++++++++++++");





                    //  MessageBox.Show(temp.memberName);
                    //   MessageBox.Show(temp.memberName);
                    //   MessageBox.Show(temp.memberName);
                    //   MessageBox.Show(temp.memberName);
                    //   MessageBox.Show(temp.memberName);
                  // MessageBox.Show(temp.memberName,"Member Name");

                    fillConstraint.UseProceedure("updateConstraintCounters", "@workLoadName", "@memberNumber", "@updatedTimer", "@constraintNumber", "@updatedDateTime", workLoadName, temp.memberNumber, temp.counterValue , temp.constraintNumber, temp.lastTickDateTime);

                    numberOfCOnstraints = numberOfCOnstraints - 1;

            }











            string returnValue = (workLoadName + " / " + temp.memberName);temp = temp.next;
                if (sizeOfList > 1)
                {
                    strArray[elementNumberForArray] = returnValue;
                    elementNumberForArray = elementNumberForArray + 1;
                }

            

                


               

        }



            return strArray;

        }


        public void selectNodesForList(linkedListClass inputList,/*ring nameOfProceedure, DataGrid inputDataGrid,*/string workLoadName, DateTime calenderTime, int numberOfWokers, int sizeOfList, DataGridView inputDatGrid)
        {
            
            
            Node temp = head;
            //linkedListClass outPutList = new linkedListClass();


            //   workLoadName = "G Line";//for testing
           
            

            int rownumber = 0;
            int constraintId = 0;
            string relations = "";// greater than, lesser than ect
            int timer1 = 0;
            //this many timer
            //per
            int duration = 0;  //this manmy time increments
            string timeFrame = "";//per week/month
            DateTime myDateTime=DateTime.Now;
            DataRow row;
            DataRow counterRow;int lineNumber = 0;

            AdminScheduleCallProceedure findNumberOfConstraint = new AdminScheduleCallProceedure();
            AdminScheduleCallProceedure fillTable = new AdminScheduleCallProceedure();
            AdminScheduleCallProceedure counterDateProceedure = new AdminScheduleCallProceedure();
            SortAlgorithm.sortConstraints newSort =new SortAlgorithm.sortConstraints();
            AdminScheduleCallProceedure fillConstraint = new AdminScheduleCallProceedure();
           // TimeSpan differnce;
            //int differenceOfTime;

            int constraintcount = findNumberOfConstraint.UseProceedureReturnInt2("ReturnNumberOfConstraints", "@workLoadName", workLoadName);
            

            DataTable sortingDatatable = new DataTable();// fills with all the constraints from a workload
            DataTable counterDateTable = new DataTable();//fills with the timers and last use date froim the timer table

            sortingDatatable = fillTable.UseProceedure("returnConstraintsByWorkloadNameWithRowNUmber", "@workLoadName", workLoadName);
          

            // sortingDatatable=
          //  MessageBox.Show("Is this the problem?");
            //int numberOfNodes = in.countNodes();

            while (temp != null)
            {
               int numberOfCOnstraints = constraintcount;
               

              //  MessageBox.Show(Convert.ToString(numberOfCOnstraints),"constraints");
               // MessageBox.Show("Tock");
                /*  name = row["Member_Name"].ToString();*/

                ////  rownumber = (int)sortingDatatable.Rows[0][0];

            int tick=0;

            tick = tick + 1;

                //for (int x = 0; x < numberOfCOnstraints; x++)
                while(numberOfCOnstraints>0)
                {
                 //   MessageBox.Show("inpick");

                    int rowNumer = numberOfCOnstraints-1;
                    row = sortingDatatable.Rows[rowNumer];
                    rownumber = Convert.ToInt32(row["rowNum"]);  
                    relations = Convert.ToString(row["Relation"]);
                    timer1 = Convert.ToInt32(row["timer1"]);
                    duration = Convert.ToInt32(row["Duration"]);
                    timeFrame = Convert.ToString(row["Time_Frame"]);
                    //myDateTime = Convert.ToDateTime(timeFrame);

                 //   MessageBox.Show(Convert.ToString(rownumber),"Row Number");
                    constraintId = Convert.ToInt32(row["Constraint_ID"]);
                    //inputDatGrid.ColumnCount = 6;
                    //inputDatGrid.Rows.Insert(1);

                    counterDateTable = counterDateProceedure.UseProceedure("timerWorkloadMemberInnerJoinReturnsAll2",  "@constraint", "@workLoad", constraintId,workLoadName);// this will be 
                    inputDatGrid.DataSource = counterDateTable;

                    for (int x= 1; x<= inputDatGrid.Rows.Count; x++)


                    {

                        int index = 0;
                        if (x==inputDatGrid.Rows.Count)

                        {
                            inputList.insertBack(temp.constraintNumber, temp.memberNumber, temp.counterValue, temp.counter2Value, temp.memberName, temp.lastTickDateTime);
                            break;

                        }
                        
                        else if ((Convert.ToInt32(inputDatGrid.Rows[index].Cells[3].Value)==temp.memberNumber))
                        {

                            temp.counterValue = (Convert.ToInt32(inputDatGrid.Rows[index].Cells[0].Value));
                             temp.counter2Value =  (Convert.ToInt32(inputDatGrid.Rows[index].Cells[1].Value ));
                               temp.lastTickDateTime =(Convert.ToDateTime(inputDatGrid.Rows[index].Cells[2].Value));

                        }


                    }



                   // string myTimer = inputDatGrid.Rows[0].Cells[0].Value.ToString();
                    //MessageBox.Show(myTimer);

                    temp.constraintNumber = constraintId;
                    //  counterRow = counterDateTable.Rows[0];////was 0
                    //inputDatGrid.Rows.RemoveAt(1);

                  // lineNumber = inputDatGrid.Rows.Count;
                    //  lineNumber = lineNumber - 1;

               //     MessageBox.Show(Convert.ToString(lineNumber),"Line Number");
                    int rowIncremenet = lineNumber - 1;

                

                    

                  
                    
                    
                    
                  /*  temp.counterValue = Convert.ToInt32(inputDatGrid.Rows[lineNumber].Cells[0].Value);
                    temp.counter2Value = Convert.ToInt32(inputDatGrid.Rows[lineNumber].Cells[1].Value);
                    temp.lastTickDateTime = Convert.ToDateTime(inputDatGrid.Rows[lineNumber].Cells[2].Value);*/


                   // inputDatGrid.DataSource = null;


                    myDateTime = temp.lastTickDateTime;

                    tick = tick + 1;
                    

                    int memberNumberupdate = temp.memberNumber;
                    int counter1Value = temp.counterValue;
                 //   MessageBox.Show(Convert.ToString(memberNumberupdate), "Member Number");
                //    MessageBox.Show(Convert.ToString(counter1Value), "Timer 1 Value tick 1");
//MessageBox.Show(Convert.ToString(constraintId), "constraintID");

                    //     MessageBox.Show(Convert.ToString(tick), "nodes loaded");

                    //  MessageBox.Show(relations, "relation is");


                    //   MessageBox.Show(relations,"relations");

                    /*if (numberOfWokers<1)

                    {

                        inputList.insertBack(temp.constraintNumber, temp.memberNumber, temp.counterValue, temp.counter2Value, temp.memberName, temp.lastTickDateTime);
                        if (head == null || temp == null)

                        {
                            return inputList;

                        }

                        head = temp;

                        temp = temp.next;
                        head = temp;


                        if (head == null || temp == null)

                        {
                            return inputList;

                        }
                        head.prev = null;  }*/


                    if (relations == "More than")
                    {

                        if (timeFrame == "Day/Days")
                        {
                            /*  differnce = calenderTime - temp.lastTickDateTime;
                              differenceOfTime = Convert.ToInt32(differnce.Days);*/
                            tick = tick + 1;
                        //    MessageBox.Show(Convert.ToString(tick), "if 1");


                            //going to look at who has the lowest
                            // is equal to or less than
                            //
                        }
                        else if (timeFrame == "Month/Months")

                        {
                            /*

                            differnce = calenderTime - temp.lastTickDateTime;
                            differenceOfTime = (Convert.ToInt32(differnce.Days)*30);
                            // is equal to or less than*/
                            tick = tick + 1;
                      //      MessageBox.Show(Convert.ToString(tick), "if 2");
                            //going to look at who has the lowest
                        }
                        else if (timeFrame == "Week/Weeks")
                        {
                            /*
                            differnce = calenderTime - temp.lastTickDateTime;
                            differenceOfTime = (Convert.ToInt32(differnce.Days) * 7);
                            //going to look at who has the lowest
                            // is equal to or less than
                            */
                        }
                        tick = tick + 1;
                     //   MessageBox.Show(Convert.ToString(tick), "if 3");
                    }

                    else if (relations == "Not More Than")
                    {
                        if (timeFrame == "Day/Days")
                        {    //is equal to or greater than so many timer is so many days
                            if ((temp.counterValue >= timer1) || (temp.lastTickDateTime > calenderTime.AddDays(-duration)))
                            {
                                // MessageBox.Show("while the");
                               
                                inputList.insertBack(temp.constraintNumber, temp.memberNumber, temp.counterValue, temp.counter2Value, temp.memberName, temp.lastTickDateTime);
                              //  MessageBox.Show("Push 1");

                                //     MessageBox.Show("Push");
                                if (head == null || temp == null)

                                {
                                    return; //inputList;

                                }

                                head = temp;

                                temp = temp.next;
                                head = temp;


                                if (head == null || temp == null)

                                {
                                    return;// inputList;

                                }
                                head.prev = null;
                                tick = tick + 1;
                         //       MessageBox.Show(Convert.ToString(tick), "if 4");
                            }
                        }
                        else if (timeFrame == "Month/Months")
                        {
                            if ((temp.counterValue >= timer1) && (temp.lastTickDateTime > calenderTime.AddDays((-duration) * 30)))

                            {
                                
                                inputList.insertBack(temp.constraintNumber, temp.memberNumber, temp.counterValue, temp.counter2Value, temp.memberName, temp.lastTickDateTime);
                            //    MessageBox.Show("Push 2");


                                if (head == null || temp == null)

                                {
                                    return;// inputList;

                                }

                                head = temp;

                                temp = temp.next;
                                head = temp;


                                if (head == null || temp == null)

                                {
                                    return;// inputList;

                                }
                                head.prev = null;

                                //  transferNodesThatContain(temp.counter2Value - 1, inputList, numberOfWokers);

                                //is equal to or greater than so many timer is so many days
                                tick = tick + 1;
                           //     MessageBox.Show(Convert.ToString(tick), "if 5");
                            }
                        }
                        else if (timeFrame == "Week/Weeks")
                        {
                            if ((temp.counterValue >= timer1) && (temp.lastTickDateTime > calenderTime.AddDays((-duration) * 7)))
                            {
                                
                                inputList.insertBack(temp.constraintNumber, temp.memberNumber, temp.counterValue, temp.counter2Value, temp.memberName, temp.lastTickDateTime);
                            //    MessageBox.Show("Push 3");

                                if (head == null || temp == null)

                                {
                                    return;// inputList;

                                }

                                head = temp;

                                temp = temp.next;
                                head = temp;


                                if (head == null || temp == null)

                                {
                                    return;// inputList;

                                }
                                head.prev = null;
                                tick = tick + 1;
                            //    MessageBox.Show(Convert.ToString(tick), "if 5");
                            }

                        }

                    }
                    // >


                    else if (relations == "Less Than")
                    



                        {
                            if (timeFrame == "Day/Days")
                            {    //is equal to or greater than so many timer is so many days
                                if ((temp.counterValue > timer1) && (temp.lastTickDateTime > calenderTime.AddDays(-duration)))
                                {
;
                                

                                inputList.insertBack(temp.constraintNumber, temp.memberNumber, temp.counterValue, temp.counter2Value, temp.memberName, temp.lastTickDateTime);
                             //   MessageBox.Show("Push 4");


                                if (head == null || temp == null)
                                    
                                {
                                    return;// inputList;

                                }

                                head = temp;

                                temp = temp.next;
                                head = temp;


                                if (head == null || temp == null)

                                {
                                    return;// inputList;

                                }
                                head.prev = null;
                                tick = tick + 1;
                           //     MessageBox.Show(Convert.ToString(tick), "if 7 ");
                           //     //MessageBox.Show(Convert.ToString( temp.prev));

                                ;

                              /*  if (head.prev != null)
                                {

                                    temp.prev = null;

                                }
                                    

                                // transferNodesThatContain(temp.counter2Value, inputList, numberOfWokers);

                            }
                        }
                            else if (timeFrame == "Month/Months")
                            {
                            if ((temp.counterValue > timer1) && (temp.lastTickDateTime > calenderTime.AddDays((-duration) * 30)))
                            {



                            

                                inputList.insertBack(temp.constraintNumber, temp.memberNumber, temp.counterValue, temp.counter2Value, temp.memberName, temp.lastTickDateTime);
                                MessageBox.Show("Push 5");


                            /*    if (head == null || temp == null)

                                {
                                    return;// inputList;

                                }

                                head = temp;

                                temp = temp.next;
                                head = temp;


                                if (head == null || temp == null)

                                {
                                    return;// inputList;

                                }
                                head.prev = null;*/
                                tick = tick + 1;
                            //    MessageBox.Show(Convert.ToString(tick), "if 8");

                                // transferNodesThatContain(temp.counter2Value, inputList, numberOfWokers);

                                //is equal to or greater than so many timer is so many days
                            }
                        }
                            else if (timeFrame == "Week/Weeks")
                            {
                                if ((temp.counterValue > timer1) && (temp.lastTickDateTime > calenderTime.AddDays((-duration) * 7)))
                                {

                                
                             


                                inputList.insertBack(temp.constraintNumber, temp.memberNumber, temp.counterValue, temp.counter2Value, temp.memberName, temp.lastTickDateTime);
                            //    MessageBox.Show("Push 6");

                                if (head == null || temp == null)

                                {
                                    return;// inputList;

                                }

                                head = temp;

                                temp = temp.next;
                                head = temp;


                                if (head == null || temp == null)

                                {
                                    return;// inputList;

                                }
                                head.prev = null;
                                tick = tick + 1;
                           //     MessageBox.Show(Convert.ToString(tick), "if 9");

                                // transferNodesThatContain(temp.counter2Value, inputList, numberOfWokers);

                            }

                        }
                        }
                            //   <

                            else if (relations == "At Least")
                            {

                                continue;
                            }


                    // >=
                    if (relations == "Exactly")
                    {
                        if (timeFrame == "Day/Days")
                        {
                            if ((temp.counterValue >= timer1)& ((temp.lastTickDateTime > calenderTime.AddDays(-duration))))
                            {
                               

                                inputList.insertBack(temp.constraintNumber, temp.memberNumber, temp.counterValue, temp.counter2Value, temp.memberName, temp.lastTickDateTime);

                          //      MessageBox.Show("Push 7");


                                if (head == null || temp == null)

                                {
                                    return;// inputList;

                                }

                                head = temp;

                                temp = temp.next;
                                head = temp;


                                if (head == null || temp == null)

                                {
                                    return;// inputList;

                                }
                                head.prev = null; 
                                
                                tick = tick + 1;
                         //       MessageBox.Show(Convert.ToString(tick), "if 10");

                                // transferNodesThatContain(timer1, inputList, numberOfWokers);

                            }
                        }
                        else if (timeFrame == "Week/Weeks")
                        {
                            if ((temp.counterValue >= timer1) && ((temp.lastTickDateTime > calenderTime.AddDays(-duration*7))))
                            {

                                
                            

                                inputList.insertBack(temp.constraintNumber, temp.memberNumber, temp.counterValue, temp.counter2Value, temp.memberName, temp.lastTickDateTime);
                        //        MessageBox.Show("Push 8");


                                if (head == null || temp == null)

                                {
                                    return;// inputList;

                                }

                                head = temp;

                                temp = temp.next;
                                head = temp;


                                if (head == null || temp == null)

                                {
                                    return;// inputList;

                                }
                                head.prev = null;
                                tick = tick + 1;
                         //       MessageBox.Show(Convert.ToString(tick), "if 11");

                                //   transferNodesThatContain(timer1, inputList, numberOfWokers);


                            }

                        }
                        else if (timeFrame =="Month/Months")
                        {

                            if ((timer1 >= temp.counterValue) && ((temp.lastTickDateTime > calenderTime.AddDays(-duration* 30))))
                            {
                                //
                                
                               
                                inputList.insertBack(temp.constraintNumber, temp.memberNumber, temp.counterValue, temp.counter2Value, temp.memberName, calenderTime);

                      //          MessageBox.Show("Push 9");

                                if (head == null || temp == null)

                                {
                                    return; //inputList;

                                }

                                head = temp;

                                temp = temp.next;
                                head = temp;


                                if (head == null || temp == null)

                                {
                                    return;// inputList;

                                }head.prev = null;
                                tick = tick + 1;
                     //           MessageBox.Show(Convert.ToString(tick), "if 12");
                                //  head.prev = null;

                                //  transferNodesThatContain(timer1, inputList, numberOfWokers);


                            }

                        }
                    }
                    //   ==

                  //  int memberNumberupdate = temp.memberNumber;
                 //   int counter1Value = temp.counterValue;
               //     MessageBox.Show(Convert.ToString(memberNumberupdate), "Member Number this is where it ends");
              //      MessageBox.Show(Convert.ToString(counter1Value), "Timer 1 Value tick 1");



                    //inputList.transferNodesWithLessThanCounter(, outPutList);



                    //
                    // MessageBox.Show(Convert.ToString(nodeNUmber), "Number of nodes in output list");




                    //switchStatement(inputList,relations, timer1, duration, timeFrame);


                    lineNumber=lineNumber+1;
                    numberOfCOnstraints = numberOfCOnstraints - 1;
                    }
               /* if (temp==null)
                {

                    break;
                }*/
                    
               temp = temp.next;

               // lineNumber = lineNumber + 1;
            }




            //outPutList= newSort.sortingSwitch(inputList,outPutList, relations, timer1, duration,timeFrame,DateBeingAddressed);

            // select from dataTable tabel row# (where the timer is) where the name of the workflow = A and the namne of the constraint = b
            // MessageBox.Show("Couting Input Linked List After sorting");
            //inputList.readAllValues();
            return;// inputList;
        }
        /*internal linkedListClass switchStatement (linkedListClass inputList, linkedListClass outputList,String relation,int timer1,int duration,DateTime timeFrame)
        {



            Node temp = inputList.head;


            //string relations =temp.;// greater than, lesser than ect
            int timer1 = 0;       //this many timer
            //per
            int duration = 0;  //this manmy time increments
            string timeFrame = "";//per week/month

           int counter1 = temp.counterValue;





        }*/


    }

    }


   

/* A recusring switch statement based on the
return number of counters in the workload. 
the query will return the number of counter, 
the recursing function will cycle through the number of 
coutners useing by counting the rows in the data structures,
it will then use that string value of the rows in the dataset
to indicate which paart of the switch statement to use 
so lets say we have: if (stringValue= "more than") {swtichInt =1} 
else if(stringValue= "less than") {switchInt =2}
AND it calls that switch statement from inside the loop untill 
it has gone through all the rows in the dataset*/