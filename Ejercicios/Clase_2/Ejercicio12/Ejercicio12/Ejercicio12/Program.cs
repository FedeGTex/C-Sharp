using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
  class Program
  {
    static void Main(string[] args)
    {
      string res;
      int num;
      
      Console.WriteLine("Ingrese el primer numero");
      num = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Ingrese el segundo numero");
      num += Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("La suma es {0} ", num);
      Console.WriteLine("Desea seguir sumando? s/n");
      res = Console.ReadLine();
      do
      {
        Console.WriteLine("Ingrese el siguiente numero: ");
        num += Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("La suma es de: {0}", num);
        Console.WriteLine("Desea seguir sumando? s/n");
        res = Console.ReadLine();
      } while (!ValidarRespuesta.ValidaS_N(Convert.ToChar(res)));
      Console.WriteLine("La suma final fue de: {0}", num);
      Console.ReadKey();
    }
  }
}
