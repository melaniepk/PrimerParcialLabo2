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

        /// <summary>
        /// determina si la key del item recibido es mayor a 16, es decir perteneceria a una barra
        /// crea una nueva mesa y le asigna el total del label total
        /// evalua el color de fondo del boton y le asigna uno diferente
        /// (la peor solucion del mundo pero es lo unico que se me ocurrio despues de fallar en repetidas ocasiones)
        /// imprime el numero de mesa y el nombre del vendedor en sus respectivos labels
        /// inhabilita los botones para ordenar comida si es barra
        /// asigna como vendedor de la mesa al usuario recibido.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="usuario"></param>
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

        /// <summary>
        /// crea los inventarios de comida y bebida
        /// llama a las funciones para cargar las comboBoxes correspondientes
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuNuevaVenta_Load(object sender, EventArgs e)
        {            
            comidas = new List<Comida>(Local.CrearInventarioComida());
            bebidas = new List<Bebida>(Local.CrearInventarioBebida());
            
            this.CargarComboBoxes(comidas,bebidas);
        }

        /// <summary>
        /// agrega los nombres de las coidas y las bebidas a las comboboxes
        /// agrega los tamaños correspondientes a cada comboBox de tamaño
        /// </summary>
        /// <param name="comidas"></param>
        /// <param name="bebidas"></param>
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

        /// <summary>
        /// llama a la funcion sumar total
        /// imprime el total en el label correspondiente y lo asigna a la mesa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {           
            double total = this.SumarTotal();
            lblTotal.Text = total.ToString();
            nuevaMesa.total = total;
        }

        /// <summary>
        /// convierte a numero el texto de total o en caso de ser imposible 
        /// lo deja en 0
        /// iguala "suma" a la suma de los pedidos hecha en AgregarElem
        /// y la asigna al total
        /// </summary>
        /// <returns>devuelve el total</returns>
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

        /// <summary>
        /// crea pedidos de comidas y bebidas. realiza las validaciones correspondientes 
        /// muestar la info de los productos seleccionados en la richtextBox.
        /// asigna los datos del producto agregado a sus correspondientes celdas en el dgv
        /// agrega la bebida o comida seleccionada a pedidoBebida o pedidoComida.
        /// agrega el pedido a la mesa
        /// suma a precioBebida o precioComida el precio del item seleccionado
        /// devuelve la suma de los precios de los pedidos.
        /// </summary>
        /// <returns></returns>
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
                        cmbBebidas.Text = " ";
                        cmbTamanioBebi.Text = " ";
                        pedidoBebida = bebida;
                        nuevaMesa.pedidoBeb.Add(pedidoBebida);
                        bebida.CantidadStock--;
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
                        cmbComidas.Text = " ";
                        cmbTamanioComi.Text = " ";
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

            return (precioComida + precioBebida);          
           
        }

        /// <summary>
        /// crea el formulario de CerrarVenta, libera la mesa
        /// y oculta el form actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrarVenta_Click(object sender, EventArgs e)
        {
            CerrarVenta frmCerrarVenta = new CerrarVenta(nuevaMesa);
            frmCerrarVenta.ShowDialog();
            nuevaMesa.estaLibre = true;
            
            this.Hide();
        }

        /// <summary>
        /// envia un mensaje de tipo dialogResult, en caso de respuesta positiva cieera el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
    }
}