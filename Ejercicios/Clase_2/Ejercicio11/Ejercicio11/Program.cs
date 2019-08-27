using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int min=int.MaxValue;
            int max=int.MinValue;
            int contador = 0;
            

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese 10 numeros",i+1);

                numero = Convert.ToInt32(Console.ReadLine());
                while(!Validacion.Validar(numero,-100,100))
                {
                    Console.WriteLine("Ingrese un numero valido!!");
                }
                if (numero < min)
                {
                    min = numero;
                }
                else if (numero > max)
                {
                    max = numero;
                }
                contador += numero;
            }

            Console.WriteLine("Valor min: {0} Valor max: {1} Promedio: {2}", min, max, (contador / 10));
            Console.ReadLine();
        }
    }
}
