using EDDemo.Estructuras_Lineales.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_Lineales
{
    public partial class frmCircularesDobles : Form
    {
        private CircularesDobles Cdobles = new CircularesDobles();
        public frmCircularesDobles()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtPosicion.Text, out int posicion) && int.TryParse(txtValor.Text, out int valor))
            {
                Cdobles.Agregar(posicion, valor);
            }
            else
            {
                MessageBox.Show("Ingrese un valor valido.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtPosicion.Text,out int posicion))
            {
                int valorEliminado = Cdobles.Eliminar(posicion);
                if(valorEliminado != 0)
                {
                    MessageBox.Show($"El valor {valorEliminado} se a eliminado correctamente.");
                    Cdobles.Mostrar(listDobles);
                }
            }
            else
            {
                MessageBox.Show("Ingresar una posicion valida.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtValor.Text, out int valor))
            {
                NodosActuales encontrado = Cdobles.Buscar(valor);
                if(encontrado != null)
                {
                    MessageBox.Show($"El valor {encontrado.Valor} si se encuenta en la lista");
                }
            }
            else
            {
                MessageBox.Show("Ingresar un valor para buscar.");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Cdobles.Mostrar(listDobles);
        }
    }
}
