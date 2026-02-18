using System.Collections.Generic;

namespace PokemonBattleGame
{
    // Clase que representa un ataque
    public class Ataque
    {
        private string _nombre;
        private int _daño;
        private int _precision;
        private string _tipo;

        public string Nombre => _nombre;
        public int Daño => _daño;
        public int Precision => _precision;
        public string Tipo => _tipo;

        public Ataque(string nombre, int daño, int precision, string tipo)
        {
            _nombre = nombre;
            _daño = daño;
            _precision = precision;
            _tipo = tipo;
        }
    }

    // Clase base para todos los Pokémon
    public class Pokemon
    {
         private string _nombre;
        private string _tipo;
        private int _hp;
        private List<Ataque> _ataques;

        public string Nombre => _nombre;
        public string Tipo => _tipo;
        //public int HP => _hp;
        public List<Ataque> Ataques => _ataques;
         public int HP
        {
        get => _hp;
        set => _hp = value < 0 ? 0 : value;  // Evita HP negativos
        }

        public Pokemon(string nombre, string tipo, int hp, List<Ataque> ataques)
        {
            _nombre = nombre;
            _tipo = tipo;
            _hp = hp;
            _ataques = ataques;
        }

        // MÉTODO VIRTUAL: Puede ser sobrescrito por las clases hijas
        // Recibe daño y descuenta HP
        public virtual void RecibirDanio(int cantidad, string tipoAtaque)
        {
            _hp -= cantidad;
        }

        // Sobrecarga: solo recibe la cantidad de daño (ataque normal)
        public void RecibirDanio(int cantidad)
        {
            _hp -= cantidad;
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
