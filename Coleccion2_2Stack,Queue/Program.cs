using System;
using Show;

namespace Coleccion2_2Stack_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.Generic.Stack<Punto> puntosStack =
                new System.Collections.Generic.Stack<Punto>();

            // Stack
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Stack");
            Console.ForegroundColor = ConsoleColor.DarkGray;

            // Añadiendo nuevos datos
            puntosStack.Push(new Punto(3, 4));
            puntosStack.Push(new Punto(5, 7));
            puntosStack.Push(new Punto(9, 6));
            puntosStack.Push(new Punto(1, 4));
            Coleccion coleccion = new Coleccion();
            coleccion.Show(puntosStack);

            // Hacemos un peek
            Console.Write("Peek {0}\n",puntosStack.Peek());

            coleccion.Show(puntosStack);

            // Hacemos dos pop
            Console.Write("Pop {0}\n", puntosStack.Pop());
            Console.Write("Pop {0}\n", puntosStack.Pop());

            coleccion.Show(puntosStack);

            // Queue
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Queue");
            Console.ForegroundColor = ConsoleColor.White;

            System.Collections.Generic.Queue<Punto> puntosQueue =
                new System.Collections.Generic.Queue<Punto>();

            // Añadiendo nuevos datos
            puntosQueue.Enqueue(new Punto(5, 4));
            puntosQueue.Enqueue(new Punto(4, 7));
            puntosQueue.Enqueue(new Punto(1, 6));
            puntosQueue.Enqueue(new Punto(7, 4));
            
            coleccion.Show(puntosQueue);

            // Hacemos un Peek
            Console.Write("Peek {0}\n", puntosQueue.Peek());

            // Hacemos dequeue
            Console.Write("Dequeue {0}\n", puntosQueue.Dequeue());
            Console.Write("Dequeue {0}\n", puntosQueue.Dequeue());
            Console.Write("Dequeue {0}\n", puntosQueue.Dequeue());
            coleccion.Show(puntosQueue);
            Console.Write("Dequeue {0}\n", puntosQueue.Dequeue());
            coleccion.Show(puntosQueue);
            Console.ReadKey();
        }
    }
}
