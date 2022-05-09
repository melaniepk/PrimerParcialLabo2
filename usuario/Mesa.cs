using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Mesa
    {
        public List<Bebida> pedidoBeb;
        public List<Comida> pedidoCom;
        public int id;
        public bool estaLibre;
        public string vendedor;
        public int numeroMesa;
        public bool esBarra;
        public double total;

        public Mesa()
        {

        }
        public Mesa(int id, bool estaLibre, string vendedor, int numeroMesa, bool esBarra)
        {
            this.id = id;
            this.estaLibre = estaLibre;
            this.vendedor = vendedor;
            this.numeroMesa = numeroMesa;
            this.esBarra = esBarra;
            pedidoCom = new List<Comida>();
            pedidoBeb = new List<Bebida>();
        }


        public void AgregarPedido(Bebida bebida, Comida comida)
        {
            this.pedidoBeb.Add(bebida);
            this.pedidoCom.Add(comida);
        }
    }
}
