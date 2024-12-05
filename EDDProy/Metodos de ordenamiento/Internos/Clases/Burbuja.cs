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
            for(int i = 0; i < n - 1; i++)  //se realiza un  intercambio para cada elemento
            {
                ordenado = false; //inicializamos un intercambio como falso
                for (int j = 0; j < n - i - 1; j++) // se realiza el recorido del arreglo
                {
                    if (array[j] > array[j + 1])
                    {
                        CambiarElementos(array, j); //se realiza la comparacion para saber si el numero actual es mayor que el que le sigue y se intercambian
                        ordenado = true; //se realiza una marca para indiar que se realizo un intercambio
                    }
                }
                Mostrar(array, i); // se muestra el recorrido despues de el intercambio
                if (!ordenado) //Se realiza una comparacion para saber si se realizo un intercambio, si no el arreglo ya esta ordenado
                {
                    listCamino.Items.Add("El arreglo ya fue ordenado.");
                    break; //se indica una salida del ciclo 
                }
            }
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
