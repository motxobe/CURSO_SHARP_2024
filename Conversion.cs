using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hola
{
    class Conversion
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello COnversion de tipos!");
            double d = 5673.74;
            int i;

            // cast double to int.
            i = (int)d;
            Console.WriteLine("Hola soy d "+d);
            Console.WriteLine("Hola soy i " + i);
            Console.ReadKey();
            Console.ReadLine(); // Console.ReadKey(true);
        }

    }
}
