using Show;
namespace Coleccion1_2BitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            #region https://youtu.be/_UtKEYYhi24
            Coleccion show = new Coleccion();
            System.Collections.BitArray bitArray =
                new System.Collections.BitArray(
                    new byte[] { 1, 2, 4, 8, 16 });// Convertiendo byte a bit

            CountElement.Count(bitArray);
            Coleccion.Show(bitArray, 2);

            //// Obtenemos un bit en particular
            System.Console.WriteLine(bitArray.Get(3));

            //// ponemos un bit en particular
            bitArray.Set(3, true);
            System.Console.WriteLine(bitArray.Get(3));
            Coleccion.Show(bitArray, 2);


            //https://youtu.be/pGS78ttnqfY

            // Clonacion del BitArray
            System.Collections.BitArray bitArray2 =
               (System.Collections.BitArray)bitArray.Clone();

            //// Invertir el Array, NOT
            bitArray2.Not();
            Coleccion.Show(bitArray2, 2);

            // Creando otro Array
            System.Collections.BitArray bitArray3 =
                new System.Collections.BitArray(new byte[] { 5, 7, 9, 13, 15 });
            Coleccion.Show(bitArray3, 2, "3°Array");

            //// Hacemos Or entre Arreglos
            bitArray3.Or(bitArray); // El resultado se guarda en el Array que llevo
                                    //acabo la invocacion.
            Coleccion.Show(bitArray, pNombre: "1°Array");
            Coleccion.Show(bitArray3, 3, pNombre: "Result");
            System.Console.WriteLine("=|||||||||=");

            //// Hacemos AND entre Array
            Coleccion.Show(bitArray, pNombre: "1°Array");
            Coleccion.Show(bitArray3, pNombre: "3°Array");

            // Hacemos el AND, BitArray 3 se modifica con el resultado
            bitArray3.And(bitArray);
            Coleccion.Show(bitArray3,3,"Result");
            System.Console.WriteLine("=&&&&&&&&&&&=");

            //// Hamos XOR entre Array
           bitArray3 = 
                new System.Collections.BitArray(new byte[] { 5, 7, 9, 13, 21 });
            Coleccion.Show(bitArray, pNombre:"1°Array");
            Coleccion.Show(bitArray3,pNombre: "3°Array");
                
            // Hacemos el XOR, Array 3 se modifica con el resultado
            bitArray3.Xor(bitArray);
            Coleccion.Show(bitArray3, pNombre:"Result");

            System.Console.ReadKey();
            #endregion
        }
    }
}
