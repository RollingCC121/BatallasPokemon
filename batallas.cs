// Batallas.cs
using System;


namespace PokemonBattleGame
{
    public static class Batallas
    {
        private static Random rnd = new Random();

        public static void IniciarBatalla(Pokemon jugador)
        {
            // Elegir enemigo aleatorio diferente al jugador
            Pokemon enemigo;
            do
            {
                enemigo = Pokedex.Pokemones[rnd.Next(Pokedex.Pokemones.Count)];
            } while (enemigo.Nombre == jugador.Nombre);

            Console.Clear();
            Console.WriteLine("¡Comienza la batalla!");
            Console.WriteLine($"{jugador.Nombre} VS {enemigo.Nombre}");
            Console.WriteLine();

            int vidaJugador = jugador.HP;
            int vidaEnemigo = enemigo.HP;

            while (vidaJugador > 0 && vidaEnemigo > 0)
            {
                // Aquí debes mostrar el menú de batalla
                Interfaz.MostrarPantallaBatalla(jugador, vidaJugador, enemigo, vidaEnemigo, jugador.Ataques);

                int eleccion = Utils.LeerOpcion(1, jugador.Ataques.Count);
                Ataque ataqueElegido = jugador.Ataques[eleccion - 1];

                if (rnd.Next(1, 101) <= ataqueElegido.Precision)
                {
                    int danioJugador = CalcularDanio(ataqueElegido.Daño);
                    vidaEnemigo -= danioJugador;
                    Console.WriteLine($"{jugador.Nombre} usó {ataqueElegido.Nombre} y causó {danioJugador} de daño.");
                }
                else
                {
                    Console.WriteLine($"{jugador.Nombre} falló el ataque {ataqueElegido.Nombre}.");
                }

                if (vidaEnemigo <= 0)
                {
                    Console.WriteLine($"¡Has derrotado a {enemigo.Nombre}!");
                    break;
                }

                // Turno enemigo ataca
                Ataque ataqueEnemigo = enemigo.Ataques[rnd.Next(enemigo.Ataques.Count)];
                if (rnd.Next(1, 101) <= ataqueEnemigo.Precision)
                {
                    int danioEnemigo = CalcularDanio(ataqueEnemigo.Daño);
                    vidaJugador -= danioEnemigo;
                    Console.WriteLine($"{enemigo.Nombre} usó {ataqueEnemigo.Nombre} y causó {danioEnemigo} de daño.");
                }
                else
                {
                    Console.WriteLine($"{enemigo.Nombre} falló el ataque {ataqueEnemigo.Nombre}.");
                }

                if (vidaJugador <= 0)
                {
                    Console.WriteLine("¡Has sido derrotado!");
                    break;
                }

                Console.WriteLine("\nPresiona cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }

            Console.WriteLine("Batalla terminada. Presiona cualquier tecla para volver al menú...");
            Console.ReadKey();
        }

        private static int CalcularDanio(int danioBase)
        {
            // Daño simple con aleatoriedad entre 80%-120% del daño base
            double multiplicador = 0.8 + rnd.NextDouble() * 0.4;
            return (int)(danioBase * multiplicador);
        }
    }
}