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
    public partial class frmBurbuja : Form
    {
        public frmBurbuja()
        {
            InitializeComponent();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            string input = txtValor.Text;// se toma el valor ingresado
            string[] datos = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries); // se realiza lla division de la cadena
            int[] arreglo = datos.Select(int.Parse).ToArray(); //Se convierte los datos string a enteros 
            Burbuja burbuja = new Burbuja(listOrdenar); //se crea una instancia de la clae burbuja y se agrega al listbox
            burbuja.OrdenarBurbuja(arreglo); // se manda llamar el metodo para ordenar el arreglo 
        }
    }
}
