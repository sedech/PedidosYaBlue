namespace PedidosYaBlue.Entities
{
    public class Drone
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public float PesoMaximo { get; set; }
        public float AlturaMaxima { get; set; }

    public Drone(int id, string marca, string modelo, float pesoMaximo, float alturaMaxima)
        {
            Id = id;
            Marca = marca;
            Modelo = modelo;
            PesoMaximo = pesoMaximo;
            AlturaMaxima = alturaMaxima;
        }

    public void AddRepartidor()
        {
            throw new NotImplementedException();
        }
    
    
    }


        
}
