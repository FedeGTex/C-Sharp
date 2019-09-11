using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20
{
    class Dolar
    {
        private double cantidad;
        private static float cotizacionRespectoDolar;

        private Dolar()
        {
            Dolar.cotizacionRespectoDolar = 1;
        }

        public Dolar(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, float cotizacion) : this(cantidad)
        {
            Dolar.cotizacionRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static float GetCotizacion()
        {
            return Dolar.cotizacionRespectoDolar;
        }

        public static explicit operator Euro(Dolar d)
        {
            Euro e = new Euro(d.GetCantidad() / Euro.GetCotizacion());
            return e;
        }

        public static explicit operator Peso(Dolar d)
        {
            Peso p = new Peso(d.GetCantidad() * Peso.GetCotizacion());
            return p;
        }
        
        public static implicit operator Dolar(double d)
        {
            Dolar temp = new Dolar(d);
            return temp;
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            bool returnAux = false;
            if (d.GetCantidad() == e.GetCantidad())
            {
                returnAux = true;
            }
            return returnAux;
        }

        public static bool operator ==(Dolar d, Peso p)
        {
            bool returnAux = false;
            if (d.GetCantidad() == p.GetCantidad())
            {
                return true;
            }
            return returnAux;
        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            bool returnAux = false;
            if (d1.GetCantidad() == d2.GetCantidad())
            {
                return true;
            }
            return returnAux;
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

        public static bool operator !=(Dolar d, Peso p)
        {
            return !(d == p);
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            return ((Dolar)e).GetCantidad() + d.GetCantidad();
        }

        public static Dolar operator +(Dolar d, Peso p)
        {
            return ((Dolar)p).GetCantidad() + d.GetCantidad();
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            return ((Dolar)e).GetCantidad() - d.GetCantidad();
        }

        public static Dolar operator -(Dolar d, Peso p)
        {
            return ((Dolar)p).GetCantidad() - d.GetCantidad();
        }



    }
}
