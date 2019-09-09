using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador num1 = new Sumador();
            Sumador num2 = new Sumador(8);

            Console.WriteLine(num1.Sumar("a","b"));
            Console.WriteLine(num1.Sumar(1,2));

            Console.WriteLine("Cantidad sumas num1 {0}",(int)num1);
            Console.WriteLine("Cantidad sumas num2 {0}", (int)num2);

            Console.WriteLine("Suma de sumadores {0}", num1 + num2);
            Console.WriteLine("Igualdad de num1 y num2 {0}", num1 | num2);
            Console.WriteLine("Igualdad de num1 y num1 {0}", num1 | num1);

            Console.ReadLine();
        }
    }
}
