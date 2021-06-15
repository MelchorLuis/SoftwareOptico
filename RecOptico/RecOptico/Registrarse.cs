using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RecOptico
{
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();
        }
        //Nueva forma
        frmLogin Log = new frmLogin();

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellidos.Text == "")
            {
                MessageBox.Show("Ingrese minimo un nombre y apellido, por favor");
            }
            else
            {
                if (Correo(txtCorreo.Text) == true)
                {
                    if (txtContrasenaRegistrarse.Text == "")
                    {
                        MessageBox.Show("Ingrese contraseña, por favor");
                        txtContrasenaRegistrarse.Focus();
                    }
                    else
                    {
                        if (txtContrasenaRegistrarse.Text == txtContrasenaConfirmar.Text)
                        {

                            if (Usuario.CrearCuenta(txtNombre.Text, txtApellidos.Text, date.Value.ToString("yyyyMMdd"), cmbSexo.Text, txtCorreo.Text, txtContrasenaRegistrarse.Text) > 0)
                            {
                                MessageBox.Show("Cuenta creada con éxito!");
                                frmLogin Login = new frmLogin();
                                this.Close();
                                Login.Show();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo crear cuenta", "Error");
                            }
                        }
                        else if (txtContrasenaRegistrarse.Text != txtContrasenaConfirmar.Text)
                        {
                            MessageBox.Show("La contraseña no coincide", "Error");
                            txtContrasenaRegistrarse.Clear();
                            txtContrasenaConfirmar.Clear();
                            txtContrasenaRegistrarse.Focus();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Correo no válido", "Error");
                    txtCorreo.Clear();
                    txtCorreo.Focus();
                }
            }
        }

        private Boolean Correo(string email)
        {
            string expresion;
            expresion = @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Log.Show();
        }
    }
}
