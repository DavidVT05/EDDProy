using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Recursividad.Clases
{
    internal class CalcularExponente
    {
        public double Tiempo { get; set; } //se utiliza paramedir el tiempo que tarda la ejecucion del programa
        public int  Operaciones { get; set; } // se utiliza para caluclar el total de operaciones que realiza el programa
        public double Mediciones(double valor, int exponente, ref int operaciones)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            operaciones = 0; // se regresa el contador de operaciones 
            double resultado = Exponentes(valor, exponente, ref operaciones);
            stopwatch.Stop();
            Tiempo = stopwatch.Elapsed.TotalMilliseconds;
            return resultado;

        }
        private double Exponentes(double valor, int exponente, ref int operaciones)
        {
            operaciones++; // se utiliza para incrementar el numero de operaciones
            if(exponente < 0) //Comprobamos si el exponente es negativo
            {
                valor = 1 / valor; // Se invierte la base cuando el exponente es negativo
                exponente = -exponente; // se convierte en positivo el exponente
                return Exponentes(valor, exponente, ref operaciones);
            }
            
            if( exponente == 0) // comprobamos si el exponente es cero
            {
                return 1;
            }
            if(exponente % 2 == 0)
            {
                double elevado = Exponentes(valor, exponente / 2, ref operaciones);
                return elevado * elevado;
            }
            else // comprobamos si el exponente es impar
            {
                return valor * Exponentes(valor, exponente - 1, ref operaciones);
            }
        }
    }
}
