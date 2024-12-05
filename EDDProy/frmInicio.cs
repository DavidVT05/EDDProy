using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Estructuras_Lineales;
using EDDemo.Estructuras_No_Lineales;
using EDDemo.Metodos_de_busqueda;
using EDDemo.Metodos_de_ordenamiento.Externos;
using EDDemo.Metodos_de_ordenamiento.Internos;
using EDDemo.Recursividad;

namespace EDDemo
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPilas mPilas = new frmPilas();
            mPilas.MdiParent = this;
            mPilas.Show();
        }

        private void estructurasLinealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arbolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArboles mArboles = new frmArboles();
            mArboles.MdiParent = this;
            mArboles.Show();
        }

        private void colasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColas mColas = new frmColas();
            mColas.MdiParent = this;
            mColas.Show();
        }

        private void simplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListas frmListas = new frmListas();
            frmListas.MdiParent = this;
            frmListas.Show();
        }

        private void doblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListasDobles frmDobles = new frmListasDobles();
            frmDobles.MdiParent = this;
            frmDobles.Show();
        }

        private void circularesSimplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCircularesSimples frmCirculares = new frmCircularesSimples();
            frmCirculares.MdiParent = this;
            frmCirculares.Show();
        }

        private void circularesDoblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCircularesDobles frmDobles = new frmCircularesDobles();
            frmDobles.MdiParent = this;
            frmDobles.Show();
        }

        private void factorialDeUnNumeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFactorial Factorial = new frmFactorial();
            Factorial.MdiParent = this;
            Factorial.Show();
        }

        private void calculoDeUnExponenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalculoExponente frmCalculo = new frmCalculoExponente();
            frmCalculo.MdiParent = this;
            frmCalculo.Show();
        }

        private void sumarLosExponentesDeUnArregloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSumaElementosArreglo frmSuma = new frmSumaElementosArreglo();
            frmSuma.MdiParent = this;
            frmSuma.Show();
        }

        private void secuencuaDeFibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSecuenciaFibonacci fibonacci = new frmSecuenciaFibonacci();
            fibonacci.MdiParent = this;
            fibonacci.Show();
        }

        private void busquedaBinariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBusquedaBinaria binaria = new frmBusquedaBinaria();
            binaria.MdiParent = this;
            binaria.Show();
        }

        private void algoritmoDeLaTorreDeHanoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTorreHanoi torreHanoi = new frmTorreHanoi();
            torreHanoi.MdiParent = this;
            torreHanoi.Show();
        }

        private void burbujaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBurbuja burbuja = new frmBurbuja();
            burbuja.MdiParent = this;
            burbuja.Show();
        }

        private void quicksortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuicksort quicksort = new frmQuicksort();
            quicksort.MdiParent = this;
            quicksort.Show();
        }

        private void shellSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShellSort shellSort = new frmShellSort();
            shellSort.MdiParent = this;
            shellSort.Show();
        }

        private void radixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRadix radix = new frmRadix();
            radix.MdiParent = this;
            radix.Show();
        }

        private void intercalacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIntercalacion intercalacion = new frmIntercalacion();
            intercalacion.MdiParent = this;
            intercalacion.Show();
        }

        private void mezclaDirectaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMezclaDirecta mezclaDirecta = new frmMezclaDirecta();
            mezclaDirecta.MdiParent = this;
            mezclaDirecta.Show();
        }

        private void mezclaNaturalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMezclaNatural mezclaNatural = new frmMezclaNatural();
            mezclaNatural.MdiParent = this;
            mezclaNatural.Show();
        }

        private void busquedaBinariaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBusquedaBinariaa binariaa = new frmBusquedaBinariaa();
            binariaa.MdiParent = this;
            binariaa.Show();
        }
    }
}
