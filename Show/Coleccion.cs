namespace Show
{
    public class Coleccion
    {
        #region ArrayList
            /// <summary>
            /// Mostrar con el loop For a un String
            /// </summary>
            /// <param name="array">Nombre del Array</param>
            /// <param name="salto">Divisor de pantalla</param>
            public void Show
                (System.Collections.ArrayList array, int salto = 1)
            {
                for(int n = 0 ; n < array.Count ; n++) {
                    System.Console.Write(" {0}", array[n]);
                }
                LineasEsp.Salto(salto);
            }
            /// <summary>
            /// Mostrar con el Loop for a un Integer
            /// </summary>
            /// <param name="array">Nombre del Array</param>
            /// <param name="salto">Divisor de pantalla</param>
            /// <param name="r">Como sobre cargador</param>
            public void Show
                (System.Collections.ArrayList array, int salto = 1, int r = 0)
            {
                for(int n = 0 ; n < array.Count ; n++) {
                    r = (int)array[n];// Convertir de Object a Integer
                    System.Console.Write(" {0}\n", r);
                }
                LineasEsp.Salto(salto);
            }
            /// <summary>
            /// Mostrar con el Loop foreach el contenido
            /// </summary>
            /// <param name="array">Nombre el Array</param>
            /// <param name="salto">Divisor de pantalla</param> 
            public void ShowForeach
                (System.Collections.ArrayList array, int salto = 1)
            {
                foreach(object objecto in array) {
                    System.Console.Write(" {0}", objecto);
                }
                LineasEsp.Salto(salto);
            }
            // Mostramos la cantidad de elementos del arreglo
        #endregion
        #region BitArray
        /// <summary>
        ///  Mostramos el contenido del Array
        /// </summary>
        /// <param name="bitArray">Nombre de BitArray</param>
        /// <param name="salto">Divisor de pantalla</param>
        /// <param name="pNombre">Nombre de la instacia</param>
        public static void Show
        (System.Collections.BitArray bitArray, int salto = 2, string pNombre = "")
        {
            int c = 0;
            System.Console.Write("{0}\t", pNombre);

            foreach(bool b in bitArray) {
                c++;
                if(b) System.Console.Write("1");
                else System.Console.Write("0");
                if(c % 8 == 0) System.Console.Write(",");
            }
            LineasEsp.Salto(salto);
        }
        #endregion
        #region HashTable
        /// <summary>
        /// Muestra El contenido de un HashTable
        /// </summary>
        /// <param name="Tabla">Nombre de la tabla</param>
        public static void Show
            (System.Collections.Hashtable Tabla)
        {
            foreach(System.Collections.DictionaryEntry elemento in Tabla)
                System.Console.Write("({0}, {1})\n", elemento.Key, elemento.Value);
        }
        #endregion
        #region Queue
        /// <summary>
        /// Muestra el contenido de un Queue
        /// </summary>
        /// <param name="Queue">Muestra un Array Queue</param>
        /// <param name="algumento">Muestra un texto por delante</param>
        /// <param name="salto">Un salto de linia</param>
        public void Show
            (System.Collections.Queue Queue, System.String algumento="", int salto = 1) {
            foreach(string fruta in Queue)
                System.Console.Write("{1}->{0}\n", fruta, algumento);
            LineasEsp.Salto(salto);
        }
        #endregion
        #region SortedList
        /// <summary>
        /// Muestra una lista de tipo SortedList
        /// </summary>
        /// <param name="sortedList">Un Array SortedList</param>
        /// <param name="salto">Tipo de Salto</param>
        public void Show
            (System.Collections.SortedList sortedList, int salto = 1)
        {
            foreach(System.Collections.DictionaryEntry elemento in sortedList)
                System.Console.Write("({0}, {1}) \n", elemento.Key, elemento.Value);
            LineasEsp.Salto(salto);
        }
        #endregion
        #region Stack
        /// <summary>
        /// Muestra los Valores de un Stack
        /// </summary>
        /// <param name="Stack">Un Array Stack</param>
        /// <param name="algumento">Un Texto por delante</param>
        /// <param name="salto">El Tipo de Salto</param>
        public void Show
            (System.Collections.Stack Stack, string algumento, int salto=1) {
            foreach(object fruta in Stack) 
                System.Console.Write("{1}-> {0}\n",fruta,algumento);
                
            LineasEsp.Salto(salto);
        }
        #endregion
        #region Lista<INT(Short|INT16)>
        /// <summary>
        /// Muestra el contenido de una lista generica de Short,Int16
        /// </summary>
        /// <param name="Lista">Nombre de la Lista</param>
        /// <param name="salto">Tipo de Salto deciado</param>
        public void Show
            (System.Collections.Generic.List<System.Int16> Lista, int salto=1) {

            for(int i=0 ; i<Lista.Count; i++) {
                System.Console.Write("{0}\n", Lista[i]);
            }
            LineasEsp.Salto(salto);
        }
        #endregion
        #region Stack<Punto>
        /// <summary>
        /// Muestra los Valores de un Stack generio de tipo Class Punto
        /// </summary>
        /// <param name="puntos">Nombre de la Instacia de la Class Punto</param>
        /// <param name="salto">Tipo de Salto deciado</param>
        public void Show(System.Collections.Generic.Stack<Punto> puntos, int salto= 1)
        {
            foreach(Punto p in puntos)
                System.Console.Write("->{0}\n", p);
            LineasEsp.Salto(salto);
        }
        #endregion
        #region Queue<Punto>
        /// <summary>
        /// Muestra los Valores de un Queue generio de tipo Class Punto
        /// </summary>
        /// <param name="puntos">Nombre de la Instacia de la Class Punto</param>
        /// <param name="salto">Tipo de Salto deciado</param>
        public void Show(System.Collections.Generic.Queue<Punto> puntos, int salto = 1)
        {
            foreach(Punto p in puntos)
                System.Console.Write("->{0}\n", p);
            LineasEsp.Salto(salto);
        }
        #endregion
        #region SortedSet<Punto>
        /// <summary>
        /// Muestra los Valores de un SortedSet generio de tipo Class Punto
        /// </summary>
        /// <param name="StPuntos">Nombre de la Instacia de la Class Punto</param>
        /// <param name="salto">Tipo de Salto deciado</param>
        public void Show
            (System.Collections.Generic.SortedSet<Punto> StPuntos, int salto=1)
        {
            foreach (Punto p in StPuntos)
                System.Console.Write("->{0}\n", p);
            LineasEsp.Salto(salto);
        }
        #endregion
    }
}