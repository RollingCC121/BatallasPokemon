using System;

namespace PokemonBattleGame
{
    public static class Utils
    {
        // Lee una opción numérica dentro de un rango válido.
        public static int LeerOpcion(int min, int max)
        {
            while (true)
            {
                Console.Write($"> "); // Pide al usuario una opción
                string? input = Console.ReadLine(); // Lee la entrada del usuario

                // Intenta convertir la entrada a número y verifica si está en el rango
                if (int.TryParse(input, out int opcion) && opcion >= min && opcion <= max)
                    return opcion; // Si es válido, lo retorna

                // Si no es válido, muestra mensaje de error y repite
                Console.WriteLine($"⛔ Entrada inválida. Ingresa un número entre {min} y {max}.");
            }
        }

        
        // Pausa el programa hasta que se presione Enter.
        public static void EsperarEnter()
        {
            Console.WriteLine("\nPresiona ENTER para continuar...");
            Console.ReadLine();
        }

        // Hace una pausa en milisegundos (ej. para dramatismo)
        public static void Delay(int milisegundos)
        {
            System.Threading.Thread.Sleep(milisegundos);
        }

        
        // Imprime texto como si estuviera escribiéndose.
        public static void EscribirConDelay(string texto, int msPorLetra = 30)
        {
            foreach (char c in texto)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(msPorLetra);
            }
            Console.WriteLine();
        }
    }
}
