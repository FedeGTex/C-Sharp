using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
  class Program
  {
    static void Main(string[] args)
    {
      Alumno alumnoUno = new Alumno();
      alumnoUno.nombre = "Adolfito";
      alumnoUno.apellido = "Hee";
      alumnoUno.legajo = 123;
      alumnoUno.Estudiar(9, 8);
      Console.WriteLine(alumnoUno.Mostrar());
      Console.ReadKey();
      Console.WriteLine("\n**********");

      Alumno alumnoDos = new Alumno();
      alumnoDos.nombre = "Isabel";
      alumnoDos.apellido = "La Catolica";
      alumnoDos.legajo = 122;
      alumnoDos.Estudiar(9, 9);
      Console.WriteLine(alumnoDos.Mostrar());
      Console.ReadKey();
      Console.WriteLine("\n**********");

      Alumno alumnoTres = new Alumno();
      alumnoTres.nombre = "Mirta";
      alumnoTres.apellido = "Le";
      alumnoTres.legajo = 121;
      alumnoTres.Estudiar(2, 8);
      Console.WriteLine(alumnoTres.Mostrar());
      Console.ReadKey();
      Console.WriteLine("\n**********");

      Console.ReadKey();

    }
  }
}
