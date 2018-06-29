using System;

namespace Coleccion2_1Generica
{
    //https://youtu.be/G7ca-1s7ySY
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.Generic.List<Int16> Lista =
                new System.Collections.Generic.List<short> {
                    7,5,4,3,8
                };// Desde que iniciamos 
            Lista.Add(9);// Anadiendo nuevos datos

            Show.Coleccion coleccion = new Show.Coleccion();
            coleccion.Show(Lista);
            Show.CountElement.Count(Lista);

            // Vemos sin contiene a determinado Elemento
            Console.WriteLine(Lista.Contains(5));
            Console.WriteLine("-------------");
            // Obtenemos indice de un elemento
            Console.WriteLine(Lista.IndexOf(4));
            Console.WriteLine("-------------");
            // Insertamos elementos en un indice
            Lista.Insert(2, 55);
            Console.WriteLine("-------------");

            foreach(int valor in Lista)
                Console.WriteLine(valor);// Coleccion.Show(Lista);
            Console.WriteLine("-------------");

            // Eliminamos elementos en un indice
            Lista.RemoveAt(2);
            Console.WriteLine("-------------");

            coleccion.Show(Lista);
            Console.WriteLine("-------------");

            // Eliminar por valor
            Lista.Remove(8);// Elimina el primero que se encuentre
            coleccion.Show(Lista);
            Console.WriteLine("-------------");

            // 

            Console.ReadKey();
        }
    }
}
