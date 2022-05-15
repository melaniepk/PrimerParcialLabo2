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
    public partial class Login : Form
    {
        public List<Usuario> usuarios;

        public Login()
        {
            InitializeComponent();
            usuarios = new List<Usuario>();
            Usuario.CargarUsuarios(usuarios);
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string usuario = this.tbxUsuario.Text.ToLower();
            string clave = this.tbxClave.Text.ToLower();
            int usuarioCorrecto = 1;
            foreach (Usuario usuario1 in usuarios)
            {
                if (usuario1.Nombre == usuario && usuario1.EsUsuarioValido(clave))
                {
                    AdministracionLocal frmAdmLocal = new AdministracionLocal(usuario1);

                    frmAdmLocal.Show();
                    this.Hide();
                    usuarioCorrecto = 1;
                }

            }
            if (usuarioCorrecto == 0)
            {
                string mensaje = "El usuario o la contraseña ingresados son incorrectos";
                string titulo = "ERROR";
                MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //int usuarioCorrecto = 0;

            //if (string.IsNullOrEmpty(tbxUsuario.Text) || string.IsNullOrEmpty(tbxClave.Text))
            //    MessageBox.Show("Ingrese datos validos");
            //else
            //{
            //    if (int.TryParse(tbxUsuario.Text, out int id))
            //    {
            //        Usuario userLogueado = Local.LoguearUsuario(id, tbxClave.Text);

            //        if (userLogueado is not null)
            //        {
            //            AdministracionLocal frmAdmLocal = new AdministracionLocal(userLogueado);

            //            frmAdmLocal.Show();
            //            this.Hide();
            //            //usuarioCorrecto = 1;
                       
            //        }
            //    }
            //}
        }

        private void btnRellenarDue_Click(object sender, EventArgs e)
        {
            tbxUsuario.Text = "Melanie";
            tbxClave.Text = "12345";
        }

        private void btnRellenarEmp_Click(object sender, EventArgs e)
        {
            tbxUsuario.Text = "pepe";
            tbxClave.Text = "peposo";
        }

        //private void tbxUsuario_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}
