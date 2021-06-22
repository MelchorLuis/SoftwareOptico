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
    public partial class frmHistorial : Form
    {
        //Nueva forma
        Menu menu = new Menu();

        public frmHistorial()
        {
            InitializeComponent();
        }

        private void frmHistorial_Load(object sender, EventArgs e)
        {

        }

        private void cmdModificarPaciente_Click(object sender, EventArgs e)
        {

        }

        private void dtwHistorialPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void cmdEliminarPaciente_Click(object sender, EventArgs e)
        {
            if(Usuario.Eliminar(Convert.ToInt32(txtBusquedaPaciente.Text)) > 0)
            {
                MessageBox.Show("Se eliminó el paciente");
            }
            else
            {
                MessageBox.Show("No se encontró el paciente");
            }
        }

        private void cmdAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }

        private void frmHistorial_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
    }
}
