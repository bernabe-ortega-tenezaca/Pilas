public static class Hanoi{

    static Stack<int> torreA = new Stack<int>();
    static Stack<int> torreB = new Stack<int>();
    static Stack<int> torreC = new Stack<int>();

    
    public static void Run(){
        System.Console.WriteLine("Cuántos discos contiene la torre");
        int NumDiscos = int.Parse(Console.ReadLine());

        for (int i = NumDiscos; i >=1 ; i--){
            torreA.Push(i);
        }
        DibujarTorres();
        Resolver(NumDiscos, torreA, torreC, torreB);
    }

    static void Resolver(int n, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar){
        if (n == 1)
        {
            MoverDisco(origen, destino);
        }
        else{
            Resolver(n-1, origen, auxiliar, destino);
            MoverDisco(origen, destino);
            DibujarTorres();

            Resolver(n-1, auxiliar, destino, origen);
        }
    }

    static void MoverDisco(Stack<int> origen, Stack<int> destino){
        destino.Push(origen.Pop());
    }

    static void DibujarTorres(){
        System.Console.WriteLine("Estado de las Torres:");
        System.Console.WriteLine("Torre A: {0}", string.Join(", ", torreA));
        System.Console.WriteLine("Torre B: {0}", string.Join(", ", torreB));
        System.Console.WriteLine("Torre C: {0}", string.Join(", ", torreC));
        System.Console.WriteLine(new string('*',30));
    }
}