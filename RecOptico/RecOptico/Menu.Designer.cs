﻿
namespace RecOptico
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.cmdAgenda = new System.Windows.Forms.Button();
            this.cmdHistorial = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.cmdPagos = new System.Windows.Forms.Button();
            this.cmdHistorialP = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCerarSesion = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.BackColor = System.Drawing.Color.AliceBlue;
            this.cmdAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAgregar.Location = new System.Drawing.Point(110, 96);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(113, 69);
            this.cmdAgregar.TabIndex = 2;
            this.cmdAgregar.Text = "Agregar paciente";
            this.cmdAgregar.UseVisualStyleBackColor = false;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // cmdAgenda
            // 
            this.cmdAgenda.BackColor = System.Drawing.Color.AliceBlue;
            this.cmdAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAgenda.Location = new System.Drawing.Point(299, 177);
            this.cmdAgenda.Name = "cmdAgenda";
            this.cmdAgenda.Size = new System.Drawing.Size(113, 69);
            this.cmdAgenda.TabIndex = 4;
            this.cmdAgenda.Text = "Agenda";
            this.cmdAgenda.UseVisualStyleBackColor = false;
            this.cmdAgenda.Click += new System.EventHandler(this.cmdAgenda_Click);
            // 
            // cmdHistorial
            // 
            this.cmdHistorial.BackColor = System.Drawing.Color.AliceBlue;
            this.cmdHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdHistorial.Location = new System.Drawing.Point(110, 178);
            this.cmdHistorial.Name = "cmdHistorial";
            this.cmdHistorial.Size = new System.Drawing.Size(113, 69);
            this.cmdHistorial.TabIndex = 5;
            this.cmdHistorial.Text = "Historial de pagos";
            this.cmdHistorial.UseVisualStyleBackColor = false;
            this.cmdHistorial.Click += new System.EventHandler(this.cmdHistorial_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(12, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 10;
            this.lblUsuario.Text = "Usuario:";
            // 
            // cmdPagos
            // 
            this.cmdPagos.BackColor = System.Drawing.Color.AliceBlue;
            this.cmdPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPagos.Location = new System.Drawing.Point(199, 269);
            this.cmdPagos.Name = "cmdPagos";
            this.cmdPagos.Size = new System.Drawing.Size(113, 69);
            this.cmdPagos.TabIndex = 12;
            this.cmdPagos.Text = "Pagos";
            this.cmdPagos.UseVisualStyleBackColor = false;
            this.cmdPagos.Click += new System.EventHandler(this.cmdPagos_Click);
            // 
            // cmdHistorialP
            // 
            this.cmdHistorialP.BackColor = System.Drawing.Color.AliceBlue;
            this.cmdHistorialP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdHistorialP.Location = new System.Drawing.Point(299, 96);
            this.cmdHistorialP.Name = "cmdHistorialP";
            this.cmdHistorialP.Size = new System.Drawing.Size(113, 69);
            this.cmdHistorialP.TabIndex = 14;
            this.cmdHistorialP.Text = "Historial de pacientes";
            this.cmdHistorialP.UseVisualStyleBackColor = false;
            this.cmdHistorialP.Click += new System.EventHandler(this.cmdHistorialP_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Pink;
            this.pictureBox7.Image = global::RecOptico.Properties.Resources.order_history;
            this.pictureBox7.Location = new System.Drawing.Point(238, 96);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(64, 69);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 15;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Pink;
            this.pictureBox6.Image = global::RecOptico.Properties.Resources.Imagenpago;
            this.pictureBox6.Location = new System.Drawing.Point(139, 269);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(64, 69);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Pink;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(238, 177);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(64, 69);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Pink;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(50, 178);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 69);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Pink;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(50, 96);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(333, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblCerarSesion
            // 
            this.lblCerarSesion.AutoSize = true;
            this.lblCerarSesion.LinkColor = System.Drawing.Color.Black;
            this.lblCerarSesion.Location = new System.Drawing.Point(12, 31);
            this.lblCerarSesion.Name = "lblCerarSesion";
            this.lblCerarSesion.Size = new System.Drawing.Size(80, 13);
            this.lblCerarSesion.TabIndex = 16;
            this.lblCerarSesion.TabStop = true;
            this.lblCerarSesion.Text = "¿Cerrar sesión?";
            this.lblCerarSesion.Click += new System.EventHandler(this.cmdLogOff_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(444, 357);
            this.Controls.Add(this.lblCerarSesion);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.cmdHistorialP);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.cmdPagos);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cmdHistorial);
            this.Controls.Add(this.cmdAgenda);
            this.Controls.Add(this.cmdAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.Button cmdAgenda;
        private System.Windows.Forms.Button cmdHistorial;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        public System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button cmdPagos;

        private System.Windows.Forms.Button cmdHistorialP;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.LinkLabel lblCerarSesion;
    }
}