/// <summary>
/// La clase nodo se usa para guardar valores de cadena
/// </summary>
class Nodo { // se entiende que es una clase pública
    public string Valor; // aqui se almacenaran los valores
    public Nodo? LadoIzquierdo; 
    public Nodo? LadoDerecho; // La incognita indica que puede ser Nulo

    public Nodo(string valor){
        Valor = valor;
        LadoIzquierdo = null;
        LadoDerecho = null;
    }
}