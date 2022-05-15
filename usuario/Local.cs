using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace Clases
{
    public static class Local
    {
        static List<Comida> inventarioComida;
        static List<Bebida> inventarioBebida;
        static Mesa[] mesas;
        static List<Comida> comidas;

        static Local()
        {
            CrearMesas();
            CrearInventarioComida();
            CrearInventarioBebida();
        }
        public static void CrearMesas()
        {
            mesas = new Mesa[20];
            mesas[0] = new Mesa(true, 1, false);
            mesas[1] = new Mesa(true,  2, false);
            mesas[2] = new Mesa(true, 3, false);
            mesas[3] = new Mesa(true,  4, false);
            mesas[4] = new Mesa(true, 5, false);
            mesas[5] = new Mesa(true, 6, false);
            mesas[6] = new Mesa(true, 7, false);
            mesas[7] = new Mesa(true, 8, false);
            mesas[8] = new Mesa(true, 9, false);
            mesas[9] = new Mesa(true, 10, false);
            mesas[10] = new Mesa(true, 11, false);
            mesas[11] = new Mesa(true, 12, false);
            mesas[12] = new Mesa(true, 13, false);
            mesas[13] = new Mesa(true,14, false);
            mesas[14] = new Mesa(true, 15, false);
            mesas[15] = new Mesa(true, 16, true);
            mesas[16] = new Mesa(true,17, true);
            mesas[17] = new Mesa(true, 18, true);
            mesas[18] = new Mesa(true, 19, true);
            mesas[19] = new Mesa(true, 20, true);
        }

        public static List<Comida> CrearInventarioComida()
        {
            inventarioComida = new List<Comida>();
            inventarioComida.Add(new Comida("Papas con Cheddar", 400, false, 500, 15, 1));
            inventarioComida.Add(new Comida("Hamburguesa Especial", 800, true, 800, 15, 1));
            inventarioComida.Add(new Comida("Hambuguesa Clasica", 850, true, 850, 15, 1));
            inventarioComida.Add(new Comida("Nuggets de Pollo", 450, false, 560, 15, 1));
            inventarioComida.Add(new Comida("Sticks de Muzzarella", 560, true, 600, 15, 1));
            inventarioComida.Add(new Comida("Pizza individual Napolitana", 600, true, 700, 15, 1));
            inventarioComida.Add(new Comida("Pizza individual Muzzarella", 550, true, 700, 15, 1));
            inventarioComida.Add(new Comida("Nachos con cheddar", 360, true, 450, 15, 1));
            inventarioComida.Add(new Comida("Ensalada Caesar", 280, false, 500, 15, 1));
            inventarioComida.Add(new Comida("Ensalada Completa", 380, false, 600, 15, 1));
            inventarioComida.Add(new Comida("Picada para 3", 1200, true, 1500, 15, 1));
            inventarioComida.Add(new Comida("Brownie con Helado", 500, false, 500, 15, 1));
            
            return inventarioComida;


        }

        public static List<Bebida> CrearInventarioBebida()
        {
            inventarioBebida = new List<Bebida>();
            inventarioBebida.Add(new Bebida("Cerveza Honey", true, 300, 30, 1));
            inventarioBebida.Add(new Bebida("Cerveza IPA", true, 300, 30, 1));
            inventarioBebida.Add(new Bebida("Cerveza Brahma", true, 250, 30, 1));
            inventarioBebida.Add(new Bebida("Cerveza Honey", true, 300, 30, 1));
            inventarioBebida.Add(new Bebida("Fernet", true, 400, 30, 1));
            inventarioBebida.Add(new Bebida("Gin tonic", true, 450, 30, 1));
            inventarioBebida.Add(new Bebida("Gancia", true, 350, 30, 1));
            inventarioBebida.Add(new Bebida("Margarita", true, 500, 30, 1));
            inventarioBebida.Add(new Bebida("Mojito", true, 300, 500, 1));
            inventarioBebida.Add(new Bebida("Caipirinha", true, 500, 30, 1));
            inventarioBebida.Add(new Bebida("Gaseosa Fanta", false, 200, 30, 1));
            inventarioBebida.Add(new Bebida("Gaseosa Sprite", false, 200, 30, 1));
            inventarioBebida.Add(new Bebida("Gaseosa Coca-Cola", false, 200, 30, 1));
            return inventarioBebida;
        }




        public static List<Menu> ActualizarInventario(List<Menu> prod)
        {
            return prod;
        }
        //public static void CargarComidas()
        //{
        //    comidas = new List<Comida>();
        //    Comida comida1 = new Comida("Papas con Cheddar", 400, false, 500, 15, 1);
        //    Comida comida2 = new Comida("Hamburguesa Especial", 800, true, 800, 15, 1);
        //    Comida comida3 = new Comida("Hambuguesa Clasica", 850, true, 850, 15, 1);
        //    Comida comida4 = new Comida("Nuggets de Pollo", 450, false, 560, 15, 1);
        //    Comida comida5 = new Comida("Sticks de Muzzarella", 560, true, 600, 15, 1);
        //    Comida comida6 = new Comida("Pizza individual Napolitana", 600, true, 700, 15, 1);
        //    Comida comida7 = new Comida("Pizza individual Muzzarella", 550, true, 700, 15, 1);
        //    Comida comida8 = new Comida("Nachos con cheddar", 360, true, 450, 15, 1);
        //    Comida comida9 = new Comida("Ensalada Caesar", 280, false, 500, 15, 1);
        //    Comida comida10 = new Comida("Ensalada Completa", 380, false, 600, 15, 1);
        //    Comida comida11 = new Comida("Picada para 3", 1200, true, 1500, 15, 1);
        //    Comida comida12 = new Comida("Brownie con Helado", 500, false, 500, 15, 1);

        //    comidas.Add(comida1);
        //    comidas.Add(comida2);
        //    comidas.Add(comida3);
        //    comidas.Add(comida4);
        //    comidas.Add(comida5);
        //    comidas.Add(comida6);
        //    comidas.Add(comida7);
        //    comidas.Add(comida8);
        //    comidas.Add(comida9);
        //    comidas.Add(comida10);
        //    comidas.Add(comida11);
        //    comidas.Add(comida12);

        //}
        //public static List<Bebida> CargarBebidas(List<Bebida> bebidas)
        //{

        //    Bebida bebida1 = new Bebida("Cerveza Honey", true, 300, 30, 1);
        //    Bebida bebida2 = new Bebida("Cerveza IPA", true, 300, 30, 1);
        //    Bebida bebida3 = new Bebida("Cerveza Brahma", true, 250, 30, 1);
        //    Bebida bebida4 = new Bebida("Fernet", true, 400, 30, 1);
        //    Bebida bebida5 = new Bebida("Gin tonic", true, 450, 30, 1);
        //    Bebida bebida6 = new Bebida("Gancia", true, 350, 30, 1);
        //    Bebida bebida7 = new Bebida("Margarita", true, 500, 30, 1);
        //    Bebida bebida8 = new Bebida("Mojito", true, 300, 500, 1);
        //    Bebida bebida9 = new Bebida("Caipirinha", true, 500, 30, 1);
        //    Bebida bebida10 = new Bebida("Gaseosa Fanta", false, 200, 30, 1);
        //    Bebida bebida11 = new Bebida("Gaseosa Sprite", false, 200, 30, 1);
        //    Bebida bebida12 = new Bebida("Gaseosa Coca-Cola", false, 200, 30, 1);

        //    bebidas.Add(bebida1);
        //    bebidas.Add(bebida2);
        //    bebidas.Add(bebida3);
        //    bebidas.Add(bebida4);
        //    bebidas.Add(bebida5);
        //    bebidas.Add(bebida6);
        //    bebidas.Add(bebida7);
        //    bebidas.Add(bebida8);
        //    bebidas.Add(bebida9);
        //    bebidas.Add(bebida10);
        //    bebidas.Add(bebida11);
        //    bebidas.Add(bebida12);
        //    return bebidas;


        //}

        //private static void InstanciarUsuarios()
        //{
        //    listaUsuarios = new List<Usuario>()
        //    {
        //        new Usuario(true,"Pepe Peposo","ruf123",1),
        //        new Usuario(false,"Juana RoyalCanin","MadeINLanus",2),

        //    };
        //}

        //public static Usuario LoguearUsuario(int idUser, string password)
        //{
        //    foreach (Usuario user in listaUsuarios)
        //    {
        //        if (user.Id == idUser && user.EsUsuarioValido(password))
        //            return user;
        //    }
        //    return null;
        //}

        public static Dictionary<int, bool> EstadoMesas()
        {
            Dictionary<int, bool> estadoMesas = new Dictionary<int, bool>();

            for (int i = 0; i < mesas.Length; i++)
            {
                estadoMesas.Add(i + 1, mesas[i].estaLibre == true); // true si las mesas estan libres, false si estan desocupadas
            }

            return estadoMesas;
        }

        public static string MostrarInformacionMesa(int idMesa)
        {
            Mesa auxMesa = null;
            foreach (Mesa mesa in mesas)
            {
                if (mesa.numeroMesa == idMesa)
                    auxMesa = mesa;
            }

            if (auxMesa is null)
                return "mesa no encontrada";

            return auxMesa.ToString();
        }

         
        

    }




}
