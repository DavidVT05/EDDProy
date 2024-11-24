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
            
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            if(int.TryParse(btnPush.Text, out int valor))
            {
                miPila.Push(valor);
                MessageBox.Show("Se agrego el valor a la pila.");
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
            if(int.TryParse(btnBuscar.Text, out int valorBuscado))
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

        private void button1_Click(object sender, EventArgs e)
        {
            if(miPila != null)
            {
                int 
            }
        }
    }
}
