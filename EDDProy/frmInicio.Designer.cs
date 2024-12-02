
namespace EDDemo
{
    partial class frmInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.estructurasLinealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pilasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circularesSimplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circularesDoblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estructurasNoLibealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arbolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.factorialDeUnNumeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculoDeUnExponenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumarLosExponentesDeUnArregloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secuencuaDeFibonacciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaBinariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmoDeLaTorreDeHanoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodosDeOrdenamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.externosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.burbujaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quicksortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shellSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intercalacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mezclaDirectaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mezclaNaturalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recurToolStripMenuItem,
            this.estructurasLinealesToolStripMenuItem,
            this.estructurasNoLibealesToolStripMenuItem,
            this.metodosDeOrdenamientoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // estructurasLinealesToolStripMenuItem
            // 
            this.estructurasLinealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pilasToolStripMenuItem,
            this.colasToolStripMenuItem,
            this.listasToolStripMenuItem});
            this.estructurasLinealesToolStripMenuItem.Name = "estructurasLinealesToolStripMenuItem";
            this.estructurasLinealesToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.estructurasLinealesToolStripMenuItem.Text = "Estructuras lineales";
            this.estructurasLinealesToolStripMenuItem.Click += new System.EventHandler(this.estructurasLinealesToolStripMenuItem_Click);
            // 
            // pilasToolStripMenuItem
            // 
            this.pilasToolStripMenuItem.Name = "pilasToolStripMenuItem";
            this.pilasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pilasToolStripMenuItem.Text = "Pilas";
            this.pilasToolStripMenuItem.Click += new System.EventHandler(this.pilasToolStripMenuItem_Click);
            // 
            // colasToolStripMenuItem
            // 
            this.colasToolStripMenuItem.Name = "colasToolStripMenuItem";
            this.colasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colasToolStripMenuItem.Text = "Colas";
            this.colasToolStripMenuItem.Click += new System.EventHandler(this.colasToolStripMenuItem_Click);
            // 
            // listasToolStripMenuItem
            // 
            this.listasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simplesToolStripMenuItem,
            this.doblesToolStripMenuItem,
            this.circularesSimplesToolStripMenuItem,
            this.circularesDoblesToolStripMenuItem});
            this.listasToolStripMenuItem.Name = "listasToolStripMenuItem";
            this.listasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listasToolStripMenuItem.Text = "Listas";
            // 
            // simplesToolStripMenuItem
            // 
            this.simplesToolStripMenuItem.Name = "simplesToolStripMenuItem";
            this.simplesToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.simplesToolStripMenuItem.Text = "Simples";
            this.simplesToolStripMenuItem.Click += new System.EventHandler(this.simplesToolStripMenuItem_Click);
            // 
            // doblesToolStripMenuItem
            // 
            this.doblesToolStripMenuItem.Name = "doblesToolStripMenuItem";
            this.doblesToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.doblesToolStripMenuItem.Text = "Dobles";
            this.doblesToolStripMenuItem.Click += new System.EventHandler(this.doblesToolStripMenuItem_Click);
            // 
            // circularesSimplesToolStripMenuItem
            // 
            this.circularesSimplesToolStripMenuItem.Name = "circularesSimplesToolStripMenuItem";
            this.circularesSimplesToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.circularesSimplesToolStripMenuItem.Text = "Circulares simples";
            this.circularesSimplesToolStripMenuItem.Click += new System.EventHandler(this.circularesSimplesToolStripMenuItem_Click);
            // 
            // circularesDoblesToolStripMenuItem
            // 
            this.circularesDoblesToolStripMenuItem.Name = "circularesDoblesToolStripMenuItem";
            this.circularesDoblesToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.circularesDoblesToolStripMenuItem.Text = "Circulares dobles";
            this.circularesDoblesToolStripMenuItem.Click += new System.EventHandler(this.circularesDoblesToolStripMenuItem_Click);
            // 
            // estructurasNoLibealesToolStripMenuItem
            // 
            this.estructurasNoLibealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arbolesToolStripMenuItem});
            this.estructurasNoLibealesToolStripMenuItem.Name = "estructurasNoLibealesToolStripMenuItem";
            this.estructurasNoLibealesToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.estructurasNoLibealesToolStripMenuItem.Text = "Estructuras no libeales";
            // 
            // arbolesToolStripMenuItem
            // 
            this.arbolesToolStripMenuItem.Name = "arbolesToolStripMenuItem";
            this.arbolesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.arbolesToolStripMenuItem.Text = "Arboles";
            this.arbolesToolStripMenuItem.Click += new System.EventHandler(this.arbolesToolStripMenuItem_Click);
            // 
            // recurToolStripMenuItem
            // 
            this.recurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.factorialDeUnNumeroToolStripMenuItem,
            this.calculoDeUnExponenteToolStripMenuItem,
            this.sumarLosExponentesDeUnArregloToolStripMenuItem,
            this.secuencuaDeFibonacciToolStripMenuItem,
            this.busquedaBinariaToolStripMenuItem,
            this.algoritmoDeLaTorreDeHanoiToolStripMenuItem});
            this.recurToolStripMenuItem.Name = "recurToolStripMenuItem";
            this.recurToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.recurToolStripMenuItem.Text = "Recursividad";
            // 
            // factorialDeUnNumeroToolStripMenuItem
            // 
            this.factorialDeUnNumeroToolStripMenuItem.Name = "factorialDeUnNumeroToolStripMenuItem";
            this.factorialDeUnNumeroToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.factorialDeUnNumeroToolStripMenuItem.Text = "Factorial de un numero ";
            this.factorialDeUnNumeroToolStripMenuItem.Click += new System.EventHandler(this.factorialDeUnNumeroToolStripMenuItem_Click);
            // 
            // calculoDeUnExponenteToolStripMenuItem
            // 
            this.calculoDeUnExponenteToolStripMenuItem.Name = "calculoDeUnExponenteToolStripMenuItem";
            this.calculoDeUnExponenteToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.calculoDeUnExponenteToolStripMenuItem.Text = "Calculo de un exponente";
            this.calculoDeUnExponenteToolStripMenuItem.Click += new System.EventHandler(this.calculoDeUnExponenteToolStripMenuItem_Click);
            // 
            // sumarLosExponentesDeUnArregloToolStripMenuItem
            // 
            this.sumarLosExponentesDeUnArregloToolStripMenuItem.Name = "sumarLosExponentesDeUnArregloToolStripMenuItem";
            this.sumarLosExponentesDeUnArregloToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.sumarLosExponentesDeUnArregloToolStripMenuItem.Text = "Sumar los elementos de un arreglo";
            this.sumarLosExponentesDeUnArregloToolStripMenuItem.Click += new System.EventHandler(this.sumarLosExponentesDeUnArregloToolStripMenuItem_Click);
            // 
            // secuencuaDeFibonacciToolStripMenuItem
            // 
            this.secuencuaDeFibonacciToolStripMenuItem.Name = "secuencuaDeFibonacciToolStripMenuItem";
            this.secuencuaDeFibonacciToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.secuencuaDeFibonacciToolStripMenuItem.Text = "Secuencua de Fibonacci";
            this.secuencuaDeFibonacciToolStripMenuItem.Click += new System.EventHandler(this.secuencuaDeFibonacciToolStripMenuItem_Click);
            // 
            // busquedaBinariaToolStripMenuItem
            // 
            this.busquedaBinariaToolStripMenuItem.Name = "busquedaBinariaToolStripMenuItem";
            this.busquedaBinariaToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.busquedaBinariaToolStripMenuItem.Text = "Busqueda binaria";
            this.busquedaBinariaToolStripMenuItem.Click += new System.EventHandler(this.busquedaBinariaToolStripMenuItem_Click);
            // 
            // algoritmoDeLaTorreDeHanoiToolStripMenuItem
            // 
            this.algoritmoDeLaTorreDeHanoiToolStripMenuItem.Name = "algoritmoDeLaTorreDeHanoiToolStripMenuItem";
            this.algoritmoDeLaTorreDeHanoiToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.algoritmoDeLaTorreDeHanoiToolStripMenuItem.Text = "Algoritmo de la torre de Hanoi";
            this.algoritmoDeLaTorreDeHanoiToolStripMenuItem.Click += new System.EventHandler(this.algoritmoDeLaTorreDeHanoiToolStripMenuItem_Click);
            // 
            // metodosDeOrdenamientoToolStripMenuItem
            // 
            this.metodosDeOrdenamientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.internosToolStripMenuItem,
            this.externosToolStripMenuItem});
            this.metodosDeOrdenamientoToolStripMenuItem.Name = "metodosDeOrdenamientoToolStripMenuItem";
            this.metodosDeOrdenamientoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.metodosDeOrdenamientoToolStripMenuItem.Text = "Metodos de ordenamiento";
            // 
            // internosToolStripMenuItem
            // 
            this.internosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.burbujaToolStripMenuItem,
            this.quicksortToolStripMenuItem,
            this.shellSortToolStripMenuItem,
            this.radixToolStripMenuItem});
            this.internosToolStripMenuItem.Name = "internosToolStripMenuItem";
            this.internosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.internosToolStripMenuItem.Text = "Internos";
            // 
            // externosToolStripMenuItem
            // 
            this.externosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.intercalacionToolStripMenuItem,
            this.mezclaDirectaToolStripMenuItem,
            this.mezclaNaturalToolStripMenuItem});
            this.externosToolStripMenuItem.Name = "externosToolStripMenuItem";
            this.externosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.externosToolStripMenuItem.Text = "Externos";
            // 
            // burbujaToolStripMenuItem
            // 
            this.burbujaToolStripMenuItem.Name = "burbujaToolStripMenuItem";
            this.burbujaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.burbujaToolStripMenuItem.Text = "Burbuja";
            // 
            // quicksortToolStripMenuItem
            // 
            this.quicksortToolStripMenuItem.Name = "quicksortToolStripMenuItem";
            this.quicksortToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quicksortToolStripMenuItem.Text = "Quicksort";
            // 
            // shellSortToolStripMenuItem
            // 
            this.shellSortToolStripMenuItem.Name = "shellSortToolStripMenuItem";
            this.shellSortToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.shellSortToolStripMenuItem.Text = "ShellSort";
            // 
            // radixToolStripMenuItem
            // 
            this.radixToolStripMenuItem.Name = "radixToolStripMenuItem";
            this.radixToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.radixToolStripMenuItem.Text = "Radix";
            // 
            // intercalacionToolStripMenuItem
            // 
            this.intercalacionToolStripMenuItem.Name = "intercalacionToolStripMenuItem";
            this.intercalacionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.intercalacionToolStripMenuItem.Text = "Intercalacion";
            // 
            // mezclaDirectaToolStripMenuItem
            // 
            this.mezclaDirectaToolStripMenuItem.Name = "mezclaDirectaToolStripMenuItem";
            this.mezclaDirectaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mezclaDirectaToolStripMenuItem.Text = "Mezcla directa";
            // 
            // mezclaNaturalToolStripMenuItem
            // 
            this.mezclaNaturalToolStripMenuItem.Name = "mezclaNaturalToolStripMenuItem";
            this.mezclaNaturalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mezclaNaturalToolStripMenuItem.Text = "Mezcla natural";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 425);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem estructurasLinealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pilasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estructurasNoLibealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arbolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doblesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circularesSimplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circularesDoblesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem factorialDeUnNumeroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculoDeUnExponenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumarLosExponentesDeUnArregloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secuencuaDeFibonacciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaBinariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmoDeLaTorreDeHanoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metodosDeOrdenamientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem burbujaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quicksortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem externosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shellSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intercalacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mezclaDirectaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mezclaNaturalToolStripMenuItem;
    }
}

