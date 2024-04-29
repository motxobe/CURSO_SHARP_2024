using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hola
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("hola mundo");
            Console.Write("Introduzca un texto ");
            String texto;
            texto = Console.ReadLine();
            Console.WriteLine("El texto introducido es: " + texto);
            Console.WriteLine("PULSA UNA TECLA PARA CONTINUAR");
            texto = Console.ReadLine();

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
