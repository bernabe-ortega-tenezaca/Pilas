public static class EjemplosCola{
    public static void Run(){
        // Queue sirve para definir una cola
        // usuarios es una colección con strings
        Queue<string> usuarios = new Queue<string>();

        // Enqueue sirve para encolar, agregar elementos a la cola
        usuarios.Enqueue("Ana");
        usuarios.Enqueue("Juan");
        usuarios.Enqueue("Carla");
        usuarios.Enqueue("Enrique");

        foreach (var item in usuarios)
        {
            System.Console.WriteLine(item);
        }

    }
}