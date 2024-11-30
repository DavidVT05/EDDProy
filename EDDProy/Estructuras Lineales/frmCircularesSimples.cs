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
    public partial class frmCircularesSimples : Form
    {
        private CircularesSimples circulares = new CircularesSimples();
        public frmCircularesSimples()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int dato;
            int posicion;
            //Se realiza una verificacion para comprobar que la posiciony el dato sean validos
            if (int.TryParse(txtValor.Text, out dato) && int.TryParse(txtPosicion.Text, out posicion))
            {
                circulares.Agregar(posicion, dato);
            }
            else
            {
                MessageBox.Show("Ingresar un valor valido.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int posicion;
            if(int.TryParse(txtPosicion.Text, out posicion))
            {
                circulares.Eliminar(posicion);
                circulares.Mostrar(listCirculares); //Actualizamos el listbox despues de eliminar un valor
            }
            else
            {
                MessageBox.Show("Ingresar una posicion valida.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int dato;
            if (int.TryParse(txtValor.Text, out dato))
            {
                NodosActuales encontrado = new NodosActuales();
                encontrado = circulares.Buscar(dato);
                if(encontrado != null)
                {
                    MessageBox.Show("El valor si se encuentra en la lista.");
                }
                else
                {
                    MessageBox.Show("Ingrese un valor valido.");
                }
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            circulares.Mostrar(listCirculares);

        }
    }
}
