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
            Fibonacci fibonacci = new Fibonacci(); // se manda llamar la funcion para calcular la secuencia
            int operaciones = 0; // se cuentan las operaciones realizadas
            double tiempo; //se utliza para obtener el tiempo que dura la ejhecucion del programa
            long resultado = fibonacci.SecFibonacci(n, ref operaciones, out tiempo);
            lblResultado.Text = $"{resultado}";
            lblOperaciones.Text = $"{operaciones}";
            lblTiempo.Text = $"{tiempo} ms";
        }
    }
}
