namespace Show
{
    /// <summary>
    /// Devuelve la Cantidad de elementos
    /// </summary>
    public static class CountElement
    {
        /// <summary>
        /// Mostrar la cantidad de elementos del HashTable
        /// </summary>
        /// <param name="Hashtable">Instacia del HashTable</param>
        /// <returns>la Cantidad de elementos</returns>
        public static int Count
            (System.Collections.Hashtable Hashtable)
        {
            System.Console.Write("Total de Elementos {0} \n" ,Hashtable.Count);
            return Hashtable.Count;
        }
        /// <summary>
        /// Mostrar la cantidad de elementos del BitArray
        /// </summary>
        /// <param name="BitArray">Instacia del BitArray</param>
        /// <returns>la Cantidad de elementos</returns>
        public static int Count
            (System.Collections.BitArray Array)
        {
            System.Console.Write("Total de Elementos {0} \n", Array.Count);
            return Array.Count;
        }
        /// <summary>
        /// Mostrar la cantidad de elementos del ArrayList
        /// </summary>
        /// <param name="ArrayList">Instacia del ArrayList</param>
        /// <returns>la Cantidad de elementos</returns>
        public static int Count
            (System.Collections.ArrayList Array)
        {
            System.Console.Write("Total de Elementos {0} \n", Array.Count);
            return Array.Count;
        }
        /// <summary>
        /// Muestra la cantidad de elementos del SortedList
        /// </summary>
        /// <param name="SortedList">Instacia del SortedList</param>
        /// <returns>la Cantidad de elementos</returns>
        public static int Count
            (System.Collections.SortedList SortedList)
        {
            System.Console.Write("Total de Elementos {0} \n", SortedList.Count);
            return SortedList.Count;
        }
        /// <summary>
        /// Muestra la cantidad de elementos del Stack
        /// </summary>
        /// <param name="Stack">La instacia a cuantifical</param>
        /// <returns>la Cantidad de elementos</returns>
        public static int Count
            (System.Collections.Stack Stack){
            System.Console.Write("Total de Elementos {0} \n", Stack.Count);
            return Stack.Count;
        }
        /// <summary>
        /// Muestra la cantidad de elementos de la Lista
        /// </summary>
        /// <param name="List">La instacia a cuantifical</param>
        /// <returns>la Cantidad de elementos</returns>
        public static int Count
            (System.Collections.Generic.List<System.Int16> List)
        {
            System.Console.Write("Total de elementos {0}",List.Count);
            return List.Count;
        }
        /// <summary>
        /// Muestra la cantidad de elementos de un SortedSet
        /// </summary>
        /// <param name="StPuntos">La instacia a cuantifical</param>
        /// <returns>la Cantidad de elementos</returns>
        public static int Count
            (System.Collections.Generic.SortedSet<Punto> StPuntos)
        {
            foreach (Punto p in StPuntos)
                System.Console.Write("->{0}", StPuntos);
            return StPuntos.Count;
        }
    }
}
