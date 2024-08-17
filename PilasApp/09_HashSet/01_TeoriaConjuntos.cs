public static class Conjuntos{
    public static void Run(){
        // Definimos un conjunto llamado numeros que contendra enteros
        HashSet<int> numeros = new HashSet<int>();

        // Con el método add agregamos elementos al conjunto
        numeros.Add(2); 
        numeros.Add(3); // Agregamos el elmento 3 al conjunto

        //Imprimir el conjunto
        foreach (var item in numeros) // recorrer la colección numeros
        {
            Console.WriteLine(item);
        }

    }

}