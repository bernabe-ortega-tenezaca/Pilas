public static class Diccionario{

    // Este ejemplo NO resuelve palabras con doble significado
    // book => libro, reservación
    // bug => gusano, error de programación
    public static void Run(){
        Dictionary<string, string> idioma = new Dictionary<string, string>();

        //Agregar palabras al diccionario
        idioma.Add("Hola", "Hello");
        idioma.Add("Adios", "bye");
        // idioma.Add("book", "libro");
        // idioma.Add("book", "reservación");

        //Agregar palabras al diccionario desde una variable
        //string clave = "bienvenido";
        //string valor = "welcome";

        System.Console.WriteLine("Ingrese una nueva clave y valor al diccionario");
        
        //Agregar datos al diccionario desde teclado
        System.Console.WriteLine("Ingrese una clave");
        string? clave = Console.ReadLine();
        System.Console.WriteLine("Ingrese el valor asociado");
        string? valor = Console.ReadLine();
        
        //ContainsKey comprueba si una clave ya existe
        if(idioma.ContainsKey(clave))
        {
            System.Console.WriteLine("La palabra ya existe");
        }else{
            idioma.Add(clave, valor);
        }

        
        //Traductor
        System.Console.WriteLine("Ingrese un texto a traducir");
        string? texto = Console.ReadLine();

        string[] palabras = texto.Split(" "); //convertimos el texto en un vector
        string textoTraducido = string.Empty;
        string textoBuscado = string.Empty;

        // //imprimir contenido del diccionario
        // foreach (var item in idioma)
        // {
        //     System.Console.WriteLine(item);
        // }

        foreach (var item in palabras)
        {
            textoBuscado = item;

            if(idioma.ContainsKey(item)){
                // System.Console.WriteLine("palabra encontrada en el diccionario " + item);
                textoBuscado = idioma[item];
            }
            textoTraducido = textoTraducido + " " + textoBuscado;
        }
        
        System.Console.WriteLine(textoTraducido);
    }
}