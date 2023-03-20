using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    public class DemoGeneric<T> where T : IComparable
    {
        public T a, b, c;
        public DemoGeneric(T a, T b, T c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void FindMax () 
        {
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0)
            {
                Console.WriteLine(a + " is Max");
            }
            if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0)
            {
                Console.WriteLine(b + " is Max");
            }
            if (c.CompareTo(a) > 0 && c.CompareTo(b) > 0)
            {
                Console.WriteLine(c + " is Max");
            }


        }
    }
}
