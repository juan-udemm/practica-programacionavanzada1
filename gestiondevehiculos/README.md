# Sistema de Gestión de Vehículos 🚗

## Descripción
Este proyecto implementa un sistema de gestión de vehículos utilizando Programación Orientada a Objetos (POO) en C#. El sistema incluye una clase base `Vehiculo` y diferentes tipos de vehículos que heredan de ella, como `Auto`, `Moto` y `Camion`.

## Requisitos del Sistema

1. **Clase Base `Vehiculo`**:
    - Atributos encapsulados:
      - `Marca`
      - `Modelo`
      - `Año`
      - `VelocidadActual`
    - Método `Acelerar(int cantidad)`:
      - Incrementa la velocidad del vehículo.
      - Redefinido en las clases derivadas para aplicar polimorfismo.
    - Método `MostrarDetalles()`:
      - Muestra la información completa del vehículo.

2. **Clases Derivadas**:
    - `Auto`, `Moto` y `Camion` heredan de `Vehiculo`.
    - Cada clase redefine el método `Acelerar` para ajustar el comportamiento según el tipo de vehículo.

3. **Relación de Composición**:
    - La clase `Vehiculo` tiene una relación de composición con la clase `Motor`.

4. **Funcionalidad en el `Main`**:
    - Crear una lista de vehículos.
    - Recorrer la lista para mostrar los detalles de cada vehículo.

## Estructura del Proyecto

### Clases Principales
- **`Vehiculo`**: Clase base con atributos y métodos comunes.
- **`Auto`**, **`Moto`**, **`Camion`**: Clases derivadas que implementan comportamientos específicos.
- **`Motor`**: Clase que representa el motor de un vehículo.

### Métodos Clave
- **`Acelerar(int cantidad)`**:
  - Incrementa la velocidad del vehículo.
  - Redefinido en las clases derivadas.
- **`MostrarDetalles()`**:
  - Muestra la marca, modelo, año, velocidad actual y detalles del motor.

## Ejemplo de Uso

En el método `Main`:
1. Crear instancias de `Auto`, `Moto` y `Camion`.
2. Agregar las instancias a una lista de vehículos.
3. Recorrer la lista y llamar al método `MostrarDetalles()` para cada vehículo.

## Tecnologías Utilizadas
- Lenguaje: C#
- Paradigma: Programación Orientada a Objetos (POO)

## Cómo Ejecutar
1. Clona este repositorio.
2. Abre el proyecto en tu IDE de C# preferido (Visual Studio, Rider, etc.).
3. Compila y ejecuta el programa.

## Autor
Este proyecto fue desarrollado como parte de una práctica de Programación Avanzada.

## Licencia
Este proyecto está bajo la Licencia MIT. Consulta el archivo `LICENSE` para más detalles.  