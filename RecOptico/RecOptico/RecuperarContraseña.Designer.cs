
namespace RecOptico
{
    partial class RecuperarContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecuperarContraseña));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdAtras = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdCambiar = new System.Windows.Forms.Button();
            this.cmdVerificar = new System.Windows.Forms.Button();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.cmdAtras);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmdCambiar);
            this.panel1.Controls.Add(this.cmdVerificar);
            this.panel1.Controls.Add(this.txtOldPass);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtConfirmPass);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNewPass);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCorreo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 482);
            this.panel1.TabIndex = 4;
            // 
            // cmdAtras
            // 
            this.cmdAtras.Location = new System.Drawing.Point(214, 405);
            this.cmdAtras.Name = "cmdAtras";
            this.cmdAtras.Size = new System.Drawing.Size(121, 23);
            this.cmdAtras.TabIndex = 19;
            this.cmdAtras.Text = "Atras";
            this.cmdAtras.UseVisualStyleBackColor = true;
            this.cmdAtras.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(299, 35);
            this.label5.TabIndex = 18;
            this.label5.Text = "Restablecer contraseña";
            // 
            // cmdCambiar
            // 
            this.cmdCambiar.Location = new System.Drawing.Point(42, 405);
            this.cmdCambiar.Name = "cmdCambiar";
            this.cmdCambiar.Size = new System.Drawing.Size(121, 23);
            this.cmdCambiar.TabIndex = 17;
            this.cmdCambiar.Text = "Cambiar contraseña";
            this.cmdCambiar.UseVisualStyleBackColor = true;
            this.cmdCambiar.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmdVerificar
            // 
            this.cmdVerificar.Location = new System.Drawing.Point(128, 160);
            this.cmdVerificar.Name = "cmdVerificar";
            this.cmdVerificar.Size = new System.Drawing.Size(100, 23);
            this.cmdVerificar.TabIndex = 16;
            this.cmdVerificar.Text = "Verificar correo";
            this.cmdVerificar.UseVisualStyleBackColor = true;
            this.cmdVerificar.Click += new System.EventHandler(this.cmdVerificar_Click);
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(20, 224);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Size = new System.Drawing.Size(335, 20);
            this.txtOldPass.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Contraseña antigua";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(19, 348);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(335, 20);
            this.txtConfirmPass.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Confirmar contraseña";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(20, 285);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(335, 20);
            this.txtNewPass.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nueva contraseña";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(20, 134);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(335, 20);
            this.txtCorreo.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Correo electrónico";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(430, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 254);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // RecuperarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 472);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "RecuperarContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecuperarContraseña";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdCambiar;
        private System.Windows.Forms.Button cmdVerificar;
        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdAtras;
    }
}