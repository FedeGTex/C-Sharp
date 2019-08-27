using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2
{
  class Program
  {
    static void Main(string[] args)
    {
      string ingreso;
      int ingresoEntero;
      double ingresoDouble;
      double salida;
      Cuadrado miCuadrado = new Cuadrado();
      do
      {
        do
        {
          Console.WriteLine("Ingrese un numero");

          ingreso = Console.ReadLine();
        } while (!int.TryParse(ingreso, out ingresoEntero));


        double.TryParse(ingreso, out ingresoDouble);


      } while (!miCuadrado.PotenciarNumero(ingresoDouble,out salida));
      Console.ReadLine();

    }
  }
}
