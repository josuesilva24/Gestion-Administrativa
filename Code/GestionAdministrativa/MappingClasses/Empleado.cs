using System.Collections.Generic;
using System.Linq;

namespace MappingClasses
{
    public class Empleado:BaseData
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string TipoIdentificacion { get; set; }
        public string Identificacion { get; set; }
        public string Telefono { get; set; }
        public string Telefono2 { get; set; }
        public string Direccion { get; set; }
        public string Notas { get; set; }
        public decimal? Salario { get; set; }
        public string Tipo_Salario { get; set; }

        public ICollection<Historial_Salario_Empleado> Historial_Salario_Empleado { get; set; }



        public List<Empleado> GetAllEmpleados()
        {
        
         return  context.Empleadoes.ToList();

        }

        public Empleado GetAEmpleado(int IdEmpleado)
        {
            return context.Empleadoes.Where(e => e.Id == IdEmpleado).firstOrDefault();
        }


        public void AddEmpleado(Empleado empleado)
        {
             context.Empleadoes.add(empleado);
        }

    }
}
