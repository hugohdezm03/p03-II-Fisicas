# Interfaces Inteligentes

- Hugo Hernández Martín (alu0101481227@ull.edu.es)

# Práctica 3: Introducción a las Físicas de Unity


## Experimentando con las físicas del editor

### Situación 1:

* El plano no es un objeto físico perfecto, sólo tiene collider.
* El cubo es un objeto físico perfecto (con collider y Rigidbody).
* La esfera no es un objeto físico perfecto, sólo tiene collider.

![Imagen situación 1](docs/p03_II_situacion_01.png)

No sucede nada, ya que el cubo es el único que se ve afectado por las físicas y está sobre el plano (que tiene un collider que impide que caiga por la gravedad). Como la esfera tiene collider pero no está en la simulación de físicas, no cae.

### Situación 2:

* El plano no es un objeto físico perfecto, sólo tiene collider.
* El cubo es un objeto físico perfecto (con collider y Rigidbody).
* La esfera es un objeto físico perfecto (con collider y Rigidbody).

![GIF situación 2](docs/p03_II_situacion_02.gif)

La esfera es añadida a la simulación de físicas, por lo tanto se ve afectada por la gravedad, colisiona con el cubo (ya que este posee collider) y, al salirse del plano cae al vacío. Además, el cubo no se desplaza por el choque.

### Situación 3:

* El plano no es un objeto físico perfecto, sólo tiene collider.
* El cubo es un objeto físico perfecto (con collider y Rigidbody).
* La esfera es un objeto físico cinemático (con collider y Rigidbody).

![Imagen situación 3](docs/p03_II_situacion_01.png)

Al convertir la esfera a cinemática, el motor de físicas no se encargará de su movimiento, por lo que la gravedad dejará de afectarle. Nos encontraremos en una situación similar a la presentada en la situación 1 aunque posea un Rigidbody.

### Situación 4:

* El plano es un objeto físico perfecto (con collider y Rigidbody).
* El cubo es un objeto físico perfecto (con collider y Rigidbody).
* La esfera es un objeto físico perfecto (con collider y Rigidbody).

![GIF situación 4](docs/p03_II_situacion_04.gif)

Al ser todos los objetos físicos perfectos, todos son están incluidos en el motor de físicas y son afectados por la gravedad, es por ello que todos caen al vacío a la vez.

### Situación 5:

* El plano es un objeto físico perfecto (con collider y Rigidbody).
* El cubo es un objeto físico perfecto (con collider y Rigidbody).
* La esfera es un objeto físico perfecto (con collider y Rigidbody). Además, tiene una masa 10 veces mayor que el cubo.

![GIF situación 5](docs/p03_II_situacion_05.gif)

En este caso sucede lo mismo que en la situación anterior, ya que la aceleración de la gravedad es la misma para todos los cuerpos a la misma distancia, independientemente de su masa (en ausencia de rozamiento).

### Situación 6:

* El plano es un objeto físico perfecto (con collider y Rigidbody).
* El cubo es un objeto físico perfecto (con collider y Rigidbody).
* La esfera es un objeto físico perfecto (con collider y Rigidbody). Además, tiene una masa 100 veces mayor que el cubo.

![GIF situación 6](docs/p03_II_situacion_06.gif)

Se puede observar que sucede lo mismo que en la situación anterior, a causa de lo mismo.

### Situación 7

* El plano es un objeto físico perfecto (con collider y Rigidbody).
* El cubo es un objeto físico perfecto (con collider y Rigidbody).
* La esfera es un objeto físico perfecto (con collider y Rigidbody). Además, tiene una fuerza de fricción (en este caso de 5).

![GIF situación 7](docs/p03_II_situacion_07.gif)

Se puede observar como tanto el plano como el cubo caen a la misma velocidad por la gravedad (sin rozamiento). En cambio, como la esfera está siendo afectada por el rozamiento cae más lentamente (por el parametro introducido, que puede variar para cambiar la velocidad a la que cae).

### Situación 8

* El plano es un objeto físico perfecto (con collider y Rigidbody).
* El cubo es un objeto físico perfecto (con collider y Rigidbody).
* La esfera es un objeto físico cinemático (con collider y Rigidbody). Además, tiene la opción *isTrigger* activada.

![GIF situación 8](docs/p03_II_situacion_08.gif)

El plano y el cubo son físicos perfectos, por lo que caen por la gravedad. Por otra parte, la esfera se queda en la misma posición porque es cinemática, el motor de físicas no la mueve. Que la esfera sea Trigger hace que no colisione con otros colliders, aunque no se da la circustancia en el ejemplo.

### Situación 9

* El plano es un objeto físico perfecto (con collider y Rigidbody).
* El cubo es un objeto físico perfecto (con collider y Rigidbody).
* La esfera es un objeto físico perfecto (con collider y Rigidbody). Además, tiene la opción *isTrigger* activada.

![GIF situación 9](docs/p03_II_situacion_09.gif)

Los tres objetos son movidos por el motor de físicas, en mi caso, le he puesto un drag (rozamiento) de 5 al plano y al cubo para visualizar mejor el resultado de que la esfera sea Trigger. Como se puede observar, no interactúa con los colliders ni del plano ni del cubo y los atraviesa.

## Movimientos - Físicas