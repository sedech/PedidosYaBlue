namespace PedidosYaBlue
{
    public class BuilterTXT
    {
        /*
    Fernandez Ignacio.

    Rodrigo Martinez Peralta .

    Melchisedech Belizaire.


    Patrón Builder: 

        El patrón de diseño Builder es un patrón de diseño creacional que se utiliza para construir objetos complejos paso a paso. 
        Permite la creación de objetos complejos con una gran cantidad de opciones y configuraciones, 
        sin necesidad de crear una clase para cada posible combinación de opciones. 
        En lugar de eso, el patrón de diseño Builder separa la construcción de un objeto complejo en varios pasos,
        permitiendo que los objetos sean construidos de forma incremental y flexible.

    Ejemplo: Digamos que queremos construir una clase “Casa”, esta puede tener muchas características como un jardín, pileta,
        2 pisos, etc.
    Envés de crear una clase nueva para cada una de las posibles combinaciones con builder 
        podemos crearlas paso a paso según nuestra necesidad.
        /////////////////////////////////////////////////////////
        
    Patrón Mediator: 

    Es un patrón de comportamiento que hace de puente entre dos o más objetos para que la comunicación entre ellos 
    sea más ordenada y se reduzcan las dependencias entre los objetos.

    Ejemplo: En una sala de chat, se utiliza un mediador para evitar que los usuarios se comuniquen entre ellos directamente. 
    En cambio, los usuarios envían y reciben información del mediador.
        ///////////////////////////////////////////////////////////////
        
    Patrón chain of responsibility:

    El patrón de diseño "Chain of Responsibility" (Cadena de responsabilidad) es un patrón de comportamiento que se utiliza
        para diseñar sistemas en los que se desea procesar una solicitud a través de una serie de objetos que pueden 
        manejar la solicitud de forma jerárquica. En este patrón, cada objeto en la cadena tiene la oportunidad de manejar
        la solicitud o pasarla al siguiente objeto en la cadena. Si un objeto en la cadena no puede manejar la solicitud,
        la pasa al siguiente objeto de la cadena hasta que se maneje la solicitud o se llegue al final de la cadena.

    En un sistema de manejo de correos electrónicos, en el que los correos electrónicos pueden ser manejados 
        por diferentes filtros (por ejemplo, filtro de spam, filtro de publicidad, etc.), 
        y cada filtro tiene la oportunidad de manejar el correo antes de pasarlo al siguiente filtro o a la bandeja de entrada.

        ///////////////////////////////////////////////////////////////
        

    Patrón Strategy:

    El patrón de diseño "Strategy" (Estrategia) es un patrón de comportamiento que se utiliza para permitir que un objeto 
        pueda cambiar su comportamiento en tiempo de ejecución, seleccionando una estrategia de entre varias disponibles. 
        En este patrón, se define una interfaz común para las diferentes estrategias, 
        lo que permite que los objetos que utilizan estas estrategias no necesiten conocer las especificidades de cada una. 
        De esta forma, es posible cambiar la estrategia utilizada en tiempo de ejecución sin afectar el funcionamiento 
        del objeto que la utiliza.

    Un ejemplo en el que se puede utilizar este patrón es en un sistema de simulación de juegos de estrategia,
        en el que se pueden seleccionar diferentes estrategias para las unidades de combate.
        Cada unidad puede tener una estrategia diferente, pero todas implementan la misma interfaz Estrategia. 
        De esta forma, es posible cambiar la estrategia utilizada por una unidad en tiempo de ejecución, 
        sin necesidad de modificar el código de la unidad.

        ///////////////////////////////////////////////////////////////

    Patron Template method:

    El patrón de diseño "Template Method" (Método de Plantilla) es un patrón de comportamiento que se utiliza 
        para definir un esqueleto de un algoritmo en una superclase, mientras que permite que las subclases 
        proporcionen implementaciones específicas para algunas de las partes del algoritmo. 
        En este patrón, se define una clase abstracta que contiene un método que implementa 
        el esqueleto del algoritmo y llama a métodos abstractos (o a métodos con implementaciones por defecto) 
        que las subclases deben implementar para proporcionar su propia funcionalidad.

    Un ejemplo en el que se puede utilizar este patrón es en la creación de un juego de ajedrez, 
        donde se pueden definir las reglas generales del juego en la clase abstracta y 
        las reglas específicas de cada pieza en las subclases correspondientes.

         */
    }
}
