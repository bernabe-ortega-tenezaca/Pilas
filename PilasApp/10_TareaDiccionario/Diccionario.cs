public static class Diccionario{
    public static void Run(){
        Dictionary<string, string> idioma = new Dictionary<string, string>();

        //Agregar palabras al diccionario
        idioma.Add("Hola", "Hello");
        idioma.Add("Adios", "bye");

        //Agregar palabras al diccionario desde una variable
        System.Console.WriteLine("Ingrese una nueva clave y valor al diccionario");
        System.Console.WriteLine("Ingrese una clave");
        string? clave = Console.ReadLine();
        //string clave = "bienvenido";
        //string valor = "welcome";
        System.Console.WriteLine("Ingrese el valor asociado");
        string? valor = Console.ReadLine();

        idioma.Add(clave, valor);

        //imprimir contenido del diccionario
        foreach (var item in idioma)
        {
            System.Console.WriteLine(item);
        }
    }
}