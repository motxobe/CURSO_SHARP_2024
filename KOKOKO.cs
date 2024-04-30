using System;

namespace Program
{
    class KOKOKO

    {
        static void Main(string[] args)
        {
            Console.WriteLine("hoy es martes");
            Console.Write(Environment.NewLine); // line break
            Console.Write("What is your name? ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Hello " + nombre);
            DateTime fecha;
            DateTime currentDate = DateTime.Now;
            fecha = DateTime.Now;
            int dia, mes, anio;
            dia = fecha.Day;
            mes = fecha.Month;
            anio = fecha.Year;
            Console.Write(Environment.NewLine + "Today is " + dia + "/" + mes + "/" + anio);
            Console.Write(Environment.NewLine + "Press a key to exit... ");
            Console.ReadLine(); // Console.ReadKey(true);
        }
    }
}

