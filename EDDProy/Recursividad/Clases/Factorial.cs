using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Recursividad.Clases
{
    internal class Factorial
    {
        private long FactorialNumero(int n, ref int operaciones)
        {
            operaciones++;
            if (n <= 1)
            {
                return 1;
            }
            return n * FactorialNumero(n - 1, ref operaciones);
        }
        public NodoResultado FactorialE(int n)
        {
            int operaciones = 0;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            long resultado = FactorialNumero(n, ref operaciones);
            stopwatch.Stop();
            double tiempo = stopwatch.Elapsed.TotalMilliseconds;
            return new NodoResultado(resultado, operaciones, tiempo);
        }
    }
}
