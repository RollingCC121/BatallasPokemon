# Batallas Pokémon (Consola C#)

¡Bienvenido a Batallas Pokémon!  
Este es un juego de consola en C# donde puedes elegir tu Pokémon y enfrentarte a rivales en batallas por turnos, al estilo clásico de GameBoy.

## Descripcion del proyecto
El propósito de este proyecto es aplicar conceptos de Programación Orientada a Objetos (POO) y Programación Funcional en un entorno práctico y entretenido. A través de un juego de batallas Pokémon, se busca fortalecer habilidades en diseño modular, clases, herencia y manejo de listas mediante expresiones funcionales como LINQ. El juego se ejecuta en la consola y cuenta con menús ASCII, selección de personajes y batallas por turnos


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
  ## Diagrama de clases principales

 
![Diagrama_UML](https://github.com/user-attachments/assets/b822ff71-19ca-4a25-b515-68b6e09a5e01)

  
---
  ## ¿Que partes usan POO y cuales funcional?

  ### Programacion orientada a objetos
   - pokemon.cs: Definición de clases Pokemon y Ataque.
   - batallas.cs: Manejo de objetos Pokémon en combate.
   - interfaz.cs: Uso de objetos para mostrar menús y controlar el flujo de interacción.

  ### Programacion funcional
  - En pokedex.cs: Uso de expresiones lambda y LINQ para filtrar y seleccionar Pokémon.
  - Posiblemente en utils.cs: Métodos que usan expresiones funcionales para mejorar la legibilidad.
---

## 🎮 ¿Cómo jugar?

1. **Elige "Start" en el menú principal.**
2. **Selecciona tu Pokémon favorito.**
3. **Enfréntate a un rival controlado por la máquina.**
4. **Elige tus ataques y observa la batalla en pantalla con barras de vida y menús ASCII.**
5. **¡Gana la batalla o inténtalo de nuevo!**

## Reflexión

### ¿Que fue facil?

Diseñar las clases y entender cómo se relacionan entre sí fue intuitivo gracias a la lógica del universo Pokémon. También fue divertido crear los menús ASCII y dar personalidad al juego.

### ¿Que fue dificil?

Integrar elementos de programación funcional dentro de un diseño orientado a objetos. También equilibrar la lógica del combate y asegurar que no haya errores durante el turno de la IA.

### ¿Que aprendimos?
Aprendimos a combinar dos paradigmas de programación: cómo los objetos nos ayudan a organizar entidades complejas, y cómo LINQ y expresiones funcionales simplifican la manipulación de datos. También mejoramos nuestra capacidad para estructurar proyectos más grandes y modularizados.


