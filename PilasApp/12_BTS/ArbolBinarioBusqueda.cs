public static class ArbolBinarioBusqueda{
    public static void Run(){
        
        ArbolBST bst = new ArbolBST();

        string[] frutas = {"banana", "apple", "orange", "peach", "grape"};

        System.Console.WriteLine("Elementos del árbol");
        foreach (var item in frutas)
        {
            bst.Insertar(item);
            System.Console.Write(" - " + item);
        }

        System.Console.WriteLine();
        System.Console.WriteLine(" ****** Recorrido de un bst ****** ");
        System.Console.WriteLine("pre-order");
        bst.PreOrden(bst.raiz);
        System.Console.WriteLine();
        System.Console.WriteLine("in-order");
        bst.EnOrden(bst.raiz);
        System.Console.WriteLine();
        System.Console.WriteLine("post-order");
        bst.PostOrden(bst.raiz);
        System.Console.WriteLine();

        System.Console.WriteLine();
        string buscar = "orange";
        Nodo? buscado = bst.Buscar(buscar);
        if (buscado != null)
            Console.WriteLine($"Nodo con valor \"{buscar}\" encontrado.");
        else
            Console.WriteLine($"Nodo con valor \"{buscar}\" no encontrado.");
    }
}