using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        /// <summary>
        /// Asigna un valor al atributo previa Validacion
        /// </summary>
        public string SetNumero
        {
            set
            {
                if (ValidarNumero(value) != 0)
                    numero = ValidarNumero(value);
            }
        }

        /// <summary>
        /// Valida que el valor recibido sea numerico caso contrario retorna 0
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns>retorna 0 o el numero en formato double</returns>
        private static double ValidarNumero(string strNumero)
        {
            double auxDecimal;

            if (double.TryParse(strNumero, out auxDecimal))
                return auxDecimal;
            return 0;
        }

        /// <summary>
        /// Asigna 0 al atributo numero
        /// </summary>
        public Numero()
        {
            numero = 0;
        }


        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string numero)
        {
            SetNumero = numero;
        }

        /// <summary>
        /// Verifica que el valor binario sea 0 o 1
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>retorna falso si es esta vacio o si es distinto a 0 o 1</returns>
        private static bool EsBinario(string binario)
        {
            if (!string.IsNullOrEmpty(binario))
            {
                foreach (char item in binario)
                {
                    if (item != '1' && item != '0')
                        return false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Convierte numero decimal a binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>el numero decimal convertido</returns>
        public static string DecimalBinario(double numero)
        {
            string binario = "";
            string auxBinario = "";
            StringBuilder aux = new StringBuilder("");
            int modulo = 0;
            int resultado = 0;

            if (numero != 0 && numero != 1)
            {
                resultado = (int)numero;

                while (resultado / 2 != 1)
                {
                    modulo = resultado % 2;
                    resultado = resultado / 2;
                    aux.Append(modulo.ToString());
                }

                modulo = resultado % 2;
                resultado = resultado / 2;

                aux.Append(modulo.ToString());
                aux.Append(resultado.ToString());
                auxBinario = aux.ToString();


                for (int i = auxBinario.Length - 1; i >= 0; i--)
                {
                    binario = binario + auxBinario[i];
                }
            }
            else
            {
                binario = numero.ToString();
            }

            return binario;
        }

        /// <summary>
        /// Convierte el valor decimal a binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>El numero decimal convertido</returns>
        public static string DecimalBinario(string numero)
        {
            string numeroBinario = "Valor invalido";
            string resultado = "";
            double num;
            int resto;
            int i;

            if (double.TryParse(numero, out num))
            {
                num = Math.Truncate(Math.Abs(num));
                numeroBinario = DecimalBinario(num);

                if (numeroBinario.Length >= 5)
                {
                    resto = numeroBinario.Length % 4;
                    for (i = 0; i < resto; i++)
                    {
                        resultado = resultado + numeroBinario[i];
                    }

                    resultado += ' ';
                    for (int j = 0; i < numeroBinario.Length; i++, j++)
                    {
                        resultado = resultado + numeroBinario[i];
                        if (j == 3)
                        {
                            if (i != numeroBinario.Length - 1)
                            {
                                resultado = resultado + ' ';
                            }

                            j = -1;
                        }
                    }
                    numeroBinario = resultado;
                }
            }
            return numeroBinario;
        }

        /// <summary>
        /// Convierte string binario a decimal string
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>El numero decimal a binario</returns>
        public static string BinarioDecimal(string binario)
        {
            int i;
            double total = 0;
            double potencia = 0;
            int flag = 0;
            string cadena = "Valor invalido";


            if (EsBinario(binario))
            {
                for (i = binario.Length - 1; i >= 0; i--)
                {
                    if (binario[i] == '1')
                    {
                        total = total + (Math.Pow(2, potencia) * 1);
                        potencia++;
                    }
                    else if (binario[i] == '0')
                    {
                        potencia++;
                    }
                    else
                    {
                        cadena = "Valor invalido";
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                {
                    cadena = total.ToString();
                }
            }
            return cadena;
        }

        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }

        public static double operator /(Numero n1, Numero n2)
        {

            if (n2.numero == 0)
                return double.MinValue;

            return n1.numero / n2.numero;
        }

    }
}
