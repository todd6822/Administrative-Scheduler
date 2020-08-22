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

namespace Administrative_Scheduler
{
    class TimerAlgorithm
    {


       public void NodeTimer1Add(linkedListClass.Node inputNode)
        {


            int incremenet = 0;

            incremenet= inputNode.counterValue;

            incremenet = incremenet + 1;

            inputNode.counterValue = incremenet;


            

        }

        public void NodeTimer1Minus (linkedListClass.Node inputNode)
        {

            int incremenet = 0;

            incremenet = inputNode.counterValue;

            incremenet = incremenet - 1;

            inputNode.counterValue = incremenet;


            


        }


        

    }
}
