public static class EjemplosCola{
    public static void Run(){
        // Queue sirve para definir una cola
        // usuarios es una colección con strings
        Queue<string> usuarios = new Queue<string>();

        // Enqueue sirve para encolar, agregar elementos a la cola
        usuarios.Enqueue("Ana"); // Ana es el elemento que entra primero
        usuarios.Enqueue("Juan");
        usuarios.Enqueue("Carla");
        usuarios.Enqueue("Enrique");
        imprimirCola(usuarios);

        // Dequeue: Extrae el primer elemento
        usuarios.Dequeue();
        System.Console.WriteLine();
        imprimirCola(usuarios);
        
        // llenar una cola con 50 usuarios
        for (int i = 1; i <= 50; i++)
        {
            usuarios.Enqueue("usuario_"+i.ToString()); // Eje: usuario_1, usuario_2 ....
        }
        imprimirCola(usuarios);


        //TODO: Cola prioritaria 
    }

    private static void imprimirCola(Queue<string> cola){   
        foreach (var item in cola)
        {
            System.Console.WriteLine(item);
        }
    }
}