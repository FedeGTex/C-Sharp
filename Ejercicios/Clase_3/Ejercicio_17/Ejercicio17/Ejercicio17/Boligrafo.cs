using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boli
{
    public class Boligrafo
    {
        private const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            if (tinta >= 0 && tinta <= cantidadTintaMaxima)
            {
                this.tinta = tinta;
            }
        }

        public void Recargar()
        {
            this.SetTinta(cantidadTintaMaxima);
        }

        public bool Pintar(int gasto, out string dibujo)
        {
            bool returnAux = false;
            dibujo = "";
            int resto = this.GetTinta() - (short)gasto;
            if(resto > 0)
            {
                this.SetTinta((short)resto);
                returnAux = true;
                for(int i=1;i<=gasto;i++)
                {
                    dibujo += '*';
                }
            }
            return returnAux;
            
        }

    }
}
