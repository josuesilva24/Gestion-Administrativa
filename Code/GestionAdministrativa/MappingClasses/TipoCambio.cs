using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingClasses
{
    public class TipoCambio
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public System.DateTime Fecha { get; set; }
        public bool Activo { get; set; }
    }
}
