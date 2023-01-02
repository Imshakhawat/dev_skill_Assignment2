using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Grid<T> where T : struct
    {
        private T[,,] _grid { get; set; }

        public T this[int x, int y, int z]
        {
            get
            {
                return _grid[x, y, z];
            }
        }
    }
