namespace PedidosYaBlue
{
    /*
     en una aplicación de pedidos delivery usando el lenguaje C#, 
    el patrón Observer se puede utilizar para notificar 
    a los clientes sobre el estado de sus pedidos en tiempo real.
     */
    public class Patrones
    {
        /*
        Esa clase de PedidoPremium debe tener una lista de observers y métodos para añadir
        y eliminar , así como para notificarles 
        cuando hay un cambio del estado de pedido
         */
        public class PedidoPremium
        {
            private List<IObersver> observers = new List<IObersver>();
            public string Estado { get; private set; }

            public void NotifyEstado(string newEstado)
            {
                this.Estado = newEstado;
                NotifyObservers();
            }

            public void AddObserver(IObserver observer)
            {
                observers.Add(observer);
            }

            public void DeleteObserver(IObserver observer)
            {
                observers.Remove(observer);
            }

            public void NotifyObserver()
            {
                foreach (var observer in observers)
                    observer.Notify(this);
            }
        }

        /*
         Creamos una interfaz IObserver que sea implementada por los observadores de la clase PedidoPremium. 
        Esta interfaz tiene un método que se llame Actualizar, 
        el cual se llamará cada vez que el estado del pedido cambie.
         */

        public interface Iobserver
        {
            void Notify(PedidoPremium pedidoPremium);
        }

        /*
         Creamos una clase ClientePremium que implemente la interfaz IObserver.
        Esta clase tiene un método que se llame Notify 
        y que se llame cada vez que haya un cambio en el estado del pedido.
         */

        public class ClientePremium : IObserver
        {
            public void Notify(PedidoPremium pedidoPremium)
            {
                Console.WriteLine("El pedido está en {pedidoPremium.Estado}");
            }
        }

        /*
        
         */
        static void Main(string[] args)
        {
            var pedidoPremium = new PedidoPremium();
            var clientePremium = new ClientePremium();

            pedidoPremium.AddObserver(clientePremium);

            pedidoPremium.NotifyEstado("Recibido");
            pedidoPremium.NotifyEstado("En preparación");
            pedidoPremium.NotifyEstado("Enviado");
            pedidoPremium.NotifyEstado("Entregado");
        }


        /*
        
         */

        /*
         Definimos una interfaz IObserver que contenga 
        el método Update para que los observadores
        puedan ser notificados de los cambios 
        en el estado del pedido.
         */

        public interface IObserver
        {
            void Update(PedidoPremium pedidoPremium);
        }

        /*
         * ok
         Definimos una clase Usuario que actúe como observador y que implemente la interfaz IObserver. 
        La clase Usuario podría contener la información del cliente
        debería implementar el método Update para recibir notificaciones cuando se actualice el estado del pedido.
         */

        public class PedidoPremium : IObservable
        {
            private List<IObserver> observers = new List<IObserver>();
            public string Estado { get; set; }
            public string Dirección { get; set; }
            public DateTime HoraEntrega { get; set; }

            public void AddObserver(IObserver observer)
            {
                observers.Add(observer);
            }

            public void DeleteObserver(IObserver observer)
            {
                observers.Delete(observer);
            }

            public void NotifyObservers()
            {
                foreach (Iobserver observer in observers)
                {
                    observer.Update(this);
                }
            }

            public void NotifyEstado(string Estado)
            {
                Estado = estado;
                NotifyObservers();
            }
            

        }
    }
}
