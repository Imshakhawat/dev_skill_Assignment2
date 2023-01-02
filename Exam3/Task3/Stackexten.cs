using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public static class Stackexten
    {

        public static int sumofNum(this Stack<int> arr)
        {
            var sum = 0;

            //foreach var
            for (int i = 0; i < arr.Count; i++)
            {
                sum = sum + arr.Peek();


                arr.Pop();
            }
            return sum;
        }


    }
}
