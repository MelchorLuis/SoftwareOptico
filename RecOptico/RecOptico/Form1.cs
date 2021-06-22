using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecOptico
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtContra.PasswordChar = '*';
        }

        private void cmdIngresar_Click(object sender, EventArgs e)
        {
            Agendar a = new Agendar();
            a.Show();
            
            if (Usuario.Autentificar(txtCorreo.Text, txtContra.Text) > 0)
            {
                Menu m = new Menu();
                m.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Cuenta no encontrada, favor de registrarse");
                label4.Visible = true;
                label5.Visible = true;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            RecuperarContraseña recu = new RecuperarContraseña();
            recu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registrarse Regi = new Registrarse();
            Regi.Show();
     
            this.Hide();
        }

     
    }
}
