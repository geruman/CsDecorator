# Decorator
Es un patr�n estructural. [Link descripci�n](https://sourcemaking.com/design_patterns/decorator)

El decorador es un patr�n que se utiliza para agregar funcionalidad a una clase sin tener que heredarla ni modificarla, se utilizan clases "decoradoras" que implementan la misma interfaz pero pueden agregar funcionalidad a cada uno de sus m�todos.

## Diagrama de clases
![UML](decorator.jpg)

## SOLID

* Single responsibility

Cada decorador tiene una sola responsabilidad, la de agregar una unidad de funcionalidad a una clase concreta.

* Open/Closed principle

Gracias al patr�n podemos implementar nueva funcionalidad a una clase sin tener que modificarla. Si se necesitan m�s puntos de extensi�n basta con crear nuevos decoradores y encolarlos

* Liskov substitution

Por naturaleza los decorators son "apilables" y cada uno se comporta como su padre, no hay raz�n para que rompan este principio

* Interface segregation

El decorator ayuda a la segregaci�n de interfaces ya que tienen una reducida responsabilidad y son encolables, cada decorator puede apuntar a una funcionalidad especifica ayudando a mantener clases peque�as y especializadas.

* Dependency inversion

Un decorador se maneja a trav�s de interfaces, lo que viene muy bien para cumplir con este principio

