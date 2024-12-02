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
using System.Numerics;
namespace EDDemo.Recursividad
{
    public partial class frmFactorial : Form
    {
        public frmFactorial()
        {
            InitializeComponent();
        }

        private void btnCalular_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtValor.Text, out int n) && n > 0) // Se convierte a entero los numeros ingresados, si no lo son
            {
                Stopwatch stopwatch = new Stopwatch(); //Se mide el tiempo de ejecucion 
                stopwatch.Start();
                int operaciones = 0;
                long resultados = FactorialNumero(n, ref operaciones);
                stopwatch.Stop();
                lblResultado.Text = " " + resultados;
                lblOperaciones.Text = " " + operaciones;
                lblTiempo.Text = $"{stopwatch.Elapsed.TotalMilliseconds} ms";  
            }
            else
            {
                MessageBox.Show("Ingresar un valor entero positivo.");
            }
        }
        private long FactorialNumero(int n, ref int operaciones)
        {
            operaciones++;
            if(n <= 1)
            {
                return 1;
            }
            return n * FactorialNumero(n - 1, ref operaciones);
        }
    }
}
