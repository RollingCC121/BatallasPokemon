using System;
using System.Threading;

namespace PokemonBattleGame
{
    public static class Interfaz
    {
        public static void MostrarMenuPrincipal()
        {
            Console.Clear(); //limpia la pantalla de la consola
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Permite mostrar codificacion utf-8
            Console.ForegroundColor = ConsoleColor.Green; // Cambia el color del texto a verde

            Console.WriteLine(@"
╔════════════════════════════════════════╗
║      █▀▀█ █── █▀▀ █▀▀█ █▀▀▄ ▀▀█▀▀      ║
║      █▄▄▀ █── █▀▀ █▄▄▀ █──█ ──█──      ║
║      ▀─▀▀ ▀▀▀ ▀▀▀ ▀─▀▀ ▀▀▀─ ──▀──      ║
║                                        ║
║          ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄           ║
║             POKÉMON BATTLE             ║
║          ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀           ║
║                                        ║
║               1. Start                 ║
║               2. Pokedex               ║
║               3. Salir                 ║
╚════════════════════════════════════════╝
");

        }

        public static int ElegirPokemon()
        {
            Console.Clear();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Green;

            // Encabezado del menú
            Console.WriteLine(@"
╔══════════════════════════════════════════════╗
║      █▀▀█ █── █▀▀ █▀▀█ █▀▀▄ ▀▀█▀▀            ║
║      █▄▄▀ █── █▀▀ █▄▄▀ █──█ ──█──            ║
║      ▀─▀▀ ▀▀▀ ▀▀▀ ▀─▀▀ ▀▀▀─ ──▀──            ║
║                                              ║
║         ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄                 ║
║         ELIGE TU POKÉMON                     ║
║         ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀                 ║
╠══════════════════════════════════════════════╣");

            // Listado de Pokémon y ataques dentro del menú
            for (int i = 0; i < Pokedex.Pokemones.Count; i++)
            {
                var p = Pokedex.Pokemones[i];
                Console.WriteLine($"║  {i + 1}. {p.Nombre} ({p.Tipo}) - HP: {p.HP,-22}");
                foreach (var atk in p.Ataques)
                {
                    string ataqueInfo = $"• {atk.Nombre} (Daño: {atk.Daño}, Precisión: {atk.Precision}%)";
                    Console.WriteLine($"║     {ataqueInfo,-34}");
                }
                Console.WriteLine("╠══════════════════════════════════════════════╣");
            }

            Console.WriteLine("╚══════════════════════════════════════════════╝");
            Console.ResetColor();

            Console.WriteLine("Selecciona el número de tu Pokémon:");
            int eleccion = Utils.LeerOpcion(1, Pokedex.Pokemones.Count);

            return eleccion - 1;
        }

    }


}