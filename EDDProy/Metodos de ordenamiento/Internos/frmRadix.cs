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
    public partial class frmRadix : Form
    {
        private Radix radix = new Radix();
        public frmRadix()
        {
            InitializeComponent();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                //se obtiene los valores ingresados y se convierten en una lista de enteros
                string input = txtValor.Text;
                string[] inputs = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                List<int> lista = new List<int>();
                for(int i = 0; i < inputs.Length; i++)
                {
                    lista.Add(int.Parse(inputs[i].Trim())); //se convierten los valores y se agregan a la lista
                }
                List<string> pasos = new List<string>(); //se almacenan los pasos
                listMovimientos.Items.Clear();
                listMovimientos.Items.Add("La lista oriignal:" + string.Join(",", lista));
                radix.OrdenarDigito(lista, 1, pasos); // se manda llamar al metodo para ordenar digitos
                for(int i = 0; i < pasos.Count; i++)
                {
                    listMovimientos.Items.Add("paso" + (i + 1) + ":" + pasos[i]);
                }
                listMovimientos.Items.Add("La lista ordenada:" + string.Join(",", lista));
                
            }
            catch(FormatException)
            {
                MessageBox.Show("Ingresar correctamente los valores.");
            }
        }
    }
}
