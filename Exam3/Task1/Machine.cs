using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Machine<T> where T : class, new()
    {
        //public delegate void Starter(params T[] args);

        //public event Starter OnStart;

        //public void Start(params T[] args)
        //{
        //    OnStart.Invoke(args);
        //}

        // public delegate void Starter(params T[] args);


        public event Action<T> OnStart;

        public void Start(List<T> items, params T[] args)
        {

            if (OnStart != null)
            {

                //List<T> obj = new List<T>();
                //foreach (var t in args)
                //{
                //    obj.Add(t);
                //}
                var items = args;
                OnStart.Invoke(items);

            }


        }


    }
}
