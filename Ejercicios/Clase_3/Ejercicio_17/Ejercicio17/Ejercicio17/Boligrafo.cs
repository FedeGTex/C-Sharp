using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boligrafo
{
  class Boligrafo
  {
    private const short cantidadTintaMaxima = 100;
    private ConsoleColor color;
    private short tinta;

    public Boligrafo(short tinta,ConsoleColor color)
    {
      this.color = color;
      this.tinta = tinta;
    }

    public ConsoleColor GetColor()
    {
      return color;
    }

    public short GetTinta()
    {
      return tinta;
    }

    private void SetTinta(short tinta)
    {
      if(GetTinta()<=)
    }
  }
}
