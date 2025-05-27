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
                    Console.Clear();
                    Console.WriteLine("🚀 Comenzando aventura...\n");
                    Thread.Sleep(1000);
                    // Aquí podrías invocar Batallas.Iniciar() más adelante
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
