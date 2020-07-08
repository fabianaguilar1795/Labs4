using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Entidades;
using System.Configuration;


namespace CapaDatos
{
    public class GestionBD
    {
        List<Facturas> listado;

        public List<Facturas> listaFacturas()
        {
            listado = new List<Facturas>();
            Facturas objFactura = new Facturas();
            objFactura = new Facturas() { idFactura = 0001, numLinea = 1, codProducto = "A100", detProducto = " PRODUCTO X", cantProducto = 5, costUnitario = 1000, totalLinea = 5000 };
            listado.Add(objFactura);
            objFactura = new Facturas() { idFactura = 0002, numLinea = 1, codProducto = "A200", detProducto = " PRODUCTO Y", cantProducto = 2, costUnitario = 2500, totalLinea = 5000 };
            listado.Add(objFactura);
            objFactura = new Facturas() { idFactura = 0003, numLinea = 1, codProducto = "B100", detProducto = " PRODUCTO Z", cantProducto = 1, costUnitario = 3000, totalLinea = 3000 };
            listado.Add(objFactura);
            objFactura = new Facturas() { idFactura = 0004, numLinea = 1, codProducto = "B200", detProducto = " PRODUCTO A", cantProducto = 3, costUnitario = 500, totalLinea = 1500 };
            listado.Add(objFactura);
            return listado;
        }
    }
}
