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
    public partial class frmSumaElementosArreglo : Form
    {
        public frmSumaElementosArreglo()
        {
            InitializeComponent();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int cantidad;
            //Se mandda llamar el metodo de la clase arreglo
            int[] arreglo = SumarElementosArreglo.Arreglo(txtCantidad.Text, txtValores.Text, out cantidad);
            if(arreglo != null) // cuando el arreglo es diferente de nulo
            {
                Stopwatch stopwatch = new Stopwatch(); //Se empieza a medir el tiempo
                stopwatch.Start();
                int operaciones = 0;
                int suma = SumarElementosArreglo.Sumar(arreglo, 0, ref operaciones);
                stopwatch.Stop();
                lblResultado.Text = $"{suma}";
                lblOperaciones.Text = $"{operaciones}";
                lblTiempo.Text = $"{stopwatch.Elapsed.TotalMilliseconds} ms";
            }
        }
    }
}
