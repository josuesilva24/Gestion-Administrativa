using System.Collections.Generic;
namespace MappingClasses
{
    public class Proveedor:BaseData
    {

        public List<Proveedor> GetAllProveedores()
        {
            return context.Proveedors.ToList();
        }

        public Proveedor GetProveedor(int IdEmpleado)
        {
            return context.Proveedors.Where(e => e.Id == IdEmpleado).firstOrDefault();
        }


        public void AddProveedor(Proveedor provedor)
        {
            context.Proveedors.add(provedor);
            context.Proveedors.SaveChanges();

        }
    }
}
