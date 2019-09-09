using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    public class Sumador
    {
        private int cantidadSumas;
        
        public Sumador()
        {
            this.cantidadSumas = 0;
        }

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public long Sumar(long a, long b)
        {
            this.cantidadSumas++;
            return a + b;
        }

        public string Sumar(string a, string b)
        {
            this.cantidadSumas++;
            return a + b;
        }

        public static explicit operator int (Sumador sumador)
        {
            return sumador.cantidadSumas;
        }

        public static long operator +(Sumador sumador_1,Sumador sumador_2)
        {
            return sumador_1.cantidadSumas + sumador_2.cantidadSumas;
        }

        public static bool operator |(Sumador sumador_1, Sumador sumador_2)
        {
           return (sumador_1.cantidadSumas == sumador_2.cantidadSumas);
        }

    }
}
