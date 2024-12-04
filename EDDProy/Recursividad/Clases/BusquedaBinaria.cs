using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Recursividad.Clases
{
    internal class BusquedaBinaria
    {
        public static int Busqueda(int[] arreglo, int valor, int izquierda, int derecha, ref int operaciones)
        {
            operaciones++;
            if (izquierda > derecha)
            {
                return -1;
            }
            int medio = izquierda + (derecha - izquierda) / 2;
            if (arreglo[medio] == valor) //verificar que el valor este a la mitad
            {
                return medio;
            }
            if (valor < arreglo[medio])
            {
                return Busqueda(arreglo, valor, izquierda, medio - 1, ref operaciones);
            }
            return Busqueda(arreglo, valor, medio + 1, derecha, ref operaciones);
        }
    }
}
