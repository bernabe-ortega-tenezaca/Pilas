
while (true)
{
    menu();
    string? opcion = Console.ReadLine();

    switch (opcion)
    {
        case "0":
            return;
        case "1":
            encabezado("Teoría de pilas");
            Pila.Run();
            pie();
            break;
        case "2":
            encabezado("Pilas - Torre de Hanoi");
            Hanoi.Run();
            pie();
            break;
        case "3":
            encabezado("Pilas - Balanceo de ecuaciones básicas");
            Balanceo.Run();
            pie();
            break;
        case "4":
            encabezado("Colas - Teoría");
            Colas.Run();
            pie();
            break;
        case "5":
            encabezado("Colas - Ejemplo");
            EjemplosCola.Run();
            pie();
            break;
        case "6":
            encabezado("Conjuntos HashSet - Teoría");
            Conjuntos.Run();
            pie();
            break;
        case "7":
            encabezado("Conjuntos HashSet - Ejemplo");
            EjConjuntos.Run();
            pie();
            break;
        case "8":
            encabezado("Diccionarios");
            Diccionario.Run();
            pie();
            break;
        case "9":
            encabezado("Arboles");
            //Diccionario.Run();
            pie();
            break;
        default:
            System.Console.WriteLine("Opción no válida, presione una tecla para continuar");
            break;
    }
} 


/**
* Muestra el menú
*/
static void menu(){
    caratula();
    System.Console.WriteLine("1 Teoría de pilas");
    System.Console.WriteLine("2     Pilas - Torre de Hanoi");
    System.Console.WriteLine("3     Pilas - Balanceo de ecuaciones básica");
    System.Console.WriteLine("4 Teoría de colas");
    System.Console.WriteLine("5     Ejemplos de colas");
    System.Console.WriteLine("6 Teoría de conjuntos");
    System.Console.WriteLine("7     Ejemplos de conjuntos");
    System.Console.WriteLine("8 Diccionario");
    System.Console.WriteLine("9 Árboles");
    System.Console.WriteLine(new string('-', 55));
    System.Console.WriteLine("0 Salir");
    System.Console.WriteLine();
}

/**
*   Muestra la caratula general del ejercicio.
*/
static void caratula()
{
    // Console.Clear();
    Console.WriteLine("\f\u001b\x1b[3J"); 
    System.Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++");
    System.Console.WriteLine("+             UNIVERSIDAD ESTATAL AMAZÓNICA           +");
    System.Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++");
    System.Console.WriteLine();
    System.Console.WriteLine("           Menú de opciones - Escriba un número");
    System.Console.WriteLine();

}

static void encabezado(string opcion){
    System.Console.WriteLine("======================================");
    System.Console.WriteLine(opcion);
    System.Console.WriteLine("======================================");
}

static void pie(){
    System.Console.WriteLine(new string('=', 20)); 
    System.Console.WriteLine("                          Pulse la tecla enter para continuar ...");
    Console.ReadLine();
}