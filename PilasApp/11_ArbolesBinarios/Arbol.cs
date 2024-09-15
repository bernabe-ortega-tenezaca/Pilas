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

        private string code_graph = "";

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

        public Node? Search(Node root, int key) {
            if (root == null || root.Value == key) return root;
            if (key < root.Value) return Search(root.left, key);
                return Search(root.right, key);
        }

        public void imprimirInOrder(Node raiz){
            if (raiz != null)
            {
                imprimirInOrder(raiz.left);
                Console.Write(raiz.Value + " ");
                imprimirInOrder(raiz.right);
            }
            System.Console.WriteLine();
        }

        /// <summary>
        /// El método de graficar esta basado en la solución de César Sazo
        /// https://www.youtube.com/watch?v=chrIJgjr4MI
        /// Arbol Binario de Busqueda en C#
        /// </summary>
        public void graficar()
        {
            // lineas para windows
            // TextWriter text;
            // text = new StreamWriter("C:\\Fuentes\\abbT.txt");

            // lineas para MacOS
            string path = "/Users/aqui_el_usuario/Downloads";  // cambie por el usuario correspondiente de su macbook
            string fileName = "abbT.txt";
            TextWriter text;

            // Asegúrate de que la carpeta exista
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            text = new StreamWriter(Path.Combine(path, fileName));


            string escribir;
            escribir = obtenernodos();
            text.WriteLine(escribir);
            text.Close();

            //Generar imagen en windows            
            //Generate_Graph("abbT.txt", "C:/Fuentes");

            // Generar imagen en macOS
            Generate_Graph(fileName, path);
        }

        private string obtenernodos()
        {
            code_graph += "digraph{";
            code_graph += "\n";
            code_graph += "\n";

            code_graph += "subgraph cluster_1{ ";
            code_graph += "\n";
            code_graph += "label = \"ARBOL BINARIO DE BUSQUEDA:\"; ";
            code_graph += "\n";

            agregarmasnodos(Raiz);//METODO QUE AGREGA EL CUERPO DEL ARCHIVO .txt QUE SE VA A GENERAR

            code_graph += "\n";
            code_graph += "}";
            code_graph += "\n";
            code_graph += "\n";
            code_graph += "}";

            return code_graph;
        }

        private void agregarmasnodos(Node raiz)
        {
            if (raiz != null)
            {
                code_graph += "\n";
                if (raiz.left != null)
                {
                    agregarmasnodos(raiz.left);
                    code_graph += (raiz.Value.ToString() + "->" + raiz.left.Value.ToString());
                    code_graph += "\n";
                }
                if (raiz.right != null)
                {
                    agregarmasnodos(raiz.right);
                    code_graph += (raiz.Value.ToString() + "->" + raiz.right.Value.ToString());
                    code_graph += "\n";
                }
            }
        }

        private static void Generate_Graph(string fileName, string path)
        {
            try
            {
                var command = string.Format("dot -Tjpg {0} -o {1}", Path.Combine(path, fileName), Path.Combine(path, fileName.Replace(".txt", ".jpg")));
                
                // lineas para windows
                // var procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd.exe", "/C " + command);
                // var proc = new System.Diagnostics.Process();

                //lineas para macOS
                var procStartInfo = new System.Diagnostics.ProcessStartInfo("/bin/bash", "-c \"" + command + "\"");
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                procStartInfo.CreateNoWindow = true;

                var proc = new System.Diagnostics.Process();


                proc.StartInfo = procStartInfo;
                proc.Start();
                proc.WaitForExit();
            }
            catch (Exception x)
            {
                Console.WriteLine(x.ToString());
            }
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
        // Creamos un árbol binario llamado miArbol
        ArbolBinario miArbol = new ArbolBinario();

        // creamos un vector con todos los valores que insertaremos en el arbol
        int[] valores = {18,9,25,7,12,23,29,2,8,11,21,24,31}; 
        
        // insertamos los valores en el árbol
        foreach (var item in valores)
        {
            miArbol.insertar(item);
        }

        miArbol.insertar(32);

        miArbol.imprimirInOrder(miArbol.Raiz);

        miArbol.graficar();
        
    }
}