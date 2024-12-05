using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Metodos_de_ordenamiento.Internos.Clases
{
    internal class ShellSort
    {
        public List<int> Ordenar(List<int> lista, List<string> pasos)
        {
            int n = lista.Count;
            List<int> secuenciaInter = Secuencia(n); //se genera una secuencia de intervalos usando la formula de decremento 
            for(int i = 0; i < secuenciaInter.Count; i++)
            {
                int intervalos = secuenciaInter[i];
                Insercion(lista, intervalos, pasos);
            }
            return lista; //se devuelve la lista ordenada 
        }
        private List<int> Secuencia(int n)
        {
            List<int> secuencia = new List<int>();
            int camino = n / 2;
            while(camino > 0)
            {
                secuencia.Add(camino);
                camino /= 2; // se reduce el intervalo 
            }
            return secuencia;
        }
        private void Insercion(List<int> lista, int camino, List<string> pasos)
        {
            int n = lista.Count;
            for(int i = camino; i < n; i++)
            {
                int temp = lista[i];
                int j = i;
                while(j >= camino && lista[j - camino] > temp) //se realiza una insercion por medio de un intervalo
                {
                    lista[j] = lista[j - camino];
                    j -= camino;
                }
                lista[j] = temp;
            }
            pasos.Add(string.Join("-", lista)); // Se guarda los cambios que se realizan
        }
    }
}
