using System;

namespace MappingClasses
{
    public class Ingreso
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public decimal MontoColones { get; set; }
        public decimal? MontoDolares { get; set; }
        public int? IdTipoCambio { get; set; }
        public Proyecto Proyecto { get; set; }

        public  TipoCambio TipoCambio { get; set; }
    }
}
