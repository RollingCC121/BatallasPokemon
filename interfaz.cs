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
╔══════════════════════════════════════════════╗
║      █▀▀█ █── █▀▀ █▀▀█ █▀▀▄ ▀▀█▀▀            ║
║      █▄▄▀ █── █▀▀ █▄▄▀ █──█ ──█──            ║
║      ▀─▀▀ ▀▀▀ ▀▀▀ ▀─▀▀ ▀▀▀─ ──▀──            ║
║                                              ║
║          ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄                 ║
║             POKÉMON BATTLE                   ║
║          ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀                 ║
║                                              ║
║               1. Start                       ║
║               2. Pokedex                     ║
║               3. Salir                       ║
╚══════════════════════════════════════════════╝
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

        public static void MostrarPantallaBatalla(
            Pokemon jugador, int vidaJugador,
            Pokemon enemigo, int vidaEnemigo,
            List<Ataque> ataques,
            string mensaje = "")
        {
            Console.Clear();
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Encabezado estilo GameBoy
            Console.WriteLine(@"
╔════════════════════════════════════════════════════════════════╗
║      █▀▀█ █── █▀▀ █▀▀█ █▀▀▄ ▀▀█▀▀        BATALLA POKÉMON       ║
╚════════════════════════════════════════════════════════════════╝
");

            // Enemigo arriba
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"  Enemigo: {enemigo.Nombre} ({enemigo.Tipo})");
            Console.Write("  HP: ");
            MostrarBarraVida(enemigo.HP, vidaEnemigo, 20);
            Console.WriteLine($" {vidaEnemigo}/{enemigo.HP}");
            Console.WriteLine();
            Console.ResetColor();

            // Espacio para simular pantalla GameBoy
            Console.WriteLine("  ----------------------------------------------");
            Console.WriteLine();

            // Jugador abajo
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"  Tu Pokémon: {jugador.Nombre} ({jugador.Tipo})");
            Console.Write("  HP: ");
            MostrarBarraVida(jugador.HP, vidaJugador, 20);
            Console.WriteLine($" {vidaJugador}/{jugador.HP}");
            Console.WriteLine();
            Console.ResetColor();

            // Ataques disponibles
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  Ataques disponibles:");
            for (int i = 0; i < ataques.Count; i++)
            {
                var atk = ataques[i];
                Console.WriteLine($"    {i + 1}. {atk.Nombre} (Daño: {atk.Daño}, Precisión: {atk.Precision}%)");
            }
            Console.ResetColor();

            // Mensaje de batalla (daño, fallo, victoria, etc.)
            if (!string.IsNullOrWhiteSpace(mensaje))
            {
                Console.WriteLine("\n  " + mensaje);
            }

            Console.WriteLine("\n  Elige un ataque (1-{0}):", ataques.Count);

        }

        // Barra de vida horizontal estilo GameBoy
        public static void MostrarBarraVida(int max, int actual, int largo = 20)
        {
            int llenado = (int)Math.Round((double)actual / max * largo);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[");
            for (int i = 0; i < llenado; i++) Console.Write("█");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            for (int i = llenado; i < largo; i++) Console.Write("░");
            Console.ResetColor();
            Console.Write("]");

        }
        
    }

}