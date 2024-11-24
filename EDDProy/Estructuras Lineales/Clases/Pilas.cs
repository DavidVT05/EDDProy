using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo
{
    public class Pilas
    {
        private Nodo tope;
        public Nodo topNodo()
        {
            return tope;
        }
        public void Push(int valor) //metodo para agregar un nodo a la pila
        {
            if(tope != null)
            {
                Eliminar(tope); // Eliminamos el nodo anterior, si existe
            }
            tope = new  Nodo { Valor = valor, sig = tope}; // creamos un nuevo nodo y lo asignamos como tope
        }
        public int Pop()
        {
            if(tope == null)
            {
                throw new ApplicationException("La pila esta vacia");
            }
            int valor = tope.Valor;
            tope = tope.sig; // elimina el valor para liberar memoria
            return valor;
        }
        public int Tope()
        {
            if(tope == null)
            {
                throw new ApplicationException("La pila esta vacia.");
            }
            return tope.Valor;
        }
        public bool Vacia(Nodo nodo)
        {
            nodo = null;
            return tope == null; // se regresa nulo si la pila esta vacia
        }
        public void Mostrar(ListBox listBox)
        {
            listBox.Items.Clear(); // limpiar el listbox antes de mostrar
            Nodo actual = tope;
            while(actual != null)
            {
                listBox.Items.Add(actual.Valor); // se agrega el valor a la listbox
                actual = actual.sig;
            }
        }
        public bool Buscar(int valor)
        {
            Nodo actual = tope;
            while (actual != null)
            {
                if (actual.Valor == valor)
                    return true;  // el nodo se encontro
                actual = actual.sig;
            }
            return false; // no se encontro el nodo 
        }
    }
}
