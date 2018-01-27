using System;
using System.Collections.Generic;
using System.Linq;

namespace MappingClasses
{
    public class Factura:BaseData
    {
        public List<EFF.Factura> GetAllFacturas()
        {
            return context.Facturas.ToList();
        }

        public EFF.Factura GetProveedor(int IdFactura)
        {
            return context.Facturas.Where(e => e.Id == IdFactura).FirstOrDefault();
        }


        public void AddProveedor(EFF.Factura factura)
        {
            context.Facturas.Add(factura);
        }

    }
}
