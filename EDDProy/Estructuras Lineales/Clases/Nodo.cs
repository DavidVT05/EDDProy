using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo
{
    public class Nodo
    {
        public string Dato;
        public Nodo sig {  get; set; }
        public int Valor { get; set; }
        public object Nombre { get; internal set; }
    }
    public class NodoSimple
    {
        public int Dato;
        public NodoSimple sig;
        public NodoSimple(int dato)
        {
            Dato = dato;
            sig = null;
        }
    }
    public class NodosActuales
    {
        public int Valor;
        public NodosActuales sig;
        public NodosActuales ant;

    }
}
