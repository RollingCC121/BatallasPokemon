# Batallas Pokémon (Consola C#)

¡Bienvenido a Batallas Pokémon!  
Este es un juego de consola en C# donde puedes elegir tu Pokémon y enfrentarte a rivales en batallas por turnos, al estilo clásico de GameBoy.

---

## 🚀 ¿Cómo ejecutar el proyecto?

1. **Clona o descarga este repositorio en tu computadora.**

2. **Abre una terminal en la carpeta del proyecto.**

3. **Ejecuta el siguiente comando para compilar y correr el juego:**
   ```sh
   dotnet run
   ```

4. **¡Listo! Sigue las instrucciones en pantalla para jugar.**

---

## 📁 Estructura de archivos

- **Program.cs**  
  Punto de entrada del programa. Controla el menú principal y el flujo general del juego.

- **interfaz.cs**  
  Contiene todos los menús en arte ASCII, la lógica de selección de Pokémon y la pantalla de batalla estilo GameBoy.

- **pokedex.cs**  
  Define la lista de Pokémon disponibles y sus ataques.

- **batallas.cs**  
  Lógica de las batallas: turnos, cálculo de daño, selección de ataques y control de la vida de los Pokémon.

- **utils.cs**  
  Funciones auxiliares para leer opciones del usuario y pausar la consola.

- **pokemon.cs**  
  Define las clases `Pokemon` y `Ataque` con sus propiedades y constructores.

---

## 🎮 ¿Cómo jugar?

1. **Elige "Start" en el menú principal.**
2. **Selecciona tu Pokémon favorito.**
3. **Enfréntate a un rival controlado por la máquina.**
4. **Elige tus ataques y observa la batalla en pantalla con barras de vida y menús ASCII.**
5. **¡Gana la batalla o inténtalo de nuevo!**

---

## 📝 Notas

- El juego se ejecuta completamente en la consola.
- Puedes modificar la lista de Pokémon y ataques editando `pokedex.cs`.
- El diseño de los menús y la batalla está inspirado en la estética de los juegos clásicos de GameBoy.

---

¡Diviértete jugando y aprendiendo C#!