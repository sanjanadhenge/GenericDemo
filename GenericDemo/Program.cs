using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
                Console.WriteLine("Select Option\n1.MaxInteger\n2.FloatMax\n3.StringMax\n4.Find Max by Generic Method\n5.Find Max By Generic Class\n6.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        demo.MaxInteger(10, 50, 100);
                        break;
                    case 2:
                        demo.FolatMax(15.85, 98.45, 75.96);
                        break;
                    case 3:
                        demo.StringMax("Apple", "Orange", "Mango");
                        break;
                    case 4:
                       // DemoGeneric demoGeneric = new DemoGeneric();
                       // demoGeneric.FindMax(10, 20, 30);
                       // demoGeneric.FindMax(85.45, 98.65, 12.56);
                       /// demoGeneric.FindMax("Blue", "White", "Black");
                        break;
                    case 5:
                        DemoGeneric<int> demoGeneric1 = new DemoGeneric<int>(1500,1000,300);
                        demoGeneric1.FindMax();
                        DemoGeneric<double> demoGeneric2 = new DemoGeneric<double>(15.75, 10.50, 30.50);
                        demoGeneric2.FindMax();
                        DemoGeneric<String> demoGeneric3 = new DemoGeneric<String>("Blue", "White", "Black");
                        demoGeneric3.FindMax();
                        break;
                    case 6:
                        flag = false;
                        break;
                }
            }
        }
    }
}
