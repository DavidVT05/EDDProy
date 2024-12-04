using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Recursividad.Clases
{
    internal class TorreHanoi
    {
        public int operaciones { get; set; }
        public TorreHanoi()
        {
            operaciones = 0;
        }
        public void Hanoi(int n, char inicio, char aux, char final, ListBox listBox)
        {
            if(n == 1) //comprobamos si solo hay un disco se recorre de manera directa 
            {
                listBox.Items.Add($"Se rocorre de {inicio} a {final}");
                operaciones++; //se realiza el conteo de las operaciones realizadas
            }
            else
            {
                Hanoi(n - 1, inicio, final, aux, listBox); //Se comienza moviendo a la torre auxiliar
                listBox.Items.Add($"Se recorre el disco {n} de {inicio} a {final}"); //se realiza el moviemeinto del disco n asta el final 
                operaciones++;
                Hanoi(n - 1, aux, inicio, final, listBox); //se realiza el movimiento de los discos que estan en auxiliar a el final
            }
        }
        public double Tiempo(int n, ListBox listBox)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            operaciones = 0;
            Hanoi(n, 'A', 'B', 'C', listBox); // se realiza la resolucion de la tore de hanoi
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalMilliseconds;
        }
        public bool Resolver(string valor, ListBox listBox, Label lbltiempo, Label lblOperaciones)
        {
            try
            {
                int n;
                if(!int.TryParse(valor, out n) || n <= 0)
                {
                    MessageBox.Show("Ingresar un valor entero que no sea negativo.");
                    return false;
                }
                double tiempo = Tiempo(n, listBox); //se mide el tiempo y se procede a resolver la torre
                lbltiempo.Text = $"{tiempo} ms";
                lblOperaciones.Text = $"{operaciones}";
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return false;
            }
        }
    }
}
