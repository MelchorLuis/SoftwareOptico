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
    public partial class Calendario : Form
    {
        public Calendario()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            SqlConnection Con = DBComun.ObtenerConexion();
            string fecha = monthCalendar1.SelectionStart.Date.ToString("yyyy-MM-dd");
            SqlCommand Comando = new SqlCommand(string.Format("Select Agenda.Id_Calendario, Agenda.Nombre_Pac as 'Nombre del paciente', Agenda.Telefono_Pac as 'Telefono', Agenda.Nombre_Enc as 'Encargado', Agenda.Fecha as 'Fecha', Agenda.Hora from Agenda,Horas where Agenda.Id_Calendario = Horas.ID_Calendario" +
                " and Agenda.Fecha='{0}'", fecha), Con);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = Comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            Con.Close();
        }
    }
}
