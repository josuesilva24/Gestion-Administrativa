using System.Collections.Generic;
using System.Linq;

namespace MappingClasses
{
    public class Empleado:BaseData
    {
 

        public List<EFF.Empleado> GetAllEmpleados()
        {
        
         return  context.Empleadoes.ToList();

        }

        public EFF.Empleado GetEmpleado(int IdEmpleado)
        {
            return context.Empleadoes.Where(e => e.Id == IdEmpleado).FirstOrDefault();
        }


        public void AddEmpleado(EFF.Empleado empleado)
        {
             context.Empleadoes.Add(empleado);
             context.SaveChanges();

        }

    }
}
