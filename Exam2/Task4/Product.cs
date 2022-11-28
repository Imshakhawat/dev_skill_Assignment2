using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public  class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }



        public string? GetShortName()
        {
            return Name?.Substring(0, 5);
        }
    }
}
