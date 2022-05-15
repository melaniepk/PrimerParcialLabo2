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
        public bool estaLibre;
        public Usuario vendedor;
        public int numeroMesa;
        public bool esBarra;
        public double total;

        public Mesa()
        {

        }
        public Mesa(bool estaLibre,int numeroMesa, bool esBarra)
        {
            this.estaLibre = estaLibre;
            this.numeroMesa = numeroMesa;
            this.esBarra = esBarra;
            pedidoCom = new List<Comida>();
            pedidoBeb = new List<Bebida>();
        }
      
       

    }
}
