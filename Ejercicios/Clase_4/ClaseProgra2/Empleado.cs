using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseProgra2
{
    class Empleado
    {
        public string nombre;
        public string apellido;
        public double sueldoBruto;
        public double sueldoNeto;
        public double jubilacion;
        public double ley19032;
        public double obraSocial;


        public Empleado(string nombre, string apellido,double sueldoBruto,double sueldoNeto,double jubilacion,double ley19032,double obraSocial)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.sueldoBruto = sueldoBruto;
            this.sueldoNeto = sueldoNeto;
            this.jubilacion = jubilacion;
            this.ley19032 = ley19032;
            this.obraSocial = obraSocial;

        }
        public Empleado(string nombre,string apellido, double sueldoBruto)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.sueldoBruto = sueldoBruto;
  
        }

        
        public double CalcularNeto(double sueldoBruto)
        {
            this.jubilacion = (sueldoBruto * 0.11);
            this.obraSocial = (sueldoBruto * 0.03);
            this.ley19032 = (sueldoBruto * 0.03);
            return this.sueldoNeto =  (sueldoBruto - this.jubilacion - this.obraSocial - this.ley19032);
        }

        public void Mostrar()
        {


        }

        //public bool CalcularNeto(double sueldoBruto,bool sindicato)
        //{
        //    if(sueldoBruto>0)
        //    {
        //        sindicato = this.sueldoBruto * 02;
        //    }
        //    return sindicato;
        //}

        public void Aumento(double sueldoBruto)
        {

        }

        public void Aumento(int porcentajeAAumentar)
        {

        }
    }
}
