using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_Lineales.Clases
{
    internal class Colas
    {
        Nodo colas = null;
        public void Agregar(Nodo nodo)
        {
            if (colas == null)
            {
                colas = nodo; // si la cola esta vacia se agrega como primer nodo

            }
            else
            {
                Nodo aux = Ultimo(colas); // encontramos el ultimo nodo
                while(aux.sig != null)
                {
                    aux = aux.sig;
                }
                aux.sig = nodo; // se conectan el ultimo nodo con el nuevo nodo
            }
        }
        private Nodo Ultimo(Nodo nodo)
        {
            if (nodo.sig == null)
            {
                return nodo; // si el nodo siguiente es nulo, se encontro el utimo nodo 
            }
            else
            {
                return Ultimo(nodo.sig); // se utiliza la recursividad para avanzar al siguiente nodo
            }
        }
        public void Eliminar()
        {
            if(colas != null)
            {
                colas = colas.sig;
            }
            else
            {
                MessageBox.Show("La cola se encuentra vacia.");
            }
        }
        public Nodo Inicio
        {
            get
            {
                return colas;
            }
        }
        public bool Vacia()
        {
            return (colas == null);
        }
        public void Mostrar(ListBox listBox)
        {
            listBox.Items.Clear();
            Nodo temp = colas;
            while(temp != null)
            {
                listBox.Items.Add(temp.Dato);
                temp = temp.sig;   
            }
        }
        public bool Buscar(string valor)
        {
            Nodo temp = colas;
            while(temp != null)
            {
                if (temp.Dato == valor)
                {
                    return true; // el nodo si fue encontrado
                }
                temp = temp.sig;
            }
            return false; // el valor del nodo no se encontro 
        }
    }
}
