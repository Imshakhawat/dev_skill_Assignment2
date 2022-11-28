using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class StringHelper
    {


        string array_of_strings;

        public string Append(params string[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                array_of_strings = list[i] + array_of_strings;
            }

            return array_of_strings;
        }


        //public string Append(string a, string b):this(a, b, "", "")
        //{
        //    return a + b;
        //}

        //public string Append(string a, string b, string c)
        //{
        //    return a + b + c;
        //}

        //public string Append(string a, string b, string c, string d)
        //{
        //    return a + b + c + d;
        //}
    }
}
