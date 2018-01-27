using System;
using System.Collections.Generic;

namespace MappingClasses
{
    public class Factura:BaseData
    {
        public List<Factura> GetAllFacturas()
        {
            return context.Facturas.ToList();
        }

        public Factura GetProveedor(int IdFactura)
        {
            return context.Facturas.Where(e => e.Id == IdFactura).firstOrDefault();
        }


        public void AddProveedor(Factura factura)
        {
            context.Facturas.add(factura);
        }

    }
}
