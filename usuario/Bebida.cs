using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    //public enum tamanio
    //{
    //    vaso, lata, botella
    //}
    public class Bebida:Menu
    {
        protected bool tieneAlcohol;

        public Bebida(string nombre, bool tieneAlcohol, double precio, int cantidadStock, int cantidadAComprar)
           : base(precio, cantidadStock, cantidadAComprar)
        {
            this.nombre = nombre;
            this.tieneAlcohol = tieneAlcohol;
        }
        protected override Etamanio Tamanio
        {
            get { return new Etamanio(); }
        }

        public override string Nombre
        {
            get { return nombre; }
        }

        public bool TieneAlcohol
        {
            get { return tieneAlcohol;}
        }
        public override int CantidadAComprar
        {
            get { return 1;}
        }
        public override double Precio
        {
            get { return this.precio;}
        }
        public override int CantidadStock
        {
            get { return this.cantidadStock; }
            set { this.cantidadStock = value; }
        }
       
        /// <summary>
        /// muestra los detalles de la bebida 
        /// </summary>
        /// <returns></returns>
        public override string MostrarProducto()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"   DETALLES DEL PRODUCTO   ");
            sb.AppendLine($"-----------------------------");
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Tiene alcohol: {tieneAlcohol}");
            sb.AppendLine(base.MostrarProducto());
            return sb.ToString();
        }
    }

}
