using System;
using System.Collections.Generic;
using System.Linq;
namespace MappingClasses
{
    public class Proyecto:BaseData
    {

        public List<EFF.Proyecto> GetAllProyectos()
        {

            return context.Proyectoes.ToList();

        }

        public EFF.Proyecto GetProyecto(int IdProyecto)
        {
            return context.Proyectoes.Where(e => e.Id == IdProyecto).FirstOrDefault();
        }


        public void AddProyecto(EFF.Proyecto proyecto)
        {
            context.Proyectoes.Add(proyecto);
            context.SaveChanges();

        }
    }
}
