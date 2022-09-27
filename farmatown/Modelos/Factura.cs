using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmatown.Modelos
{
    class Factura
    {
		public int IdFactura { get; set; }
		public int IdUsuario { get; set; }
		public int DniCliente { get; set; }
		public DateTime Fecha { get; set; }
		public double Descuento { get; set; }
		public double Total { get; set; }
        public bool ObraSocial { get; set; }
        public List<DetalleFactura> Detalles { get; set; }
		public Factura(bool obraSocial)
		{
			ObraSocial = obraSocial;
			Detalles = new List<DetalleFactura>();
		}

		public void AgregarDetalle(DetalleFactura detalle)
		{
			Detalles.Add(detalle);
		}

		public void QuitarDetalle(int indice)
		{
			Detalles.RemoveAt(indice);
		}

		public double CalcularTotal()
		{
			double total = 0;
			foreach (DetalleFactura detalle in Detalles)
			{
				total += detalle.CalcularSubtotal();
			}
			return total;
		}
	}
}
