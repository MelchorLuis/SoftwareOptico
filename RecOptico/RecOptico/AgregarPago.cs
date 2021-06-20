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
    public partial class AgregarPago : Form
    {
        public AgregarPago()
        {
            InitializeComponent();
        }

        private void cmdDesplegar_Click(object sender, EventArgs e)
        {
            if(cbPagos.Text == "Añadir precio de lente")
            {
                lblFolio.Visible = true;
                txtFolio.Visible = true;
                lblPrecioLente.Visible = true;
                txtPrecioLente.Visible = true;
                lblMonto.Visible = false;
                txtMonto.Visible = false;
                lblAbono.Visible = false;
                txtAbono.Visible = false;
            }
            if(cbPagos.Text == "Contado")
            {
                lblFolio.Visible = true;
                txtFolio.Visible = true;
                lblPrecioLente.Visible = false;
                txtPrecioLente.Visible = false;
                lblMonto.Visible = true;
                txtMonto.Visible = true;
                lblAbono.Visible = false;
                txtAbono.Visible = false;
            }
            if(cbPagos.Text == "Abono")
            {
                lblFolio.Visible = true;
                txtFolio.Visible = true;
                lblPrecioLente.Visible = false;
                txtPrecioLente.Visible = false;
                lblMonto.Visible = false;
                txtMonto.Visible = false;
                lblAbono.Visible = true;
                txtAbono.Visible = true;
            }
        }
    }
}
