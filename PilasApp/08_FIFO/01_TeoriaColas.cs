public static class Colas{
    public static void Run(){
        Queue<string> nombres = new Queue<string>();

        // Llenado de nombres simulados
        for (int i = 0; i < 30; i++)
        {
            nombres.Enqueue("Usuario - " + i.ToString());
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