using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20
{
    class Peso
    {
        private double cantidad;
        private static float cotizacionRespectoDolar;

        private Peso()
        {
            Peso.cotizacionRespectoDolar = 1 / (float)38.33;
        }

        public Peso(double cantidad):this()
        {
            this.cantidad = cantidad;
        }

        public Peso(double cantidad, float cotizacion):this(cotizacion)
        {
            Peso.cotizacionRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static float GetCotizacion()
        {
            return Peso.cotizacionRespectoDolar;
        }

        public static explicit operator Dolar(Peso p)
        {
            Dolar d = new Dolar(p.GetCantidad() * Peso.GetCotizacion());
            return d;
        }

        public static explicit operator Euro(Peso p)
        {
            Dolar d = (Dolar)p;
            return (Euro)d;
        }

        public static implicit operator Peso(double d)
        {
            Peso temp = new Peso(d);
            return temp;
        }

        public static bool operator ==(Peso p , Dolar d)
        {
            bool returnAux = false;
            if(p.GetCantidad() == d.GetCantidad())
            {
                returnAux = true;
            }
            return returnAux;
        }

        public static bool operator !=(Peso p, Dolar d)
        {
            return !(p == d);
        }

        public static bool operator ==(Peso p, Euro e)
        {
            bool returnAux = false;
            if (p.GetCantidad() == e.GetCantidad())
            {
                returnAux = true;
            }
            return returnAux;
        }

        public static bool operator !=(Peso p, Euro e)
        {
            return !(p == e);
        }

        public static bool operator ==(Peso p1, Peso p2)
        {
            bool returnAux = false;
            if (p1.GetCantidad() == p2.GetCantidad())
            {
                returnAux = true;
            }
            return returnAux;
        }

        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1 == p2);
        }

        public static Peso operator +(Peso p, Dolar d)
        {
            return ((Peso)d).GetCantidad() + p.GetCantidad();
        }

        public static Peso operator +(Peso p,Euro e)
        {
            return ((Peso)e).GetCantidad() + p.GetCantidad();
        }

        public static Peso operator -(Peso p, Dolar d)
        {
            return ((Peso)d).GetCantidad() - p.GetCantidad();
        }

        public static Peso operator -(Peso p, Euro e)
        {
            return ((Peso)e).GetCantidad() + p.GetCantidad();
        }
    }
}
