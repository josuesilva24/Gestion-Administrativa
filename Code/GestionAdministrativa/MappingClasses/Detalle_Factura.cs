using EFF;
using System.Collections.Generic;
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
            return context.DetalleFacturas.Where(e => e.Id == IdDetFactura).firstOrDefault();
        }


        public void AddProveedor(DetalleFactura detfactura)
        {
            context.DetalleFacturas.add(detfactura);
            context.DetalleFacturas.SaveChanges();
        }
    }
}
