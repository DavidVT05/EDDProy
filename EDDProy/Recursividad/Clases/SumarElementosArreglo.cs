using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Recursividad.Clases
{
    internal class SumarElementosArreglo
    {
        public static int[] Arreglo(string capasidad, string valor, out int cantidad)
        {
            cantidad = 0;
            if(int.TryParse(capasidad, out cantidad) && cantidad > 0)
            {
                int[] arreglo = new int[cantidad];
                string[] elementos = valor.Split(',');
                if(elementos.Length == cantidad)
                {
                    for(int i = 0; i < cantidad; i++)
                    {
                        try
                        {
                            arreglo[i] = int.Parse(elementos[i].Trim());
                        }
                        catch (FormatException)
                        {
                            return null; //el numero ingresado no es entero
                        }
                    }
                    return arreglo;
                }
                else
                {
                    return null; // el arreglo no es del mismo tamaño
                }
            }
            else
            {
                return null; // la entrada de la cantidad del arreglo no es valida
            }
        }
        public static int Sumar(int[] arreglo, int indice, ref int operaciones)
        {
            operaciones++;
            if(indice == arreglo.Length) //comprobamos si el indice es igual al tamaño del arreglo
            {
                return 0;
            }
            int total = 0;
            for(int i = indice; i < arreglo.Length; i++)
            {
                total += arreglo[i];
                operaciones++;
            }
            return total;
        }
    }
}
