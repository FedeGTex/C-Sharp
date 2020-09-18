using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Valida que el operador sea el correcto caso contrario retorna +
        /// </summary>
        /// <param name="operador"></param>
        /// <returns>retorna el operador</returns>
        private static string ValidarOperador(string operador)
        {
            if (operador != "+" && operador != "-" && operador != "/" && operador != "*")
                operador = "+";

            return operador;
        }

        /// <summary>
        /// Realiza la operacion elegida por el usuario
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns>el resultado de la operacion</returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            switch (ValidarOperador(operador))
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "/":
                    return (num1 / num2);
                case "*":
                    return num1 * num2;
                default:
                    return 0;
            }
        }
    }
}