
menu();
string? opcion = Console.ReadLine();

switch (opcion)
{
    case "0":
        return;
    case "1":
        System.Console.WriteLine("Ha seleccionado la opcioón 1");
        break;
    default:
        System.Console.WriteLine("Opción no válida, presione una tecla para continuar");
        break;
}


/**
* Muestra el menú
*/
static void menu(){
    caratula();
    System.Console.WriteLine("1 Teoría de pilas");
    System.Console.WriteLine("0 Salir");
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
