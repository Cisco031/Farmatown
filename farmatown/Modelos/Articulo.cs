using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmatown.Modelos
{
    class Articulo
    {
        public Articulo(int idArticulo, double preUnitario, string nomArticulo)
        {
            this.idArticulo = idArticulo;
            this.preUnitario = preUnitario;
            this.nomArticulo = nomArticulo;
        }

        public int idArticulo { get; set; }
        public double preUnitario { get; set; }
        public string nomArticulo { get; set; }


    }
}
