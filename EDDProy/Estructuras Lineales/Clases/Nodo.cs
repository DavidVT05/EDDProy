﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo
{
    public class Nodo
    {
        public String Dato;
        public Nodo sig;
        public int Valor { get; set; }
        public object Nombre { get; internal set; }
    }
}
