using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    public class Program
    {
      static void Main(string[] args)
        {
            Demo demo = new Demo();
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("Select Option\n1.MaxInteger\n2.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        demo.MaxInteger(10, 50, 100);
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}
