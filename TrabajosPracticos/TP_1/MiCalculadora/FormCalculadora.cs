using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Realiza la operacion deseada
        /// </summary>
        /// <param name="numero1">valor del numero 1</param>
        /// <param name="numero2">valor del numero 2</param>
        /// <param name="operador">valor del operando</param>
        /// <returns>Devuelve el resultado de la opercion deseada</returns>

        private static double Operar(string n1, string n2, string operador)
        {
            return Calculadora.Operar(new Numero(n1), new Numero(n2), operador);
        }

        /// <summary>
        /// Muesta el resultado de la operacion en el lblResultado.text 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text).ToString();
        }

        /// <summary>
        /// cierra el programa al hacer click en el boton cerrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// limpia los valores de todos los operandos 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNumero1.Text = string.Empty;
            this.txtNumero2.Text = string.Empty;
            this.lblResultado.Text = string.Empty;
            this.cmbOperador.Text = string.Empty;
        }

        /// <summary>
        /// convierte en binario el valor del lblResultado.text o entrega un 
        /// mensaje de error si el valor es invalido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = Numero.DecimalBinario(lblResultado.Text).ToString();
        }

        /// <summary>
        /// convierte en binario el valor del lblResultado.text o entrega un 
        /// mensaje de error si el valor es invalido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void btnConvertirABinario_Click_1(object sender, EventArgs e)
        {
            this.lblResultado.Text = Numero.DecimalBinario(lblResultado.Text).ToString();
        }

        /// <summary>
        /// convierte en decimal el valor del lblResultado.text o entrega un 
        /// mensaje de error si el valor es invalido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></pa
        private void btnConvertirADecimal_Click_1(object sender, EventArgs e)
        {
            this.lblResultado.Text = Numero.BinarioDecimal(lblResultado.Text).ToString();

        }
    }
}
