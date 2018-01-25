using System;

namespace MappingClasses
{
    public class Historial_Salario_Empleado
    {
        public int Id { get; set; }
        public decimal Salario_Anterios { get; set; }
        public decimal Salario_Nuevo { get; set; }
        public DateTime Fecha_Modificacion { get; set; }
    }
}
