using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Recursividad.Clases
{
    internal class Fibonacci
    {
        public long SecFibonacci(int n,ref int operaciones, out double tiempo)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            operaciones = 0;
            long resultado =    NodoFibonacci(n, ref operaciones);
            stopwatch.Stop();
            tiempo = stopwatch.Elapsed.TotalMilliseconds;
            return resultado;
        }
        private long NodoFibonacci(int n, ref int operaciones)
        {
            operaciones++;
            if (n < 1)
            {
                return n;
            }
            long a = 0;
            long b = 1;
            for (int i = 2; i <= n; i++) //Se realiza la secuenciua de fibonacci
            {
                long temp = a + b;
                a = b;
                b = temp;
                operaciones++;
            }
            return b;
        }
    }
}
