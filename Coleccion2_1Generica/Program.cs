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

            // Eliminar por valor
            Lista.Remove(8);// Elimina el primero que se encuentre
            coleccion.Show(Lista);

            //  Lista se coloca en sentido contrario
            Lista.Reverse();
            coleccion.Show(Lista);

            // Mandamos a ordenar la Lista
            Lista.Sort();
            coleccion.Show(Lista);

            // Creamos nuna lista para Clase // https://youtu.be/49ls_biDRog
            System.Collections.Generic.List<Show.Punto> ListPuntos =
                new System.Collections.Generic.List<Show.Punto> {
                    new Show.Punto(5, 7),
                    new Show.Punto(7, 8)// Modo simplificado
                };

            ListPuntos.Add(new Show.Punto(12, 5)); // Modo posterior

            foreach(Show.Punto punto in ListPuntos)
                Console.WriteLine(punto);
            // No funciona por que no hemos implementado Icomparable
            // ListPuntos.Sort();
            Console.ReadKey();
        }
    }
}
