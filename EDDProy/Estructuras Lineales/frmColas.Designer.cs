namespace EDDemo.Estructuras_Lineales
{
    partial class frmColas
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
            this.btbAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCola = new System.Windows.Forms.Label();
            this.Valor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btbAgregar
            // 
            this.btbAgregar.Location = new System.Drawing.Point(311, 107);
            this.btbAgregar.Name = "btbAgregar";
            this.btbAgregar.Size = new System.Drawing.Size(76, 29);
            this.btbAgregar.TabIndex = 0;
            this.btbAgregar.Text = "Agregar";
            this.btbAgregar.UseVisualStyleBackColor = true;
            this.btbAgregar.Click += new System.EventHandler(this.btbAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(311, 142);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(76, 36);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cola:";
            // 
            // lblCola
            // 
            this.lblCola.AutoSize = true;
            this.lblCola.Location = new System.Drawing.Point(161, 154);
            this.lblCola.Name = "lblCola";
            this.lblCola.Size = new System.Drawing.Size(35, 13);
            this.lblCola.TabIndex = 3;
            this.lblCola.Text = "label2";
            // 
            // Valor
            // 
            this.Valor.Location = new System.Drawing.Point(117, 112);
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(153, 20);
            this.Valor.TabIndex = 4;
            // 
            // frmColas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Valor);
            this.Controls.Add(this.lblCola);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btbAgregar);
            this.Name = "frmColas";
            this.Text = "frmColas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btbAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCola;
        private System.Windows.Forms.TextBox Valor;
    }
}