using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entidades
{
    public class Facturas
    {
        public int idFactura { set; get; }
        public int numLinea { set; get; }
        public string codProducto { set; get; }
        public string detProducto { set; get; }
        public int cantProducto { set; get; }
        public double costUnitario { set; get; }
        public double totalLinea { set; get; }

    }
}
