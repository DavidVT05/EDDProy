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
    public partial class frmTorreHanoi : Form
    {
        public frmTorreHanoi()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            listMovimientos.Items.Clear(); // se limpian el listbox
            lblOperaciones.Text = " ";
            lblTiempo.Text = " ";
            int n;
            if(!int.TryParse(txtValor.Text, out n) || n < 1)
            {
                MessageBox.Show("Se debe de ingresar un valor entero mayor a uno.");
                return;
            }
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int operaciones = 0;
            Hanoi(n, 'A', 'B', 'C', ref operaciones); // se manda llamar al metodo recursivo
            stopwatch.Stop();
            //Se muestra el numero de operaciones que se relizan y el tiempo que tarda
            lblOperaciones.Text = $"{operaciones}";
            lblTiempo.Text = $"{stopwatch.Elapsed.TotalMilliseconds} ms";
        }
        private void Hanoi(int n, char inicio, char final, char aux, ref int operaciones)
        {
            operaciones++;
            if(n == 1)
            {
                listMovimientos.Items.Add($"Se recorre el primer disco desde {inicio} a {final}");
                return;
            }
            Hanoi(n - 1, inicio, aux, final, ref operaciones); // se realizan los primeros movimientos
            listMovimientos.Items.Add($"Se recorre el disco {n} desde {inicio} a {final}"); // se realiza los movimientos que restan para llegar al final
            Hanoi(n - 1, aux, final, inicio, ref operaciones); // Se mueven los discos restantes alta el final
        }
    }
}
