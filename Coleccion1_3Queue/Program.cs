using System;
using Show;

namespace Coleccion1_3Queue
{
    class Program
    {
       static Coleccion Show = new Coleccion();

        // https://youtu.be/MjCjQCCtmcE
        static void Main(string[] args)
        { 
            System.Collections.Queue miQueue = new System.Collections.Queue();
            // Addicionamos objetos
            miQueue.Enqueue("Manzana");
            miQueue.Enqueue("Freza");
            miQueue.Enqueue("Pera");

            // Interactuamos
            Show.Show(miQueue);

            // Obtener el primer objeto y sacarlo del Queue
            Console.WriteLine("DeQueue {0}", miQueue.Dequeue());
            Console.WriteLine("DeQueue {0}", miQueue.Dequeue());
            Show.Show(miQueue,"Despues DeQueue");

            // Add Elementos
            miQueue.Enqueue("Limon");
            miQueue.Enqueue("Mango");
            miQueue.Enqueue("Ciruela");

            //  Obtener el primer objeto y sin sacarlo del Queue
            Console.WriteLine("Peek {0}", miQueue.Peek());

            Show.Show(miQueue, "Despues Peek");

            // Conteo de Objeto
            Console.WriteLine("Numero de Objetos {0}\n",miQueue.Count);

            // Verifica si existe un objeto
            Console.WriteLine("Hay Mango {0}", miQueue.Contains("Mango"));
            Console.WriteLine("Hay Manzana {0}", miQueue.Contains("Manzana"));

            System.Console.ReadKey();
        }
    }
}
