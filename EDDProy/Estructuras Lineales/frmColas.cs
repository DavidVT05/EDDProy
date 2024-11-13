using EDDemo.Estructuras_Lineales.Clases;
using System;
using System.Windows.Forms;

namespace EDDemo.Estructuras_Lineales
{
    public partial class frmColas : Form
    {
        Colas cola = new Colas();
        public frmColas()
        {
            InitializeComponent();
        }

        private void btbAgregar_Click(object sender, EventArgs e)
        {
            if (Valor.Text.Length == 0)
            {
                MessageBox.Show("Se debe ingresar un valor valido.");
            }
            else
            {
                Nodo nuevoNodo = new Nodo();
                nuevoNodo.Dato = Valor.Text;
                cola.Agregar(nuevoNodo);
                lblCola.Text = " El nodo se agrego.";
                
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cola.Vacia())
            {
                MessageBox.Show("La cola esta vacia.");
            }
            else
            {
                cola.Eliminar();
            }
        }
    }
}
