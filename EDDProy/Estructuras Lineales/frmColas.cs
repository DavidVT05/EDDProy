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
            if(int.TryParse(Valor.Text, out int valor))
            {
                if(Valor.Text != " ")
                {
                    Nodo nuevoNodo = new Nodo();
                    nuevoNodo.Dato = Valor.Text;
                    cola.Agregar(nuevoNodo);
                    MessageBox.Show("El valor se agrego a la cola.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un valor valido.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cola.Eliminar();
            cola.Mostrar(listCola);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            cola.Mostrar(listCola);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string valorBuscado = Valor.Text;
            if(valorBuscado != " ")
            {
                bool encontrado = cola.Buscar(valorBuscado);
                if (encontrado)
                {
                    MessageBox.Show($"El valor '{valorBuscado}' si se encuentra en la cola.");
                }
                else
                {
                    MessageBox.Show($"El valor '{valorBuscado}' no se encontro en la cola.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un valor valido.");
            }
        }
    }
}
