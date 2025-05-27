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

    public class Pokemon
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int HP { get; set; }
        public int MaxHP { get; set; }
        public List<Ataque> Ataques { get; set; }

        public Pokemon(string nombre, string tipo, int hp, List<Ataque> ataques)
        {
            Nombre = nombre;
            Tipo = tipo;
            HP = hp;
            MaxHP = hp;
            Ataques = ataques;
        }

        public bool EstaVivo() => HP > 0;
    }
}
