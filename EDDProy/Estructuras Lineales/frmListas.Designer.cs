namespace EDDemo.Estructuras_Lineales
{
    partial class frmListas
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
            this.listLista = new System.Windows.Forms.ListBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnAgregarI = new System.Windows.Forms.Button();
            this.btnAgregarF = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listLista
            // 
            this.listLista.FormattingEnabled = true;
            this.listLista.Location = new System.Drawing.Point(32, 37);
            this.listLista.Name = "listLista";
            this.listLista.Size = new System.Drawing.Size(152, 277);
            this.listLista.TabIndex = 0;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(210, 48);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(136, 20);
            this.txtValor.TabIndex = 1;
            // 
            // btnAgregarI
            // 
            this.btnAgregarI.Location = new System.Drawing.Point(210, 88);
            this.btnAgregarI.Name = "btnAgregarI";
            this.btnAgregarI.Size = new System.Drawing.Size(135, 23);
            this.btnAgregarI.TabIndex = 2;
            this.btnAgregarI.Text = "Agregar al inicio";
            this.btnAgregarI.UseVisualStyleBackColor = true;
            // 
            // btnAgregarF
            // 
            this.btnAgregarF.Location = new System.Drawing.Point(210, 124);
            this.btnAgregarF.Name = "btnAgregarF";
            this.btnAgregarF.Size = new System.Drawing.Size(135, 24);
            this.btnAgregarF.TabIndex = 3;
            this.btnAgregarF.Text = "Agregar al final";
            this.btnAgregarF.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(209, 163);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(134, 22);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(209, 200);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(133, 22);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(209, 237);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(134, 24);
            this.btnMostrar.TabIndex = 6;
            this.btnMostrar.Text = "Mostrar lista";
            this.btnMostrar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Agregar un valor a la lista:";
            // 
            // frmListas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregarF);
            this.Controls.Add(this.btnAgregarI);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.listLista);
            this.Name = "frmListas";
            this.Text = "frmLitas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listLista;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnAgregarI;
        private System.Windows.Forms.Button btnAgregarF;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label label1;
    }
}