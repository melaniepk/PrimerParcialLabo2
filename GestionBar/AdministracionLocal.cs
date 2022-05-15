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
    public partial class AdministracionLocal : Form
    {
        //private string usuarioN;
        private Usuario usuario;
        Dictionary<int, Button> botones;
        Dictionary<int, bool> disponibilidadMesas;


        public AdministracionLocal()
        {

            InitializeComponent();           
            botones = new Dictionary<int, Button>();
            CargarMesas();
            playSimpleSound();


        }

        /// <summary>
        /// recibe el usuario logueado y evalua si es sueño o no
        /// asigna un color de fondo diferente en cada caso y habilita/deshabilita botones
        /// </summary>
        /// <param name="usuario"></param>
        public AdministracionLocal(Usuario usuario):this()
        {
            this.usuario = usuario;
            if (usuario.EsDuenio == false)
            {
                btnInventario.Enabled = false;
                btnPersonal.Enabled = false;
                this.BackColor = Color.DarkSlateBlue;
            }
            else
            {
                btnInventario.Enabled = true;
                btnPersonal.Enabled = true;
                this.BackColor = System.Drawing.Color.FromArgb(39,39,79);
            }
            lblBienvenida.Text = $"Bienvenido/a {usuario.Nombre.ToUpperInvariant()}";
        }

        private void AdministracionLocal_Load(object sender, EventArgs e)
        {
            ObtenerEstadoMesas();
        }

        /// <summary>
        /// agrega los botones y sus keys al diccionario de botones
        /// </summary>
        private void CargarMesas()
        {

            botones.Add(1, this.btnMesa1);
            botones.Add(2, this.btnMesa2);
            botones.Add(3, this.btnMesa3);
            botones.Add(4, this.btnMesa4);
            botones.Add(5, this.btnMesa5);
            botones.Add(6, this.btnMesa6);
            botones.Add(7, this.btnMesa7);
            botones.Add(8, this.btnMesa8);
            botones.Add(9, this.btnMesa9);
            botones.Add(10, this.btnMesa10);
            botones.Add(11, this.btnMesa11);
            botones.Add(12, this.btnMesa12);
            botones.Add(13, this.btnMesa13);
            botones.Add(14, this.btnMesa14);
            botones.Add(15, this.btnMesa15);
            botones.Add(16, this.btnBarra16);
            botones.Add(17, this.btnBarra17);
            botones.Add(18, this.btnBarra18);
            botones.Add(19, this.btnBarra19);
            botones.Add(20, this.btnBarra20);

        }

        /// <summary>
        /// obtiene la disponibilidad de las mesas, comprobando cuales de estas estan libres
        /// luego asigna un color a cada boton segun el bool del value 
        /// este seteado en true o false
        /// </summary>
        private void ObtenerEstadoMesas()
        {
            disponibilidadMesas = Local.EstadoMesas();

            foreach (KeyValuePair<int, bool> mesa in disponibilidadMesas)
            {
                if (mesa.Value)
                    botones[mesa.Key].BackColor = Color.Green;
                else
                    botones[mesa.Key].BackColor = Color.IndianRed;
            }
        }       

        /// <summary>
        /// pregunta y cierra el form en caso de respuesta positiva
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            string mensaje = "Seguro que desea salir?";
            string titulo = "Cerrar";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mensaje, titulo, buttons,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                
                this.Close();
            }
        }

        private void AdministracionLocal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// castea el sender a button, recorre los pares keyValue en botones y busca
        /// coincidencia entre el boton auxiliar y el value del item.
        /// en caso de exitir, abre y muestar el formulario de nueva venta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMesa_Click(object sender, EventArgs e)
        {
            Button auxBtn = (Button)sender;
            foreach (KeyValuePair<int, Button> mesa in botones)
            {
                if (mesa.Value == auxBtn)
                {
                    MenuNuevaVenta frmMenu = new MenuNuevaVenta(mesa, usuario);
                    frmMenu.ShowDialog();                     
                }
            }

        }
       
        /// <summary>
        /// Abre un formulario de inventario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInventario_Click(object sender, EventArgs e)
        {
            Inventario frmInventario = new Inventario();
            frmInventario.Show();
        }

        /// <summary>
        /// Abre un formulario de Personal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPersonal_Click(object sender, EventArgs e)
        {
            Personal frmPersonal = new Personal();  
            frmPersonal.Show();
        }

        /// <summary>
        /// reproduce un sonido 
        /// </summary>
        private void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\mkale\source\repos\PrimerParcialLabo2\GestionBar\Properties\audioPopup.wav");
            simpleSound.Play();
        }
    }
}
