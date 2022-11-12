using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





// didnt understand the question
namespace Task6
{
    public static class SystemDate
    {
        private static int _counter;

         static SystemDate()
        {
            _counter = 0;
        }

        public DateTime GetCurrentDate()
        {
            _counter++;
            return DateTime.Now;
        }

        public DateTime GetCurrentUtcDate()
        {
            _counter++;
            return DateTime.UtcNow;
        }
    }
}
