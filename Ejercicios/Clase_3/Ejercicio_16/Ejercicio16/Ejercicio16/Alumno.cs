using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
  class Alumno
  {
    protected byte nota1;
    protected byte nota2;
    protected float notaFinal;
    public string apellido;
    public int legajo;
    public string nombre;



    public void CalcularFinal()
    {
      if(nota1>=4 && nota2>=4)
      {
        Random miRandom = new Random();
        notaFinal = miRandom.Next(4, 10);
      }
    }
    public void Estudiar(byte nota1,byte nota2)
    {
      this.nota1 = nota1;
      this.nota2 = nota2;
    }

    public string Mostrar()
    {
      StringBuilder retorno = new StringBuilder();
      retorno.AppendFormat($"Alumno: {nota1}, {nota2}\n");
      retorno.AppendFormat($"Legajo: {legajo}\n");
      retorno.AppendFormat($"Nota 1: {nota1} y nota 2: {nota2}\n");

      CalcularFinal();
      if (notaFinal >= 4)
        retorno.AppendFormat($"Nota final: {notaFinal}");
      else
        retorno.AppendFormat("Alumno desaprobado");

      return retorno.ToString();
    }


  }
}
