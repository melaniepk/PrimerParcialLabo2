using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    
    public class Comida: Menu
    {
        protected string nombre;
        protected int calorias;
        protected bool conSal;
        

        protected override Etamanio Tamanio
        {
            get { return new Etamanio(); }
        }

        public Comida(string nombre, int calorias, bool conSal, double precio, int cantidadStock, int cantidadAComprar)
            :base(precio,cantidadStock,cantidadAComprar)
        {
            this.nombre = nombre; 
            this.calorias = calorias;
            this.conSal = conSal;
        }
        
        public string Nombre
        {
            get { return nombre; }
        }
        
        public override double Precio
        {
            get { return this.precio; }
        }
        public override int CantidadAComprar
        {
            get { return this.cantidadAComprar; }
        }
        public override int CantidadStock
        {
            get { return cantidadStock; }
            set { this.cantidadStock = value; }
        }
        //public Etamanio SeleccionTamanio()
        //{

        //}
        public override string MostrarProducto()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"   DETALLES DEL PRODUCTO   ");
            sb.AppendLine($"-----------------------------");
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Calorias: {calorias}"); 
            sb.AppendLine($"Tiene sal {conSal}");
            sb.AppendLine(base.MostrarProducto());
            return sb.ToString();

        }

    }
}
