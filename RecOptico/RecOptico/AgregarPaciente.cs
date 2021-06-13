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
            if(Usuario.DatosPaciente(txtNombres.Text,txtApellidos.Text,txtEdad.Text, txtNumCel.Text, txtCorreo.Text, txtDireccion.Text) > 0)
            {
                if(Usuario.Receta(System.Decimal.Parse(txtEsfeDerLejos.Text), System.Decimal.Parse(txtCilDerLejos.Text), System.Decimal.Parse(txtEjeDerLejos.Text), System.Decimal.Parse(txtEsfeIzqLejos.Text), System.Decimal.Parse(txtCilIzqLejos.Text), 
                    System.Decimal.Parse(txtEjeIzqLejos.Text), System.Decimal.Parse(txtEsfeDerCerca.Text), System.Decimal.Parse(txtCilDerCerca.Text), System.Decimal.Parse(txtEjeDerCerca.Text), System.Decimal.Parse(txtEsfeIzqCerca.Text), System.Decimal.Parse(txtCilIzqCerca.Text), 
                    System.Decimal.Parse(txtEjeIzqCerca.Text), System.Decimal.Parse(txtDIP.Text), txtObservaciones.Text) > 0)
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
