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
    public partial class Agendar : Form
    {
        public Agendar()
        {
            InitializeComponent();
            SqlConnection Con = DBComun.ObtenerConexion();
            SqlCommand Comando = new SqlCommand(string.Format("Select * from Pacientes"), Con);
            SqlDataAdapter da = new SqlDataAdapter(Comando);

            DataSet ds = new DataSet();

            da.Fill(ds, "Pacientes");

            foreach (DataRow row in ds.Tables["Pacientes"].Rows)
            {
                cbPaciente.Items.Add(row["Nombre_Pacientes"].ToString());
            }

            // Encargados
            SqlCommand Com = new SqlCommand(string.Format("Select * from Usuario"), Con);
            SqlDataAdapter da1 = new SqlDataAdapter(Com);

            DataSet ds1 = new DataSet();

            da1.Fill(ds1, "Usuario");

            foreach (DataRow row in ds1.Tables["Usuario"].Rows)
            {
                cbEncargado.Items.Add(row["Nombre_Usuario"].ToString());
            }


            Con.Close();
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            if (cbHora.Text != "" && cbEncargado.Text != "" && cbPaciente.Text != "" && txtTelefono.Text != "" && txtProcedimiento.Text != "")
            {
                string fecha = Calendario.SelectionStart.Date.ToString("yyyy-MM-dd");

                SqlConnection Con = DBComun.ObtenerConexion();
                SqlCommand Comando = new SqlCommand(string.Format("Update Horas SET Nombre_Pac='{0}', Telefono_Pac = '{1}', Nombre_Enc= '{2}', Hora='{3}', Procedimiento= '{4}' where Fecha='{5}' and Hora='{3}'", cbPaciente.SelectedItem, txtTelefono.Text, cbEncargado.SelectedItem, cbHora.SelectedItem, txtProcedimiento.Text, fecha), Con);
                Comando.ExecuteNonQuery();
                Con.Close();
                cbHora.Items.Clear();
                Calendario.Enabled = true;
                MessageBox.Show("Se guardo la cita");
            }
            else
            {
                MessageBox.Show("Por favor llenar todos los campos");
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Con = DBComun.ObtenerConexion();
            string fecha = Calendario.SelectionStart.Date.ToString("yyyy-MM-dd");

            SqlCommand Coma = new SqlCommand(string.Format("Select * from Horas "), Con);
            SqlDataAdapter da2 = new SqlDataAdapter(Coma);

            DataSet ds2 = new DataSet();

            da2.Fill(ds2, "Horas");
            string repetido = "", bo = "";
            foreach (DataRow row in ds2.Tables["Horas"].Rows)
            {
                repetido = Convert.ToDateTime(row["Fecha"]).ToString("yyyy-MM-dd");

                if (repetido == fecha)
                {
                    bo = "si";
                    break;
                }

            }
            if (bo == "")
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into Agenda (Fecha) values ('{0}')", fecha), Con);
                Comando.ExecuteNonQuery();
            }
            Con.Close();
            cbEncargado.Visible = true;
            cbPaciente.Visible = true;
            cbHora.Visible = true;
            txtTelefono.Visible = true;
            txtProcedimiento.Visible = true;
            lblEncargado.Visible = true;
            lblHora.Visible = true;
            lblPaciente.Visible = true;
            lblProcedimiento.Visible = true;
            label2.Visible = true;
            button1.Visible = true;
            cmdRegistrar.Visible = true;
            Calendario.Enabled = false;
            Hora();
        }


        void Hora()
        {
            SqlConnection Con = DBComun.ObtenerConexion();

            string fecha = Calendario.SelectionStart.Date.ToString("yyyy-MM-dd");
            // Hora
            SqlCommand Coma = new SqlCommand(string.Format("Select * from Horas where Fecha='{0}' and disponible is NULL", fecha), Con);
            SqlDataAdapter da2 = new SqlDataAdapter(Coma);

            DataSet ds2 = new DataSet();

            da2.Fill(ds2, "Horas");

            foreach (DataRow row in ds2.Tables["Horas"].Rows)
            {
                cbHora.Items.Add(row["Hora"].ToString());
            }
            Con.Close();
        }

        private void Agendar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void cmdAtras_Click(object sender, EventArgs e)
        {
            Menu men = new Menu();
            men.Show();
            this.Hide();
        }
    }
}
