using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {
      int num;
      int i;
      int contadorCeros;
      
      Console.WriteLine("Digite un numero: ");
      num = int.Parse(Console.ReadLine());

      Console.WriteLine("Numeros primos: ");

      for (i = 1; i <= num; i++)
      {
        contadorCeros = 0;

        for (int j = 1; j < i; j++)
        {
          if (i % j == 0)
          {
            contadorCeros++;
            if (contadorCeros > 1)
            {
              break;
            }
          }
        }
        if(contadorCeros == 1)
        {
          Console.WriteLine("- " + i);
        }
      }

      Console.ReadLine();
    }
  }
}
