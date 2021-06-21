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
    public partial class frmExamen : Form
    {
        public frmExamen()
        {
            InitializeComponent();
        }

        private void cmdConfirmar_Click(object sender, EventArgs e)
        {
            AgregarPaciente agregar = new AgregarPaciente();
            if (Usuario.Receta(txtEsfeDerLejos.Text, txtCilDerLejos.Text, txtEjeDerLejos.Text, txtEsfeIzqLejos.Text, txtCilIzqLejos.Text,
                    txtEjeIzqLejos.Text, txtEsfeDerCerca.Text, txtCilDerCerca.Text, txtEjeDerCerca.Text, txtEsfeIzqCerca.Text, txtCilIzqCerca.Text,
                    txtEjeIzqCerca.Text, txtDIP.Text, txtObservaciones.Text, agregar.txtNumCel.Text) > 0)
            {
                MessageBox.Show("El paciente y su examen fueron agregados");
            }
            else
            {
                MessageBox.Show("Hubo un error");
            }
        }
    }
}
