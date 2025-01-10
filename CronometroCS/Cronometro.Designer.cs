
using System;

namespace CronometroCS
{
    partial class FrmCronometro
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
            this.lblTempo = new System.Windows.Forms.Label();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnComecarPausar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.Location = new System.Drawing.Point(75, 27);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(204, 37);
            this.lblTempo.TabIndex = 0;
            this.lblTempo.Text = "00:00:00.000";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.Location = new System.Drawing.Point(12, 351);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(112, 98);
            this.btnReiniciar.TabIndex = 1;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnComecarPausar
            // 
            this.btnComecarPausar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComecarPausar.Location = new System.Drawing.Point(310, 351);
            this.btnComecarPausar.Name = "btnComecarPausar";
            this.btnComecarPausar.Size = new System.Drawing.Size(112, 98);
            this.btnComecarPausar.TabIndex = 2;
            this.btnComecarPausar.Text = "Iniciar / Pausar";
            this.btnComecarPausar.UseVisualStyleBackColor = true;
            this.btnComecarPausar.Click += new System.EventHandler(this.btnComecarPausar_Click_1);
            // 
            // FrmCronometro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.btnComecarPausar);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.lblTempo);
            this.MaximizeBox = false;
            this.Name = "FrmCronometro";
            this.Text = "Cronômetro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnComecarPausar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnComecarPausar;
    }
}

