﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace RecOptico
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
       

        private void cmdHistorial_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario();
            Historial_de_pagos Historial_Pagos = new Historial_de_pagos();

            Historial_Pagos.Show();
            this.Hide();

            Historial_Pagos.dtwHistorialPagos.DataSource = usu.MostrarPago();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            AgregarPaciente A = new AgregarPaciente();
            A.Show();
            this.Hide();
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            frmHistorial historial = new frmHistorial();
            historial.Show();
            this.Hide();
        }

        private void cmdAgenda_Click(object sender, EventArgs e)
        {
            Agendar Age = new Agendar();
            Age.Show();
            this.Hide();
        }

        private void cmdPagos_Click(object sender, EventArgs e)
        {
            AgregarPago pago = new AgregarPago();
            pago.Show();
            this.Hide();
        }
        private void cmdHistorialP_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario();
            frmHistorial Historial_Pacientes = new frmHistorial();

            Historial_Pacientes.Show();
            this.Hide();

            Historial_Pacientes.dtwHistorialPacientes.DataSource = usu.MostrarPacientes();
        }

        private void cmdLogOff_Click(object sender, EventArgs e)
        {
            frmLogin Login = new frmLogin();
            Login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calendario c = new Calendario();
            c.Show();

        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void cmdCalendario_Click(object sender, EventArgs e)
        {
            Calendario Cal = new Calendario();
            Cal.Show();
            this.Hide();
        }
    }
}
