using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20
{
  class Program
  {
    static void Main(string[] args)
    {
      Dolar d1 = new Dolar(10, 1);
      Dolar d2 = new Dolar(10, 1);
      Dolar d3 = new Dolar(20, 1);
      Euro e1 = new Euro(30);
      Euro e2 = new Euro(40);
      Euro e3 = new Euro(40);
      Peso p1 = new Peso(50);
      Peso p2 = new Peso(60);
      Peso p3 = new Peso(60);

      Console.WriteLine("d1: {0} d2: {1} d3: {2}", d1.GetCantidad(), d2.GetCantidad(), d3.GetCantidad());
      Console.WriteLine("e1: {0} e2: {1} e3: {2}", e1.GetCantidad(), e2.GetCantidad(), e3.GetCantidad());
      Console.WriteLine("e1: {0} e2: {1} e3: {2}", p1.GetCantidad(), p2.GetCantidad(), p3.GetCantidad());

      Console.WriteLine("e1 a dolar: {0}", ((Dolar)e1).GetCantidad());
      Console.WriteLine("d1 a euro: {0}", ((Euro)d1).GetCantidad());
      Console.WriteLine("e1 a pesos: {0}", ((Peso)e1).GetCantidad());




      Console.ReadKey();

    }
  }
}
