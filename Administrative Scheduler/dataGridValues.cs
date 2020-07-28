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
namespace Administrative_Scheduler

{

    class dataGridValues

    {
      /*  DataTable DataTable1 = new DataTable();
        SqlConnection connection1 = new SqlConnection("Server=tcp:administrativescheduler.database.windows.net,1433;Initial Catalog=administrativeServer;Persist Security Info=False;User ID=todd6822;Password=Ou812sir!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        SqlDataAdapter Adapter1;
        SqlCommand SQLCmd;*/

        public string returnElementString (object sender, DataGridViewCellEventArgs e, DataGridView inputDataGridView, DataTable dataTable, int cellNumber)

        {

            string outPutString="";



            int rows = 0;
            for (rows = 0; rows < dataTable.Rows.Count; rows++)
            {

                var row = dataTable.Rows[rows];
            }


            if ((e.RowIndex >= 0) && (e.RowIndex < rows))
            {

                DataGridViewRow row = inputDataGridView.Rows[e.RowIndex];
                outPutString = row.Cells[cellNumber].Value.ToString();
                MessageBox.Show(outPutString);
                //idValueFromDataGrid2 =this.missingWorkLoadView.Columns[1].Name;
                //  valueFromDataGrid2 = missingWorkLoadView.Rows[e.RowIndex].Cells[idValueFromDataGrid2].Value.ToString();





            }

            return outPutString;


        }
    }
}
