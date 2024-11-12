using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_No_Lineales.Clases
{
    internal class ColaAuxiliar
    {
        
            public NodoBinario dato;
            public ColaAuxiliar Sig;
            public ColaAuxiliar(NodoBinario nodo)
            {
                dato = nodo;
                Sig = null;
            }
        
    }
    public class Cola
    {
        private ColaAuxiliar frente;
        private ColaAuxiliar final;
        public Cola()
        {
            frente = null;
            final = null;
        }
        public bool Vacia()
        {
            return frente == null;
        }
        public void Push(NodoBinario nodo)
        {
            ColaAuxiliar nuevo = new ColaAuxiliar(nodo);
            if (Vacia())
            {
                frente = nuevo;
                final = nuevo;
            }
            else
            {
                final.Sig = nuevo;
                final = nuevo;
            }
        }
        public NodoBinario Pop()
        {
            if (Vacia())
            {
                throw new InvalidOperationException("La cola esta vacia.");
            }
            NodoBinario nodo = frente.dato;
            frente = frente.Sig;
            if (frente == null)
            {
                final = null;
            }
            return nodo;
        }
    }

}
