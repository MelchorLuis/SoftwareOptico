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
    public partial class Historial_de_pagos : Form
    {

        //Nueva forma
        Menu menu = new Menu();

        public Historial_de_pagos()
        {
            InitializeComponent();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            if (Usuario.Buscar(Convert.ToInt32(txtBusquedaPaciente.Text)) > 0)
            {
                MessageBox.Show("Se encontré al paciente");
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

        private void Historial_de_pagos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
    }
}
