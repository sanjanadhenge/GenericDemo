using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    public class Demo
    {
        public void MaxInteger(int a,int b,int c)
        {
            if(a.CompareTo(b) >0 && a.CompareTo(c)>0)
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
        public void FolatMax(double a, double b, double c)
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
        public void StringMax(String a, String b, String c)
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
