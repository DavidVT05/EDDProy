using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Metodos_de_busqueda.Clases
{
    internal class BusquedaBinariaas
    {
        public static string Busqueda(int[] arreglo, int num, int l, int n)
        {
            if( l > n)
            {
                return $"El valor {num} no esta en el arreglo.";
            }
            int b = (l + n) / 2;
            if (arreglo[b] == num)
            {
                return $"El elemento {num} esta en la posicion {b + 1}";
            }
            else if (arreglo[b] > num)
            {
                return Busqueda(arreglo, num, l, b - 1); //se realiza la llamada recursiva en el limite superior
            }
            else
            {
                return Busqueda(arreglo, num, b + 1, n); //se realiza la llamada recursiva en el limite inferior 
            }
        }
    }
}
