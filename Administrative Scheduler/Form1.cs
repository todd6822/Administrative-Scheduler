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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            linkedListClass myList = new linkedListClass();
            linkedListClass newList = new linkedListClass();
           // SortAlgorithm.sortConstraints=new


            myList.insertBack(1, 3, 1, 2, "tingtwo", DateTime.Now);
            myList.insertBack(1, 4, 1, 2, "tingtwo", DateTime.Now);
            myList.insertBack(1, 5, 1, 2, "tingtwo", DateTime.Now);
            myList.insertBack(1, 6, 1, 2, "tingtwo", DateTime.Now);
            myList.insertBack(1, 7, 1, 2, "tingtwo", DateTime.Now);
            myList.insertBack(1, 8, 1, 2, "tingtwo", DateTime.Now);
            myList.insertBack(1, 9, 1, 2, "tingtwo", DateTime.Now);
            myList.insertBack(1, 0, 1, 2, "tingtwo", DateTime.Now);
            myList.insertBack(1, 10, 1, 2, "tingtwo", DateTime.Now);
            myList.insertBack(1, 20, 1, 2, "tingtwo", DateTime.Now);
            myList.insertBack(1, 50, 1, 2, "tingtwo", DateTime.Now);

            myList.transferToNewList(0, 11, newList);


            myList.readAllValues();

          //  myList.
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
