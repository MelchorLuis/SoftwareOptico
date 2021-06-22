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
            if (txtBusquedaPaciente.Text != "")
            {
                if (Usuario.Modificar(Convert.ToInt32(txtBusquedaPaciente.Text)) == 0)
                {
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No se encontró al paciente");
                }
            }
            else
            {
                MessageBox.Show("Porfavor ingrese un folio");
            }
        }

        private void dtwHistorialPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void cmdEliminarPaciente_Click(object sender, EventArgs e)
        {
            if (txtBusquedaPaciente.Text != "")
            {
                    if (Usuario.Eliminar(Convert.ToInt32(txtBusquedaPaciente.Text)) > 0)
                    {
                        DialogResult dialogResult = MessageBox.Show("¿Desea elimar el registro?", "Eliminar paciente", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            MessageBox.Show("Se eliminó el paciente");

                            Usuario usu = new Usuario();
                            dtwHistorialPacientes.DataSource = usu.MostrarPacientes();
                            txtBusquedaPaciente.Text = "";
                            txtBusquedaPaciente.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el paciente");
                    }
            }
            else
            {
                MessageBox.Show("Porfavor ingrese un folio");
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
