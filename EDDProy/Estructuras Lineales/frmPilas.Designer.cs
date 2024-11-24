
namespace EDDemo
{
    partial class frmPilas
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
            this.Valor = new System.Windows.Forms.TextBox();
            this.btnPush = new System.Windows.Forms.Button();
            this.btnPop = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.listPila = new System.Windows.Forms.ListBox();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Valor
            // 
            this.Valor.Location = new System.Drawing.Point(264, 32);
            this.Valor.Margin = new System.Windows.Forms.Padding(2);
            this.Valor.Multiline = true;
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(105, 27);
            this.Valor.TabIndex = 0;
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(264, 73);
            this.btnPush.Margin = new System.Windows.Forms.Padding(2);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(51, 21);
            this.btnPush.TabIndex = 1;
            this.btnPush.Text = "Push";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // btnPop
            // 
            this.btnPop.Location = new System.Drawing.Point(327, 73);
            this.btnPop.Margin = new System.Windows.Forms.Padding(2);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(51, 21);
            this.btnPop.TabIndex = 2;
            this.btnPop.Text = "Pop";
            this.btnPop.UseVisualStyleBackColor = true;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(264, 109);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(51, 22);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // listPila
            // 
            this.listPila.FormattingEnabled = true;
            this.listPila.Location = new System.Drawing.Point(17, 22);
            this.listPila.Name = "listPila";
            this.listPila.Size = new System.Drawing.Size(110, 186);
            this.listPila.TabIndex = 4;
            // 
            // btnVaciar
            // 
            this.btnVaciar.Location = new System.Drawing.Point(329, 109);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(49, 22);
            this.btnVaciar.TabIndex = 5;
            this.btnVaciar.Text = "Vaciar";
            this.btnVaciar.UseVisualStyleBackColor = true;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(288, 160);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(59, 22);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ingresa valor a la pila:";
            // 
            // frmPilas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 234);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.listPila);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnPop);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.Valor);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPilas";
            this.Text = "frmPilas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Valor;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ListBox listPila;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
    }
}