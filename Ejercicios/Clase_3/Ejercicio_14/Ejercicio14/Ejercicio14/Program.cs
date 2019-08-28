using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
  class Program
  {
    static void Main(string[] args)
    {
      double numero1;
      double numero2;

      Console.WriteLine("CALCULAR CUADRADO: Ingrese un numero");
      numero1 = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("El area es: {0}", CalculoDeArea.CalcularCuadrado(numero1));

      Console.WriteLine("CALCULAR TRIANGULO: Ingrese el primer numero: ");
      numero1 = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Ingrese el segundo numero");
      numero2 = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("El area es {0}", CalculoDeArea.CalcularTriangulo(numero1, numero2));

      Console.WriteLine("Calcular Circulo: Ingrese un numero");
      numero1 = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("El area del circulo es {0}", CalculoDeArea.CalcularCirculo(numero1));

      Console.ReadKey();
    }
  }
}
