using EDDemo.Estructuras_Lineales.Clases;
using EDDemo.Recursividad.Clases;
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
            CalcularExponente exponentes = new CalcularExponente();
            int Operaciones = 0;
            double resultado = exponentes.Mediciones(valor, exponente, ref Operaciones);
            lblResultado.Text = $"{resultado} ";
            lblOperaciones.Text = $"{Operaciones} ";
            lblTiempo.Text = $"{exponentes.Tiempo} ms";
        }
    }
}
