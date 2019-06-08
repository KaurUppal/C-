using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var functions = new StringFunctions();
            functions.ReferenceString();
            var technical = new Technical();
            technical.swap(15, 16);
            Console.ReadKey();
            //delegates
        }
    }
}
