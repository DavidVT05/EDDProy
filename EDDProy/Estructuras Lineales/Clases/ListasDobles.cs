using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_Lineales.Clases
{
    internal class ListasDobles
    {
        public NodosActuales Cabeza;
        public NodosActuales Fin;
        public ListasDobles()
        {
            Cabeza = null; // Apunta al primer nodo de la lista
            Fin = null; // Apunta al ultimo nodo de la lista
        }
        public void Insertar(int posicion, int dato)
        {
            NodosActuales nuevo = new NodosActuales();
            nuevo.Valor = dato;
            nuevo.sig = null;
            nuevo.ant = null;
            if(Cabeza == null && Fin == null)   // cuando la lista se encuentra vacia 
            {
                Cabeza = nuevo;
                Fin = nuevo;
                return;
            }
            if(posicion == 0 || posicion == 1) //cuando el valor a ingresar se quiere en el inicio
            {
                nuevo.sig = Cabeza;
                if (Cabeza != null)
                {
                    Cabeza.ant = nuevo;
                }
                Cabeza = nuevo;
                return;
            }
            int pos = 1; // Se recorre la lista para buscar la popsicion que se desea
            NodosActuales aux = Cabeza;
            while (pos < posicion && aux != null)
            {
                aux = aux.sig;
                pos++;
            }
            if(aux != null) // pos si se quiere insertar un valor en medio de la lista
            {
                nuevo.sig = aux;
                nuevo.ant = aux.ant;
                if(aux.ant != null)
                {
                    aux.ant.sig = nuevo;
                }
                aux.ant = nuevo;
            }
            else // si queremos que se inserte un valor al final de la lista
            {
                Fin.sig = nuevo;
                nuevo.ant = Fin;
                Fin = nuevo;
            }
        }
        public int Eliminar(int posicion)
        {
            if(Cabeza == null && Fin == null) // comprobamos si la lista se encuentra vacia
            {
                MessageBox.Show("La lista se encuentra vacia.");
                return -1; // Se indica que no se pudo eliminar ningun nodo
            }
            if(posicion < 1) // Se realiza una revision para saber si la posicion solicitada es valida.
            {
                MessageBox.Show("La poscion ingresada no es valida.");
                return -1;
            }
            int pos = 1;
            NodosActuales aux = Cabeza;
            while (pos < posicion && aux != null) // Se realiza un recorido para encontrar la posicion indicada
            {
                aux = aux.sig;
                pos++;
            }
            if(aux != null) // Cuando se encuentra el nodo en la posicion inidicada se realiza lo siguiente
            {
                if(aux == Cabeza) // cuando el nodo a eliminar es el primero
                {
                    Cabeza = aux.sig; // Se recorre el inicio al siguiente nodo
                    if(Cabeza != null) //Si la lista nos queda vacia
                    {
                        Cabeza.ant = null; //se actualiza el puntero 
                    }
                }
                else if(aux == Fin) // cuando el nodo al eliminar se encuentra al final
                {
                    Fin = aux.ant; // Se regresa un nodo para asignar que es el nuevo fin
                }
                else // cuando el nodo se encuentra en medio de la lista
                {
                    aux.ant.sig = aux.sig; // apuntamos el nodo anterior al nodo sigueinte
                    aux.sig.ant = aux.ant; // apuntamos el nodo siguiente al nodo anterior
                }
                int datoEliminado = aux.Valor; // Se guarda el dato del nodo que se quiere eliminar
                // se limpia el nodo 
                aux.sig = null;
                aux.ant = null;
                aux = null;
                return datoEliminado; //Se regresa el dato del nodo indicado a eliminar
            }
            else
            {
                MessageBox.Show("El nodo buscado no se encontro.");
                return 0; // si no se encuentra el nodo en la posicion inidicada
            }
        }
        public NodosActuales Buscar(int dato)
        {
            NodosActuales aux = Cabeza;
            while(aux != null)
            {
                if(aux.Valor == dato)
                {
                    return aux;
                }
                aux = aux.sig;
            }
            return null;
        }
        public void Mostrar(ListBox listBox)
        {
            NodosActuales aux = Cabeza;
            listBox.Items.Clear(); // limpiamos el listbox antes de mostrar los valores
            while (aux != null)
            {
                listBox.Items.Add(aux.Valor);
                aux = aux.sig;
            }
        }
    }
}
