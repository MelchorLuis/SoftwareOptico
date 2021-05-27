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
    public partial class RecuperarContraseña : Form
    {
        public RecuperarContraseña()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            this.Close();
            f.Show();
        
        }

        private void cmdVerificar_Click(object sender, EventArgs e)
        {
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();

            msg.To.Add(txtCorreo.Text);
            msg.Subject = "Recuperación de contraseña";
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
            msg.Bcc.Add("poptometria@gmail.com");

            msg.Body = Usuario.ValidarCorreo(txtCorreo.Text);
            msg.BodyEncoding = System.Text.Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.From = new System.Net.Mail.MailAddress("poptometria@gmail.com");

            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();

            cliente.Credentials = new System.Net.NetworkCredential("poptometria@gmail.com", "Melcan00");

            cliente.Port = 587;
            cliente.EnableSsl = true;

            cliente.Host = "smtp.gmail.com";

            try
            {
                cliente.Send(msg);
            }
            catch
            {
                MessageBox.Show("Error al enviar");
            }
        }
    }
}
