using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorOverloads
{
    class Program
    {
        static void Main(string[] args)
        {
            ZClass z1 = new ZClass(5, 10);
            ZClass z2 = new ZClass(15, 20);
            ZClass z3 = z1 + z2;

            Console.WriteLine(z1.Total);
            Console.WriteLine(z2.Total);
            Console.WriteLine(z3.Total);
            Console.Write("Press the AnyKey to Continue....");
            Console.ReadKey();
        }
    }
}
