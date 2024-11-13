using EDDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace EDDemo.Estructuras_No_Lineales
{
    public partial class frmArboles : Form
    {
        ArbolBusqueda miArbol;
        NodoBinario miRaiz;

        public frmArboles()
        {
            InitializeComponent();
            miArbol = new ArbolBusqueda();
            miRaiz = null;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
 
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();

            //Limpiamos la cadena donde se concatenan los nodos del arbol 
            miArbol.strArbol = "";

            //Se inserta el nodo con el dato capturado
            miArbol.InsertaNodo(int.Parse(txtDato.Text), ref miRaiz);

            //Leer arbol completo y mostrarlo en caja de texto
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;
            
            txtDato.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            miArbol = null;
            miRaiz = null;
            txtArbol.Text  = null;
            txtDato.Text = null;
            lblRecorridoPreOrden.Text = null;
            lblRecorridoInOrden.Text = null;
            lblRecorridoPostOrden.Text = null;
            lblAltura.Text = null;
            lblCompleto.Text = null;
            lblHojas.Text = null;
            lblNiveles.Text = null;
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            String graphVizString;

            miRaiz = miArbol.RegresaRaiz();
            if (miRaiz == null)
            {
                MessageBox.Show("El arbol esta vacio");
                return;
            }

            StringBuilder b = new StringBuilder();
            b.Append("digraph G { node [shape=\"circle\"]; " + Environment.NewLine);
            b.Append(miArbol.ToDot(miRaiz));
            b.Append("}");
            graphVizString = b.ToString();

            //graphVizString = @" digraph g{ label=""Graph""; labelloc=top;labeljust=left;}";
            //graphVizString = @"digraph Arbol{Raiz->60; 60->40. 60->90; 40->34; 40->50;}";
            Bitmap bm = FileDotEngine.Run(graphVizString);


            frmGrafica graf = new frmGrafica();
            graf.ActualizaGrafica(bm);
            graf.MdiParent = this.MdiParent;
            graf.Show();
        }

        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            //Recorrido en PreOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPreOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoPreOrden.Text = "";
            miArbol.PreOrden(miRaiz);

            lblRecorridoPreOrden.Text = miArbol.strRecorrido;


            //Recorrido en InOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPostOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoInOrden.Text = "";
            miArbol.InOrden(miRaiz);
            lblRecorridoInOrden.Text = miArbol.strRecorrido;


            //Recorrido en PostOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPostOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoPostOrden.Text = "";
            miArbol.PostOrden(miRaiz);
            lblRecorridoPostOrden.Text = miArbol.strRecorrido;
        }

        private void btnCrearArbol_Click(object sender, EventArgs e)
        {
            //Limpiamos los objetos y clases del anterior arbol
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text = "";
            txtDato.Text = "";

            miArbol.strArbol = "";

            Random rnd = new Random();

            for (int nNodos = 1; nNodos <= txtNodos.Value; nNodos++)
            {
                int Dato = rnd.Next(1, 100);
                //Obtenemos el nodo Raiz del arbol
                miRaiz = miArbol.RegresaRaiz();

                //Se inserta el nodo con el dato capturado
                miArbol.InsertaNodo(Dato, ref miRaiz);
            }

            //Leer arbol completo y mostrarlo en caja de texto
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;

            txtDato.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBusqueda.Text, out int datoBuscado))
            {
                var nodoEncontrado = miArbol.BuscarNodo(datoBuscado, miArbol.RegresaRaiz());
                if (nodoEncontrado != true)
                {
                    MessageBox.Show("El nodo ingresado no se encuentra en el arbol.");
                }
                else
                {
                    MessageBox.Show("El nodo si se encuentra en el arbol");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un valor valido.");
            }
            txtDato.Text = " ";
        }
        private void btnPredecesor_Click(object sender, EventArgs e)
        {
            txtArbol.Text = " ";
            if(int.TryParse(txtDato.Text, out int dato))
            {
                miArbol.EliminarPredecesor(dato, ref miRaiz);
                MessageBox.Show($"El predecesor del nodo con el dato{dato} eliminado si existia.");
                miArbol.MuestraArbolAcostado(1, miRaiz);
                txtArbol.Text = miArbol.strArbol;
                lblAltura.Text = $"{miArbol.ArbolAltura(miRaiz)}";
                lblCompleto.Text = miArbol.EsCompleto(miRaiz) ?"El arbol es completo." : "El arbol no esta completo";
                lblHojas.Text = $"{miArbol.ContarHojas(miRaiz)}";
                lblRecorridoPreOrden.Text = miArbol.PreOrden(miRaiz);
                lblNiveles.Text = miArbol.RecorrerPorNiveles(miRaiz);
                lblRecorridoPostOrden.Text = miArbol.PostOrden(miRaiz);
                lblRecorridoInOrden.Text = miArbol.InOrden(miRaiz);
            }
            else
            {
                MessageBox.Show("Ingresar un numero valido.");
            }
           
            
        }

        private void btnNiveles_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = " ";
            if(miRaiz == null)
            {
                lblNiveles.Text = "El arbol se encuentra vacio.";
                return;
            }
            miArbol.RecorrerPorNiveles(miRaiz);
            lblNiveles.Text = miArbol.strRecorrido;

        }

        private void btnSucesor_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDato.Text, out int dato))
            {
                miArbol.EliminarSucesor(dato, ref miRaiz);
                MessageBox.Show($"El sucesor del nodo con el dato{dato} eliminado si existia.");
                miArbol.MuestraArbolAcostado(1, miRaiz);
                txtArbol.Text = miArbol.strArbol;
                lblAltura.Text = $"{miArbol.ArbolAltura(miRaiz)}";
                lblCompleto.Text = miArbol.EsCompleto(miRaiz) ? "El arbol es completo." : "El arbol no esta completo";
                lblHojas.Text = $"{miArbol.ContarHojas(miRaiz)}";
                lblRecorridoPreOrden.Text = miArbol.PreOrden(miRaiz);
                lblNiveles.Text = miArbol.RecorrerPorNiveles(miRaiz);
                lblRecorridoPostOrden.Text = miArbol.PostOrden(miRaiz);
                lblRecorridoInOrden.Text = miArbol.InOrden(miRaiz);
            }
            else
            {
                MessageBox.Show("Ingresar un numero valido.");
            }
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;
        }

        private void btnAltura_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();
            if(miRaiz == null)
            {
                lblAltura.Text = "El arbol se encuentra vacio.";
                return;
            }
            int altura = miArbol.ArbolAltura(miRaiz);
            lblAltura.Text = " " + altura;
        }

        private void btnHojas_Click(object sender, EventArgs e)
        {
            int totalHojas = miArbol.ContarHojas(miRaiz);
            lblHojas.Text = " " + totalHojas;
        }

        private void btnCompleto_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();
            bool Completo = miArbol.EsCompleto(miRaiz);
            lblCompleto.Text = Completo ? "El arbol se encuentra completo." : "El arbol no se encuentra completo." ;
        }
    }
}
