using System;

namespace Avanzado4_2ClasesGenericas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Para puntoI, T Trabaja como int
            CPunto<int> puntoI = new CPunto<int>(3, 4);

            // Para puntoI, T Trabaja como Double
            CPunto<double> puntoD = new CPunto<double>(2.56, 1.87);

            // Para puntoI, T Trabaja como Float
            CPunto<float> puntoF = new CPunto<float>(8.98f, 7.69f);

            Console.WriteLine(puntoI);
            Console.WriteLine(puntoD);
            Console.WriteLine(puntoF);

            // Colocamos el valor de defaut
            puntoI.Reset();
            Console.WriteLine(puntoI);

            // Verificar el tipo
            puntoI.EncuentraTipo();
            puntoF.EncuentraTipo();
            puntoD.EncuentraTipo();

            Console.ReadKey();
        }
    }
}
