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
    public partial class ModificarPaciente : Form
    {
        public ModificarPaciente()
        {
            InitializeComponent();
        }

        private void cmdAtras_Click(object sender, EventArgs e)
        {
            frmHistorial his = new frmHistorial();
            his.Show();
            this.Hide();

            Usuario usu = new Usuario();
            his.dtwHistorialPacientes.DataSource = usu.MostrarPacientes();
        }

        private void cmdActulizar_Click(object sender, EventArgs e)
        {
            if (txtNombres.Text != "" && txtApellidos.Text != "" && txtEdad.Text != "" && txtNumCel.Text != "" && txtCorreo.Text != "" && txtDireccion.Text != "")
            {
                Usuario.Actulizar(txtNombres.Text, txtApellidos.Text, txtEdad.Text, txtNumCel.Text, txtCorreo.Text, txtDireccion.Text, Convert.ToInt32(txtID.Text));
                MessageBox.Show("Actualizado correctamente");

                frmHistorial his = new frmHistorial();
                his.Show();
                this.Hide();

                Usuario usu = new Usuario();
                his.dtwHistorialPacientes.DataSource = usu.MostrarPacientes();
            }
            else
            {
                MessageBox.Show("Por favor de llenar todos los campos");
            }
        }
    }
}
