﻿namespace EDDemo
{
    partial class frmGrafica
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
            this.picGrafica = new System.Windows.Forms.PictureBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.picGrafica)).BeginInit();
            this.SuspendLayout();
            // 
            // picGrafica
            // 
            this.picGrafica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picGrafica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picGrafica.Location = new System.Drawing.Point(0, 0);
            this.picGrafica.Margin = new System.Windows.Forms.Padding(2);
            this.picGrafica.Name = "picGrafica";
            this.picGrafica.Size = new System.Drawing.Size(651, 458);
            this.picGrafica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picGrafica.TabIndex = 0;
            this.picGrafica.TabStop = false;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(635, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(16, 458);
            this.vScrollBar1.TabIndex = 1;
            this.vScrollBar1.UseWaitCursor = true;
            // 
            // frmGrafica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(651, 458);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.picGrafica);
            this.Name = "frmGrafica";
            this.Text = "Grafica";
            this.Load += new System.EventHandler(this.frmGrafica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picGrafica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picGrafica;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}