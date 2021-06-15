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
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-MO6T4C3\\SQLEXPRESS; Integrated Security = SSPI; Initial Catalog = Proyecto");

        private void cmdVerificar_Click(object sender, EventArgs e)
        {
            conexion.Open();

            //Instancia para la alta
            SqlCommand consulta = new SqlCommand("select Nombre_Usuario, Contrasena_Usuario from Usuario where Correo_Usuario = @email", conexion);



            consulta.Parameters.AddWithValue("@email", txtCorreo.Text);
            SqlDataReader reader = consulta.ExecuteReader();

            string Usuario = "";
            string Contra = "";
            while (reader.Read())
            {
                Usuario = reader.GetString(0);
                Contra = reader.GetString(1);



            }
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
            msg.To.Add(txtCorreo.Text); // Destinatario msg.To.Add(txtCorreo)
            msg.Subject = "Recuperación de contraseña"; // Asunto
            msg.SubjectEncoding = System.Text.Encoding.UTF8;

            msg.Body = "Usuario: " + Usuario + "    \n\n\r    " + "Contraseña: " + Contra; // Cuerpo del mensaje  
            msg.BodyEncoding = System.Text.Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.From = new System.Net.Mail.MailAddress("poptometria@gmail.com"); // Remitente

            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();

            cliente.Credentials = new System.Net.NetworkCredential("poptometria@gmail.com", "Melcan00"); // Credenciales del remitente (Usuario, Contraseña)

            cliente.Port = 587;
            cliente.EnableSsl = true;

            cliente.Host = "smtp.gmail.com";
            try
            {
                cliente.Send(msg);
                MessageBox.Show("Se enviaron sus datos al correo "+txtCorreo.Text);
                conexion.Close();
            }
            catch
            {
                MessageBox.Show("El correo no existe");
                conexion.Close();
            }

        }
    }
}
