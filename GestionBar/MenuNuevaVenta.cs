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
    public partial class MenuNuevaVenta : Form
    {
        public List<Bebida> bebidas;
        public List<Comida> comidas;
        public Mesa nuevaMesa = new Mesa();
        //public List<Menu> productos;
        //Usuario usuario = new Usuario();
        public MenuNuevaVenta()
        {
            InitializeComponent();
        }

        public MenuNuevaVenta(KeyValuePair<int, Button> item, Usuario usuario):this()
        {
            bool esBarra = false;
            if (item.Key >= 16)
            {
                esBarra = true;
            }
            nuevaMesa = new Mesa(false, item.Key, esBarra);
            Int32.TryParse(lblTotal.Text, out int total);
            nuevaMesa.total = total;
            if (item.Value.BackColor != Color.Tomato)
            {
                item.Value.BackColor = Color.Tomato;
            }
            else
            {
                item.Value.BackColor = Color.Green;
            }
            lblNroMesa.Text = ($"N° de Mesa :{item.Key}");
            lblVendedor.Text = ($"Vendedor :{usuario.Nombre.ToString()}");
            if (esBarra)
            {
                cmbComidas.Enabled = false;
                cmbTamanioComi.Enabled = false;
            }
            nuevaMesa.vendedor = usuario;

        }
        private void MenuNuevaVenta_Load(object sender, EventArgs e)
        {
            
            comidas = new List<Comida>(Local.CrearInventarioComida());
            bebidas = new List<Bebida>(Local.CrearInventarioBebida());
            //productos = new List<Menu>(Local.CrearInventarioComida());
            
            this.CargarComboBoxes(comidas,bebidas);
            //rtbPedido.Text = nuevaMesa.pedidoBeb.ToString();
            //rtbPedido.Text = nuevaMesa.pedidoCom.ToString();
           // lblTotal.Text = nuevaMesa.total.ToString();
            lblTotal.Text = lblTotal.Text.Trim();

        }


        //private void cmbTamanioBebi_SelectedIndexChanged(object sender, EventArgs e)
        //{
            

        //}

        public void CargarComboBoxes(List<Comida> comidas, List<Bebida> bebidas)
        {
            foreach (Comida com in comidas)
            {
                cmbComidas.Items.Add(com.Nombre.ToString());
            }
            cmbComidas.Items.Add(" ");

            foreach (Bebida bebida in bebidas)
            {
                cmbBebidas.Items.Add(bebida.Nombre.ToString());
            }
            cmbBebidas.Items.Add(" ");

            cmbTamanioBebi.Items.Add(Menu.Etamanio.Lata.ToString());
            cmbTamanioBebi.Items.Add(Menu.Etamanio.Botella.ToString());
            cmbTamanioBebi.Items.Add(Menu.Etamanio.Vaso.ToString());

            cmbTamanioComi.Items.Add(Menu.Etamanio.Chico.ToString());
            cmbTamanioComi.Items.Add(Menu.Etamanio.Mediano.ToString());
            cmbTamanioComi.Items.Add(Menu.Etamanio.Grande.ToString());



        }

        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {
           
            double total = this.SumarTotal();
            lblTotal.Text = total.ToString();
            nuevaMesa.total = total;

        }

        public double SumarTotal()
        {
            double total;
            
           if(Double.TryParse(lblTotal.Text, out double suma))
            {
                total = suma;
            }
           else
            {
                total = 0;
            }

            suma = this.AgregarElem();
            if (suma != 0)
            {
                total = suma + total;
            }
            return total;

        }
        public double AgregarElem()
        {
            Bebida pedidoBebida;
            Comida pedidoComida;
            double precioComida = 0;
            double precioBebida = 0;

            foreach (Bebida bebida in bebidas)
            {
                if (bebida != null && cmbBebidas.SelectedItem != null)
                {
                    if (cmbBebidas.SelectedItem.ToString() == bebida.Nombre.ToString() && bebida.CantidadStock > 0 && bebida != null
                        && cmbTamanioBebi != null)
                    {
                        rtbPedido.Text = bebida.MostrarProducto();
                        int n = dgvPedido.Rows.Add();
                        dgvPedido.Rows[n].Cells[0].Value = bebida.Nombre.ToString();
                        dgvPedido.Rows[n].Cells[1].Value = bebida.CantidadAComprar.ToString();
                        dgvPedido.Rows[n].Cells[2].Value = cmbTamanioBebi.SelectedItem.ToString();
                        dgvPedido.Rows[n].Cells[3].Value = bebida.Precio.ToString();

                        pedidoBebida = bebida;
                        nuevaMesa.pedidoBeb.Add(pedidoBebida);
                        precioBebida += bebida.Precio;

                    }
                }
                else
                {
                    rtbPedido.Text = "El stock no es suficiente para agregar el producto ";
                }
            }


            foreach (Comida com in comidas)
            {
                if (com != null && cmbComidas.SelectedItem != null)
                {
                    if (nuevaMesa.esBarra == false && cmbComidas.SelectedItem.ToString() == com.Nombre.ToString()
                        && com.CantidadStock > 0 && com != null
                        && cmbTamanioComi != null)
                    {
                        rtbPedido.Text = com.MostrarProducto();
                        int n = dgvPedido.Rows.Add();
                        dgvPedido.Rows[n].Cells[0].Value = com.Nombre.ToString();
                        dgvPedido.Rows[n].Cells[1].Value = com.CantidadAComprar.ToString();
                        dgvPedido.Rows[n].Cells[2].Value = cmbTamanioComi.SelectedItem.ToString();
                        dgvPedido.Rows[n].Cells[3].Value = com.Precio.ToString();
                        pedidoComida = com;
                        nuevaMesa.pedidoCom.Add(pedidoComida);
                        com.CantidadStock--;
                        precioComida += com.Precio;
                        
                    }
                }
                else
                {
                    rtbPedido.Text = " ";
                }
            }
            //nuevaMesa.AgregarPedido(Bebida)(cmbBebidas.SelectedItem);

            return (precioComida + precioBebida);
            
            

        }

        private void btnCerrarVenta_Click(object sender, EventArgs e)
        {
            
            CerrarVenta frmCerrarVenta = new CerrarVenta(nuevaMesa);
            frmCerrarVenta.ShowDialog();
            nuevaMesa.estaLibre = true;
            Local.EstadoMesas();
            AdministracionLocal frmAdmLocal = new AdministracionLocal(nuevaMesa.vendedor);
            frmAdmLocal.Show();
           
            
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            string mensaje = "Seguro de querer salir?";
            string titulo = "Cerrar";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mensaje, titulo, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            
           
        }

        //private void lblTotaltxt_Click(object sender, EventArgs e)
        //{

        //}

        //private void panel2_Paint(object sender, PaintEventArgs e)
        //{

        //}
    }
}