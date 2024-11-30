using EDDemo.Estructuras_Lineales.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_Lineales
{
    public partial class frmListasDobles : Form
    {
        private ListasDobles dobles = new ListasDobles();

        public frmListasDobles()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int dato = int.Parse(txtValor.Text);
            NodosActuales encontrado = dobles.Buscar(dato);
            if(encontrado != null)
            {
                MessageBox.Show("El Nodo si se encuentra en la lista");
            }
            else
            {
                MessageBox.Show("El nodo no se encontro en la lista.");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int posicion = int.Parse(txtPosicion.Text); // Se obitenen la posicion ingresada
            int dato = int.Parse(txtValor.Text); // Se obtiene el valor ingresado
            dobles.Insertar(posicion, dato);
            MessageBox.Show("El nodo se ingreso correctamente.");
        }

        private void btmMostrar_Click(object sender, EventArgs e)
        {
            dobles.Mostrar(listDobles);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int posicion = int.Parse(txtPosicion.Text);
            int datoEliminado = dobles.Eliminar(posicion);
            if(datoEliminado != -1)
            {
                MessageBox.Show("El nodo ha sido eliminado");
            }
            dobles.Mostrar(listDobles);
        }
    }
}
