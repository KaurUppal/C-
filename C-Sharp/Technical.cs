using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    class Technical
    {
        //swap the two nmbers without using third number
        public void swap(int a, int b)
        {
            Console.WriteLine("without swaping: a= {0}, b={1}", a, b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("after swaping: a= {0}, b={1}", a, b);
        }
    }
}
