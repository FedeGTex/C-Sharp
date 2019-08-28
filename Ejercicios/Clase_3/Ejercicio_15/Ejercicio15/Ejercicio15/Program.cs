using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
  class Program
  {
    static void Main(string[] args)
    {

      char opc;
      string operador;
      int numero1;
      int numero2;

      do
      {
        Console.WriteLine("Ingrese el primer numero: ");
        numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el operador");
        operador = Console.ReadLine();
        Console.WriteLine("Ingrese el segundo numero");
        numero2 = Convert.ToInt32(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("Si el segundo numero ingresado es 0, la operacion / (division) devolvera el primer numero \n");
        Console.WriteLine("El resultado es {0}", Calculadora.Calcular(numero1, numero2, operador));

        Console.WriteLine("Desea continuar? s/n");
        opc = Convert.ToChar(Console.ReadLine());

      } while (opc == 's' || opc == 'S');






      #region Mi region Nisman
      //double numero1 = 56.4;
      //Console.WriteLine($"El numero es: {numero1} asdjpaosdjasposaj {45}");
      //Console.WriteLine(string.Format("El numero es: {0} asdjpaosdjasposaj {1}", numero1, 45));
      //Console.WriteLine("El numero es: " + numero1 + "asdjpaosdjasposaj" + 45);
      //StringBuilder builder = new StringBuilder();
      //builder.AppendLine("HOla como estas");
      //int pepe = 0;
      //while (pepe < 5)
      //{
      //  builder.AppendLine($"HOla como estas{pepe}");
      //  pepe++;
      //}

      //Console.WriteLine(builder.ToString());
      //Console.ReadKey();  
      #endregion

    }
  }
}
