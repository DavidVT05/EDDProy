using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo
{
    class Listas
    {
        private NodoSimple Inicio;
        private NodoSimple Fin;
        public Listas()
        {
            Inicio = null;
            Fin = null;
        }
        public void Agregar(int posicion, int dato)
        {
            NodoSimple nuevo =new NodoSimple(dato);
            if(Inicio == null) // verificamos si la lista se encuentra vacia
            {
                Inicio = nuevo;
                Fin = nuevo;
                return;
            }
            if(posicion == 0) // para agregar al inicio de la lista
            {
                nuevo.sig = Inicio;
                Inicio = nuevo;
                return;
            }
            NodoSimple aux = Inicio;
            NodoSimple temp = null;
            int pos = 0;
            while(aux != null && pos < posicion) // se va ala posicion que deseamos
            {
                temp = aux;
                aux = aux.sig;
                pos++;
            }
            if(aux != null) // se realiza para agregar en una posicion intermedia o final
            {
                nuevo.sig = aux;
                temp.sig = nuevo;
            }
            else
            {
                Fin.sig = nuevo;
                Fin = nuevo;
            }
        }
        public int Eliminar(int posicion)
        {
            if (Inicio == null) //verificamos si la lista se encuentra vacia
            {
                MessageBox.Show("La lista se encuentra vacia.");
                return -1; //se indica que no se elimino nada
            }
            NodoSimple aux = Inicio;
            NodoSimple temp = null;
            int pos = 1;
            while(aux != null && pos < posicion) // buscamos la posicion de la lista
            {
                temp = aux;
                aux = aux.sig;
                pos++;
            }
            if(aux == null) // si no se encunetra el nodo 
            {
                MessageBox.Show("No se encontro el dato buscado.");
                return 0; 
            }
            if(aux == Inicio) // si el nodo a eliminar es el primero
            {
                Inicio = aux.sig;
                if(Inicio == null) // si solo existia un solo nodo en la lista
                {
                    Fin = null;
                }
            }
            else if(aux == Fin) // si el nodo que buscamos eliminar es el ultimo
            {
                Fin = temp;
                Fin.sig = null;
            }
            else // si el nodo esta en el medio 
            {
                temp.sig = aux.sig;
            }
            int dato = aux.Dato;
            aux = null; // se elimina el nodo 
            return dato;
        }
        public NodoSimple Buscar(int dato)
        {
            NodoSimple aux = Inicio;
            while(aux != null) 
            {
                if(aux.Dato == dato)
                {
                    return aux; //se devuelve el nodo buscado  si el dato se encuentra
                }
                aux = aux.sig;
            }
            return null;
        }
        public void Mostrar(ListBox listBox)
        {
            listBox.Items.Clear();
            NodoSimple aux = Inicio;
            if(aux == null)
            {
                listBox.Items.Add("La lista se encuentra vacia");
                return;
            }
            while(aux != null)
            {
                listBox.Items.Add(aux.Dato);
                aux = aux.sig;
            }
        }
    }
}
