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
        public List<DetalleFactura> GetDetFacturasPorFactura(int IdFactura)
        {
            return context.DetalleFacturas.Where(e => e.IdFactura == IdFactura).ToList();
        }


        public void AddProveedor(DetalleFactura detfactura)
        {
            context.DetalleFacturas.Add(detfactura);
            context.SaveChanges();
        }
    }
}
