namespace EDDemo.Metodos_de_ordenamiento.Internos
{
    partial class frmBurbuja
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
            this.listOrdenar = new System.Windows.Forms.ListBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listOrdenar
            // 
            this.listOrdenar.FormattingEnabled = true;
            this.listOrdenar.Location = new System.Drawing.Point(27, 212);
            this.listOrdenar.Name = "listOrdenar";
            this.listOrdenar.Size = new System.Drawing.Size(423, 147);
            this.listOrdenar.TabIndex = 0;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(70, 93);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(97, 25);
            this.btnOrdenar.TabIndex = 1;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(51, 65);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(208, 20);
            this.txtValor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingresa valores:";
            // 
            // frmBurbuja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.listOrdenar);
            this.Name = "frmBurbuja";
            this.Text = "frmBurbuja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listOrdenar;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label1;
    }
}