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

        }
    }
}
