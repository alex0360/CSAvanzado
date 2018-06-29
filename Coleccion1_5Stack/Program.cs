using System;
using System.Collections;

namespace Coleccion1_5Stack
{
    //https://youtu.be/zSE4imxQbG0
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.Stack stack = new Stack();
            Show.Coleccion coleccion = new Show.Coleccion();
            // Agragar Objetos
            stack.Push("Manzana");
            stack.Push("Pera");
            stack.Push("Ciruela");
            stack.Push("Mango");

            // Iteramos
            coleccion.Show(stack,"");

            // Hacemos pop
            Console.WriteLine(stack.Pop());
            coleccion.Show(stack,"");

            // Hacemos 
            Console.WriteLine(stack.Peek());
            coleccion.Show(stack,"");

            // Cantida de elementos
            Show.CountElement.Count(stack);

            Console.ReadKey();
        }
    }
}
