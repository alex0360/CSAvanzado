using System;
using System.Collections;

namespace Coleccion1_4SorteList
{
    class Program
    {
        // https://youtu.be/3VsCtkfQMPI
        static void Main(string[] args)
        {
            System.Collections.SortedList sortedList = new SortedList();

            // Agregamos datos
            sortedList.Add(754, "Honda");
            sortedList.Add(123, "Volvo");
            sortedList.Add(587, "Nissan");
            sortedList.Add(323, "Fiat");
            //

            Show.Coleccion show = new Show.Coleccion();
            // Iteramos
            show.Show(sortedList);

            // Cantidad de elementos
            Show.CountElement.Count(sortedList);

            // Contiene elementos
            Console.WriteLine(sortedList.Contains(123));
            Console.WriteLine(sortedList.Contains(678));

            Console.WriteLine(sortedList.ContainsKey(587));
            Console.WriteLine(sortedList.ContainsValue("Volvo"));

            Console.WriteLine("----------");

            //// Obtenemos elemento por indice
            Console.WriteLine(sortedList.GetKey(2));
            Console.WriteLine(sortedList.GetByIndex(2));

            Console.ReadKey();
        }
    }
}
