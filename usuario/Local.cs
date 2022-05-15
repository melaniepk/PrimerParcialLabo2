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

        /// <summary>
        /// crea las mesas 
        /// </summary>
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

        /// <summary>
        /// crea el inventario de comidas, agrega las comidas a la lista y devuelve la lista cargada
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// carga las bebidas creadas a la lista de inventario de bebidas y la devuelve
        /// </summary>
        /// <returns></returns>
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
        
        /// <summary>
        /// evalua el estado de las mesas, seteando el bool en true si estan libres
        /// y en false si estan ocupadas
        /// </summary>
        /// <returns></returns>
        public static Dictionary<int, bool> EstadoMesas()
        {
            Dictionary<int, bool> estadoMesas = new Dictionary<int, bool>();

            for (int i = 0; i < mesas.Length; i++)
            {
                estadoMesas.Add(i + 1, mesas[i].estaLibre == true);
            }

            return estadoMesas;
        }

       
        

    }




}
