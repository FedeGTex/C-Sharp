using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
  class Estante
  {
    #region fields
    private int ubicacionEstante;
    private Producto[] producto;
    #endregion

    #region methods

    private Estante(int capacidad)
    {
      producto = new Producto[capacidad];
    }

    public Estante(int capacidad, int ubicacion) : this(capacidad)
    {
      this.ubicacionEstante = ubicacion;
    }

    public Producto[] GetProductos() 
    {
      return producto;
    }

    public static string MostrarEstante(Estante unEstante)
    {
      StringBuilder retorno = new StringBuilder();
      retorno.AppendLine($"Ubicacion del estante: {unEstante.ubicacionEstante}");

      for(int i=0;i<unEstante.producto.Length;i++)
      {
        retorno.AppendLine(Producto.MostrarProducto(unEstante.producto[i]));
      }
      return retorno.ToString(); 
    }

    public static bool operator ==(Estante e,Producto p)
    {
      for(int i=0;i<e.producto.Length;i++)
      {
        if (e.producto[i] == p)
          return true;
      }
      return false;
    }

    public static bool operator !=(Estante e, Producto p)
    {
      return !(e == p);
    }

    public static Estante operator -(Estante e,Producto p)
    {
      for(int i=0;i<e.producto.Length;i++)
      {
        if(e.producto[i] == p)
        {
          e.producto[i] = null;
          return e;
        }
      }
      return e;
    }

    public static bool operator +(Estante e,Producto p)
    {
      for(int i=0;i<e.producto.Length;i++)
      {
        if(ReferenceEquals(e.producto[i],null) && e != p)
        {
          e.producto[i] = p;
          return true;
        }
      }
      return false;
    }

    #endregion

  }
}
