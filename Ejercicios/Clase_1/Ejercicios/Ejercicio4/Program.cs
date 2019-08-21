using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
  class Program
  {
    static void Main(string[] args)
    {
      int acumulador;
      int i;
      int j;
      int numPerfecto=0;

      Console.WriteLine("NUMEROS PERFECTOS: ");

      for(i=1;numPerfecto<4;i++)
      {
        acumulador = 0;
        for(j=i-1;j>0;j--)
        {
          if (i % j == 0)
          {
            acumulador = acumulador + j;
          }
        }
        if (acumulador == i)
        {
          numPerfecto++;
          Console.WriteLine(" -{0}- ", i);
          Console.ReadLine();
        }
      }
    }
  }
}
