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
    public partial class frmListas : Form
    {
        private Listas simples;
        public frmListas()
        {
            InitializeComponent();
            simples = new Listas();
        }

        private void btnAgregarI_Click(object sender, EventArgs e)
        {
            int dato = 0;
            if(!int.TryParse(txtValor.Text, out dato)) // se veriifica siel dato obtenido es valido o no
            {
                MessageBox.Show("Ingrese un valor valido.");
                return;
            }
            int posicion = 0; // Establecemos una posicion por defecto
            if(txtPosicion.Text != " ") // se verifica si se ingreso una posicion 
            {
                if(!int.TryParse(txtPosicion.Text, out posicion) || posicion < 0)
                {
                    MessageBox.Show("Ingresar una posicion valida.");
                    return;
                }
            }
            simples.Agregar(posicion, dato); // se manda llamar al metodo agregar
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int posicion = int.Parse(txtPosicion.Text); //Se obtiene la posicion 
            int datoEliminar = simples.Eliminar(posicion); // se manda llamar al metodo eliminar
            if(datoEliminar != -1)
            {
                MessageBox.Show("Se elimino el dato indicado.");
            }
            simples.Mostrar(listLista);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            simples.Mostrar(listLista); // mostramos la lista creada
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int dato = int.Parse(txtValor.Text); // se obtiene el dato que buscamos
            NodoSimple nodo = simples.Buscar(dato); // se madna llama el metodo buscar
            if(nodo != null)
            {
                MessageBox.Show("Si se encontro el dato buscado:" + nodo.Dato);
            }
            else
            {
                MessageBox.Show("No se encontro el valor ingresado.");
            }
        }
    }
}
