using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmatown.Modelos
{
    class DetalleFactura
    {
		public Articulo Articulo { get; set; }
		public int Cantidad { get; set; }
        public int Descuento { get; set; }
        public double MontoDescontado { get; set; }
        public DetalleFactura(Articulo articulo, int cantidad, int descuento)
		{
			Articulo = articulo;
			Cantidad = cantidad;
			Descuento = descuento;
		}

		public double CalcularMontoDescontado()
        {
			if (Descuento > 0)
			{
				MontoDescontado = ((Articulo.preUnitario * Cantidad) * Descuento) / 100;
				return MontoDescontado;
			} else
            {
				MontoDescontado = 0;
				return MontoDescontado;
			}

		}

		public double CalcularSubtotal()
		{
			return (Articulo.preUnitario * Cantidad) - CalcularMontoDescontado();
		}

	}
}
