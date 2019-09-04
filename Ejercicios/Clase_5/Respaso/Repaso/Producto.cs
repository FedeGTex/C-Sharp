using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
  class Producto
  {
    #region fields
    private string codigoDeBarra;
    private string marca;
    private float precio;
    #endregion

    #region methods

    public Producto(string marca, string codigo, float precio)
    {
      this.marca = marca;
      this.codigoDeBarra = codigo;
      this.precio = precio;
    }

    public string GetMarca()
    {
      return marca;
    }

    public float GetPrecio()
    {
      return precio;
    }

    public static string MostrarProducto(Producto unProducto)
    {
      StringBuilder retorno = new StringBuilder();
      retorno.AppendLine($"Marca: {unProducto.GetMarca()}\n");
      retorno.AppendLine($"Precio: {unProducto.GetPrecio()}\n");
      retorno.AppendLine($"Codigo de barra: {unProducto.codigoDeBarra}\n");

      return retorno.ToString();
    }

    public static explicit operator string(Producto unProducto)
    {
      return unProducto.codigoDeBarra;
    }

    public static bool operator ==(Producto producto1,Producto producto2)
    {
      if (ReferenceEquals(producto1,producto2) && producto1.codigoDeBarra == producto2.codigoDeBarra)
        return true;
      else
        return false;
    }

    public static bool operator !=(Producto producto1,Producto producto2)
    {
      if (!(producto1 == producto2))
        return true;
      else
        return false;
    }

    public static bool operator ==(Producto producto1,string marca)
    {
      if (producto1.GetMarca() == marca)
        return true;
      else
        return false;
    }

    public static bool operator !=(Producto producto1,string marca)
    {
      if (!(producto1 == marca))
        return true;
      else
        return false;
    }

    #endregion




  }

}
