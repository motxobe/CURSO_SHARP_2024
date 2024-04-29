using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hola // lo he cambiado a las 16:04
{
    class ENUM
    {

        enum WeekDays
        {
            Lunes,
            Martes,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {


            Console.WriteLine("hola KOKO modificado 17 07");
            Console.Write("Introduzca un texto ");
            String texto;

            DateTime dt1 = new DateTime(2024, 4, 3);
            DateTime dt2 = new DateTime(2024, 4, 26);
            TimeSpan result = dt2.Subtract(dt1);
            Console.WriteLine(result);

            texto = Console.ReadLine();
            Console.WriteLine("El texto introducido es: " + texto);

            Console.WriteLine(WeekDays.Lunes); // Monday
            Console.WriteLine(WeekDays.Martes); // Tuesday
            Console.WriteLine(WeekDays.Wednesday); // Wednesday
            Console.WriteLine(WeekDays.Thursday); // Thursday
            Console.WriteLine(WeekDays.Friday); // Friday
            Console.WriteLine(WeekDays.Saturday); // Saturday
            Console.WriteLine(WeekDays.Sunday); // Sunday

            Console.WriteLine("PULSA UNA TECLA PARA CONTINUAR");
            texto = Console.ReadLine();

        }
    }
}
