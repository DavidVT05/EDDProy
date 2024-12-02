using EDDemo.Estructuras_Lineales.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Recursividad
{
    public partial class frmCalculoExponente : Form
    {
        public frmCalculoExponente()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valor;
            int exponente;
            if(!double.TryParse(txtValor.Text, out valor))
            {
                MessageBox.Show("Ingresar un valor entero.");
                return;
            }
            if(!int.TryParse(txtExponente.Text, out exponente))
            {
                MessageBox.Show("Ingrese un valor entero para el exponente.");
                return;
            }
            if(valor == 0 && exponente < 0) // verificar que la base no sea cero y el exponente negativo
            {
                MessageBox.Show("No se puede calcular la potencia con base 0 y exponente negativo.");
                return;
            }
            Stopwatch stopwatch = new Stopwatch(); // se mide el tiempo 
            stopwatch.Start();
            int operaciones = 0;
            double resultado = Potencia(valor, exponente, ref operaciones);
            stopwatch.Stop();
            lblResultado.Text = $"{resultado} ";
            lblOperaciones.Text = $"{operaciones} ";
            lblTiempo.Text = $"{stopwatch.Elapsed.TotalMilliseconds} ms";
        }
        private double Potencia(double valor, int exponente, ref int operacion)
        {
            operacion++;
            if(exponente < 0) // si el exponente es negativo
            {
                return 1 / Potencia(valor, -exponente, ref operacion);
            }
            if(exponente == 0)
            {
                return 1; // cuando un numero tiene de exponente cero su resultado es uno
            }
            if(exponente % 2 == 0) // cuand oel exponente es par
            {
                double elevado = Potencia(valor, exponente / 2, ref operacion);
                    return elevado * elevado;
            }
            else // si el exponente es impar
            {
                return valor * Potencia(valor, exponente - 1, ref operacion);
            }
        }
    }
}
