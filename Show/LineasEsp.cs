namespace Show
{
    class LineasEsp
    {
        /// <summary>
        /// Dividir la pantalla:
        /// defaut : Salto sin divicion.
        ///    valor 0: divicion sin salto.
        ///    valor 1: divicin y un salto.
        ///    valor 2: salto, divicion y salto.
        /// </summary>
        /// <param name="salto"></param>
        public static void Salto(int salto = 3)
        {
            switch(salto) {
                case 0: System.Console.Write("--------"); break;
                case 1: System.Console.Write("--------\n"); break;
                case 2: System.Console.Write("\n--------\n"); break;
                default: System.Console.Write("\n"); break;
            }
        }
    }
}
