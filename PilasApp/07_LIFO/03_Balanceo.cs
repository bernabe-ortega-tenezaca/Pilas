public static class Balanceo{

    public static void Run(){
        // (4+3*)2+5)))

        // Definimos una pila para almacenar letras
        Stack<char> ecuacion = new Stack<char>();

        string formula = "(4+3*((2+5)))";

        foreach (char letra in formula)
        {
            ecuacion.Push(letra); // Pasamos cada letra de la formula a la pila de caracteres
        }
        imprimirPila(ecuacion);

        int ParentesisAbiertos = 0;
        int ParentesisCerrados = 0;

        while(ecuacion.Count > 0){
            char signo = ecuacion.Pop();
            if(signo == '('){
                ParentesisAbiertos ++;
                // System.Console.WriteLine("abierto {0}", signo);
            }

            if(signo == ')'){
                ParentesisCerrados++;
                // System.Console.WriteLine("cerrado {0}", signo);

            } 
            // System.Console.WriteLine("tiene {0} elementos", ecuacion.Count);
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