using Show;
namespace Coleccion1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Colecciones adentro de System.Collection
            // ArrayList
            // BitArray
            // Hashtable (k,v)
            // Queue
            // SortedList (k,v) k,v
            // Stack
            int r = 0;
            Coleccion show = new Coleccion();

            #region https://youtu.be/GAal3fPN59g
            System.Collections.ArrayList Palabras =
               new System.Collections.ArrayList();
   
            // Podemos adiccionar con rango
            Palabras.AddRange(new System.String[] {
                "Hola","como","estas?"});

             CountElement.Count(Palabras);

            // Recorremos el Array con loop for
            show.Show(Palabras,2);

            // Agragar mas palabra
            Palabras.Add("Bien y tu?");
            // Volvemos a mostrar el total de elementos
            CountElement.Count(Palabras);

            //Recorriendo con foreach
            show.ShowForeach(Palabras,2);
            
            #endregion

            #region https://youtu.be/bdGSQ-9N22s
            // Array con valores numericos
            System.Collections.ArrayList Valores =
                new System.Collections.ArrayList();
            
            Valores.AddRange(new int[] { 5, 6 });
            Valores.Add(7);
            Valores.Add(8);

            ////
            CountElement.Count(Valores);
            ////

            // Recorremos con loop for
            show.Show(Valores,1,r);
            

            // Verificar si existe un elemento en el ArrayList
            //con el metodo Contains()
            System.Console.WriteLine(" 5 existe "+Valores.Contains(5));
            System.Console.WriteLine(" 1 existe {0}",Valores.Contains(1));
            System.Console.Write("--------\n");

            // Insertamos en un indice en particular
            Valores.Insert(2, 4);

            ////
            CountElement.Count(Valores);
            ////

            show.ShowForeach(Valores,2);

            // Remover un elemento
            Valores.Remove(4);
            CountElement.Count(Valores);
            show.Show(Valores,1,r);

            // Remover en una posicion
            Valores.RemoveAt(0);
            CountElement.Count(Valores);
            show.Show(Valores, 1, r);
            #endregion
            System.Console.ReadKey();
        }
    }
}
