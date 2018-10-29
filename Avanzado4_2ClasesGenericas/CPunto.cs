using System;
using System.Collections.Generic;
using System.Text;

namespace Avanzado4_2ClasesGenericas
{
    // Tipo Representa al tipo con el que se trabaja en un momento dado
    class CPunto<Tipo>
    {
        // Creamos variables de tipo Tipo
        private Tipo x;
        private Tipo y;

        // Podemos recibir parametros de tipo Tipo
        public CPunto(Tipo px, Tipo py) {
            x = px;
            y = py;
        }

        public override string ToString()
        {
            return string.Format("X={0}, Y={1}", x, y);
        }

        public void Reset() {
            // Colocamos el valor de default para el tipo Tipo
            // Numero 0
            // Referencias Null

            x = default(Tipo);
            y = default(Tipo);
        }

        public void EncuentraTipo() {
            if(typeof(Tipo) == typeof(int))
                System.Console.WriteLine("Trabajando con Entero");
            if(typeof(Tipo) == typeof(double))
                System.Console.WriteLine("Trabajando con Doble");
            if(typeof(Tipo) == typeof(string))
                System.Console.WriteLine("Trabajando con Texto");
            if(typeof(Tipo) == typeof(char))
                System.Console.WriteLine("Trabajando con Caracter");
            if(typeof(Tipo) == typeof(float))
                System.Console.WriteLine("Trabajando con Flotante");
        }
    }
}
