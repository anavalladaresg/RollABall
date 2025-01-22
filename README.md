# Roll a Ball 🎮

## Introducción

Este proyecto es un juego de plataformas en el que el jugador controla una bola que recolecta objetos para ganar puntos. El objetivo es recolectar la mayor cantidad de objetos posibles antes de que te pille el enemigo. 🏃‍♂️💨

>[!NOTE]
> **SCRIPTS MOVIMIENTOS:**
> - [`CameraController`](Assets/Scripts/CameraController.cs) 📷
> - [`CameraSwitcher`](Assets/Scripts/CameraSwitcher.cs) 🔄
> - [`FirstPersonController`](Assets/Scripts/FirstPersonController.cs) 👀
> - [`PlayerController`](Assets/Scripts/PlayerController.cs) 🎮
> - [`EnemyMovement`](Assets/Scripts/EnemyMovement.cs) 👾

## Explicación

Para que el jugador pueda mover la bola, se ha creado un script llamado `PlayerController` que se encarga de mover la bola en función de las teclas de dirección. Este script utiliza el componente `Rigidbody` para aplicar fuerzas a la bola y permitir su movimiento. Además, el script `PlayerController` también maneja la recolección de objetos y la actualización de la interfaz de usuario para mostrar la cantidad de objetos recolectados. 

### Funciones del `PlayerController`:

- **`Start()`**: Inicializa el componente `Rigidbody`, el contador de objetos recolectados y la interfaz de usuario. 🚀
- **`OnMove(InputValue movementValue)`**: Detecta la entrada de movimiento del jugador y la convierte en un vector de movimiento. 🎯
- **`FixedUpdate()`**: Aplica las fuerzas de movimiento a la bola en cada frame de física. ⚙️

Además, se ha creado un script llamado `FirstPersonController` que se encarga de mover la cámara en función de la entrada del jugador. Este script permite al jugador controlar la cámara en primera persona, moviéndola y rotándola según las teclas de dirección y el ratón. 

### Funciones del `FirstPersonController`:

- **`Update()`**: Llama a la función `MoveAndRotateCamera()` en cada frame para actualizar la posición y rotación de la cámara. 🔄
- **`MoveAndRotateCamera()`**: Detecta la entrada del teclado para mover la cámara y ajusta la rotación de la cámara para que mire en la dirección del movimiento. 👁️

Por último, se ha creado un script llamado `EnemyMovement` que se encarga de mover al enemigo en función de la posición de la bola. Este script permite que el enemigo siga al jugador, creando un desafío adicional en el juego. 

### Funciones del `EnemyMovement`:

- **`Update()`**: Actualiza la posición del enemigo para que siga al jugador en cada frame. 🕹️
- **`MoveTowardsPlayer()`**: Calcula la dirección hacia el jugador y mueve al enemigo en esa dirección. 📍