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
    public partial class Personal : Form
    {
        private List<Usuario> usuarios;
        public Personal()
        {
            InitializeComponent();
            usuarios = new List<Usuario>();
            Usuario.CargarUsuarios(usuarios);
            AgregarInfo();
        }

        /// <summary>
        /// agrega la informacion de los empleados y dueños a sus respectivas dataGridView
        /// </summary>
        public void AgregarInfo()
        {
            foreach (Usuario user in usuarios)
            {
                if(user.EsDuenio == false)
                {
                    int n = dgvEmpleados.Rows.Add();

                    dgvEmpleados.Rows[n].Cells[0].Value = user.Nombre;
                    dgvEmpleados.Rows[n].Cells[1].Value = user.Id;

                }
                else
                {
                    int n = dgvDuenios.Rows.Add();

                    dgvDuenios.Rows[n].Cells[0].Value = user.Nombre;
                    dgvDuenios.Rows[n].Cells[1].Value = user.Id;
                }
            }
        }
        
    }
}
