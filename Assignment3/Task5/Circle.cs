using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Circle : TestInterface 
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            Radius = radius;
        }


        public double CalulateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
