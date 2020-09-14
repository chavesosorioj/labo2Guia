using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 5";
            int numero, acumP = 0, acumA = 0;

            Console.WriteLine("Numero centrico");
            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            for (int i = numero; i > 0; i--)
            {
                acumP = 0;
                acumA = 0;

                for (int j = i-1; j > 0; j--)
                {
                    acumA += j;
                }

                for (int w = i+1; acumP < acumA; w++)
                {
                    acumP += w;
                }
                if (acumP == acumA)
                    Console.WriteLine("centro numero {0}", i);
            }

            Console.ReadKey();
        }
    }
}
