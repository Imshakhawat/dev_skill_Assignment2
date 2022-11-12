using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Lock
    {

        private string lockValue ;
        public string LockStatus {


            get
            {
                return lockValue;
            }
            set
            {
                if (value == "Open" || value == "Close")
                {
                    lockValue = value;
                }
                
            }
        
        } // Correct lock status are: Open & Close

    }
}
