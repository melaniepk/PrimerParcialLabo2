using System;
using System.Collections.Generic;

namespace Clases
{
    public class Usuario
    {

        private bool esDuenio;
        private string nombre;
        private string clave;
        private int id;

        public Usuario()
        {

        }
           
        public Usuario(bool esDuenio, string nombre, string clave, int id):this()
        {
            this.esDuenio = esDuenio;
            this.nombre = nombre;
            this.clave = clave;
            this.id = id;
        }

        public Usuario(string nombre, string clave):this()
        {
            this.nombre=nombre;
            this.clave=clave;
        }
        public int Id
        {
            get { return id; }
        }
        public bool EsDuenio
        {
            get => esDuenio; set => esDuenio = value; 
        }
        public string Nombre
        {
            get => nombre; set => nombre = value; 
        }
       
        public string Clave
        {
            set => clave = value; 
        }

        public bool EsUsuarioValido(string clave)
        {
            return (!string.IsNullOrEmpty(clave) && clave.Trim() == this.clave.Trim());
        }

        public Usuario RellenarUsuarioDuenio()
        {
            Usuario usuario = new Usuario(true, "Melanie", "12345", 1235);
            return usuario;
        }

        public Usuario RellenarUsuarioEmp()
        {
            Usuario usuario = new Usuario(false, "Ernesto", "678910", 1238);

            return usuario;
        }

        public static void CargarUsuarios(List<Usuario> usuarios)
        {
            Usuario usuario1 = new Usuario(false, "pepe", "peposo", 123);
            Usuario usuario2 = new Usuario(false, "maria", "marolio", 124);
            Usuario usuario3 = new Usuario(true, "melanie", "12345", 1235);
            Usuario usuario4 = new Usuario(true, "ernesto", "678910", 1238);

            usuarios.Add(usuario1);
            usuarios.Add(usuario2);
            usuarios.Add(usuario3);
            usuarios.Add(usuario4);
        }




    }
}
