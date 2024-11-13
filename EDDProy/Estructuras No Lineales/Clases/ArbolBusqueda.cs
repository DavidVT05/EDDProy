using System;
using System.Collections.Generic;
using System.Text;
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
        public String PreOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return " ";
            strRecorrido = strRecorrido + nodo.Dato + ", ";
            PreOrden(nodo.Izq);
            PreOrden(nodo.Der);
            return " ";
        }
        public String InOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return " ";

            InOrden(nodo.Izq);
            strRecorrido = strRecorrido + nodo.Dato + ", ";
            InOrden(nodo.Der);
            return " ";
        }
        public String PostOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return " ";

            PostOrden(nodo.Izq);
            PostOrden(nodo.Der);
            strRecorrido = strRecorrido + nodo.Dato + ", ";
            return " ";
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
        public void EliminarPredecesor(int Dato, ref NodoBinario nodo)
        {
            if (nodo == null)
                return;
            else if (Dato < nodo.Dato)
            {
                EliminarPredecesor(Dato,ref nodo.Izq);
            }
            else if(Dato > nodo.Dato)
            {
                EliminarPredecesor(Dato,ref nodo.Der);
            }
            else if(nodo.Izq != null && nodo.Der != null)
            {
                //  tiene dos hijos
                NodoBinario nodoMayor= BuscarMayor(nodo.Izq);
                nodo.Dato = nodoMayor.Dato;
                EliminarPredecesor(nodoMayor.Dato, ref nodo.Izq);
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
        public void EliminarSucesor(int dato, ref  NodoBinario nodo)
        {
            if (nodo == null)
                return;
            else if (dato < nodo.Dato)
                EliminarSucesor(dato, ref  nodo.Izq);
            else if (dato > nodo.Dato)
                EliminarSucesor(dato, ref nodo.Der);
            else if(nodo.Izq  != null && nodo.Der != null)
            {
                //tiene dos hijos
                NodoBinario nodoMenor = BuscarMenor(nodo.Der);
                nodo.Dato = nodoMenor.Dato;
                EliminarPredecesor(nodoMenor.Dato, ref nodo.Der);
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
        public String RecorrerPorNiveles(NodoBinario nodo)
        {
            strRecorrido = " ";
            if(nodo == null)
            {
                MessageBox.Show("El arbol se encuentra vacio.");
                return " ";
            }
            List<NodoBinario> AuxCola = new List<NodoBinario>();
            AuxCola.Add(Raiz);
            while (AuxCola.Count > 0)
            {
                NodoBinario nodoActual = AuxCola[0];
                AuxCola.RemoveAt(0);
                strRecorrido += nodoActual.Dato + " ";
                if(nodoActual.Izq != null)
                {
                    AuxCola.Add(nodoActual.Izq);
                }
                if(nodoActual.Der != null)
                {
                    AuxCola.Add(nodoActual.Der);
                }
            }
             return strRecorrido;
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
            List<NodoBinario> AuxCola = new List<NodoBinario>();
            AuxCola.Add(nodo);
            int index = 0;

            bool NoLLeno = false;
            while(index < AuxCola.Count)
            {
                NodoBinario nodoActual = AuxCola[index];
                index++;
                if(nodoActual.Izq != null)
                {
                    if (NoLLeno)
                        return false;
                    AuxCola.Add(nodoActual.Izq);
                }
                else
                {
                    NoLLeno = true;
                }
                if(nodoActual.Der != null)
                {
                    if (NoLLeno)
                        return false;
                    AuxCola.Add(nodoActual.Der);
                }
                else
                {
                    NoLLeno = true;
                }
            }
            return true;
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
