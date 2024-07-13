public static class balanceo{

    static void Run(){
        // (4+(3*(2+5)))

        // Definimos una pila para almacenar letras
        Stack<char> ecuacion = new Stack<char>();

        string formula = "(4+(3*(2+5)))";

        foreach (char letra in formula)
        {
            ecuacion.Push(letra); // Pasamos cada letra de la formula a la pila de caracteres
        }
        imprimirPila(ecuacion);

        int ParentesisAbiertos = 0;
        int ParentesisCerrados = 0;

        foreach (var item in ecuacion)
        {
            if(item == '('){
                ParentesisAbiertos ++;
            }

            if(item == ')') ParentesisCerrados++;

        }

        if(ParentesisAbiertos == ParentesisCerrados){
            System.Console.WriteLine("Ecuación Balanceada");
        }else{
            System.Console.WriteLine("Ecuación NO balanceada");
        }


    }


    //Función para recorrer la pila e imprimir sus elementos
    static void imprimirPila(Stack<char> pila){
        foreach (var item in pila) 
        {
            System.Console.WriteLine(item);
        }
    }
}