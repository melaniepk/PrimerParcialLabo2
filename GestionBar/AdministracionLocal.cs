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
    public partial class AdministracionLocal : Form
    {
        private string usuarioN;
        private Usuario usuario;
        public Mesa[] mesas;
        public Mesa nuevaMesa;


        public AdministracionLocal()
        {
            
            InitializeComponent();
            mesas = new Mesa[20];

        }

        public AdministracionLocal(Mesa mesa)
        {
            
            nuevaMesa = mesa;
            
        }
        public AdministracionLocal(Usuario usuario):this()
        {
            this.usuario = usuario;
            if (usuario.EsDuenio == false)
            {
                btnInventario.Enabled = false;
                btnPersonal.Enabled = false;
                this.BackColor = Color.PeachPuff;
            }
            else
            {
                btnInventario.Enabled = true;
                btnPersonal.Enabled = true;
                this.BackColor = Color.Thistle;
            }
        }

        public AdministracionLocal(string nombreUsuario) : this()
        {
            this.usuarioN = nombreUsuario;
            lblBienvenida.Text = ($"Bienvenida/o {usuarioN}");
           
        }

        private void AdministracionLocal_Load(object sender, EventArgs e)
        {
            mesas[0] = new Mesa(1, true, usuario.Nombre.ToString(), 1,false);
            mesas[1] = new Mesa(2, true, usuario.Nombre.ToString(), 2, false);
            mesas[2] = new Mesa(3, true, usuario.Nombre.ToString(), 3, false);
            mesas[3] = new Mesa(4, true, usuario.Nombre.ToString(), 4, false);
            mesas[4] = new Mesa(5, true, usuario.Nombre.ToString(), 5, false);
            mesas[5] = new Mesa(6, true, usuario.Nombre.ToString(), 6, false);
            mesas[6] = new Mesa(7, true, usuario.Nombre.ToString(), 7, false);
            mesas[7] = new Mesa(8, true, usuario.Nombre.ToString(), 8, false);
            mesas[8] = new Mesa(9, true, usuario.Nombre.ToString(), 9, false);
            mesas[9] = new Mesa(10, true, usuario.Nombre.ToString(), 10, false);
            mesas[10] = new Mesa(11, true, usuario.Nombre.ToString(), 11, false);
            mesas[11] = new Mesa(12, true, usuario.Nombre.ToString(), 12, false);
            mesas[12] = new Mesa(13, true, usuario.Nombre.ToString(), 13, false);
            mesas[13] = new Mesa(14, true, usuario.Nombre.ToString(), 14, false);
            mesas[14] = new Mesa(15, true, usuario.Nombre.ToString(), 15, false);
            mesas[15] = new Mesa(16, true, usuario.Nombre.ToString(), 16, false);
            mesas[16] = new Mesa(17, true, usuario.Nombre.ToString(), 17, true);
            mesas[17] = new Mesa(18, true, usuario.Nombre.ToString(), 18, true);
            mesas[18] = new Mesa(19, true, usuario.Nombre.ToString(), 19, true);
            mesas[19] = new Mesa(20, true, usuario.Nombre.ToString(), 20, true);
            btnMesa1.BackColor = Color.SpringGreen;
            btnMesa2.BackColor = Color.SpringGreen;
            btnMesa3.BackColor = Color.SpringGreen;
            btnMesa4.BackColor = Color.SpringGreen;
            btnMesa5.BackColor = Color.SpringGreen;
            btnMesa6.BackColor = Color.SpringGreen;
            btnMesa7.BackColor = Color.SpringGreen;
            btnMesa8.BackColor = Color.SpringGreen;
            btnMesa9.BackColor = Color.SpringGreen;
            btnMesa10.BackColor = Color.SpringGreen;
            btnMesa11.BackColor = Color.SpringGreen;
            btnMesa12.BackColor = Color.SpringGreen;
            btnMesa13.BackColor = Color.SpringGreen;
            btnMesa14.BackColor = Color.SpringGreen;
            btnMesa15.BackColor = Color.SpringGreen;
            btnBarra16.BackColor = Color.SpringGreen;
            btnBarra17.BackColor = Color.SpringGreen;
            btnBarra18.BackColor = Color.SpringGreen;
            btnBarra19.BackColor = Color.SpringGreen;
            btnBarra19.BackColor = Color.SpringGreen;
            btnBarra20.BackColor = Color.SpringGreen;

            
            if (nuevaMesa != null && mesas != null)
            {
                for (int i = 0; i < mesas.Length; i++)
                {
                    if (mesas[i].numeroMesa == nuevaMesa.numeroMesa)
                    {
                        mesas[i] = nuevaMesa;
                    }
                }
            }

        }

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

        private void btnMesa1_Click(object sender, EventArgs e)
        {
            MenuNuevaVenta frmMenu = new MenuNuevaVenta(mesas[0]);
            frmMenu.Show();
            //this.Hide();
            mesas[0].estaLibre = false;
            btnMesa1.BackColor = Color.Tomato;
        }

        private void btnBarra16_Click(object sender, EventArgs e)
        {
            MenuNuevaVenta frmMenu = new MenuNuevaVenta(mesas[16]);
            frmMenu.Show();
            //this.Hide();
            mesas[16].estaLibre =false;
            mesas[16].esBarra = true;
            btnBarra16.BackColor = Color.Tomato;

        }
    }
}
