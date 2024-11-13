using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_Lineales.Clases
{
    internal class Colas
    {
        Nodo inicio;
        public void Agregar(Nodo nodo)
        {
            if (inicio == null)
            {
                inicio = nodo;

            }
            else
            {
                Nodo aux = Ultimo(inicio);
                aux.sig = nodo;
            }
        }
        private Nodo Ultimo(Nodo nodo)
        {
            if (nodo.sig == null)
            {
                return nodo;
            }
            else
            {
                return Ultimo(nodo.sig);
            }
        }
        public void Eliminar()
        {
            inicio = inicio.sig;

        }
        public Nodo Inicio
        {
            get
            {
                return inicio;
            }
        }
        public bool Vacia()
        {
            return (inicio == null);
        }

    }
}
