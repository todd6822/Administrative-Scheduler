using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrative_Scheduler
{
    class ValueCheckClass
    {

      public  bool checkForInt(string inputString)

        {

            int output = 0;
           
                bool returnedValue = int.TryParse(inputString, out output);
            

            
            return returnedValue;

        }

    }
}
