﻿
namespace RecOptico
{
    partial class AgregarPago
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
            this.lblPagos = new System.Windows.Forms.Label();
            this.cbPagos = new System.Windows.Forms.ComboBox();
            this.lblFolio = new System.Windows.Forms.Label();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.lblPrecioLente = new System.Windows.Forms.Label();
            this.txtPrecioLente = new System.Windows.Forms.TextBox();
            this.lblAbono = new System.Windows.Forms.Label();
            this.txtAbono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdDesplegar = new System.Windows.Forms.Button();
            this.cmdAgregarPago = new System.Windows.Forms.Button();
            this.cmdOtro = new System.Windows.Forms.Button();
            this.cmdAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPagos
            // 
            this.lblPagos.AutoSize = true;
            this.lblPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagos.Location = new System.Drawing.Point(134, 22);
            this.lblPagos.Name = "lblPagos";
            this.lblPagos.Size = new System.Drawing.Size(108, 37);
            this.lblPagos.TabIndex = 0;
            this.lblPagos.Text = "Pagos";
            // 
            // cbPagos
            // 
            this.cbPagos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPagos.FormattingEnabled = true;
            this.cbPagos.Items.AddRange(new object[] {
            "Añadir precio de lente",
            "Abono"});
            this.cbPagos.Location = new System.Drawing.Point(131, 101);
            this.cbPagos.Name = "cbPagos";
            this.cbPagos.Size = new System.Drawing.Size(121, 21);
            this.cbPagos.TabIndex = 1;
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Location = new System.Drawing.Point(5, 193);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(35, 13);
            this.lblFolio.TabIndex = 2;
            this.lblFolio.Text = "Folio: ";
            this.lblFolio.Visible = false;
            // 
            // txtFolio
            // 
            this.txtFolio.Location = new System.Drawing.Point(46, 190);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(100, 20);
            this.txtFolio.TabIndex = 3;
            this.txtFolio.Visible = false;
            // 
            // lblPrecioLente
            // 
            this.lblPrecioLente.AutoSize = true;
            this.lblPrecioLente.Location = new System.Drawing.Point(168, 193);
            this.lblPrecioLente.Name = "lblPrecioLente";
            this.lblPrecioLente.Size = new System.Drawing.Size(106, 13);
            this.lblPrecioLente.TabIndex = 4;
            this.lblPrecioLente.Text = "Precio total del lente:";
            this.lblPrecioLente.Visible = false;
            // 
            // txtPrecioLente
            // 
            this.txtPrecioLente.Location = new System.Drawing.Point(280, 190);
            this.txtPrecioLente.Name = "txtPrecioLente";
            this.txtPrecioLente.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioLente.TabIndex = 5;
            this.txtPrecioLente.Visible = false;
            // 
            // lblAbono
            // 
            this.lblAbono.AutoSize = true;
            this.lblAbono.Location = new System.Drawing.Point(233, 193);
            this.lblAbono.Name = "lblAbono";
            this.lblAbono.Size = new System.Drawing.Size(41, 13);
            this.lblAbono.TabIndex = 8;
            this.lblAbono.Text = "Abono:";
            this.lblAbono.Visible = false;
            // 
            // txtAbono
            // 
            this.txtAbono.Location = new System.Drawing.Point(280, 190);
            this.txtAbono.Name = "txtAbono";
            this.txtAbono.Size = new System.Drawing.Size(100, 20);
            this.txtAbono.TabIndex = 9;
            this.txtAbono.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Seleccione una opción:";
            // 
            // cmdDesplegar
            // 
            this.cmdDesplegar.Location = new System.Drawing.Point(152, 138);
            this.cmdDesplegar.Name = "cmdDesplegar";
            this.cmdDesplegar.Size = new System.Drawing.Size(75, 23);
            this.cmdDesplegar.TabIndex = 11;
            this.cmdDesplegar.Text = "Desplegar";
            this.cmdDesplegar.UseVisualStyleBackColor = true;
            this.cmdDesplegar.Click += new System.EventHandler(this.cmdDesplegar_Click);
            // 
            // cmdAgregarPago
            // 
            this.cmdAgregarPago.Location = new System.Drawing.Point(288, 228);
            this.cmdAgregarPago.Name = "cmdAgregarPago";
            this.cmdAgregarPago.Size = new System.Drawing.Size(97, 23);
            this.cmdAgregarPago.TabIndex = 12;
            this.cmdAgregarPago.Text = "Agregar pago";
            this.cmdAgregarPago.UseVisualStyleBackColor = true;
            this.cmdAgregarPago.Visible = false;
            this.cmdAgregarPago.Click += new System.EventHandler(this.cmdAgregarPago_Click);
            // 
            // cmdOtro
            // 
            this.cmdOtro.Location = new System.Drawing.Point(127, 138);
            this.cmdOtro.Name = "cmdOtro";
            this.cmdOtro.Size = new System.Drawing.Size(125, 23);
            this.cmdOtro.TabIndex = 13;
            this.cmdOtro.Text = "Hacer otra operación";
            this.cmdOtro.UseVisualStyleBackColor = true;
            this.cmdOtro.Visible = false;
            this.cmdOtro.Click += new System.EventHandler(this.cmdOtro_Click);
            // 
            // cmdAtras
            // 
            this.cmdAtras.Location = new System.Drawing.Point(8, 228);
            this.cmdAtras.Name = "cmdAtras";
            this.cmdAtras.Size = new System.Drawing.Size(75, 23);
            this.cmdAtras.TabIndex = 14;
            this.cmdAtras.Text = "Atras";
            this.cmdAtras.UseVisualStyleBackColor = true;
            this.cmdAtras.Click += new System.EventHandler(this.cmdAtras_Click);
            // 
            // AgregarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(397, 263);
            this.Controls.Add(this.cmdAtras);
            this.Controls.Add(this.cmdOtro);
            this.Controls.Add(this.cmdAgregarPago);
            this.Controls.Add(this.cmdDesplegar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAbono);
            this.Controls.Add(this.lblAbono);
            this.Controls.Add(this.txtPrecioLente);
            this.Controls.Add(this.lblPrecioLente);
            this.Controls.Add(this.txtFolio);
            this.Controls.Add(this.lblFolio);
            this.Controls.Add(this.cbPagos);
            this.Controls.Add(this.lblPagos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AgregarPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarPago";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgregarPago_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPagos;
        private System.Windows.Forms.ComboBox cbPagos;
        private System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.Label lblPrecioLente;
        private System.Windows.Forms.TextBox txtPrecioLente;
        private System.Windows.Forms.Label lblAbono;
        private System.Windows.Forms.TextBox txtAbono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdDesplegar;
        private System.Windows.Forms.Button cmdAgregarPago;
        private System.Windows.Forms.Button cmdOtro;
        private System.Windows.Forms.Button cmdAtras;
    }
}