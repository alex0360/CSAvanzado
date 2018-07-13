using System;
using System.Collections.ObjectModel;

namespace Colecciones2_4ObservableCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.ObjectModel.ObservableCollection<Show.Punto> puntos =
                new System.Collections.ObjectModel.ObservableCollection<Show.Punto>()
                { new Show.Punto(4,55), new Show.Punto(17,22)};

            // Adicionamos el handler
            puntos.CollectionChanged += Puntos_CollectionChanged;

            puntos.Add(new Show.Punto(2, 3));

            Show.Punto miPunto = new Show.Punto(5, 5);
            puntos.Add(miPunto);
            puntos.Remove(miPunto);

            Console.ReadKey();
        }

        // Este es el handler que se invoca cuando cambia la coleccion
        static void Puntos_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            // El tipo de evento que ocurrio
            Console.Write("El evento es {0}\n", e.Action);

            // Si la accion es adicionar
            if(e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine("Elementos nuevos");
                foreach (Show.Punto p in e.NewItems)
                    Console.WriteLine(p.ToString());
            }

            // Si la Accion fue remover
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Elementos afectados por el cambio");
                foreach (Show.Punto p in e.OldItems)
                    Console.WriteLine(p.ToString());
            }

            Console.WriteLine();
        }
    }
}
