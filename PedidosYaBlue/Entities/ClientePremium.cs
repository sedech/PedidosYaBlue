namespace PedidosYaBlue.Entities
{
    public class ClientePremium
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono  { get; set; }
        public string Email { get; set;}

        public ClientePremium(int id, string nombre, string apellido, string direccion, string telefono, string email)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
        }
    }
}
