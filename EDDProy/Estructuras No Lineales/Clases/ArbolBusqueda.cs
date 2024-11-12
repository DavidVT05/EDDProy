using EDDemo.Estructuras_No_Lineales.Clases;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_No_Lineales
{
    public class ArbolBusqueda
    {
        NodoBinario Raiz;
        public String strArbol;
        public String strRecorrido; 

        public ArbolBusqueda()
        {
            Raiz = null;
            strArbol = "";
            strRecorrido = "";
        }
        public Boolean EstaVacio()
        {
            if (Raiz == null)
                return true;
            else
                return false;
        }
        public NodoBinario RegresaRaiz()
        {
            return Raiz;
        }

        public void InsertaNodo(int Dato, ref NodoBinario Nodo)
        {            
            if (Nodo == null)
            {
                Nodo = new NodoBinario(Dato);
                //Cambio 2

                if (Raiz == null)
                    Raiz = Nodo;
            }
            else if (Dato < Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Izq);
            else if (Dato > Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Der);          
        }
        public void MuestraArbolAcostado(int nivel, NodoBinario nodo )
        {
            if (nodo == null)
                return;
            MuestraArbolAcostado(nivel + 1, nodo.Der);
            for(int i=0; i<nivel; i++)
            {
                strArbol = strArbol + "     ";
            }
            strArbol = strArbol + nodo.Dato.ToString() + "\r\n";
            MuestraArbolAcostado(nivel + 1, nodo.Izq); 
        }
        public String ToDot(NodoBinario nodo)
        {
            StringBuilder b = new StringBuilder();
            if (nodo.Izq != null)
            {
                b.AppendFormat("{0}->{1} [side=L] {2} ", nodo.Dato.ToString(), nodo.Izq.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Izq));
            }

            if (nodo.Der != null)
            {
                b.AppendFormat("{0}->{1} [side=R] {2} ", nodo.Dato.ToString(), nodo.Der.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Der));
            }
            return b.ToString();
        }
        public void PreOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;
            strRecorrido = strRecorrido + nodo.Dato + ", ";
            PreOrden(nodo.Izq);
            PreOrden(nodo.Der);
            return;
        }
        public void InOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            InOrden(nodo.Izq);
            strRecorrido = strRecorrido + nodo.Dato + ", ";
            InOrden(nodo.Der);
            return;
        }
        public void PostOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            PostOrden(nodo.Izq);
            PostOrden(nodo.Der);
            strRecorrido = strRecorrido + nodo.Dato + ", ";
            return;
        }
        public Boolean BuscarNodo(int dato, NodoBinario nodo)
        {
            if (nodo == null)
                return false;

            if (nodo.Dato == dato)
                return true;

            if (dato < nodo.Dato)
                return BuscarNodo(dato, nodo.Izq);
            else
                return BuscarNodo(dato, nodo.Der);
        }
        public NodoBinario BuscarMenor(NodoBinario nodo)
        {
            if (nodo == null)
                return null;
            else if (nodo.Izq == null)
                return nodo;
            else
                return BuscarMenor(nodo.Izq);
        }
        public NodoBinario BuscarMayor(NodoBinario nodo)
        {
            if (nodo == null)
            {
                return null;
            }
            else if (nodo.Der == null)
                return nodo;
            else
                return BuscarMayor(nodo.Der);
        }
        public void EliminarPredecesor(int Dato, NodoBinario nodo)
        {
            if (nodo == null)
                return;
            else if (Dato < nodo.Dato)
            {
                EliminarPredecesor(Dato, nodo.Izq);
            }
            else if(Dato > nodo.Dato)
            {
                EliminarPredecesor(Dato, nodo.Der);
            }
            else if(nodo.Izq != null && nodo.Der != null)
            {
                //  tiene dos hijos
                NodoBinario nodoMayor= BuscarMayor(nodo.Izq);
                nodo.Dato = nodoMayor.Dato;
                EliminarPredecesor(nodoMayor.Dato, nodo.Izq);
            }
            else
            {
                //Tiene un solo hijo o ninguno 
                NodoBinario nodoTemporal = nodo;
                if (nodo.Izq == null)
                    nodo = nodo.Der;
                else if (nodo.Der == null)
                    nodo = nodo.Izq;
                //eliminar el nodo
                nodoTemporal = null;
            }
        } 
        public void EliminarSucesor(int dato, NodoBinario nodo)
        {
            if (nodo == null)
                return;
            else if (dato < nodo.Dato)
                EliminarSucesor(dato, nodo.Izq);
            else if (dato > nodo.Dato)
                EliminarSucesor(dato, nodo.Der);
            else if(nodo.Izq  != null && nodo.Der != null)
            {
                //tiene dos hijos
                NodoBinario nodoMenor = BuscarMenor(nodo.Der);
                nodo.Dato = nodoMenor.Dato;
                EliminarPredecesor(nodoMenor.Dato, nodo.Der);
            }
            else
            {
                //Tiene un solo hijo o ninguno 
                NodoBinario nodoTemporal = nodo;
                if (nodo.Izq == null)
                    nodo = nodo.Der;
                else if (nodo.Der == null)
                    nodo = nodo.Izq;
                //eliminar el nodo hoja 
                nodoTemporal = null;
            }
            
        }
        public void RecorrerPorNiveles(NodoBinario nodo)
        {
            if(nodo == null)
            {
                MessageBox.Show("El arbol se encuentra vacio.");
                return;
            }
            Cola auxCola = new Cola();
            auxCola.Push(nodo);
            while (!auxCola.Vacia())
            {
                NodoBinario nodoActual = auxCola.Pop();
                MessageBox.Show(nodoActual.Dato + " - ");
                if(nodoActual.Izq != null)
                {
                    auxCola.Push(nodoActual.Izq);
                }
                if(nodoActual.Der != null)
                {
                    auxCola.Push(nodoActual.Der);
                }
            }

        }
        public int ArbolAltura(NodoBinario nodo)
        {
            if (nodo == null)
                return 0;
            return (1 + Math.Max(ArbolAltura(nodo.Izq), ArbolAltura(nodo.Der)));
        }
        public int ContarHojas(NodoBinario nodo)
        {
            if (nodo == null)
                return 0;
            if (nodo.Der ==null && nodo.Izq == null)
                return 1;
            else
                return ContarHojas(nodo.Izq) + ContarHojas(nodo.Der);
        }
        public int ContarNodo(NodoBinario nodo)
        {
            if (nodo == null)
                return 0;
            return 1 + ContarNodo(nodo.Izq) + ContarNodo(nodo.Der);
        }
        public bool EsCompleto(NodoBinario nodo)
        {
            if (nodo == null)
                return true;
            int totalNodos = ContarNodo(nodo);
            return EsCompleto(nodo, 0, totalNodos);
        }

        public bool EsCompleto(NodoBinario nodo, int indice, int totalNodos)
        {

            if (nodo == null)
                return true; // un arbol vacio es completo
            if (indice >= totalNodos)
                return false;
            bool izqCompleto = EsCompleto(nodo.Izq, 2 * indice + 1, totalNodos);
            bool derCompleto = EsCompleto(nodo.Der, 2 * indice + 2, totalNodos);
            return izqCompleto && derCompleto;
        }
        public bool EsLleno(NodoBinario nodo)
        {
            if (nodo == null)
                return true;  // un nodo vacio es lleno
            // es una hoja
            if (nodo.Der == null && nodo.Izq == null)
                return true;
            // si tiene ambos hijos, se revisa que sus subnodos sean llenos
            if (nodo.Der != null && nodo.Izq != null)
                return (EsLleno(nodo.Izq) && EsLleno(nodo.Der));
            // en cualquier otro caso, no es lleno
            return false;
        }

    }
}
