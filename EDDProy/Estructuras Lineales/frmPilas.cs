using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using EDDemo.Clases;

namespace EDDemo
{
    public partial class frmPilas : Form
    {
        private Pilas miPila;
        public frmPilas()
        {
            InitializeComponent();
            miPila = new Pilas();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            if(int.TryParse(Valor.Text, out int valor))
            {
                miPila.Push(valor);
                MessageBox.Show("Se agrego el valor a la pila.");
                Valor.Clear(); // limpiamos el texbox despus de agregar el valor
            }
            else
            {
                MessageBox.Show("Ingrese un numero valido.");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            miPila.Mostrar(listPila); // se muestran los elementos de la pila 
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(int.TryParse(Valor.Text, out int valorBuscado))
            {
                if (miPila.Buscar(valorBuscado))
                {
                    MessageBox.Show("El valor si existe en la pila");
                }
                else
                {
                    MessageBox.Show("El valor no se encuentra en la pila.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un valor valido.");
            }
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            miPila = new Pilas();
            MessageBox.Show("La pila se encuentra vacia.");
            listPila.Items.Clear();
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            if (miPila != null)
            {
                int valor = miPila.Pop();
                MessageBox.Show($"El valor se a eliminado de la pila: {valor}");
                listPila.Items.Clear(); // se limpia el listbox y se muestra la pila actualizada
                miPila.Mostrar(listPila);
            }
            else
            {
                MessageBox.Show("La pila se encientra vacia.");
            }
        }
    }
}
