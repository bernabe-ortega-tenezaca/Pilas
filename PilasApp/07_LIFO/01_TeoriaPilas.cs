public static class Pila{
    public static void Run(){
        // Definición de una pila para enteros
        Stack<int> pilaEnteros = new Stack<int>();

        // Agregar elementos de la pila
        pilaEnteros.Push(1); 
        pilaEnteros.Push(2);
        pilaEnteros.Push(20);
        pilaEnteros.Push(4);

        ImprimirPila(pilaEnteros);

        // Mostrar el elemento en la parte superior sin sacarlo de la pila
        int ElementoSuperior = pilaEnteros.Peek(); 
        System.Console.WriteLine("Elemento en la cima (Peek): {0}", ElementoSuperior);

        int ElementoSacado = pilaEnteros.Pop();
        System.Console.WriteLine("Se ha sacado el elemento {0}", ElementoSacado);
        ImprimirPila(pilaEnteros);

    }

    /**
    * Imprimir pila: Función para mostrar el contenido de una pila en pantalla
    */
    static void ImprimirPila(Stack<int> pila){
        System.Console.WriteLine();
        System.Console.WriteLine("Elementos de la pila: ");
        foreach (var item in pila) // Recorrer elementos de la pila
            {
                System.Console.WriteLine(item); //muestra el item en pantalla
            }
    }
}