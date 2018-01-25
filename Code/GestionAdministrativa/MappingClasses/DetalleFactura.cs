namespace MappingClasses
{
    public class DetalleFactura
    {
        public int Id { get; set; }
        public string Producto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecionUnidad { get; set; }
    }
}
