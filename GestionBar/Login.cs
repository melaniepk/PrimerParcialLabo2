﻿using System;
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
            Usuario.Cargar(usuarios);
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string usuario = this.tbxUsuario.Text.ToLower();
            string clave = this.tbxClave.Text.ToLower();
            int usuarioCorrecto = 0;

            foreach (Usuario usuario1 in usuarios)
            {
                if (usuario1.Nombre == usuario && usuario1.esUsuarioValido(usuario1, clave))
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
                MessageBox.Show(mensaje, titulo,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        //private void tbxUsuario_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}
