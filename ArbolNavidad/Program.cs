namespace ArbolNavidad
{
    static class Program
    {
        public static void Main(string[] args)
        {
            // Éste código pide un número X, impar y crea un árbol de navidad de base X.
            // Requisitos:
            // - El número tiene que ser mayor o igual a 3.
            // Ej: X=9:
            /*
             *     *
             *    ***
             *   *****
             *  *******
             * *********
             *
             */

            // Pedir base del árbol
            int baseArbol = 0;
            bool pedirBaseArbol = true;
            const int baseArbolMin = 3;

            string mensajePedirBaseArbol =
                $"Introduce la base del árbol.{Environment.NewLine}Debe ser impar y mayor o igual a {baseArbolMin}";
            while (pedirBaseArbol)
            {
                Console.Clear();
                Console.WriteLine(mensajePedirBaseArbol);

                string numeroIntroducido = Console.ReadLine();

                bool esNumero = int.TryParse(numeroIntroducido, out baseArbol);
                if (esNumero) // Comprobar si se introdujo un número
                {
                    bool esImpar = baseArbol % 2 > 0;

                    if (esImpar && baseArbol >= baseArbolMin) // Es impar y mayor o igual al mínimo
                    {
                        pedirBaseArbol = false;
                    }
                }
            }

            Console.WriteLine($"Base: {baseArbol}");

            int filas = (baseArbol / 2) + 1;

            int charactersPerRow = 1;
            int espacios = baseArbol/2;

            for (int i = 0; i < filas; i++)
            {
                // Espacios al principio
                for (int j = 0; j < espacios; j++)
                {
                    Console.Write(" ");
                }

                // Árbol
                for (int j = 0; j < charactersPerRow; j++)
                {
                    Console.Write("*");
                }

                // Espacios al final
                for (int j = 0; j < espacios; j++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine();
                charactersPerRow += 2;
                espacios -= 1;
            }

            Console.WriteLine();
            Console.WriteLine("Pulsa 'Enter' para salir");
            Console.ReadLine();
        }
    }
}