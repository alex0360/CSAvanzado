using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coleccion2_3SortedSetGenerico
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<Show.Punto> puntos = new SortedSet<Show.Punto>
            {
                new Show.Punto(3, 7),
                new Show.Punto(8,11),
                new Show.Punto(2, 6),
            };

            puntos.Add(new Show.Punto(5, 9));

            Show.Coleccion coleccion = new Show.Coleccion();

            coleccion.Show(puntos);

            puntos.Add(new Show.Punto(1, 15));
            puntos.Add(new Show.Punto(1, 12));

            coleccion.Show(puntos);

            Console.ReadKey();

        }
    }
}
