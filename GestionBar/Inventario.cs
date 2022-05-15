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
    public partial class Inventario : Form
    {
        public List<Bebida> bebidas;
        public List<Comida> comidas;

        public Inventario()
        {
            InitializeComponent();
            bebidas = new List<Bebida>();
            comidas = new List<Comida>();           

        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            bebidas = Local.CrearInventarioBebida();
            comidas = Local.CrearInventarioComida();
            CargarComidas();
            CargarBebidas();
        }

        /// <summary>
        /// agrega los nombres de las comidas al comboBox y 
        /// llama a la funcion CargarDataGridViewComida
        /// </summary>
        public void CargarComidas()
        {
            foreach (Comida comida in comidas)
            {
                cmbComidas.Items.Add(comida.Nombre.ToString());
            }
            cmbComidas.Items.Add(" ");
            CargarDataGridViewComida();

        }

        /// <summary>
        /// agrega los nombres de las bebidas al comboBox y 
        /// llama a la funcion CargarDataGridViewBebida
        /// </summary>
        public void CargarBebidas()
        {
            foreach (Bebida bebida in bebidas)
            {
                cmbBebidas.Items.Add(bebida.Nombre.ToString());
            }
            cmbBebidas.Items.Add(" ");
            CargarDataGridViewBebida();

        }

        /// <summary>
        /// crea las filas en el data grid view por cada comida
        /// muestra en las celdas 0 y 1 el nombre y la cantidad en stock 
        /// de la comida
        /// </summary>
        public void CargarDataGridViewComida()
        {
            foreach(Comida comida in comidas)
            {
                int n = dgvEstadoStComi.Rows.Add();

                dgvEstadoStComi.Rows[n].Cells[0].Value = comida.Nombre;
                dgvEstadoStComi.Rows[n].Cells[1].Value = comida.CantidadStock;

            }
        }

        /// <summary>
        /// crea las filas en el data grid view por cada bebida
        /// muestra en las celdas 0 y 1 el nombre y la cantidad en stock 
        /// de la bebida
        /// </summary>
        public void CargarDataGridViewBebida()
        {
            foreach (Bebida bebida in bebidas)
            {
                int n = dgvEstadoStBebi.Rows.Add();

                dgvEstadoStBebi.Rows[n].Cells[0].Value = bebida.Nombre;
                dgvEstadoStBebi.Rows[n].Cells[1].Value = bebida.CantidadStock;

            }            
        }

        /// <summary>
        /// hace las verificaciones correspondientes, transforma a numero
        /// la cantidad ingresada en el textBox de comida y la agrega 
        /// a la cantidad en stock de esa comida.
        /// luego lo imprime en el dataGridView correspondiente
        /// </summary>
        public void AgregarProductosComida()
        {
            foreach (Comida comida in comidas)
            {
                if (cmbComidas.SelectedItem != null &&
                    cmbComidas.SelectedItem.ToString() == comida.Nombre.ToString())
                {
                    Int32.TryParse(txbCantidadComi.Text, out int cantidad);
                    comida.CantidadStock += cantidad;
                    dgvEstadoStComi.Rows[cmbComidas.SelectedIndex].Cells[1].Value = comida.CantidadStock;
                    comidas = Local.CrearInventarioComida();
                }
            }
        }

        /// <summary>
        /// hace las verificaciones correspondientes, transforma a numero
        /// la cantidad ingresada en el textBox de bebida y la agrega 
        /// a la cantidad en stock de esa bebida.
        /// luego lo imprime en el dataGridView correspondiente
        /// </summary>
        public void AgregarProductosBebida()
        {
            foreach (Bebida bebida in bebidas)
            {
                if (cmbBebidas.SelectedItem != null &&
                    cmbBebidas.SelectedItem.ToString() == bebida.Nombre.ToString())
                {
                    Int32.TryParse(txbCantidadBebi.Text, out int cantidad);
                    bebida.CantidadStock += cantidad;
                    dgvEstadoStBebi.Rows[cmbBebidas.SelectedIndex].Cells[1].Value = bebida.CantidadStock;
                    bebidas = Local.CrearInventarioBebida();
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarProductosComida();                    
        }

        private void btnAgregarBebi_Click(object sender, EventArgs e)
        {
            AgregarProductosBebida();
        }
    }
}
