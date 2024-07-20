public static class EjemplosCola{
    public static void Run(){
        // Queue sirve para definir una cola
        // usuarios es una colección con strings
        Queue<string> usuarios = new Queue<string>();
        Random rnd = new Random();

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
        //Thread.Sleep(2000); // Pausa de 2000 milisegundos
        
        // llenar una cola con 50 usuarios
        for (int i = 1; i <= 50; i++)
        {
            usuarios.Enqueue("usuario_"+i.ToString()); // Eje: usuario_1, usuario_2 ....
        }
        System.Console.WriteLine();
        //Thread.Sleep(3000);
        //imprimirCola(usuarios);

        // simular atención al cliente
        while (usuarios.Count > 0)
        {
            System.Console.WriteLine("El usuario {0} ha sido atendido.", usuarios.Dequeue());
            Thread.Sleep(rnd.Next(2000)); //
        }

        //TODO: Cola prioritaria 
        //TODO: Pasajes
    }

    private static void imprimirCola(Queue<string> cola){   
        foreach (var item in cola)
        {
            System.Console.WriteLine(item);
        }
    }
}