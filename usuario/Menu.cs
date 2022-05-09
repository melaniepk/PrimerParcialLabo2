using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    
    public abstract class Menu
    {
        public enum Etamanio
        {
            Chico, Mediano, Grande, Lata, Botella, Vaso
        }
        protected double precio;
        protected int cantidadStock;
        protected int cantidadAComprar;

        protected Menu(double precio,int cantidadStock, int cantidadAComprar):this()
        {
            this.precio = precio;
            this.cantidadStock = cantidadStock;
            this.cantidadAComprar = cantidadAComprar;
        }

        protected Menu()
        {

        }

        public abstract double Precio
        {
            get;
        }
        public abstract int CantidadAComprar
        {
            get;
        }
            

        protected abstract Etamanio Tamanio
        {
            get;
        }
        
        public abstract int CantidadStock
        {
            get;
            set;
        }

        protected virtual void AgregarStock()
        {

        }
        public virtual string MostrarProducto()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Precio: {precio}");
            sb.AppendLine($"Cantidad en stock {cantidadStock}");
            sb.AppendLine($"Cantidad a Comprar {cantidadAComprar}");
            return sb.ToString();
        }
        
    }
}
