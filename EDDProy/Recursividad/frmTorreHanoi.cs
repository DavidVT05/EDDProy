using EDDemo.Recursividad.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Recursividad
{
    public partial class frmTorreHanoi : Form
    {
        public frmTorreHanoi()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            TorreHanoi torreHanoi = new TorreHanoi(); // se manda llamar la funcion de la torre de hanoi
            string valor = txtValor.Text; //se guarda el valor ingresasdo
            if(torreHanoi.Resolver(valor,listMovimientos,lblTiempo, lblOperaciones))
            {
                //Si no encuentra algun error se mostraran los resultados de la cantida de discos ingresado
            }
            else
            {
                MessageBox.Show("Ingresar un valor valido.");
            }
        }
        
    }
}
