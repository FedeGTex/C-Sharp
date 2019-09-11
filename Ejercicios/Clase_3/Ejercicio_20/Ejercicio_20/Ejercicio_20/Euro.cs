using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20
{
    class Euro
    {
        private double cantidad;
        private static float cotizacionRespectoDolar;

        private Euro()
        {
            Euro.cotizacionRespectoDolar = 1 / (float)38.33;
        }

        public Euro(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, float cotizacion) : this(cotizacion)
        {
            Euro.cotizacionRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static float GetCotizacion()
        {
            return Euro.cotizacionRespectoDolar;
        }

        public static explicit operator Dolar(Euro e)
        {
            Dolar d = new Dolar(e.GetCantidad() * Euro.GetCotizacion());
            return d;
        }

        public static explicit operator Peso(Euro e)
        {
            Dolar d = (Dolar)e;
            return (Peso)d;
        }

        public static implicit operator Euro(double d)
        {
            Euro e = new Euro(d);
            return e;
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            bool returnAux = false;
            if(e.GetCantidad() == d.GetCantidad())
            {
                returnAux = true;
            }
            return returnAux;
        }

        public static bool operator ==(Euro e, Peso p)
        {
            bool returnAux = false;
            if(e.GetCantidad() == p.GetCantidad())
            {
                returnAux = true;
            }
            return returnAux;
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            bool returnAux = false;
            if (e1.GetCantidad() == e2.GetCantidad())
            {
                returnAux = true;
            }
            return returnAux;
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        public static bool operator !=(Euro e, Peso p)
        {
            return !(e == p);
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return ((Euro)d).GetCantidad() + e.GetCantidad();
        }

        public static Euro operator +(Euro e, Peso p)
        {
            return ((Euro)p).GetCantidad() + p.GetCantidad();
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            return ((Euro)d).GetCantidad() - e.GetCantidad();
        }

        public static Euro operator -(Euro e, Peso p)
        {
            return ((Euro)p).GetCantidad() - e.GetCantidad();
        }
    }
}
