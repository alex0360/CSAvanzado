using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanzando4_3ClasesGenericas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ver la Clase COperacion, no posible compilar
            // Usamos dynamic para resolverlo, el tipo se checa en ejecucion ya no en compilacion.

            Show.COperacion<int> operacion = new Show.COperacion<int>();
            //Show.COperacion<string> operacionS = new Show.COperacion<string>();

            Console.WriteLine(operacion.Multiplicacion(5, 4));
            //Console.WriteLine(operacionS.Suma("Hola", "Mundo"));

            
        }
    }
}
