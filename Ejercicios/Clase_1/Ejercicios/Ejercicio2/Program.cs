using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
  class Program
  {
    static void Main(string[] args)
    {
      
      int num;

      Console.WriteLine("Digite un numero: ");
      num = int.Parse(Console.ReadLine());
      if(num>0)
      {
        double cuadrado =Math.Pow(num, 2);
        Console.WriteLine("El cuadrado es: "+ cuadrado);
        //Console.ReadLine();

        double cubo = Math.Pow(num, 4);
        Console.WriteLine("El cubo es: " + cubo);
        Console.ReadLine();

      }
      else
      {
        Console.WriteLine("Ingrese un numero mayor a 0!");
      }
      
    }
  }
}
