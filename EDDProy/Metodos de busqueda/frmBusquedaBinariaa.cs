using EDDemo.Metodos_de_busqueda.Clases;
using EDDemo.Recursividad.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Metodos_de_busqueda
{
    public partial class frmBusquedaBinariaa : Form
    {
        private int[] arreglo;
        private int index = 0; //indice para saber en que posicion agregar el valor
        public frmBusquedaBinariaa()
        {
            InitializeComponent();
            arreglo = new int[10];
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(index < arreglo.Length) //se verifica si ya se ingresaron todos los datos
            {
                int valor; //se intenta convertir elvalor ingresado en el texbox a un numero
                if(int.TryParse(txtValor.Text, out valor))
                {
                    arreglo[index] = valor; //se agrega el numero al arreglo
                    index++; //incrementamos el indice para el siguiente numero
                    txtValor.Clear(); //Se limpia el texbox para el siguiente numero
                    //Se muestra el numero ingresadoen el label
                    lblIndicador.Text = $"valor {valor} agregado. {index} de {arreglo.Length} valores cargados";
                    if(index == arreglo.Length) // si se ingresaron los elemetos se muestra un mensaje
                    {
                        MessageBox.Show("Se agregaron todos los elementos.", "informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    MessageBox.Show("Ingresar un numero valido.", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Se agregaron todos los elementos.", "informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int num;
            if(int.TryParse(txtBuscar.Text, out num))
            {
                if(index > 0)
                {
                    string resultado = BusquedaBinariaas.Busqueda(arreglo, num, 0, index - 1);
                    lblResultado.Text = resultado; //mostrar el resultado en un label
                }

            }
            else
            {
                MessageBox.Show("Ingresar un numero valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
