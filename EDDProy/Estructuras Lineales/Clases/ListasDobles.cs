using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_Lineales.Clases
{
    internal class ListasDobles
    {
        private NodosActuales cabeza;
        private NodosActuales cola;

        public void AgregarPrim(string valor)
        {
            NodosActuales nuevoNodo = new NodosActuales(valor);
            if (cabeza == null)
            {
                cabeza = nuevoNodo;
                cola = nuevoNodo;
            }
            else
            {
                nuevoNodo.sig = cabeza;
                cabeza.ant = nuevoNodo;
                cabeza = nuevoNodo;
            }
        }

        public void AgregarUl(string valor)
        {
            NodosActuales nuevoNodo = new NodosActuales(valor);
            if (cola == null)
            {
                cabeza = nuevoNodo;
                cola = nuevoNodo;
            }
            else
            {
                cola.sig = nuevoNodo;
                nuevoNodo.ant = cola;
                cola = nuevoNodo;
            }
        }
        public void AgregarPos(string valor, int posicion)
        {
            if (posicion <= 0)
            {
                AgregarPrim(valor);
                return;
            }
            NodosActuales nuevoNodo = new NodosActuales(valor);
            NodosActuales actual = cabeza;
            int contador = 0;
            while (actual != null && contador < posicion - 1)
            {
                actual = actual.sig;
                contador++;
            }
            if (actual == null)
            {
                AgregarUl(valor);
            }
            else
            {
                nuevoNodo.sig = actual.sig;
                nuevoNodo.ant = actual;
                actual.sig = nuevoNodo;
                if (nuevoNodo.sig != null)
                {
                    nuevoNodo.sig.ant = nuevoNodo;
                }
            }
        }
        public void Eliminar(int posicion)
        {
            if (cabeza == null || posicion < 0)
                return;
            NodosActuales actual = cabeza;
            if (posicion == 0)
            {
                cabeza = cabeza.sig;
                if (cabeza != null)
                {
                    cabeza.ant = null;
                }
                else
                {
                    cola = null;

                }
                return;
            }
            int contador = 0;
            while (actual != null && contador < posicion)
            {
                actual = actual.sig;
                contador++;
            }
            if (actual != null)
            {
                if (actual.ant != null)
                {
                    actual.ant.sig = actual.sig;
                }
                if (actual.sig != null)
                {
                    actual.sig.ant = actual.ant;
                }
                if (actual == cola)
                {
                    cola = actual.ant;
                }
            }
        }
        public string ObtenerValores()
        {
            NodosActuales actual = cabeza; // Comenzamos desde el nodo cabeza
            string resultado = ""; // Inicializamos una cadena vacía
            while (actual != null) // Recorremos la lista mientras haya nodos
            {
                resultado += actual.Valor; // Agregamos el valor del nodo actual
                actual = actual.sig; // Pasamos al siguiente nodo
                if (actual != null) // Añadimos una coma si no estamos al final de la lista
                {
                    resultado += ", ";
                }
            }
            return resultado; // Devolvemos la cadena de valores
        }
    }
}
