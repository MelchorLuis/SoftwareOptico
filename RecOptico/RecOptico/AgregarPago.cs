﻿using System;
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
    public partial class AgregarPago : Form
    {
        public AgregarPago()
        {
            InitializeComponent();
        }

        private void cmdDesplegar_Click(object sender, EventArgs e)
        {
            if (cbPagos.Text == "Añadir precio de lente")
            {
                lblFolio.Visible = true;
                txtFolio.Visible = true;
                lblPrecioLente.Visible = true;
                txtPrecioLente.Visible = true;
                lblAbono.Visible = false;
                txtAbono.Visible = false;
                cmdAgregarPago.Text = "Agregar precio";
            }
            if (cbPagos.Text == "Abono")
            {
                lblFolio.Visible = true;
                txtFolio.Visible = true;
                lblPrecioLente.Visible = false;
                txtPrecioLente.Visible = false;
                lblAbono.Visible = true;
                txtAbono.Visible = true;
                cmdAgregarPago.Text = "Agregar pago";
            }
            cbPagos.Enabled = false;
            cmdOtro.Visible = true;
            cmdDesplegar.Visible = false;
            cmdAgregarPago.Visible = true;
        }

        private void AgregarPago_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void cmdAgregarPago_Click(object sender, EventArgs e)
        {
            if (cbPagos.Text == "Añadir precio de lente")
            {
                if (txtFolio.Text != "" && txtPrecioLente.Text != "")
                {
                    if (Usuario.Existe(txtFolio.Text) > 0)
                    {
                        if (Usuario.TotalLente(Convert.ToInt32(txtFolio.Text), Convert.ToDecimal(txtPrecioLente.Text)) > 0)
                        {
                            MessageBox.Show("El costo del lente fue registrado");
                        }
                        else
                        {
                            MessageBox.Show("El costo del lente no fue registrado");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Folio no encontrado");
                    }
                }
                else
                {
                    MessageBox.Show("Profavor llene los dos campos necesarios");
                }
            }
            /*--*/
            if (cbPagos.Text == "Abono")
            {
                if (txtFolio.Text != "" && txtAbono.Text != "")
                {
                    if (Usuario.ExisteAbono(txtFolio.Text) > 0)
                    {
                        if (Usuario.PalAbono(Convert.ToInt32(txtFolio.Text), Convert.ToDecimal(txtAbono.Text)) > 0)
                        {
                            MessageBox.Show("El abono fue actualizado con exito");
                        }
                        else
                        {
                            MessageBox.Show("El abono no fue actualizado");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Folio no registrado");
                    }
                }
                else
                {
                    MessageBox.Show("Profavor llene los dos campos necesarios");
                }
            }
        }

        private void cmdOtro_Click(object sender, EventArgs e)
        {
            cbPagos.Enabled = true;
            cmdOtro.Visible = false;
            cmdDesplegar.Visible = true;
            lblFolio.Visible = false;
            txtFolio.Visible = false;
            lblPrecioLente.Visible = false;
            txtPrecioLente.Visible = false;
            lblAbono.Visible = false;
            txtAbono.Visible = false;
            cmdAgregarPago.Visible = false;
        }

        private void cmdAtras_Click(object sender, EventArgs e)
        {
            Menu men = new Menu();
            men.Show();
            this.Hide();
        }
    }
}
