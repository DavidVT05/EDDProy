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
    public partial class frmSecuenciaFibonacci : Form
    {
        public frmSecuenciaFibonacci()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int n;
            if(!int.TryParse(txtValor.Text, out n) || n < 0)
            {
                MessageBox.Show("Ingresar un numero positivo.");
                return;
            }
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int operaciones = 0;
            long resultado = Fibonacci(n, ref operaciones);
            stopwatch.Stop();
            lblResultado.Text = $"{resultado}";
            lblOperaciones.Text = $"{operaciones}";
            lblTiempo.Text = $"{stopwatch.Elapsed.TotalMilliseconds} ms";
        }
        private long Fibonacci(int n, ref int operaciones)
        {
            operaciones++;
            if(n < 1)
            {
                return n;
            }
            long a = 0;
            long b = 1;
            for(int i = 2; i <= n; i++)
            {
                long temp = a + b;
                a = b;
                b = temp;
                operaciones++;
            }
            return b;
        }
    }
}
