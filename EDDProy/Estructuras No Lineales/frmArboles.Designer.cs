
namespace EDDemo.Estructuras_No_Lineales
{
    partial class frmArboles
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
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtArbol = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNodos = new System.Windows.Forms.NumericUpDown();
            this.btnCrearArbol = new System.Windows.Forms.Button();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.lblPreOrden = new System.Windows.Forms.Label();
            this.lblInOrden = new System.Windows.Forms.Label();
            this.lblPostOrden = new System.Windows.Forms.Label();
            this.lblRecorridoPreOrden = new System.Windows.Forms.Label();
            this.lblRecorridoInOrden = new System.Windows.Forms.Label();
            this.lblRecorridoPostOrden = new System.Windows.Forms.Label();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnPredecesor = new System.Windows.Forms.Button();
            this.btnNiveles = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNiveles = new System.Windows.Forms.Label();
            this.btnSucesor = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.btnAltura = new System.Windows.Forms.Button();
            this.btnHojas = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHojas = new System.Windows.Forms.Label();
            this.btnCompleto = new System.Windows.Forms.Button();
            this.lblCompleto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(82, 16);
            this.txtDato.Margin = new System.Windows.Forms.Padding(2);
            this.txtDato.Multiline = true;
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(52, 26);
            this.txtDato.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(138, 18);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(62, 24);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtArbol
            // 
            this.txtArbol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArbol.Location = new System.Drawing.Point(6, 195);
            this.txtArbol.Margin = new System.Windows.Forms.Padding(2);
            this.txtArbol.Multiline = true;
            this.txtArbol.Name = "txtArbol";
            this.txtArbol.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtArbol.Size = new System.Drawing.Size(857, 189);
            this.txtArbol.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(777, 54);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(62, 24);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dato:";
            // 
            // txtNodos
            // 
            this.txtNodos.Location = new System.Drawing.Point(85, 58);
            this.txtNodos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNodos.Name = "txtNodos";
            this.txtNodos.Size = new System.Drawing.Size(48, 20);
            this.txtNodos.TabIndex = 4;
            this.txtNodos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCrearArbol
            // 
            this.btnCrearArbol.Location = new System.Drawing.Point(139, 58);
            this.btnCrearArbol.Name = "btnCrearArbol";
            this.btnCrearArbol.Size = new System.Drawing.Size(61, 35);
            this.btnCrearArbol.TabIndex = 5;
            this.btnCrearArbol.Text = "Crear arbol";
            this.btnCrearArbol.UseVisualStyleBackColor = true;
            this.btnCrearArbol.Click += new System.EventHandler(this.btnCrearArbol_Click);
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.Location = new System.Drawing.Point(139, 99);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(61, 27);
            this.btnRecorrer.TabIndex = 6;
            this.btnRecorrer.Text = "Recorrer";
            this.btnRecorrer.UseVisualStyleBackColor = true;
            this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click);
            // 
            // lblPreOrden
            // 
            this.lblPreOrden.AutoSize = true;
            this.lblPreOrden.Location = new System.Drawing.Point(211, 49);
            this.lblPreOrden.Name = "lblPreOrden";
            this.lblPreOrden.Size = new System.Drawing.Size(55, 13);
            this.lblPreOrden.TabIndex = 7;
            this.lblPreOrden.Text = "PreOrden:";
            // 
            // lblInOrden
            // 
            this.lblInOrden.AutoSize = true;
            this.lblInOrden.Location = new System.Drawing.Point(215, 69);
            this.lblInOrden.Name = "lblInOrden";
            this.lblInOrden.Size = new System.Drawing.Size(51, 13);
            this.lblInOrden.TabIndex = 8;
            this.lblInOrden.Text = "InOrden: ";
            // 
            // lblPostOrden
            // 
            this.lblPostOrden.AutoSize = true;
            this.lblPostOrden.Location = new System.Drawing.Point(206, 93);
            this.lblPostOrden.Name = "lblPostOrden";
            this.lblPostOrden.Size = new System.Drawing.Size(60, 13);
            this.lblPostOrden.TabIndex = 9;
            this.lblPostOrden.Text = "PostOrden:";
            // 
            // lblRecorridoPreOrden
            // 
            this.lblRecorridoPreOrden.AutoSize = true;
            this.lblRecorridoPreOrden.Location = new System.Drawing.Point(279, 50);
            this.lblRecorridoPreOrden.Name = "lblRecorridoPreOrden";
            this.lblRecorridoPreOrden.Size = new System.Drawing.Size(57, 13);
            this.lblRecorridoPreOrden.TabIndex = 10;
            this.lblRecorridoPreOrden.Text = "PostOrden";
            // 
            // lblRecorridoInOrden
            // 
            this.lblRecorridoInOrden.AutoSize = true;
            this.lblRecorridoInOrden.Location = new System.Drawing.Point(279, 69);
            this.lblRecorridoInOrden.Name = "lblRecorridoInOrden";
            this.lblRecorridoInOrden.Size = new System.Drawing.Size(57, 13);
            this.lblRecorridoInOrden.TabIndex = 11;
            this.lblRecorridoInOrden.Text = "PostOrden";
            // 
            // lblRecorridoPostOrden
            // 
            this.lblRecorridoPostOrden.AutoSize = true;
            this.lblRecorridoPostOrden.Location = new System.Drawing.Point(279, 93);
            this.lblRecorridoPostOrden.Name = "lblRecorridoPostOrden";
            this.lblRecorridoPostOrden.Size = new System.Drawing.Size(57, 13);
            this.lblRecorridoPostOrden.TabIndex = 12;
            this.lblRecorridoPostOrden.Text = "PostOrden";
            // 
            // btnGraficar
            // 
            this.btnGraficar.Location = new System.Drawing.Point(777, 16);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(62, 23);
            this.btnGraficar.TabIndex = 13;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = true;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Dato a buscar: ";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(282, 18);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(48, 20);
            this.txtBusqueda.TabIndex = 15;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(336, 14);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(51, 27);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnPredecesor
            // 
            this.btnPredecesor.Location = new System.Drawing.Point(408, 13);
            this.btnPredecesor.Name = "btnPredecesor";
            this.btnPredecesor.Size = new System.Drawing.Size(72, 34);
            this.btnPredecesor.TabIndex = 17;
            this.btnPredecesor.Text = "Eliminar predecesor";
            this.btnPredecesor.UseVisualStyleBackColor = true;
            this.btnPredecesor.Click += new System.EventHandler(this.btnPredecesor_Click);
            // 
            // btnNiveles
            // 
            this.btnNiveles.Location = new System.Drawing.Point(486, 13);
            this.btnNiveles.Name = "btnNiveles";
            this.btnNiveles.Size = new System.Drawing.Size(114, 33);
            this.btnNiveles.TabIndex = 18;
            this.btnNiveles.Text = "Recorrer por niveles";
            this.btnNiveles.UseVisualStyleBackColor = true;
            this.btnNiveles.Click += new System.EventHandler(this.btnNiveles_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Recorrido por niveles:";
            // 
            // lblNiveles
            // 
            this.lblNiveles.AutoSize = true;
            this.lblNiveles.Location = new System.Drawing.Point(320, 113);
            this.lblNiveles.Name = "lblNiveles";
            this.lblNiveles.Size = new System.Drawing.Size(59, 13);
            this.lblNiveles.TabIndex = 20;
            this.lblNiveles.Text = "Por niveles";
            // 
            // btnSucesor
            // 
            this.btnSucesor.Location = new System.Drawing.Point(606, 14);
            this.btnSucesor.Name = "btnSucesor";
            this.btnSucesor.Size = new System.Drawing.Size(72, 38);
            this.btnSucesor.TabIndex = 21;
            this.btnSucesor.Text = "Eliminar sucesor";
            this.btnSucesor.UseVisualStyleBackColor = true;
            this.btnSucesor.Click += new System.EventHandler(this.btnSucesor_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(206, 136);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(81, 13);
            this.label.TabIndex = 22;
            this.label.Text = "Altura del Arbol:";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(293, 136);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(34, 13);
            this.lblAltura.TabIndex = 23;
            this.lblAltura.Text = "Altura";
            // 
            // btnAltura
            // 
            this.btnAltura.Location = new System.Drawing.Point(684, 14);
            this.btnAltura.Name = "btnAltura";
            this.btnAltura.Size = new System.Drawing.Size(71, 37);
            this.btnAltura.TabIndex = 24;
            this.btnAltura.Text = "Alturta del arbol";
            this.btnAltura.UseVisualStyleBackColor = true;
            this.btnAltura.Click += new System.EventHandler(this.btnAltura_Click);
            // 
            // btnHojas
            // 
            this.btnHojas.Location = new System.Drawing.Point(777, 90);
            this.btnHojas.Name = "btnHojas";
            this.btnHojas.Size = new System.Drawing.Size(61, 36);
            this.btnHojas.TabIndex = 25;
            this.btnHojas.Text = "Contar hojas";
            this.btnHojas.UseVisualStyleBackColor = true;
            this.btnHojas.Click += new System.EventHandler(this.btnHojas_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Total de hojas:";
            // 
            // lblHojas
            // 
            this.lblHojas.AutoSize = true;
            this.lblHojas.Location = new System.Drawing.Point(292, 159);
            this.lblHojas.Name = "lblHojas";
            this.lblHojas.Size = new System.Drawing.Size(34, 13);
            this.lblHojas.TabIndex = 27;
            this.lblHojas.Text = "Hojas";
            // 
            // btnCompleto
            // 
            this.btnCompleto.Location = new System.Drawing.Point(776, 142);
            this.btnCompleto.Name = "btnCompleto";
            this.btnCompleto.Size = new System.Drawing.Size(62, 29);
            this.btnCompleto.TabIndex = 28;
            this.btnCompleto.Text = "Completo";
            this.btnCompleto.UseVisualStyleBackColor = true;
            this.btnCompleto.Click += new System.EventHandler(this.btnCompleto_Click);
            // 
            // lblCompleto
            // 
            this.lblCompleto.AutoSize = true;
            this.lblCompleto.Location = new System.Drawing.Point(206, 180);
            this.lblCompleto.Name = "lblCompleto";
            this.lblCompleto.Size = new System.Drawing.Size(65, 13);
            this.lblCompleto.TabIndex = 29;
            this.lblCompleto.Text = "Es completo";
            // 
            // frmArboles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 388);
            this.Controls.Add(this.lblCompleto);
            this.Controls.Add(this.btnCompleto);
            this.Controls.Add(this.lblHojas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnHojas);
            this.Controls.Add(this.btnAltura);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnSucesor);
            this.Controls.Add(this.lblNiveles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNiveles);
            this.Controls.Add(this.btnPredecesor);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGraficar);
            this.Controls.Add(this.lblRecorridoPostOrden);
            this.Controls.Add(this.lblRecorridoInOrden);
            this.Controls.Add(this.lblRecorridoPreOrden);
            this.Controls.Add(this.lblPostOrden);
            this.Controls.Add(this.lblInOrden);
            this.Controls.Add(this.lblPreOrden);
            this.Controls.Add(this.btnRecorrer);
            this.Controls.Add(this.btnCrearArbol);
            this.Controls.Add(this.txtNodos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtArbol);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDato);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmArboles";
            this.Text = "frmArboles";
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtArbol;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtNodos;
        private System.Windows.Forms.Button btnCrearArbol;
        private System.Windows.Forms.Button btnRecorrer;
        private System.Windows.Forms.Label lblPreOrden;
        private System.Windows.Forms.Label lblInOrden;
        private System.Windows.Forms.Label lblPostOrden;
        private System.Windows.Forms.Label lblRecorridoPreOrden;
        private System.Windows.Forms.Label lblRecorridoInOrden;
        private System.Windows.Forms.Label lblRecorridoPostOrden;
        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnPredecesor;
        private System.Windows.Forms.Button btnNiveles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNiveles;
        private System.Windows.Forms.Button btnSucesor;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Button btnAltura;
        private System.Windows.Forms.Button btnHojas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHojas;
        private System.Windows.Forms.Button btnCompleto;
        private System.Windows.Forms.Label lblCompleto;
    }
}