using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace RecOptico
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
       

        private void cmdHistorial_Click(object sender, EventArgs e)
        {

        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            AgregarPaciente A = new AgregarPaciente();
            A.Show();
            this.Hide();
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            frmHistorial historial = new frmHistorial();
            historial.Show();
            this.Hide();
        }

        private void cmdAgenda_Click(object sender, EventArgs e)
        {
            Agendar Age = new Agendar();
            Age.Show();
        }

        private void cmdPagos_Click(object sender, EventArgs e)
        {
            AgregarPago pago = new AgregarPago();
            pago.Show();
            this.Hide();
        }

        private void cmdHistorialP_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario();
            frmHistorial Historial_Pacientes = new frmHistorial();

            Historial_Pacientes.Show();
            this.Hide();

            Historial_Pacientes.dtwHistorialPacientes.DataSource = usu.MostrarPacientes();
        }

        private void cmdLogOff_Click(object sender, EventArgs e)
        {
            frmLogin Login = new frmLogin();
            Login.Show();
            this.Hide();
        }
    }
}
