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

        public Usuario(string nombre, string clave)
        {
            this.nombre=nombre;
            this.clave=clave;
        }

        public bool EsDuenio
        {
            get => esDuenio; set => esDuenio = value; 
        }
        public string Nombre
        {
            get => nombre; set => nombre = value; 
        }
        public int Id 
        {
            get => id; set => id = value; 
        }
        public string Clave
        {
            set => clave = value; 
        }

        public bool esUsuarioValido(Usuario usuario,string clave)
        {
            if(clave != null && clave == usuario.clave)
            {
                return true;
            }
            else return false;
        }

        public static void Cargar(List<Usuario> usuarios)
        {
            Usuario usuario1 = new Usuario(false, "pepe", "peposo", 123);
            Usuario usuario2 = new Usuario(false, "maria", "marolio", 124);
            Usuario usuario3 = new Usuario(true, "jungkook", "jeon", 125);
            Usuario usuario4 = new Usuario(true, "taehyung", "kim", 1236);

            usuarios.Add(usuario1);
            usuarios.Add(usuario2);
            usuarios.Add(usuario3);
            usuarios.Add(usuario4);
        }



        





    }
}
