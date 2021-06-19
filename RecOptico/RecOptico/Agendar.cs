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
            // Pacientes
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
            SqlCommand Com = new SqlCommand(string.Format("Select * from Usuarios"), Con);
            SqlDataAdapter da1 = new SqlDataAdapter(Comando);

            DataSet ds1 = new DataSet();

            da.Fill(ds, "Pacientes");

            foreach (DataRow row in ds1.Tables["Usuario"].Rows)
            {
                cbEncargado.Items.Add(row["Nombre_Usuario"].ToString());
            }

            // Hora
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            SqlConnection Con = DBComun.ObtenerConexion();
            SqlCommand Comando = new SqlCommand(string.Format("Insert Into Agenda (Paciente, Encargado, Hora, Fecha) values ('{0}','{1}','{2}','{3}')",cbPaciente.SelectedItem, cbEncargado.SelectedItem, cbHora.SelectedItem, 
                Calendario.SelectionRange.Start.ToShortDateString()), Con);
            Comando.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("Se guardo la cita");
        }
    }
}
