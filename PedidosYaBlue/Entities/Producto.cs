namespace PedidosYaBlue.Entities
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set;}
        public string Descripcion { get; set;} 
        public string Precio{ get; set;}
        public int Stock { get; set;}

        public Producto(int id, string nombre, string descripcion, string precio, int stock)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
            Stock = stock;
        }
    }
}
