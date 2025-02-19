# Roll a Ball 🎮

## Introducción

Este proyecto es un juego de plataformas en el que el jugador controla una bola que recolecta objetos para ganar puntos. El objetivo es recolectar la mayor cantidad de objetos posibles antes de que te pille el enemigo. 🏃‍♂️💨

## Componentes Principales 🔧

### Scripts de Control
- [`PlayerController`](Assets/Scripts/PlayerController.cs) 🎮 - Control del movimiento de la bola
- [`FirstPersonController`](Assets/Scripts/FirstPersonController.cs) 👀 - Control de la cámara en primera persona
- [`CameraController`](Assets/Scripts/CameraController.cs) 📷 - Control de la cámara principal
- [`CameraSwitcher`](Assets/Scripts/CameraSwitcher.cs) 🔄 - Sistema de cambio entre cámaras
- [`EnemyMovement`](Assets/Scripts/EnemyMovement.cs) 👾 - IA del enemigo perseguidor

## Mecánicas de Juego 🎯

### Control del Jugador
- Movimiento mediante teclas de dirección o WASD
- Recolección de objetos al tocarlos
- Sistema de puntuación basado en objetos recolectados

### Sistema de Cámaras
- Vista en tercera persona siguiendo la bola
- Vista en primera persona para mayor inmersión
- Cambio dinámico entre vistas

### Enemigo
- IA que persigue constantemente al jugador
- Aumenta la dificultad y tensión del juego
- Game Over al ser alcanzado