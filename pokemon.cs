using System.Collections.Generic;

namespace PokemonBattleGame
{
    // Clase que representa un ataque
    public class Ataque
    {
        public string Nombre { get; set; }
        public int Daño { get; set; }
        public int Precision { get; set; }
        public string Tipo { get; set; } 

        public Ataque(string nombre, int daño, int precision, string tipo)
        {
            Nombre = nombre;
            Daño = daño;
            Precision = precision;
            Tipo = tipo;
        }
    }

    // Clase base para todos los Pokémon
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

        // MÉTODO VIRTUAL: Puede ser sobrescrito por las clases hijas
        // Recibe daño y descuenta HP
        public virtual void RecibirDanio(int cantidad, string tipoAtaque)
        {
            HP -= cantidad;
        }
    }

    // Clase hija: Fuego
    public class PokemonFuego : Pokemon
    {
        public PokemonFuego(string nombre, int hp, List<Ataque> ataques)
            : base(nombre, "Fuego", hp, ataques) { }

        // OVERRIDE: Sobrescribe el método RecibirDanio de la clase base
        // Si el ataque es de tipo Planta, recibe la mitad de daño
        public override void RecibirDanio(int cantidad, string tipoAtaque)
        {
            if (tipoAtaque == "Planta")
                HP -= (int)(cantidad * 0.5); // Recibe la mitad de daño de Planta
            else
                base.RecibirDanio(cantidad, tipoAtaque); // Usa el comportamiento base
        }
    }

    // Clase hija: Agua
    public class PokemonAgua : Pokemon
    {
        public PokemonAgua(string nombre, int hp, List<Ataque> ataques)
            : base(nombre, "Agua", hp, ataques) { }

        // OVERRIDE: Sobrescribe el método RecibirDanio de la clase base
        // Si el ataque es de tipo Fuego, recibe la mitad de daño
        public override void RecibirDanio(int cantidad, string tipoAtaque)
        {
            if (tipoAtaque == "Fuego")
                HP -= (int)(cantidad * 0.5); // Recibe la mitad de daño de Fuego
            else
                base.RecibirDanio(cantidad, tipoAtaque); // Usa el comportamiento base
        }
    }

    // Clase hija: Planta
    public class PokemonPlanta : Pokemon
    {
        public PokemonPlanta(string nombre, int hp, List<Ataque> ataques)
            : base(nombre, "Planta", hp, ataques) { }

        // OVERRIDE: Sobrescribe el método RecibirDanio de la clase base
        // Si el ataque es de tipo Agua, recibe la mitad de daño
        public override void RecibirDanio(int cantidad, string tipoAtaque)
        {
            if (tipoAtaque == "Agua")
                HP -= (int)(cantidad * 0.5); // Recibe la mitad de daño de Agua
            else
                base.RecibirDanio(cantidad, tipoAtaque); // Usa el comportamiento base
        }
    }
}
