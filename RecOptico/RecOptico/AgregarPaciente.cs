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
    public partial class AgregarPaciente : Form
    {
        //Nueva forma
        Menu menu = new Menu();

        public AgregarPaciente()
        {
            InitializeComponent();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            frmExamen examen = new frmExamen();
            if(Usuario.DatosPaciente(txtNombres.Text,txtApellidos.Text,txtEdad.Text, txtNumCel.Text, txtCorreo.Text, txtDireccion.Text) > 0)
            {
                examen.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No se pudo añadir el paciente");
            }
        }

        private void cmdAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }

        private void AgregarPaciente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
    }
}
