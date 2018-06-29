namespace Coleccion1_3HashTable
{
    // https://youtu.be/FOp8vP6HvL0
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.Hashtable tabla =
                new System.Collections.Hashtable {

                    // Adicionamos elementos Por instacia
                    { 123, "Hola" },
                    { 234, "Saludos" },
                    
                    { 12763, "Programacion" },
                    { 567, "C#" }
                };
            tabla.Add(45, "Adios"); // La forma mas comun de Añadir datos

            // Mostramos los elementos
            Show.Coleccion.Show(tabla);

            // Intentamos colocar un elemento con llave repetida
            //tabla.Add(123,"Otro mas"); No puede aver dos key iguales

            // Cantidad de Elementos
            Show.CountElement.Count(tabla);

            // Obtenemos el elemto de determinada llave
            System.Console.WriteLine(tabla[567]);
            System.Console.WriteLine(tabla[568]);

            System.Console.Write("--------\n");

            // https://youtu.be/FOp8vP6HvL0

            // colocamos elementos en un llave
            tabla[45] = "Avanzado";
            tabla[300] = "Colecciones"; // Si no existe el Key se adiciona como nuevo

            Show.Coleccion.Show(tabla);

            // Verificamos si hay elemento
            System.Console.WriteLine(tabla.Contains(567));
            System.Console.WriteLine(tabla.Contains(335));


            System.Console.ReadKey();

        }
    }
}
