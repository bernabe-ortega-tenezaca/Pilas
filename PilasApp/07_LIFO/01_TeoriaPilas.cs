

public class Pila{
    static void Run(){
        // Definición de una pila para enteros
        Stack<int> pilaEnteros = new Stack<int>();

        // Agregar elementos de la pila
        pilaEnteros.Push(1);
        pilaEnteros.Push(2);
        pilaEnteros.Push(100);



        static void ImprimirPila(Stack<int> pila){
            foreach (var item in pila)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine(new string('-', 20));
        }
    }
}