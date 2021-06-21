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
            SqlConnection Con = DBComun.ObtenerConexion();
            SqlCommand Comando = new SqlCommand(string.Format("Insert Into Agenda (Nombre_Pac, Telefono_Pac, Nombre_Enc, Hora, Fecha) values ('{0}','{1}','{2}','{3}',{4})",cbPaciente.SelectedItem,txtTelefono.Text, cbEncargado.SelectedItem, cbHora.SelectedItem, 
                Calendario.SelectionRange.Start.ToShortDateString()), Con);
            Comando.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("Se guardo la cita");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Con = DBComun.ObtenerConexion();
            string fecha = Calendario.SelectionStart.Date.ToString("yyyy-MM-dd");
            SqlCommand cmd = new SqlCommand(string.Format("Select * from Agenda where Fecha={0}",fecha), Con);
            cmd.Parameters.AddWithValue("Fecha", fecha);

            int count = Convert.ToInt32(cmd.ExecuteReader());
            if (count < 0) 
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into Agenda (Fecha) values ('{0}')", fecha), Con);
                Comando.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("Se guardo la cita");
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
                Hora();
            }
        }

        void Hora() 
        {
            SqlConnection Con = DBComun.ObtenerConexion();

            
            // Hora
            SqlCommand Coma = new SqlCommand(string.Format("Select * from Horas,Agenda where Agenda.Id_Calendario " +
                "= Horas.ID_Calendario and disponible=null"), Con);
            SqlDataAdapter da2 = new SqlDataAdapter(Coma);

            DataSet ds2 = new DataSet();

            da2.Fill(ds2, "Horas");

            foreach (DataRow row in ds2.Tables["Horas"].Rows)
            {
                cbHora.Items.Add(row["Hora"].ToString());
            }
            Con.Close();
        }
    }
}
