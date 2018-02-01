using System.Collections.Generic;
using System.Linq;
namespace MappingClasses
{
    public class Actividad:BaseData
    {


        public List<EFF.Actividad> GetAllActividades()
        {

            return context.Actividads.ToList();

        }

        public EFF.Actividad GetActividad(int IdActividad)
        {
            return context.Actividads.Where(e => e.Id == IdActividad).FirstOrDefault();
        }


        public void AddActividad(EFF.Actividad Actividad)
        {
            context.Actividads.Add(Actividad);
            context.SaveChanges();

        }
    }
}
