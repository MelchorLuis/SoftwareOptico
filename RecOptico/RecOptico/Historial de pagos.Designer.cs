
namespace RecOptico
{
    partial class Historial_de_pagos
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
            this.lblTexto = new System.Windows.Forms.Label();
            this.dtwHistorialPagos = new System.Windows.Forms.DataGridView();
            this.cmdAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtwHistorialPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(235, 28);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(278, 38);
            this.lblTexto.TabIndex = 0;
            this.lblTexto.Text = "Historial de pagos";
            // 
            // dtwHistorialPagos
            // 
            this.dtwHistorialPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtwHistorialPagos.Location = new System.Drawing.Point(15, 87);
            this.dtwHistorialPagos.Name = "dtwHistorialPagos";
            this.dtwHistorialPagos.Size = new System.Drawing.Size(742, 305);
            this.dtwHistorialPagos.TabIndex = 3;
            // 
            // cmdAtras
            // 
            this.cmdAtras.Location = new System.Drawing.Point(637, 424);
            this.cmdAtras.Name = "cmdAtras";
            this.cmdAtras.Size = new System.Drawing.Size(119, 44);
            this.cmdAtras.TabIndex = 10;
            this.cmdAtras.Text = "&Atras";
            this.cmdAtras.UseVisualStyleBackColor = true;
            this.cmdAtras.Click += new System.EventHandler(this.cmdAtras_Click);
            // 
            // Historial_de_pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(769, 499);
            this.Controls.Add(this.cmdAtras);
            this.Controls.Add(this.dtwHistorialPagos);
            this.Controls.Add(this.lblTexto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Historial_de_pagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de pagos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Historial_de_pagos_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dtwHistorialPagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTexto;
        public System.Windows.Forms.DataGridView dtwHistorialPagos;
        private System.Windows.Forms.Button cmdAtras;
    }
}