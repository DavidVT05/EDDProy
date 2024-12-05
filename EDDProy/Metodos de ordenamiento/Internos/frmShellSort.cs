using EDDemo.Metodos_de_ordenamiento.Internos.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace EDDemo.Metodos_de_ordenamiento.Internos
{
    public partial class frmShellSort : Form
    {
        private ShellSort shellSort = new ShellSort();
        public frmShellSort()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string inicio = txtValor.Text; //se obtienen los valores ingresados
            List<int> lista; //se intenta convertir los numeros a una lista de enteros
            try
            {
                lista = inicio.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();
            }
            catch
            {
                MessageBox.Show("Ingresar los valores separados por una coma o espacio.");
                return;
            }
            //se manda llamar a la clase  shellsort
            List<string> pasos = new List<string>(); // se almacena la secuencia de pasos
            shellSort.Ordenar(lista, pasos);
            listMovimientos.Items.Clear();
            for(int i = 0; i < pasos.Count; i++)
            {
                listMovimientos.Items.Add(pasos[i]); // se muestran los pasos
            }
            listMovimientos.Items.Add(" " + string.Join(",", lista)); // se muestra la lista ordenada
        }
    }
}
