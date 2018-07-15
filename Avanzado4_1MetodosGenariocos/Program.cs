using System;

namespace Avanzado4_1MetodosGenariocos
{
    class Program
    {
        // https://youtu.be/TaaYIv8nXAo
        static void Main(string[] args)
        {
            int x = 5;
            int y = 3;

            Console.WriteLine("x={0}, y={1}", x,y);
            Intercambio<int>(ref x, ref y);
            Console.WriteLine("x={0}, y={1}", x,y);

            double? n = 78.5;
            double? m = 95.3d;

            Console.WriteLine("n={0}, m={1}", n,m);
            Intercambio<double?>(ref n, ref m);
            Console.WriteLine("n={0}, m={1}", n,m);

            string H = Asignador() ?? "Hola";
            String M = "Mundo";

            Console.WriteLine("H={0}, M={1}", H,M);
            Intercambio<string>(ref H, ref M);
            Console.WriteLine("H={0}, M={1}", H,M);
            System.Console.ReadKey();
        }
        static string Asignador() => /*null*/ "Hello";
        static void Intercambio<Tipo>( ref Tipo a, ref Tipo b)
        {
            Tipo temporal;
            temporal = a;
            a = b;
            b = temporal;
        }
    }
}
