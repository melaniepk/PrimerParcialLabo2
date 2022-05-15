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
        //public List<Menu> productos;

        public Inventario()
        {
            InitializeComponent();
            bebidas = new List<Bebida>();
            comidas = new List<Comida>();

            bebidas = Local.CrearInventarioBebida();
            comidas = Local.CrearInventarioComida();
            CargarComidas();
            CargarBebidas();

        }

        private void Inventario_Load(object sender, EventArgs e)
        {
        }
        public void CargarComidas()
        {
            foreach (Comida comida in comidas)
            {
                cmbComidas.Items.Add(comida.Nombre.ToString());
            }
            cmbComidas.Items.Add(" ");
            CargarDataGridViewComida();

        }

        public void CargarBebidas()
        {
            foreach (Bebida bebida in bebidas)
            {
                cmbBebidas.Items.Add(bebida.Nombre.ToString());
            }
            cmbBebidas.Items.Add(" ");
            CargarDataGridViewBebida();

        }
        public void CargarDataGridViewComida()
        {
            foreach(Comida comida in comidas)
            {
                int n = dgvEstadoStComi.Rows.Add();

                dgvEstadoStComi.Rows[n].Cells[0].Value = comida.Nombre;
                dgvEstadoStComi.Rows[n].Cells[1].Value = comida.CantidadStock;

            }
        }
        public void CargarDataGridViewBebida()
        {
            foreach (Bebida bebida in bebidas)
            {
                int n = dgvEstadoStBebi.Rows.Add();

                dgvEstadoStBebi.Rows[n].Cells[0].Value = bebida.Nombre;
                dgvEstadoStBebi.Rows[n].Cells[1].Value = bebida.CantidadStock;

            }            
        }

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

        //public List<Bebida> AgregarStockBebi()
        //{
        //    foreach(Bebida bebida in bebidas)
        //    {
        //        if (cmbProductos.SelectedItem == bebida)
        //        {
        //           if( Int32.TryParse(txbCantidad.Text, out int cantidad))
        //            {
        //                bebida.CantidadStock += cantidad;
        //                int n = dgvEstadoStock.Rows.Add();

        //                dgvEstadoStock.Rows[n].Cells[1].Value = bebida.CantidadStock;

        //            }

        //        }
        //    }

        //    return bebidas;
        //}
        //public List<Comida> AgregarStockComi()
        //{
        //    foreach (Comida com in comida)
        //    {
        //        if (cmbProductos.SelectedItem == comida)
        //        {
        //            if (Int32.TryParse(txbCantidad.Text, out int cantidad))
        //            {
        //                com.CantidadStock += cantidad;
        //                int n = dgvEstadoStock.Rows.Add();

        //                dgvEstadoStock.Rows[n].Cells[1].Value = com.CantidadStock;

        //            }

        //        }
        //    }

        //    return comida;
        //}

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarProductosComida();
            //bebidas = AgregarStockBebi();
            //comida = AgregarStockComi();
            //CargarProductos(bebidas, comida);
            //CargarDataGridView();
            
         }

        private void btnAgregarBebi_Click(object sender, EventArgs e)
        {
            AgregarProductosBebida();

        }
    }
}
