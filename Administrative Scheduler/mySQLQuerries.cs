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

namespace Administrative_Scheduler
{
    class AdminScheduleCallProceedure
    {

        DataTable DataTable1 = new DataTable();
        SqlConnection connection1 = new SqlConnection("Server=tcp:administrativescheduler.database.windows.net,1433;Initial Catalog=administrativeServer;Persist Security Info=False;User ID=todd6822;Password=Ou812sir!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        SqlDataAdapter Adapter1;
        SqlCommand SQLCmd;

        public void insertSQL (string proceedureName, string parameter1Name, string parameter1Value)

            {


            connection1.Open();
            SQLCmd = new SqlCommand(proceedureName, connection1);
            SQLCmd.CommandType = CommandType.StoredProcedure;
            SQLCmd.Parameters.AddWithValue(parameter1Name, parameter1Value);
            SQLCmd.ExecuteNonQuery();

            MessageBox.Show("InsertedIntMemberTable");


        }


        public void insertSQL (string proceedureName, string parameter1Name,string parameter2Name, int parameter1Value,  int parameter2Value)

        {
            connection1.Open();
            SQLCmd = new SqlCommand(proceedureName, connection1);
            SQLCmd.CommandType = CommandType.StoredProcedure;
            SQLCmd.Parameters.AddWithValue(parameter1Name, parameter1Value);
            SQLCmd.Parameters.AddWithValue(parameter2Name, parameter2Value);
            SQLCmd.ExecuteNonQuery();

            MessageBox.Show("InsertedIntMemberTable");


        }


        public void insertSQL(string proceedureName, string parameter1Name, string parameter2Name,string parameter3Name, int parameter1Value,int parameter2Value, int parameter3Value)

        {
            connection1.Open();
            SQLCmd = new SqlCommand(proceedureName, connection1);
            SQLCmd.CommandType = CommandType.StoredProcedure;
            SQLCmd.Parameters.AddWithValue(parameter1Name, parameter1Value);
            SQLCmd.Parameters.AddWithValue(parameter2Name, parameter2Value);
            SQLCmd.Parameters.AddWithValue(parameter3Name, parameter3Value);
            SQLCmd.ExecuteNonQuery();

            MessageBox.Show("InsertedIntMemberTable");


        }

        public void deleteRow(string proceedureName, string parameter1Name, int parameter1Value)

        {


            connection1.Open();
            SQLCmd = new SqlCommand(proceedureName, connection1);
            SQLCmd.CommandType = CommandType.StoredProcedure;
            SQLCmd.Parameters.AddWithValue(parameter1Name, parameter1Value);
            SQLCmd.ExecuteNonQuery();

            MessageBox.Show("entry deleted");


        }

        public void deleteRow(string proceedureName, string parameter1Name, string parameter2Name, int parameter1Value, int parameter2Value)

        {
            connection1.Open();
            SQLCmd = new SqlCommand(proceedureName, connection1);
            SQLCmd.CommandType = CommandType.StoredProcedure;
            SQLCmd.Parameters.AddWithValue(parameter1Name, parameter1Value);
            SQLCmd.Parameters.AddWithValue(parameter2Name, parameter2Value);
            SQLCmd.ExecuteNonQuery();

            MessageBox.Show("Entry Deleted From Table");


        }



        public DataTable UseProceedure(string ProceedureName)

        {
            // DataTable DataTable1 = new DataTable();

            connection1.Open();

            SQLCmd = new SqlCommand(ProceedureName, connection1);
            SQLCmd.CommandType = CommandType.StoredProcedure;

            SQLCmd.ExecuteNonQuery();
            Adapter1 = new SqlDataAdapter(SQLCmd);
            Adapter1.Fill(DataTable1);
            connection1.Close();

            return DataTable1;

        }




        public DataTable UseProceedure(string ProceedureName, string Parameter1Name, DateTime Date1)

        {
            // DataTable DataTable1 = new DataTable();
            connection1.Open();


            SQLCmd = new SqlCommand(ProceedureName, connection1);
            SQLCmd.CommandType = CommandType.StoredProcedure;
            SQLCmd.Parameters.AddWithValue(Parameter1Name, Date1);

            SQLCmd.ExecuteNonQuery();
            Adapter1 = new SqlDataAdapter(SQLCmd);
            Adapter1.Fill(DataTable1);
            connection1.Close();
            return DataTable1;

        }
       
        public DataTable UseProceedure(string ProceedureName, string Parameter1Name, string Parameter2Name, string Parameter1Value, DateTime Date1)

        {
            // DataTable DataTable1 = new DataTable();
            connection1.Open();


            SQLCmd = new SqlCommand(ProceedureName, connection1);
            SQLCmd.CommandType = CommandType.StoredProcedure;
            SQLCmd.Parameters.AddWithValue(Parameter1Name, Parameter1Value);
            SQLCmd.Parameters.AddWithValue(Parameter2Name, Date1);

            SQLCmd.ExecuteNonQuery();
            Adapter1 = new SqlDataAdapter(SQLCmd);
            Adapter1.Fill(DataTable1);
            connection1.Close();
            return DataTable1;

        }
        public DataTable UseProceedure(string ProceedureName, string Parameter1Name, string Parameter2Name, string Parameter1Value, SqlDateTime Date1)

        {
            // DataTable DataTable1 = new DataTable();
            connection1.Open();


            SQLCmd = new SqlCommand(ProceedureName, connection1);
            SQLCmd.CommandType = CommandType.StoredProcedure;
            SQLCmd.Parameters.AddWithValue(Parameter1Name, Parameter1Value);
            SQLCmd.Parameters.AddWithValue(Parameter2Name, Date1);

            SQLCmd.ExecuteNonQuery();
            Adapter1 = new SqlDataAdapter(SQLCmd);
            Adapter1.Fill(DataTable1);
            connection1.Close();
            return DataTable1;

        }
        public DataTable UseProceedure(string ProceedureName, string Parameter1Name, string Parameter1Value)

        {
            //   DataTable DataTable1 = new DataTable();
            connection1.Open();


            SQLCmd = new SqlCommand(ProceedureName, connection1);
            SQLCmd.CommandType = CommandType.StoredProcedure;
            SQLCmd.Parameters.AddWithValue(Parameter1Name, Parameter1Value);

            SQLCmd.ExecuteNonQuery();
            Adapter1 = new SqlDataAdapter(SQLCmd);
            Adapter1.Fill(DataTable1);
            connection1.Close();
            return DataTable1;

        }
        public DataTable UseProceedure(string ProceedureName, string Parameter1Name, int Parameter1Value)

        {
            //   DataTable DataTable1 = new DataTable();
            connection1.Open();


            SQLCmd = new SqlCommand(ProceedureName, connection1);
            SQLCmd.CommandType = CommandType.StoredProcedure;
            SQLCmd.Parameters.AddWithValue(Parameter1Name, Parameter1Value);

            SQLCmd.ExecuteNonQuery();
            Adapter1 = new SqlDataAdapter(SQLCmd);
            Adapter1.Fill(DataTable1);
            connection1.Close();
            return DataTable1;

        }

        public DataTable UseProceedure(string ProceedureName, string Parameter1Name, string Parameter2Name, int Parameter1Value, string Parameter2Value)

        {
            //   DataTable DataTable1 = new DataTable();
            connection1.Open();


            SQLCmd = new SqlCommand(ProceedureName, connection1);
            SQLCmd.CommandType = CommandType.StoredProcedure;
            SQLCmd.Parameters.AddWithValue(Parameter1Name, Parameter1Value);
            SQLCmd.Parameters.AddWithValue(Parameter2Name, Parameter2Value);

            SQLCmd.ExecuteNonQuery();
            Adapter1 = new SqlDataAdapter(SQLCmd);
            Adapter1.Fill(DataTable1);
            connection1.Close();
            return DataTable1;

        }
        public DataTable UseProceedure(string ProceedureName, string Parameter1Name, string Parameter2Name,string Parameter3Name, int Parameter1Value, int Parameter2Value, int Parameter3Value)

        {
            //   DataTable DataTable1 = new DataTable();
            connection1.Open();


            SQLCmd = new SqlCommand(ProceedureName, connection1);
            SQLCmd.CommandType = CommandType.StoredProcedure;
            SQLCmd.Parameters.AddWithValue(Parameter1Name, Parameter1Value);
            SQLCmd.Parameters.AddWithValue(Parameter2Name, Parameter2Value);
            SQLCmd.Parameters.AddWithValue(Parameter3Name, Parameter3Value);
            SQLCmd.ExecuteNonQuery();
            Adapter1 = new SqlDataAdapter(SQLCmd);
            Adapter1.Fill(DataTable1);
            connection1.Close();

            return DataTable1;

        }

        public DataTable UseProceedure(string ProceedureName, string Parameter1Name, string Parameter2Name, string Parameter3Name, int Parameter1Value, int Parameter2Value, string Parameter3Value)

        {
            //   DataTable DataTable1 = new DataTable();
            connection1.Open();


            SQLCmd = new SqlCommand(ProceedureName, connection1);
            SQLCmd.CommandType = CommandType.StoredProcedure;
            SQLCmd.Parameters.AddWithValue(Parameter1Name, Parameter1Value);
            SQLCmd.Parameters.AddWithValue(Parameter2Name, Parameter2Value);
            SQLCmd.Parameters.AddWithValue(Parameter3Name, Parameter3Value);
            SQLCmd.ExecuteNonQuery();
            Adapter1 = new SqlDataAdapter(SQLCmd);
            Adapter1.Fill(DataTable1);
            connection1.Close();

            return DataTable1;

        }

        public DataTable UseProceedure(string ProceedureName, string Parameter1Name, string Parameter2Name, string Parameter3Name,string Parameter4Name, int Parameter1Value, int Parameter2Value, int Parameter3Value, int Parameter4Value)

        {
            //   DataTable DataTable1 = new DataTable();
            connection1.Open();


            SQLCmd = new SqlCommand(ProceedureName, connection1);
            SQLCmd.CommandType = CommandType.StoredProcedure;
            SQLCmd.Parameters.AddWithValue(Parameter1Name, Parameter1Value);
            SQLCmd.Parameters.AddWithValue(Parameter2Name, Parameter2Value);
            SQLCmd.Parameters.AddWithValue(Parameter3Name, Parameter3Value);
            SQLCmd.Parameters.AddWithValue(Parameter4Name, Parameter4Value);
            SQLCmd.ExecuteNonQuery();
            Adapter1 = new SqlDataAdapter(SQLCmd);
            Adapter1.Fill(DataTable1);
            connection1.Close();

            return DataTable1;

        }

        public DataTable UseProceedure(string ProceedureName, string Parameter1Name, string Parameter2Name, string Parameter3Name, string Parameter4Name, string Parameter5Name , int Parameter1Value, int Parameter2Value, int Parameter3Value, int Parameter4Value, DateTime Parameter5Value)

        {
            //   DataTable DataTable1 = new DataTable();
            connection1.Open();


            SQLCmd = new SqlCommand(ProceedureName, connection1);
            SQLCmd.CommandType = CommandType.StoredProcedure;
            SQLCmd.Parameters.AddWithValue(Parameter1Name, Parameter1Value);
            SQLCmd.Parameters.AddWithValue(Parameter2Name, Parameter2Value);
            SQLCmd.Parameters.AddWithValue(Parameter3Name, Parameter3Value);
            SQLCmd.Parameters.AddWithValue(Parameter4Name, Parameter4Value);
            SQLCmd.Parameters.AddWithValue(Parameter5Name, Parameter5Value);
            SQLCmd.ExecuteNonQuery();
            Adapter1 = new SqlDataAdapter(SQLCmd);
            Adapter1.Fill(DataTable1);
            connection1.Close();

            return DataTable1;

        }
        public DataTable UseProceedure(string ProceedureName, string Parameter1Name, string Parameter2Name, string Parameter3Name, string Parameter4Name, string Parameter5Name, string Parameter1Value, int Parameter2Value, int Parameter3Value, int Parameter4Value, DateTime Parameter5Value)

        {
            //   DataTable DataTable1 = new DataTable();
            connection1.Open();


            SQLCmd = new SqlCommand(ProceedureName, connection1);
            SQLCmd.CommandType = CommandType.StoredProcedure;
            SQLCmd.Parameters.AddWithValue(Parameter1Name, Parameter1Value);
            SQLCmd.Parameters.AddWithValue(Parameter2Name, Parameter2Value);
            SQLCmd.Parameters.AddWithValue(Parameter3Name, Parameter3Value);
            SQLCmd.Parameters.AddWithValue(Parameter4Name, Parameter4Value);
            SQLCmd.Parameters.AddWithValue(Parameter5Name, Parameter5Value);
            SQLCmd.ExecuteNonQuery();
            Adapter1 = new SqlDataAdapter(SQLCmd);
            Adapter1.Fill(DataTable1);
            connection1.Close();

            return DataTable1;

        }

        public DataTable UseProceedure(string ProceedureName, string Parameter1Name, string Parameter2Name, int Parameter1Value, int Parameter2Value)

        {
            //   DataTable DataTable1 = new DataTable();
            connection1.Open();


            SQLCmd = new SqlCommand(ProceedureName, connection1);
            SQLCmd.CommandType = CommandType.StoredProcedure;
            SQLCmd.Parameters.AddWithValue(Parameter1Name, Parameter1Value);
            SQLCmd.Parameters.AddWithValue(Parameter2Name, Parameter2Value);
            SQLCmd.ExecuteNonQuery();
            Adapter1 = new SqlDataAdapter(SQLCmd);
            Adapter1.Fill(DataTable1);
            connection1.Close();

            return DataTable1;

        }




        public DataTable UseProceedure(string ProceedureName, string Parameter1Name, string Parameter2Name, string Parameter3Name,
            string Parameter4Name, string Parameter5Name, string Parameter6Name,string Parameter1Value, string Parameter2Value, 
            int Parameter3Value, string Parameter4Value, int Parameter5Value, string Parameter6Value )

        {
            //   DataTable DataTable1 = new DataTable();
            connection1.Open();


            SQLCmd = new SqlCommand(ProceedureName, connection1);
            SQLCmd.CommandType = CommandType.StoredProcedure;
            SQLCmd.Parameters.AddWithValue(Parameter1Name, Parameter1Value);
            SQLCmd.Parameters.AddWithValue(Parameter2Name, Parameter2Value);
            SQLCmd.Parameters.AddWithValue(Parameter3Name, Parameter3Value);
            SQLCmd.Parameters.AddWithValue(Parameter4Name, Parameter4Value);
            SQLCmd.Parameters.AddWithValue(Parameter5Name, Parameter5Value);
            SQLCmd.Parameters.AddWithValue(Parameter6Name, Parameter6Value);
            SQLCmd.ExecuteNonQuery();
            Adapter1 = new SqlDataAdapter(SQLCmd);
            Adapter1.Fill(DataTable1);
            connection1.Close();

            return DataTable1;

        }
        public DataTable UseProceedure(string ProceedureName, string Parameter1Name, string Parameter2Name, string Parameter1Value, string Parameter2Value)

        {
            //   DataTable DataTable1 = new DataTable();
            connection1.Open();


            SQLCmd = new SqlCommand(ProceedureName, connection1);
            SQLCmd.CommandType = CommandType.StoredProcedure;
            SQLCmd.Parameters.AddWithValue(Parameter1Name, Parameter1Value);
            SQLCmd.Parameters.AddWithValue(Parameter2Name, Parameter2Value);
            SQLCmd.ExecuteNonQuery();
            Adapter1 = new SqlDataAdapter(SQLCmd);
            Adapter1.Fill(DataTable1);
            connection1.Close();

            return DataTable1;
        }



        public DataTable UseProceedure(string ProceedureName, string Parameter1Name, string Parameter2Name, DateTime Date1, DateTime Date2)

        {
            //   DataTable DataTable1 = new DataTable();
            connection1.Open();


            SQLCmd = new SqlCommand(ProceedureName, connection1);
            SQLCmd.CommandType = CommandType.StoredProcedure;
            SQLCmd.Parameters.AddWithValue(Parameter1Name, Date1);
            SQLCmd.Parameters.AddWithValue(Parameter2Name, Date2);
            SQLCmd.ExecuteNonQuery();
            Adapter1 = new SqlDataAdapter(SQLCmd);
            Adapter1.Fill(DataTable1);
            connection1.Close();
            return DataTable1;

        }

        public DataTable UseProceedure(string ProceedureName, string Parameter1Name, string Parameter2Name, string Parameter3Name, string parameter1Value, DateTime Date1, DateTime Date2)

        {
            //   DataTable DataTable1 = new DataTable();
            connection1.Open();


            SQLCmd = new SqlCommand(ProceedureName, connection1);
            SQLCmd.CommandType = CommandType.StoredProcedure;
            SQLCmd.Parameters.AddWithValue(Parameter1Name, parameter1Value);
            SQLCmd.Parameters.AddWithValue(Parameter2Name, Date1);
            SQLCmd.Parameters.AddWithValue(Parameter3Name, Date2);
            SQLCmd.ExecuteNonQuery();
            Adapter1 = new SqlDataAdapter(SQLCmd);
            Adapter1.Fill(DataTable1);
            connection1.Close();
            return DataTable1;


        }
        public int UseProceedureReturnInt(string ProceedureName, string Parameter1Name, string Parameter1Value)
        {
            object identity = 0;
            connection1.Open();
            int returnValue = 0;

            SQLCmd = new SqlCommand(ProceedureName, connection1);
            SQLCmd.CommandType = CommandType.StoredProcedure;
            SqlParameter SQP = new SqlParameter("returnVal", SqlDbType.Int);
            SQLCmd.Parameters.Add(SQP);
            SQLCmd.ExecuteScalar();
            identity = Convert.ToInt32(SQP.Value);
            SQLCmd.Parameters.AddWithValue(Parameter1Name, Parameter1Value);
            SQLCmd.ExecuteNonQuery();
            returnValue = Convert.ToInt32(identity);
            connection1.Close();



            return returnValue;
           
           

        }

        public int UseProceedureReturnInt(string ProceedureName, string Parameter1Name, string Parameter2Name, string Parameter1Value, string Parameter2Value)
        {
            connection1.Open();


            SQLCmd = new SqlCommand(ProceedureName, connection1);
            SQLCmd.CommandType = CommandType.StoredProcedure;
            SQLCmd.Parameters.AddWithValue(Parameter1Name, Parameter1Value);
            SQLCmd.Parameters.AddWithValue(Parameter2Name, Parameter2Value);
            SQLCmd.ExecuteNonQuery();
            Adapter1 = new SqlDataAdapter(SQLCmd);
            Adapter1.Fill(DataTable1);
            connection1.Close();
            return (int)SQLCmd.ExecuteScalar();

        }


        public int UseProceedureReturnInt3(string ProceedureName, string Parameter1Name, string Parameter1Value)
        {
            object identity = 0;
            connection1.Open();
            int returnValue = 0;

            SQLCmd = new SqlCommand(ProceedureName, connection1);
            SQLCmd.CommandType = CommandType.StoredProcedure;
            SqlParameter SQP = new SqlParameter("@returnVal", SqlDbType.Int);
            SQLCmd.Parameters.AddWithValue(Parameter1Name, Parameter1Value);
            SQLCmd.Parameters.Add(SQP);
            SQLCmd.ExecuteScalar();
            identity = Convert.ToInt32(SQP.Value);
            SQLCmd.ExecuteNonQuery();
            returnValue = Convert.ToInt32(identity);
            connection1.Close();



            return returnValue;

        }
        public int UseProceedureReturnInt2(string ProceedureName, string Parameter1Name,  string Parameter1Value)
        {
            int returnInt;
            connection1.Open();
            SQLCmd = new SqlCommand(ProceedureName, connection1);
            SQLCmd.CommandType = CommandType.StoredProcedure;
            SQLCmd.Parameters.AddWithValue(Parameter1Name, Parameter1Value);

            SQLCmd.Parameters.Add("@numberOfConstraint", SqlDbType.Int);
            SQLCmd.Parameters["@numberOfConstraint"].Direction = ParameterDirection.Output;
            //SqlParameter SQP = new SqlParameter("@numberOfConstraint", SqlDbType.Int);
           // SQP.Direction = ParameterDirection.Output;
            SQLCmd.ExecuteNonQuery();
            
            Adapter1 = new SqlDataAdapter(SQLCmd);
            Adapter1.Fill(DataTable1);
            returnInt = (int)SQLCmd.Parameters["@numberOfConstraint"].Value;
            connection1.Close();

            return returnInt;

        }
        public int UseProceedureReturnInt2(string ProceedureName, string Parameter1Name,string Parameter2Name ,string Parameter1Value)
        {
            int returnInt;
            connection1.Open();
            SQLCmd = new SqlCommand(ProceedureName, connection1);
            SQLCmd.CommandType = CommandType.StoredProcedure;
            SQLCmd.Parameters.AddWithValue(Parameter1Name, Parameter1Value);
            SQLCmd.Parameters.AddWithValue(Parameter2Name, 0);

            SQLCmd.Parameters.Add("@numberOfConstraint", SqlDbType.Int);
            SQLCmd.Parameters["@numberOfConstraint"].Direction = ParameterDirection.Output;
            //SqlParameter SQP = new SqlParameter("@numberOfConstraint", SqlDbType.Int);
            // SQP.Direction = ParameterDirection.Output;
            SQLCmd.ExecuteNonQuery();

            Adapter1 = new SqlDataAdapter(SQLCmd);
            Adapter1.Fill(DataTable1);
            returnInt = (int)SQLCmd.Parameters["@numberOfConstraint"].Value;
            connection1.Close();

            return returnInt;

        }
    }
}


//cmd.Parameters.Add("@retValue", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;