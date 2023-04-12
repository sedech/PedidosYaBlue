namespace PedidosYaBlue.Entities
{
    public class PedidoPremium
    {
        public int Id { get; set; }
        public ClientePremium Cliente { get; set; }
        public Producto Producto { get; set; }
        public string DireccionEntrega { get; set; } 
        public bool Entregado { get; set; }
        public DateTime FechaEntrega { get; set; }

        public PedidoPremium(int id, ClientePremium cliente, Producto producto, string direccionEntrega, bool entregado, DateTime fechaEntrega)
        {
            Id = id;
            Cliente = cliente;
            Producto = producto;
            DireccionEntrega = direccionEntrega;
            Entregado = entregado;
            FechaEntrega = fechaEntrega;
        }
    }
}
