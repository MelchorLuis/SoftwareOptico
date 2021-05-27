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
            if(Usuario.DatosPaciente(txtNombres.Text,txtApellidos.Text,txtEdad.Text, txtNumCel.Text, txtCorreo.Text) > 0)
            {
                if(Usuario.Receta(txtEsfeDerLejos.Text, txtCilDerLejos.Text, txtEjeDerLejos.Text, txtEsfeIzqLejos.Text, txtCilIzqLejos.Text, txtEjeIzqLejos.Text,txtEsfeDerCerca.Text, txtCilDerCerca.Text, txtEjeDerCerca.Text, txtEsfeIzqCerca.Text, txtCilIzqCerca.Text, txtEjeIzqCerca.Text, txtDIP.Text, txtObservaciones.Text) > 0)
                {
                    MessageBox.Show("Paciente añadido con exito!");
                }
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
    }
}
