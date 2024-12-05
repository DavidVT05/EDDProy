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

namespace EDDemo.Metodos_de_ordenamiento.Internos
{
    public partial class frmQuicksort : Form
    {
        private Quicksort quicksort = new Quicksort();
        public frmQuicksort()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string input = txtValor.Text; // obtener los valores del texBox
            string[] separar = input.Split(','); //Indicamos que se separen por coma los valores
            int[] arreglo = separar.Select(n => int.Parse(n.Trim())).ToArray(); //Se convierte a enteros el arreglo
            List<string> pasos = quicksort.ordenar(arreglo);
            listMovimiento.Items.Clear();
            for(int i = 0; i < pasos.Count; i++)
            {
                listMovimiento.Items.Add(pasos[i]); //se muestran los pasos
            }
        }
    }
}
