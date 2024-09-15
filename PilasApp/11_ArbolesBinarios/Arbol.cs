public static class Arbol{

    /// <summary>
    /// Definición de un nodo
    /// </summary>
    public class Node{
        public int Value; // Se almacenaran valores enteros
        public Node? left; // El nodo izquierdo puede ser nulo
        public Node? right; // El nodo derecho puede ser nulo

        /// <summary>
        /// Constructor de un nodo
        /// </summary>
        /// <param name="valor">Requiere un valor entero</param>
        public Node(int valor){ 
            Value = valor;
            left = null;
            right = null;
        }
    }

    public class ArbolBinario{
        public Node? Raiz;

        public void insertar(int nuevoValor){
            // Si la raiz es nula, inserto el nuevo valor
            if (Raiz == null)
            {
                Raiz = new Node(nuevoValor);
            } else{
                // si la raíz no es nula llamo a una función recurrente
                insertarRecurrente(Raiz, nuevoValor);
            } 
        }

        private void insertarRecurrente(Node nodo, int valor){
            // Si el valor es menor que el valor de la raiz, vamos por la izq
            if(valor<nodo.Value){
                // si el nodo es nulo lo creamos
                if(nodo.left == null){
                    nodo.left = new Node(valor);
                } else{
                    insertarRecurrente(nodo.left, valor);
                }
            } else{
                if(nodo.right == null){
                    nodo.right = new Node(valor);
                } else{
                    insertarRecurrente(nodo.right, valor);
                }
            }
        }

        public Node? eliminar(Node raiz, int key){
            if (raiz == null) return raiz;
            
            if (key < raiz.Value) {
                raiz.left = eliminar(raiz.left, key);
            } else 
                if (key > raiz.Value) {
                    raiz.right = eliminar(raiz.right, key);
                } else {
                    if (raiz.left == null) 
                        return raiz.right;
                    else 
                        if (raiz.right == null) return raiz.left;
                            raiz.Value = MinValue(raiz.right);
                            raiz.right = eliminar(raiz.right, raiz.Value);
                        }
            return raiz;
        }

    }

    private static int MinValue(Node root) {   
        int minValue = root.Value;
        while (root.left != null) {
            minValue = root.left.Value;
            root = root.left;
        }
        return minValue;
    }
    public static void Run(){
        
    }
}