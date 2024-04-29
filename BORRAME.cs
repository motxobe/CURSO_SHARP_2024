using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hola
{
    class BORRAME
    {
        static void Main(string[] args)
        {

            String valortexto;
            int valor;
            Console.WriteLine("CURSO C # 2024!");
            Console.Write(Environment.NewLine); // line break

            Console.Write("Introduzca un numero ");
            valortexto = Console.ReadLine();
            Console.WriteLine("El texto introducido es: " + valortexto);
            valor = Convert.ToInt32(valortexto);
            Console.WriteLine("HAS INTRODUCIDO " + valor);

            if (valor < 10)
            {
                Console.WriteLine("El valor es menor que 10");
            }
            else
            {
                Console.WriteLine("El valor no es menor que 10");

            }

            

            //Console.WriteLine("Size of int: {0}", sizeof(decimal));
            //Console.ReadLine();

            Console.WriteLine("PULSA UNA TECLA PARA ACABAR ");
            Console.ReadLine(); // Console.ReadKey(true);
        }
    }
}
