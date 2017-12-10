using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorOverloads
{
    class Program
    {
        static ZClass[] zArray = new ZClass[10];
        
        static void Main(string[] args)
        {
            for (int i = 0; i < zArray.Length; i++)
            {
                zArray[i] = new ZClass(i, 2 * i);
                Console.WriteLine(zArray[i]);
            }

            ZClass z1 = new ZClass(1, 10);
            ZClass z2 = new ZClass(100, 200);
            ZClass z3 = z1 + z2;

            for (int i = 0; i < zArray.Length; i++)
            {
                z1 += i;
                z2 += i;
                z3 += i;
                Console.WriteLine("z1 = " + z1);
                Console.WriteLine("z2 = " + z2);
                Console.WriteLine("z3 = " + z3);
                Console.WriteLine(new string('=', 30));
                Console.Write("Press Enter to Continue....");
                Console.ReadLine();
            }

            Console.WriteLine("Done.");
            Console.ReadLine();


        
        }
    }
}
