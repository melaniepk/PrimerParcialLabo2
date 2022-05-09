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
        public MenuNuevaVenta()
        {
            InitializeComponent();
        }

        public MenuNuevaVenta(Mesa mesa):this()
        {
            lblNroMesa.Text = ($"N° de Mesa :{mesa.numeroMesa}");
            lblVendedor.Text = ($"Vendedor :{mesa.vendedor}");
            if(mesa.esBarra == true)
            {
                cmbComidas.Enabled = false;
                cmbTamanioComi.Enabled = false;
            }
            mesa.AgregarPedido((Bebida)cmbBebidas.SelectedItem,(Comida)cmbComidas.SelectedItem);
            nuevaMesa = mesa;
        }
        private void MenuNuevaVenta_Load(object sender, EventArgs e)
        {
            comidas = new List<Comida>();
            bebidas = new List<Bebida>();
            bebidas = this.CargarBebidas(bebidas);
            comidas = this.CargarComidas(comidas);
            this.CargarComboBoxes(comidas,bebidas);
            
        }



        public List<Comida> CargarComidas(List<Comida> comidas)
        {
            Comida comida1 = new Comida("Papas con Cheddar",400,false,500,15,1);
            Comida comida2 = new Comida("Hamburguesa Especial",800, true,800, 15, 1);
            Comida comida3 = new Comida("Hambuguesa Clasica", 850, true, 850, 15, 1);
            Comida comida4 = new Comida("Nuggets de Pollo", 450, false, 560, 15, 1);
            Comida comida5 = new Comida("Sticks de Muzzarella",560, true, 600, 15, 1);
            Comida comida6 = new Comida("Pizza individual Napolitana", 600, true,700, 15, 1);
            Comida comida7 = new Comida("Pizza individual Muzzarella", 550, true, 700, 15, 1);
            Comida comida8 = new Comida("Nachos con cheddar", 360, true, 450, 15, 1);
            Comida comida9 = new Comida("Ensalada Caesar", 280, false, 500, 15, 1);
            Comida comida10 = new Comida("Ensalada Completa", 380, false, 600, 15, 1);
            Comida comida11 = new Comida("Picada para 3", 1200, true, 1500, 15, 1);
            Comida comida12 = new Comida("Brownie con Helado", 500, false, 500, 15, 1);

            comidas.Add(comida1);
            comidas.Add(comida2);
            comidas.Add(comida3);
            comidas.Add(comida4);
            comidas.Add(comida5);
            comidas.Add(comida6);
            comidas.Add(comida7);
            comidas.Add(comida8);
            comidas.Add(comida9);
            comidas.Add(comida10);
            comidas.Add(comida11);
            comidas.Add(comida12);
            return comidas;

        }
        public List<Bebida> CargarBebidas(List<Bebida> bebidas)
        {

            Bebida bebida1 = new Bebida("Cerveza Honey", true, 300, 30, 1);
            Bebida bebida2 = new Bebida("Cerveza IPA", true, 300, 30, 1);
            Bebida bebida3 = new Bebida("Cerveza Brahma", true, 250, 30, 1);
            Bebida bebida4 = new Bebida("Fernet", true, 400, 30, 1);
            Bebida bebida5 = new Bebida("Gin tonic", true, 450, 30, 1);
            Bebida bebida6 = new Bebida("Gancia", true, 350, 30, 1);
            Bebida bebida7 = new Bebida("Margarita", true, 500, 30, 1);
            Bebida bebida8 = new Bebida("Mojito", true, 300, 500, 1);
            Bebida bebida9 = new Bebida("Caipirinha", true, 500, 30, 1);
            Bebida bebida10 = new Bebida("Gaseosa Fanta", false, 200, 30, 1);
            Bebida bebida11 = new Bebida("Gaseosa Sprite", false, 200, 30, 1);
            Bebida bebida12 = new Bebida("Gaseosa Coca-Cola", false, 200, 30, 1);

            bebidas.Add(bebida1);
            bebidas.Add(bebida2);
            bebidas.Add(bebida3);
            bebidas.Add(bebida4);
            bebidas.Add(bebida5);
            bebidas.Add(bebida6);
            bebidas.Add(bebida7);
            bebidas.Add(bebida8);
            bebidas.Add(bebida9);
            bebidas.Add(bebida10);
            bebidas.Add(bebida11);
            bebidas.Add(bebida12);
            return bebidas;


        }

        private void cmbTamanioBebi_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        public void CargarComboBoxes(List <Comida> comidas, List<Bebida> bebidas)
        {
            foreach(Comida com in comidas)
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
                    if (cmbBebidas.SelectedItem.ToString() == bebida.Nombre.ToString() && bebida.CantidadStock > 0 && bebida != null)
                    {
                        rtbPedido.Text = bebida.MostrarProducto();
                        int n = dgvPedido.Rows.Add();
                        dgvPedido.Rows[n].Cells[0].Value = bebida.Nombre.ToString();
                        dgvPedido.Rows[n].Cells[1].Value = bebida.CantidadAComprar.ToString();
                        dgvPedido.Rows[n].Cells[2].Value = cmbTamanioBebi.SelectedItem.ToString();
                        dgvPedido.Rows[n].Cells[3].Value = bebida.Precio.ToString();

                        pedidoBebida = bebida;
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
                    if (cmbComidas.SelectedItem.ToString() == com.Nombre.ToString() && com.CantidadStock > 0 && com != null)
                    {
                        rtbPedido.Text = com.MostrarProducto();
                        int n = dgvPedido.Rows.Add();
                        dgvPedido.Rows[n].Cells[0].Value = com.Nombre.ToString();
                        dgvPedido.Rows[n].Cells[1].Value = com.CantidadAComprar.ToString();
                        dgvPedido.Rows[n].Cells[2].Value = cmbTamanioComi.SelectedItem.ToString();
                        dgvPedido.Rows[n].Cells[3].Value = com.Precio.ToString();
                        pedidoComida = com;
                        com.CantidadStock--;
                        precioComida += com.Precio;
                        
                    } 
                }
                else
                {
                    rtbPedido.Text = " ";
                }
            }

            return (precioComida + precioBebida);
            
            

        }

        private void btnCerrarVenta_Click(object sender, EventArgs e)
        {

            CerrarVenta frmCerrarVenta = new CerrarVenta(nuevaMesa);
            frmCerrarVenta.Show();
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
            AdministracionLocal frmAdminLocal = new AdministracionLocal();
            frmAdminLocal.Show();
           
        }
    }
}