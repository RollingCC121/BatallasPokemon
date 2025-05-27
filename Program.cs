using System;
using PokemonBattleGame;

class Program
{
    static void Main()
    {
        while (true)
        {
            Interfaz.MostrarMenuPrincipal();
            int opcion = Utils.LeerOpcion(1, 3);

            switch (opcion)
            {
                case 1:
                       int indice = Interfaz.ElegirPokemon();
                    Pokemon elegido = Pokedex.Pokemones[indice];
                    Batallas.IniciarBatalla(elegido);
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("📘 Pokémon disponibles:\n");
                    Pokedex.MostrarTodos();
                    Console.WriteLine("\nPresiona ENTER para volver...");
                    Console.ReadLine();
                    break;

                case 3:
                    Console.WriteLine("\n👋 ¡Gracias por jugar!");
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
