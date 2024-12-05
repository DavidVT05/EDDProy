using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Metodos_de_ordenamiento.Internos.Clases
{
    internal class Quicksort
    {
        public List<string> ordenar(int[] arreglo)
        {
            List<string> pasos = new List<string>();
            Empezar(arreglo, 0, arreglo.Length - 1, pasos);
            return pasos;

        }
        private void Empezar(int[] arreglo, int inicio, int fin, List<string> pasos)
        {
            if(inicio < fin)
            {
                int indiceP = Realizar(arreglo, inicio, fin, pasos);
                Empezar(arreglo, inicio, indiceP - 1, pasos);
                Empezar(arreglo, indiceP + 1, fin, pasos);
            }
        }
        private int Realizar(int[] arreglo, int inicio, int fin, List<string> pasos)
        {
            int aux = arreglo[fin];
            int menor = inicio - 1;
            for(int actual = inicio; actual < fin; actual++)
            {
                if (arreglo[actual] <= aux) // comparamos el indice actual es menor o igual a aux se intercambian
                {
                    menor++;
                    Intercambiar(arreglo, menor, actual);
                    Guardar(arreglo, pasos);
                }
            }
            Intercambiar(arreglo, menor + 1, fin); // se coloca el aux en su posicion final
            Guardar(arreglo, pasos);
            return menor + 1;
        }
        private void Intercambiar(int[] arreglo, int indi, int indic)
        {
            int temp = arreglo[indi];
            arreglo[indi] = arreglo[indic];
            arreglo[indic] = temp;
        }
        private void Guardar(int[] arreglo, List<string> pasos)
        {
            pasos.Add(string.Join(" - ", arreglo.Select(x => x.ToString())));
        }
    }
}
