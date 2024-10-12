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


## Movimientos - Físicas