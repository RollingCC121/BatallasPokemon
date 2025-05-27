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

    }


}