using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseProgra2
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleadoUno = new Empleado("Ernesto", "Rhoa", 30000.88, 35899.99, 900.00, 12, 600);
            Empleado empleadoDos = new Empleado("Sebastian", "Pepe", 40000.88, 48899.99, 900.00, 12, 600);
            Empleado empleadoTres = new Empleado("Claudio", "Asd", 50000.88, 58899.99, 900.00, 12, 600);
            Empleado empleadoCuatro = new Empleado("Sofia", "Qwerty", 55000.88, 63899.99, 900.00, 12, 600);
            Empleado empleadoCinco = new Empleado("Ludmila", "Xd", 88000.88, 98899.99, 900.00, 12, 600);

            Empleado e = new Empleado("Ernesto", "Rhoa", 35899.99);

            Console.WriteLine("El neto es : " + e.CalcularNeto(e.sueldoBruto));
            Console.ReadKey();



        }
    }
}
