using EFF;
using System.Collections.Generic;
using System.Linq;

namespace MappingClasses
{
    public class Detalle_Factura:BaseData
    {
        public List<DetalleFactura> GetAllDetFacturas()
        {
            return context.DetalleFacturas.ToList();
        }

        public DetalleFactura GetDetFacturas(int IdDetFactura)
        {
            return context.DetalleFacturas.Where(e => e.Id == IdDetFactura).FirstOrDefault();
        }


        public void AddProveedor(DetalleFactura detfactura)
        {
            context.DetalleFacturas.Add(detfactura);
            context.SaveChanges();
        }
    }
}
