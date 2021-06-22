
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
            this.ColumnaFolio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaMetodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdAtras = new System.Windows.Forms.Button();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.txtBusquedaPaciente = new System.Windows.Forms.TextBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
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
            this.dtwHistorialPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaFolio,
            this.ColumnaFecha,
            this.ColumnaCantidad,
            this.ColumnaMetodo,
            this.ColumnaID,
            this.ColumnaNombre,
            this.ColumnaApellidos});
            this.dtwHistorialPagos.Location = new System.Drawing.Point(14, 93);
            this.dtwHistorialPagos.Name = "dtwHistorialPagos";
            this.dtwHistorialPagos.Size = new System.Drawing.Size(742, 305);
            this.dtwHistorialPagos.TabIndex = 3;
            // 
            // ColumnaFolio
            // 
            this.ColumnaFolio.HeaderText = "Folio";
            this.ColumnaFolio.Name = "ColumnaFolio";
            // 
            // ColumnaFecha
            // 
            this.ColumnaFecha.HeaderText = "Fecha";
            this.ColumnaFecha.Name = "ColumnaFecha";
            // 
            // ColumnaCantidad
            // 
            this.ColumnaCantidad.HeaderText = "Cantidad";
            this.ColumnaCantidad.Name = "ColumnaCantidad";
            // 
            // ColumnaMetodo
            // 
            this.ColumnaMetodo.HeaderText = "Metodo de Pago";
            this.ColumnaMetodo.Name = "ColumnaMetodo";
            // 
            // ColumnaID
            // 
            this.ColumnaID.HeaderText = "Folio Paciente";
            this.ColumnaID.Name = "ColumnaID";
            // 
            // ColumnaNombre
            // 
            this.ColumnaNombre.HeaderText = "Nombre";
            this.ColumnaNombre.Name = "ColumnaNombre";
            // 
            // ColumnaApellidos
            // 
            this.ColumnaApellidos.HeaderText = "Apellidos";
            this.ColumnaApellidos.Name = "ColumnaApellidos";
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
            // cmdBuscar
            // 
            this.cmdBuscar.Location = new System.Drawing.Point(329, 445);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(119, 44);
            this.cmdBuscar.TabIndex = 14;
            this.cmdBuscar.Text = "&Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // txtBusquedaPaciente
            // 
            this.txtBusquedaPaciente.Location = new System.Drawing.Point(349, 418);
            this.txtBusquedaPaciente.Multiline = true;
            this.txtBusquedaPaciente.Name = "txtBusquedaPaciente";
            this.txtBusquedaPaciente.Size = new System.Drawing.Size(179, 25);
            this.txtBusquedaPaciente.TabIndex = 12;
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.Location = new System.Drawing.Point(218, 418);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(125, 24);
            this.lblBusqueda.TabIndex = 11;
            this.lblBusqueda.Text = "Ingrese Folio:";
            // 
            // Historial_de_pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(769, 490);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.txtBusquedaPaciente);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.cmdAtras);
            this.Controls.Add(this.dtwHistorialPagos);
            this.Controls.Add(this.lblTexto);
            this.Name = "Historial_de_pagos";
            this.Text = "Historial de pagos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Historial_de_pagos_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dtwHistorialPagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.DataGridView dtwHistorialPagos;
        private System.Windows.Forms.Button cmdAtras;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaFolio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaMetodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaApellidos;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.TextBox txtBusquedaPaciente;
        private System.Windows.Forms.Label lblBusqueda;
    }
}