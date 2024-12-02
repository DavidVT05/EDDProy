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
        private int SumarArreglo(int[] arreglo, int indice, ref int operaciones)
        {
            operaciones++;
            if(indice == arreglo.Length) //Si el indice es igual a la longitud del arreglo
            {
                return 0;
            }
            return arreglo[indice] + SumarArreglo(arreglo, indice + 1, ref operaciones); //Se realiza la suma del elemento actual al resultado de la suma del arreglo
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Se lee la cantidad del arreglo
            if(int.TryParse(txtCantidad.Text, out int n) && n > 0)
            {
                int[] arreglo = new int[n];
                string[] elementos = txtValores.Text.Split(',');
                if(elementos.Length == n)
                {
                    //Se leen los elementos del arreglo desde el textbox
                    for(int i = 0; i < n; i++)
                    {
                        if (!int.TryParse(elementos[i].Trim(), out arreglo[i]))
                        {
                            MessageBox.Show("Ingrese numeros validos paa el arreglo.");
                            return;
                        }
                    }
                    //Realizamos la medicion del tiempo
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    int operaciones = 0;
                    int suma = SumarArreglo(arreglo, 0, ref operaciones);
                    stopwatch.Stop();
                    lblResultado.Text = $"{suma}";
                    lblOperaciones.Text = $"{operaciones}";
                    lblTiempo.Text = $"{stopwatch.Elapsed.TotalMilliseconds} ms";
                }
                else
                {
                    MessageBox.Show($"Se deben ingresar {n} elementos al arreglo. ");
                }
            }
            else
            {
                MessageBox.Show("Ingresar un numero valido.");
            }
        }
    }
}
