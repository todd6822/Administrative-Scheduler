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

namespace Administrative_Scheduler
{


    public partial class ScheduleForm : Form
    {
        SqlDateTime startTime;
        SqlDateTime endTime;
        DataTable table1;
        DataTable table2;
        AdminScheduleCallProceedure workLoadName = new AdminScheduleCallProceedure();

        public ScheduleForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table1 = workLoadName.UseProceedure("findAllWorkloads");
            this.workLoadDataGrid.DataSource = table1;
        }

        private void startMonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void endMonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {



        }

        private void beginDatePicker_ValueChanged(object sender, EventArgs e)
        {
            startTime = beginDatePicker.Value.Date;
            MessageBox.Show(startTime.ToString());


        }

        private void endDatePicker_ValueChanged(object sender, EventArgs e)
        {
            endTime = endDateTimePicker.Value.Date;
            MessageBox.Show(endTime.ToString());

        }

        private void workLoadDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridValues constraintGridClick = new dataGridValues();
            string valuefromElementNumber = constraintGridClick.returnElementString(sender, e, workLoadDataGrid, table1, 0);

            AdminScheduleCallProceedure returnWorkersWithWorkloadsAssinged  = new AdminScheduleCallProceedure();


            

            table2 = returnWorkersWithWorkloadsAssinged.UseProceedure("returnLeaveAndWorkload", "@workLoad", "@scheduleDay", valuefromElementNumber,startTime);





            //unassignWorkLoad.UseProceedure("unassignWorkload", "@memberID", "@workLoadID", memberNumberToUpdate, unassignedWorkLoadNumber);

            this.testTable.DataSource = table2;



        }
    }
}
