using System;
using System.Collections.Generic;


namespace PokemonBattleGame
{
    public static class Pokedex
    {
        public static List<Pokemon> Pokemones = new()
        {
            new PokemonFuego("Charmander", 100, new List<Ataque> {
                new Ataque("Lanzallamas", 30, 85),
                new Ataque("Ascuas", 20, 95)
            }),
            new PokemonAgua("Squirtle", 110, new List<Ataque> {
                new Ataque("Pistola Agua", 25, 90),
                new Ataque("Burbuja", 20, 95)
            }),
            new PokemonPlanta("Bulbasaur", 105, new List<Ataque> {
                new Ataque("Latigazo", 25, 90),
                new Ataque("Drenadoras", 15, 100)
            })
        };

        public static void MostrarTodos()
        {
            foreach (var p in Pokemones)
            {
                Console.WriteLine($"🔹 {p.Nombre} ({p.Tipo}) - HP: {p.HP}");
                foreach (var atk in p.Ataques)
                {
                    Console.WriteLine($"   • {atk.Nombre} (Daño: {atk.Daño}, Precisión: {atk.Precision}%)");
                }
            }
        }
    }
}
