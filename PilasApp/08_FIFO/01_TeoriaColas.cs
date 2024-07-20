public static class Colas{
    public static void Run(){
        Queue<string> nombres = new Queue<string>();
        Random rnd = new Random();

        // Llenado de nombres simulados
        for (int i = 0; i < 30; i++)
        {
            nombres.Enqueue("Usuario_" + i.ToString());
            Thread.Sleep(rnd.Next(200)); // el equipo se tarda 3000 milisegundos antes de continuar con la siguiente instrucción
        }
        
         
        Imprimir(nombres);
    }

    public static void Imprimir(Queue<string> cola){
        foreach (var item in cola)
        {
            System.Console.WriteLine(item);
        }
    }
}