class ArbolBST
{
    public Nodo? raiz;

    /// <summary>
    /// Constuctor del árbol BST
    /// </summary>
    public ArbolBST(){
        raiz = null;
    }

    public void Insertar(string valor){
        
        raiz = InsertarRecurrente(raiz, valor);
    }

    private Nodo InsertarRecurrente(Nodo? nodo, string valor){
        if (nodo == null)
        {
            nodo = new Nodo(valor);
            return nodo;
        }

        if (string.Compare(valor, nodo.Valor) < 0)
            nodo.LadoIzquierdo = InsertarRecurrente(nodo.LadoIzquierdo, valor);
        else if (string.Compare(valor, nodo.Valor) > 0)
            nodo.LadoDerecho = InsertarRecurrente(nodo.LadoDerecho, valor);

        return nodo;
    }

    public void PreOrden(Nodo? raiz){
        System.Console.Write(" * " + raiz.Valor + " * ");
        if(raiz.LadoIzquierdo != null) PreOrden(raiz.LadoIzquierdo);
        if(raiz.LadoDerecho != null) PreOrden(raiz.LadoDerecho);
    }

    public void EnOrden(Nodo? raiz){
        if (raiz.LadoIzquierdo != null) EnOrden(raiz.LadoIzquierdo);
        System.Console.Write(" * " + raiz.Valor + " * ");
        if (raiz.LadoDerecho != null) EnOrden(raiz.LadoDerecho);
    }

    public void PostOrden(Nodo? raiz){
        if(raiz.LadoIzquierdo != null) PostOrden(raiz.LadoIzquierdo);
        if(raiz.LadoDerecho != null) PostOrden(raiz.LadoDerecho);
        System.Console.Write(" * " + raiz.Valor + " * ");
    }

    public Nodo? Buscar(string valor){
        return BuscarRecursivo(raiz, valor);
    }

    private Nodo? BuscarRecursivo(Nodo? root, string valor){
        if(root == null || root.Valor == valor) return root;

        if (string.Compare(valor, root.Valor) < 0)
            return BuscarRecursivo(root.LadoIzquierdo, valor);
        else
            return BuscarRecursivo(root.LadoDerecho, valor);
    }
}