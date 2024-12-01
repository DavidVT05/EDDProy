using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_Lineales.Clases
{
    internal class CircularesDobles
    {
        public NodosActuales Cabeza;
        public NodosActuales Fin;
        public CircularesDobles()
        {
            Cabeza = null;
            Fin = null;
        }
        public void Agregar(int posicion, int dato)
        {
            NodosActuales nuevo = new NodosActuales();
            nuevo.Valor = dato;
            nuevo.sig = nuevo;
            nuevo.ant = nuevo;
            if(Cabeza == null && Fin == null) // Comprobamos si la lista se encuentra vacia
            {
                Cabeza = nuevo;
                Fin = nuevo;
                return;
            }
            if(posicion == 0 || posicion == 1) //inidicamos que si la posicion es cero o uno se agrege el valor al inicio
            {
                nuevo.sig = Cabeza;
                Cabeza.ant = nuevo;
                Cabeza = nuevo;
                // se establece para que la lista permanesca siendo circular
                Fin.sig = Cabeza;
                Cabeza.ant = Fin;
                return;
            }
            //Para agregar en una posicion en medio de la lista
            int pos = 1;
            NodosActuales aux = Cabeza;
            while(pos < posicion && aux != null)
            {
                if(aux.sig != Cabeza)
                {
                    aux = aux.sig;
                }
                else
                {
                    aux = null;
                }
                pos++;
            }
            if(aux != null)
            {
                nuevo.sig = aux;
                nuevo.ant = aux.ant;
                aux.ant.sig = nuevo;
                aux.ant = nuevo;
            }
        }
        public int Eliminar(int posicion)
        {
            if(Cabeza == null && Fin == null)
            {
                MessageBox.Show("La lista se encuentra vacia.");
                return 0;
            }
            int pos = 1;
            NodosActuales aux = Cabeza;
            while(pos < posicion && aux != null) //Se busca el nodo en la posicion ingresada
            {
                if(aux.sig != Cabeza)
                {
                    aux = aux.sig;
                }
                else
                {
                    aux = null;
                }
                pos++;
            }
            if(aux != null) //Si se encuentra el nodo en la posicion que ingresamos
            {
                if(aux == Cabeza && aux == Fin) //si solo tenemos un unico valor en la lista
                {
                    Cabeza = null;
                    Fin = null;
                }
                else
                {
                    //Se actualiza la conexion con los nodos anterior y siguiente
                    aux.ant.sig = aux.sig;
                    aux.sig.ant = aux.ant;
                    if(aux == Cabeza) // Cuando el nodo a eliminar es el primero
                    {
                        Cabeza = aux.sig;
                    }
                    if(aux == Fin) //Cuando el nodo a eliminar es el ultimo 
                    {
                        Fin = aux.ant;
                    }
                }
                int datoEliminar = aux.Valor; // Se guarda el valor a eliminar
                aux = null; // se elimina el nodo para liberar memoria
                return datoEliminar; // se regresa el dato del nodo que se elimino
            }
            else
            {
                MessageBox.Show("El nodo a eliminar no se encontro.");
                return 0;
            }
        }
        public NodosActuales Buscar(int dato)
        {
            if(Cabeza == null && Fin == null)
            {
                MessageBox.Show("La lista se encuentra vacia.");
                return null;
            }
            NodosActuales aux = Cabeza;
            do
            {
                if (aux.Valor == dato)
                {
                    return aux;
                }
                aux = aux.sig;
            } while (aux != Cabeza); // Se realiza el recorrido de la lista y si no se encuentra el nodo se regresa el primer nodo
            MessageBox.Show("El valor indicado no se encontro en la lista.");
            return null;
        }
        public void Mostrar(ListBox listBox)
        {
            if(Cabeza == null && Fin == null)
            {
                MessageBox.Show("La lista se encuentra vacia.");
                return;
            }
            NodosActuales aux = Cabeza;
            listBox.Items.Clear(); // Se limpia el listbox antes de agregar los elementos ingresados
            do
            {
                listBox.Items.Add(aux.Valor);// se agregan los valores a la listBox
                aux = aux.sig; // se avanza al siguiente nodo
            } while (aux != Cabeza); // se realiza el recorrido de la lista circular
        }
    }
}
