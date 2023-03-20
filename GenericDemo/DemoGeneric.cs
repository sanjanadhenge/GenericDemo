using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    public class DemoGeneric
    {
        public void FindMax <T> (T a, T b, T c) where T : IComparable
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
