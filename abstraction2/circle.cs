using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction2
{
    class circle:shape
    {
        public override void area()
        {
            double r, ar;
            double pi = 3.14;
            Console.WriteLine("enter r value");
            r = double.Parse(Console.ReadLine());
            ar = pi * r * r;
            Console.WriteLine("area is" + ar);
            Console.ReadKey();
        }
    }
}
