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
                Factorial factorial = new Factorial();
                var resultado = factorial.FactorialE(n);
                lblResultado.Text = $"{resultado.Resultado}";
                lblOperaciones.Text = $"{resultado.Operaciones}";
                lblTiempo.Text = $"{resultado.Tiempo} ms";  
            }
            else
            {
                MessageBox.Show("Ingresar un valor entero positivo.");
            }
        }
    }
}
