//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Factura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Factura()
        {
            this.DetalleFacturas = new HashSet<DetalleFactura>();
        }
    
        public int Id { get; set; }
        public System.DateTime Fecha { get; set; }
        public int Proveedor { get; set; }
        public int Proyecto { get; set; }
        public int Actividad { get; set; }
        public int IdTipoCambio { get; set; }
        public Nullable<int> MontoDolares { get; set; }
        public int MontoColones { get; set; }
    
        public virtual Actividad Actividad1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; }
        public virtual Proveedor Proveedor1 { get; set; }
        public virtual Proyecto Proyecto1 { get; set; }
        public virtual TipoCambio TipoCambio { get; set; }
    }
}
