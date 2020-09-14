using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 1";
            int numeros = 0;
            int max = 0;
            int min = 0;
            int acumulador = 0;
            float promedio;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                numeros = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    max = numeros;
                    min = numeros;
                }
                else if (numeros > max)
                {
                    max = numeros;
                }
                else if (numeros < min)
                {
                    min = numeros;
                }

                acumulador += numeros;
            }

            promedio = acumulador / 5;

            Console.WriteLine("El maximo es {0}, el minimo es {1}, la suma de todos los numeros es {2} y el promedio es {3}", max, min, acumulador, promedio);
            Console.ReadLine();
        }
    }
}
