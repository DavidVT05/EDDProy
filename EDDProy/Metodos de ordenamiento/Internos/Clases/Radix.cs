using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Metodos_de_ordenamiento.Internos.Clases
{
    internal class Radix
    {
        public void OrdenarDigito(List<int> lista, int exp, List<string> pasos)
        {
            int[] contar = new int[10]; //se crea el arreglo para contar las ocurrencias de cada digito
            List<int> salida = new List<int>(new int[lista.Count]);
            for(int i = 0; i < lista.Count; i++) // 1 contar las ocurrencias del digito actual
            {
                int num = lista[i]; 
                int dato = (num / exp) % 10;
                contar[dato]++;
            }
            for(int i =1; i < contar.Length; i++) //2 ir acumulando las posiciones
            {
                contar[i] += contar[i - 1];
            }
            for(int i = lista.Count - 1; i >= 0; i--) //3 colocar los numeros en la salida ordenada
            {
                int num = lista[i];
                int dato = (num / exp) % 10;
                salida[contar[dato] - 1] = num;
                contar[dato]--;
            }
            for(int i = 0; i < lista.Count; i++) //4 copiar la salida a la lista original
            {
                lista[i] = salida[i];
            }
            pasos.Add(string.Join("-", lista)); // se guarda el registro de pasos
        }
    }
}
