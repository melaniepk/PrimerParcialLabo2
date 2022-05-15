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

        /// <summary>
        /// evaluda que el string recivido como clave no sea nulo ni vacio
        /// elimina los espacios antes y despues y evalua que se igual a la clave seteada para ese usuario
        /// </summary>
        /// <param name="clave"></param>
        /// <returns></returns>
        public bool EsUsuarioValido(string clave)
        {
            return (!string.IsNullOrEmpty(clave) && clave.Trim() == this.clave.Trim());
        }

        /// <summary>
        /// crea los uduarios y los guarda en la lista recibida
        /// </summary>
        /// <param name="usuarios"></param>
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
