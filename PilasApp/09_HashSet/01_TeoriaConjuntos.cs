public static class Conjuntos{
    public static void Run(){
        // Definimos un conjunto llamado numeros que contendra enteros
        HashSet<int> numeros = new HashSet<int>();

        // Con el método add agregamos elementos al conjunto
        numeros.Add(2); 
        numeros.Add(3); // Agregamos el elmento 3 al conjunto

        // bool existe = numeros.Contains(2);

        // if(existe == true){
        //     System.Console.WriteLine("El elemento 2 ya existe");
        // }
        // else{
        //     System.Console.WriteLine("El elemento 2 no existe");
        // }

        // El método contains busca un elemento dentro del conjunto
        if(numeros.Contains(3)){ // buscamos el elemento 3 dentro 
            System.Console.WriteLine("El elemento 3 ya existe");
        }
        else{
            System.Console.WriteLine("El elemento 3 no existe");
        }

        //Imprimir el conjunto
        // System.Console.WriteLine("El contenido del conjunto es:");
        // foreach (var item in numeros) // recorrer la colección numeros
        // {
        //     Console.WriteLine(item);
        // }
        Imprimir(numeros);
    }

    /// <summary>
    /// Funcion para imprimir los elementos de un conjunto
    /// </summary>
    /// <param name="datos">conjunto de datos que se quiere imprimir</param>
    public static void Imprimir(HashSet<int> datos){
        System.Console.WriteLine("El contenido del conjunto es: ");
        foreach (var item in datos) // recorrer la colección numeros
        {
            System.Console.WriteLine(item); 
        }
    }

    /// <summary>
    /// Funcion genérica para imprimir un conjunto de datos
    /// </summary>
    /// <typeparam name="T">Tipo de dato</typeparam>
    /// <param name="conjunto">Colección de datos</param>
    public static void Imprimir<T>(HashSet<T> conjunto)
    {
        Console.WriteLine("Elementos en el HashSet:");
        foreach (var elemento in conjunto)
        {
            Console.Write(elemento + " ");
        }
        System.Console.WriteLine();
    }
}