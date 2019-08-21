using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
  class Program
  {
    static void Main(string[] args)
    {
      int i;
      int num = 0;
      int mayor = 0;
      int menor = 0;
      int acum=0;
      float promedio;

      for (i = 0; i < 5; i++)
      {
        Console.WriteLine("Digite un numero: ");
        num = int.Parse(Console.ReadLine());
        if (i == 0)
        {
          mayor = num;
          menor = num;
        }
        else
        {
          if (num > mayor)
          {
            mayor = num;
          }
          if (num < menor)
          {
            menor = num;
          }
        }
        acum = acum + num;
      }
      promedio = (float)acum / i;

      Console.WriteLine(" numero mayor es: " + mayor);
      Console.WriteLine(" numero menor es: " + menor);
      Console.WriteLine("El promedio es: " + promedio);
      Console.ReadKey();
    }
  }
}

