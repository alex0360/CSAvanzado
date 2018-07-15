using System;

namespace Avanzado3_1varNulleableDynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tipo var
            //https://youtu.be/BcY3VBQc8JQ
            #region Var

            // Declaracion implicita de variables
            // Solo se permiten en variables locales
            // No se pueden usar en atributos
            // No se pueden usar como tipos de retorno
            // Se debe de colocar un valor en el momento de declaracion y no puede ser null
            // No confundir con var o Variant de otros lenguajes, es fuertemente tipificado
            // Se Usan en LINQ donde un query puede dar un resultado dinamicamente creando

            // Decraracion
            var a = 5;
            var b = "Hola Mundo";
            var c = 15.68f;
            var d = true;
            //var e = null; Imposible
            //var d = 58; no conciden los tipos
            var f = c; // Conciden los tipos

            // Imprecion
            Console.WriteLine("variable a:{0}", a);
            Console.WriteLine("variable b:{0}", b);
            Console.WriteLine("variable c:{0}", c);
            Console.WriteLine("variable d:{0}", d);
            Console.WriteLine("e es No puede sel Null");
            Console.WriteLine("variable f:{0}=c", f);

            Console.Write("\nTIPOS DE LAS VARIBLAS\n");
            Console.WriteLine("a es {0}", a.GetType().Name);
            Console.WriteLine("b es {0}", b.GetType().Name);
            Console.WriteLine("c es {0}", c.GetType().Name);
            Console.WriteLine("d es {0}", d.GetType().Name);
            Console.WriteLine("e es No puede sel Null");
            Console.WriteLine("f es {0}=c->{1}", f.GetType().Name,f);
            Console.Write("-------------------------\n");
            #endregion

            // Tipos Nulleables
            // https://youtu.be/BcY3VBQc8JQ?t=7m13s
            #region Tipos Nulleables
            // Los tipos de valor no pueden tener un null;

            //int valor = null;

            // Los tipos nulleables pueden representar los mismos valores mas el valor null
            // son utiles en bases de datos, pues podemos encontrar columnas no definidas
            // Para definirlo usamos ?
            // Pero realmente creamos una instacia de System.Nulleable<Tipo>

            Console.Write("\nTipos Nulleables '?'\n\n");
            int? dato = 5;// Permite la forma Nativa 
            //System.Int32? dato = null;
            Console.WriteLine("dato = {0}", dato);
            dato = null;
            Console.WriteLine("dato = {0}", dato);

            double? precio = null; // o Sytem.Double? precio = null;
            Console.WriteLine("Precio: {0}", precio);
            precio = 6.99;
            Console.WriteLine("Precio: {0}", precio);

            // El String no es nulleable ya que es un tipo por referencia
            // string? nombre = "Alex"
            
            // Saber si tiene o no Valor
            Console.Write("\nSaber Si tiene o no Valor\n\n");

            if (precio.HasValue)
                Console.WriteLine("Precio tiene valor {0}", precio.Value);
            else
                Console.WriteLine("Precio No tiene valor");

            Console.WriteLine("Precio = null");
            precio = null;

            if (precio== null)
                Console.WriteLine("Precio No tiene valor");

            // El operador ?? nos permite asignar un valor en caso de que tenga Null
            Console.Write("\nTipos Nulleables.Operador '??'\n\n");

            double? numero = Asignador() ?? 5.5;
            Console.WriteLine("numero:{0}",numero);
            Console.Write("-------------------------\n");
            #endregion

            // Tipo dynamic
            // https://youtu.be/BcY3VBQc8JQ?t=14m57s
            #region Dynamic
            Console.Write("\nTipo Dynamic\n\n");
            // Dynamic se puede ver como una forma de System.Object
            // en el sentido de que cualquier valor se puede asignar a dynamic
            // La diferecia es que no es fuertemente tipado y Object si
            // Se le puede asignar cualquier tipo al inicio y posteriormente
            // asignar otro
            dynamic i = 5;
            Console.WriteLine("Tipo {0}, valor: {1}", i.GetType(), i);

            i = "Hola Mundo";
            Console.WriteLine("Tipo {0}, valor: {1}", i.GetType(), i);

            // A diferecia de object, en dynamic se conoce el tipo hasta el
            // tiempo de ejecucion
            // Dynamic se puede usar como tipo de retorno
            // No se puede usar en expresiones lambda o en metodos anonimos
            // Puede resultar util si nos comunicamos con bibliotecas COM
            #endregion

            System.Console.ReadKey();
        }

        public static double? Asignador()
        {
            return 4.5;
            // return null;
        }
    }
}
