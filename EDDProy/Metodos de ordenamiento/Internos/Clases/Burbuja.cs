using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Metodos_de_ordenamiento.Internos.Clases
{
    internal class Burbuja
    {
        private ListBox listCamino;
        public Burbuja(ListBox listBox) // constructorpara realizar iniciar el listbox donde se mostraran los resultados
        {
            listCamino = listBox;
        }
        public void OrdenarBurbuja(int[] array) //metodo principal para ordenar el arreglo usando el algoritmo burbuja
        {
            int n = array.Length;
            bool ordenado;
            for(int i = 0; i < n - 1; i++)
            {
                ordenado = true; // si el arreglo ya esta ordenado
                if(OrdenarRecorido(array, i))
                {
                    ordenado = false; // por si se realizo un intercambio ya ordenado
                }
                if (ordenado)
                {
                    listCamino.Items.Add("El arreglo ya esta ordenado.");
                    break;
                }
                
            }
        }
        //Metodo que maneja una pasada del algoritmo burbuja
        private bool OrdenarRecorido(int[] array, int recorrido) 
        {
            bool intercambio = false;
            for(int j =0; j< array.Length - recorrido - 1; j++) //se realiza el recorido del arreglo para realizar lor intercambios necesarios
            {
                if (array[j] > array[j + 1])
                {
                    CambiarElementos(array, j);
                    intercambio = true;
                }
            }
            Mostrar(array, recorrido); //Se muestra el estad despues de la pasada
            return !intercambio; //Retornamos si se realiza o no se realiza un intercambio en esta pasada
        }
        private void CambiarElementos(int[] array, int indice) //se intercambian los elementos en las posiciones indicadas
        {
            int temp = array[indice];
            array[indice] = array[indice + 1];
            array[indice + 1] = temp;
            listCamino.Items.Add($"El cambio de {array[indice]} a {array[indice + 1]}");
        }
        private void Mostrar(int[] array, int recorido) //muestra el estado del arreglo despues de cada pasada
        {
            listCamino.Items.Add($"El arrglo se encuentra {recorido + 1}: {string.Join(",", array)}");
        }
    }
}
