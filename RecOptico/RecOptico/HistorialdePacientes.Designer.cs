﻿
namespace RecOptico
{
    partial class frmHistorial
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
            this.lblHistorial = new System.Windows.Forms.Label();
            this.dtwHistorialPacientes = new System.Windows.Forms.DataGridView();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.txtBusquedaPaciente = new System.Windows.Forms.TextBox();
            this.cmdModificarPaciente = new System.Windows.Forms.Button();
            this.cmdEliminarPaciente = new System.Windows.Forms.Button();
            this.cmdAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtwHistorialPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorial.Location = new System.Drawing.Point(231, 9);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(347, 39);
            this.lblHistorial.TabIndex = 1;
            this.lblHistorial.Text = "Historial de Pacientes";
            // 
            // dtwHistorialPacientes
            // 
            this.dtwHistorialPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtwHistorialPacientes.Location = new System.Drawing.Point(12, 66);
            this.dtwHistorialPacientes.Name = "dtwHistorialPacientes";
            this.dtwHistorialPacientes.Size = new System.Drawing.Size(745, 305);
            this.dtwHistorialPacientes.TabIndex = 2;
            this.dtwHistorialPacientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtwHistorialPacientes_CellContentClick);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.Location = new System.Drawing.Point(268, 387);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(125, 24);
            this.lblBusqueda.TabIndex = 3;
            this.lblBusqueda.Text = "Ingrese Folio:";
            // 
            // txtBusquedaPaciente
            // 
            this.txtBusquedaPaciente.Location = new System.Drawing.Point(399, 387);
            this.txtBusquedaPaciente.Multiline = true;
            this.txtBusquedaPaciente.Name = "txtBusquedaPaciente";
            this.txtBusquedaPaciente.Size = new System.Drawing.Size(179, 25);
            this.txtBusquedaPaciente.TabIndex = 6;
            // 
            // cmdModificarPaciente
            // 
            this.cmdModificarPaciente.Location = new System.Drawing.Point(298, 434);
            this.cmdModificarPaciente.Name = "cmdModificarPaciente";
            this.cmdModificarPaciente.Size = new System.Drawing.Size(119, 44);
            this.cmdModificarPaciente.TabIndex = 7;
            this.cmdModificarPaciente.Text = "&Modificar Paciente";
            this.cmdModificarPaciente.UseVisualStyleBackColor = true;
            this.cmdModificarPaciente.Click += new System.EventHandler(this.cmdModificarPaciente_Click);
            // 
            // cmdEliminarPaciente
            // 
            this.cmdEliminarPaciente.Location = new System.Drawing.Point(438, 434);
            this.cmdEliminarPaciente.Name = "cmdEliminarPaciente";
            this.cmdEliminarPaciente.Size = new System.Drawing.Size(119, 44);
            this.cmdEliminarPaciente.TabIndex = 8;
            this.cmdEliminarPaciente.Text = "&Eliminar Paciente";
            this.cmdEliminarPaciente.UseVisualStyleBackColor = true;
            this.cmdEliminarPaciente.Click += new System.EventHandler(this.cmdEliminarPaciente_Click);
            // 
            // cmdAtras
            // 
            this.cmdAtras.Location = new System.Drawing.Point(12, 434);
            this.cmdAtras.Name = "cmdAtras";
            this.cmdAtras.Size = new System.Drawing.Size(119, 44);
            this.cmdAtras.TabIndex = 9;
            this.cmdAtras.Text = "&Atras";
            this.cmdAtras.UseVisualStyleBackColor = true;
            this.cmdAtras.Click += new System.EventHandler(this.cmdAtras_Click);
            // 
            // frmHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(769, 490);
            this.Controls.Add(this.cmdAtras);
            this.Controls.Add(this.cmdEliminarPaciente);
            this.Controls.Add(this.cmdModificarPaciente);
            this.Controls.Add(this.txtBusquedaPaciente);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.dtwHistorialPacientes);
            this.Controls.Add(this.lblHistorial);
            this.Name = "frmHistorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de Pacientes";
            this.Load += new System.EventHandler(this.frmHistorial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtwHistorialPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHistorial;
        public System.Windows.Forms.DataGridView dtwHistorialPacientes;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox txtBusquedaPaciente;
        private System.Windows.Forms.Button cmdModificarPaciente;
        private System.Windows.Forms.Button cmdEliminarPaciente;
        private System.Windows.Forms.Button cmdAtras;
    }
}