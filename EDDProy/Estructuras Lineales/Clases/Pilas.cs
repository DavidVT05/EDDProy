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
            Nodo Nuevo = new Nodo();
            Nuevo.sig = null;
            if(tope != null)
            {
                Eliminar(tope); // Eliminamos el nodo anterior, si existe
            }
            tope =new  Nodo { Valor = valor}; // creamos un nuevo nodo y lo asignamos como tope
        }
        public int Pop()
        {
            if(tope == null)
            {
                throw new ApplicationException("La pila esta vacia");
            }
            int valor = tope.Valor;
            tope = tope.sig; // rlimina el valor para liberar memoria
            return valor;
        }
        public int Tope()
        {
            if(tope == null)
            {
                throw new ApplicationException("La pilka esta vacia.");
            }
            return tope.Valor;
        }
        public bool Vacia()
        {
            return tope == null; // se regresa nulo si la pila esta vacia
        }
        public void Eliminar(Nodo nodo)
        {
            nodo = null;
        }
    }
}
