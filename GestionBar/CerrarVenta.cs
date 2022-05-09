using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

namespace GestionBar
{
    public partial class CerrarVenta : Form
    {
        Mesa MesaCobrada = new Mesa();
        public CerrarVenta()
        {
            InitializeComponent();
            
        }

        public CerrarVenta(Mesa mesa):this()
        {
            MesaCobrada= mesa;
            lblMesaNro.Text = $"Nro de mesa: {MesaCobrada.numeroMesa}";
            lblVendedor.Text = $"Vendedor: {MesaCobrada.vendedor}";

        }
        private void CerrarVenta_Load(object sender, EventArgs e)
        {
            CargarComboBoxes();           
            lblTotalNro.Text = MesaCobrada.total.ToString();
        }
        public void CargarComboBoxes()
        {
            cmbPago.Items.Add("Efectivo");
            cmbPago.Items.Add("Mercado Pago");
            cmbPago.Items.Add("Tarjeta de debito");
            cmbPago.Items.Add("Tarjeta de credito");

        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (cmbPago.SelectedItem != null && tbxImporte != null)
            {
                lblTotalNro.Text = MesaCobrada.total.ToString();
                double.TryParse(tbxImporte.Text, out double importe);
                double.TryParse(lblTotalNro.Text, out double total);
                double vuelto = importe - total;
                lblVueltoNro.Text = vuelto.ToString();
                btnCobrar.Enabled = false;
            }

        }

        private void ckbEstacionamiento_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbEstacionamiento.Checked)
            {
                MesaCobrada.total += (MesaCobrada.total * 10) / 100;
                lblTotalNro.Text = MesaCobrada.total.ToString();
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            // AdministracionLocal frmAdminLocal = new AdministracionLocal(MesaCobrada);
            
            this.Hide();

            //if (frmAdminLocal.mesas.Length > 0)
            //{
            //    foreach(Mesa mesa in frmAdminLocal.mesas)
            //    {
            //        if(MesaCobrada.id == mesa.id)
            //        {
            //            mesa.estaLibre = true;

            //        }
            //    }
            //}
        }
    }
}
