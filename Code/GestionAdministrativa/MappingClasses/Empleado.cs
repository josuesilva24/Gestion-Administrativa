using System.Collections.Generic;
using System.Linq;

namespace MappingClasses
{
    public class Empleado:BaseData
    {
 

        public List<Empleado> GetAllEmpleados()
        {
        
         return  context.Empleadoes.ToList();

        }

        public Empleado GetEmpleado(int IdEmpleado)
        {
            return context.Empleadoes.Where(e => e.Id == IdEmpleado).firstOrDefault();
        }


        public void AddEmpleado(Empleado empleado)
        {
             context.Empleadoes.add(empleado);
             context.Empleadoes.SaveChanges();

        }

    }
}
