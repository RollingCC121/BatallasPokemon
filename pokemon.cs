using System.Collections.Generic;

namespace PokemonBattleGame
{
    public class Ataque
    {
        public string Nombre { get; set; }
        public int Daño { get; set; }
        public int Precision { get; set; }

        public Ataque(string nombre, int daño, int precision)
        {
            Nombre = nombre;
            Daño = daño;
            Precision = precision;
        }
    }

     // Clase base
    public class Pokemon
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int HP { get; set; }
        public List<Ataque> Ataques { get; set; }

        public Pokemon(string nombre, string tipo, int hp, List<Ataque> ataques)
        {
            Nombre = nombre;
            Tipo = tipo;
            HP = hp;
            Ataques = ataques;
        }
    }

    // Clase hija: Fuego
    public class PokemonFuego : Pokemon
    {
        public PokemonFuego(string nombre, int hp, List<Ataque> ataques)
            : base(nombre, "Fuego", hp, ataques) { }

        // Puedes agregar métodos o propiedades específicas aquí
    }

    // Clase hija: Agua
    public class PokemonAgua : Pokemon
    {
        public PokemonAgua(string nombre, int hp, List<Ataque> ataques)
            : base(nombre, "Agua", hp, ataques) { }
    }

    // Clase hija: Planta
    public class PokemonPlanta : Pokemon
    {
        public PokemonPlanta(string nombre, int hp, List<Ataque> ataques)
            : base(nombre, "Planta", hp, ataques) { }
    }
}
