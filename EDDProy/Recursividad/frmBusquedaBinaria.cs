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
    public partial class frmBusquedaBinaria : Form
    {
        public frmBusquedaBinaria()
        {
            InitializeComponent();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // se obtiene los datos que ingresamos
            string[] arreglod = txtValor.Text.Split(',');
            int[] arreglo = Array.ConvertAll(arreglod, int.Parse);
            for(int i = 1; i < arreglo.Length; i++) // se revisa si el arreglo esta ordenado
            {
                if (arreglo[i] < arreglo[i - 1])
                {
                    MessageBox.Show("El arreglo que se ingreso no esta ordenado.");
                    return;
                }
            }
            int valorB;
            if(!int.TryParse(txtBuscar.Text, out valorB))
            {
                MessageBox.Show("Ingresar un valor que se encuentre en el arreglo.");
                return;
            }
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int operaciones = 0;
            int resultado = Busqueda(arreglo, valorB, 0, arreglo.Length - 1, ref operaciones);
            stopwatch.Stop();
            if(resultado != 1)
            {
                lblResultado.Text = $"{resultado}";
            }
            else
            {
                MessageBox.Show("El valor no se encontro en el arreglo.");
            }
            lblOperaciones.Text = $"{operaciones}";
            lblTiempo.Text = $"{stopwatch.Elapsed.TotalMilliseconds} ms";
        }
        static int Busqueda(int[] arreglo, int valor, int izquierda, int derecha, ref int operaciones)
        {
            operaciones++;
            if(izquierda > derecha)
            {
                return -1;
            }
            int medio = izquierda + (derecha - izquierda) / 2;
            if (arreglo[medio] == valor) //verificar que el valor este a la mitad
            {
                return medio;
            }
            if(valor < arreglo[medio])
            {
                return Busqueda(arreglo, valor, izquierda, medio - 1, ref operaciones);
            }
            return Busqueda(arreglo, valor, medio + 1, derecha, ref operaciones);
        }
    }
}
