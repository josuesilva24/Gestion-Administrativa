using System;
using System.Collections.Generic;

namespace MappingClasses
{
    public class Factura
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public Proveedor Proveedor { get; set; }
        public Proyecto Proyecto { get; set; }
        public Actividad Actividad { get; set; }
        public TipoCambio TipoCambio { get; set; }
        public int? MontoDolares { get; set; }
        public int MontoColones { get; set; }
        public  ICollection<DetalleFactura> DetalleFacturas { get; set; }

    }
}
