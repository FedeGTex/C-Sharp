using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2
{
  public class Cuadrado
  {

    public bool PotenciarNumero(double numero,out double potencia)
    {
      potencia=0;
      if (numero > 0)
      {
        potencia = Math.Pow(numero, 2);

        return true;
        //Console.ReadLine();

        //double cubo = Math.Pow(num, 4);
        //Console.WriteLine("El cubo es: " + cubo);
        //Console.ReadLine();
      }
      else
      {
        return false;
      }
      
    }
  }
}
