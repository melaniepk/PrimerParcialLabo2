using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

namespace GestionBar
{
    public partial class CerrarVenta : Form
    {
        Mesa MesaCobrada = new Mesa();
        double recargo;

        public CerrarVenta()
        {
            InitializeComponent();            
        }

        public CerrarVenta(Mesa mesa):this()
        {
            MesaCobrada= mesa;
            lblMesaNro.Text = $"Nro de mesa: {MesaCobrada.numeroMesa}";                 
        }

        private void CerrarVenta_Load(object sender, EventArgs e)
        {
            CargarComboBoxes();           
            lblTotalNro.Text = MesaCobrada.total.ToString();
        }

        /// <summary>
        /// carga los items en la comboBox
        /// </summary>
        public void CargarComboBoxes()
        {
            cmbPago.Items.Add("Efectivo");
            cmbPago.Items.Add("Mercado Pago");
            cmbPago.Items.Add("Tarjeta de debito");
            cmbPago.Items.Add("Tarjeta de credito");

        }
        /// <summary>
        /// reproduce un sonido 
        /// comprueba que el item seleccionado y el importe no sean nulos.
        /// si el item seleccionado es tarjeta de credito, realiza una recarga 
        /// al total de la mesa y llama a la funcion cobrar.
        /// en caso contrario, solo llama a la funcion cobrar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCobrar_Click(object sender, EventArgs e)
        {
            playSimpleSoundCobrar();
            if (cmbPago.SelectedItem != null && tbxImporte != null)
            {
                if (cmbPago.SelectedItem.ToString() == "Tarjeta de credito")
                {
                    recargo = (MesaCobrada.total * 10 / 100);

                    MesaCobrada.total += recargo;
                    lblTotalNro.Text = MesaCobrada.total.ToString();
                    Cobrar();

                }
                else
                {
                    lblTotalNro.Text = MesaCobrada.total.ToString();
                    Cobrar();
                }                               
            }
            else
            {
                MessageBox.Show("Faltan datos", "ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// convierte los valores del importe y el total a numeros, realiza una verifiacion 
        /// e imprime en la label de vuelto el vuelto correspondiente. ademas de desabilitar el boton de Cobrar si la
        /// operacion se realiza con exito.
        /// en caso de error, se reproduce un sonido y se muestra una MessageBox, 
        /// y se vuelve al precio original sin el recargo en caso de que el medio
        /// de pago sea tarjeta de credito
        /// </summary>
        private void Cobrar()
        {
            double.TryParse(tbxImporte.Text, out double importe);
            double.TryParse(lblTotalNro.Text, out double total);
            if (importe > 0 && total >= 0 && importe > total)
            {
                double vuelto = importe - total;
                lblVueltoNro.Text = vuelto.ToString();
                btnCobrar.Enabled = false;
            }
            else
            {
                playSimpleSoundError();
                MessageBox.Show("Importe erroneo ", "ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (cmbPago.SelectedItem.ToString() == "Tarjeta de credito")
                {
                    MesaCobrada.total -= recargo;
                    lblTotalNro.Text = MesaCobrada.total.ToString();
                }
            }
        }

        /// <summary>
        /// si esta marcado como chequeado, le agrega un 10% al total de la mesa 
        /// y lo imprime en el label 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            
            this.Hide();
        }

        /// <summary>
        /// reproduce un sonido 
        /// </summary>
        private void playSimpleSoundCobrar()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\mkale\source\repos\PrimerParcialLabo2\GestionBar\Properties\audioParaCaja.wav");
            simpleSound.Play();
        }

        /// <summary>
        /// 
        /// reproduce un sonido de error
        /// </summary>
        private void playSimpleSoundError()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\mkale\source\repos\PrimerParcialLabo2\GestionBar\Properties\audioError.wav");
            simpleSound.Play();
        }
    }
}
