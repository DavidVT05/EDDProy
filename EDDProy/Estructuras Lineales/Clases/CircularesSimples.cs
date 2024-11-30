using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_Lineales.Clases
{
    internal class CircularesSimples
    {
        private NodosActuales Cabeza = null;
        private NodosActuales Fin = null;
        public void Agregar(int posicion, int dato)
        {
            NodosActuales nuevo = new NodosActuales();
            nuevo.Valor = dato;
            nuevo.sig = null;
            if (Cabeza == null && Fin == null) // verificamos si la lista esta vacia 
            {
                Cabeza = nuevo;
                Fin = nuevo;
                nuevo.sig = Cabeza; // se realiza que el ultimo nodo apunte al primero
                return;
            }
            if (posicion == 0 || posicion == 1) // se indica que la posicion 1 y 0 sea la misma dando por entendido que es el inicio 
            {
                nuevo.sig = Cabeza;
                Cabeza = nuevo;
                Fin.sig = Cabeza; // se vuelve a indicar que siga siendo circular
                return;
            }
            // por si la posicion donde se quiere agregar el valor es mayor a 1
            int pos = 1;
            NodosActuales aux = Cabeza;
            NodosActuales ant = null;
            while (pos < posicion && aux != null) // se realiza el recorrido de la lista hasta que encontremos la posicion deseada 
            {
                if(aux.sig == Cabeza) //  por si llegamos al final de la lista
                {
                    aux = null;
                }
                else
                {
                    ant = aux;
                    aux = aux.sig;
                    pos++;
                }
            }
            if(aux != null) //cuando encontramos la posicion realizamos lo siguiente
            {
                nuevo.sig = aux;
                ant.sig = nuevo;
            }
        }
        public void Eliminar(int posicion)
        {
            if (Cabeza == null)
                return;
            if (posicion == 0)
            {

                if (Cabeza.sig == Cabeza) //comprobamos si solo hay un nodo
                {
                    Cabeza = null;
                }
                else
                {
                    NodosActuales actual = Cabeza;
                    while (actual.sig != Cabeza) // Ubicamos el ultimo nodo
                    {
                        actual = actual.sig;
                    }
                    actual.sig = Cabeza.sig; //saltamos el nodo asignado como cabeza
                    Cabeza = Cabeza.sig; //actualizamos la cabeza
                }
                return;
            }
            NodosActuales ant = Cabeza;
            NodosActuales actNodo = Cabeza.sig;
            for (int i = 1; i < posicion; i++)
            {
                if (actNodo == Cabeza) return; // es para saber si la posicion esta fuera de rango
                ant = actNodo;
                actNodo = actNodo.sig;
            }
            if (actNodo == Cabeza) return; // volvemos a ver si la posicion esta fuera de rango
            ant.sig = actNodo.sig; // eliminamos el nodo
        }
        public NodosActuales Buscar(int dato)
        {
            if(Cabeza == null) //verificamos si la lista se encuentra vacia
            {
                return null;
            }
            NodosActuales actual = Cabeza;
            do
            {
                if (actual.Valor == dato) // si se encuentra el valor en el nodo actual 
                {
                    return actual;
                }
                actual = actual.sig; //se indica que nos movemos al siguiente nodo
            } while (actual != Cabeza); // sebuca hasta encontrar el nodo solicitado

            MessageBox.Show("El valor buscado no se encuentra en la lista");
            return null;
        }
        public void Mostrar(ListBox listBox)
        {
            listBox.Items.Clear(); //Se limpia el listBox antes de agregar los valores
            if(Cabeza == null) // miramos si la lista esta vacia
            {
                return; 
            }
            NodosActuales actual = Cabeza;
            do
            {
                listBox.Items.Add(actual.Valor); //se agrega el valor a la listBox
                actual = actual.sig; // se avanza al siguiente nodo
            } while (actual != Cabeza);  // se realiza para llegar de nuevo a la cabeza
        }
    }
}
