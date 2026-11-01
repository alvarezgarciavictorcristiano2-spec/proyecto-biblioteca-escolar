
 Biblioteca escolar con ejemplares irregulares  
**Docente: roberto rosario cruz

---

## 1. INTRODUCCIÓN

El presente proyecto consiste en desarrollar un sistema para administrar una biblioteca escolar mediante el lenguaje de programación C#.

La biblioteca cuenta con diferentes títulos de libros y cada uno puede tener una cantidad distinta de ejemplares. Algunos libros pueden tener cinco copias, mientras que otros solamente cuentan con una.

El sistema tendrá como propósito organizar la información de los libros, conocer su disponibilidad, registrar los préstamos realizados y permitir la búsqueda de libros mediante su código ISBN.

Durante el primer día de trabajo se realizará el análisis del problema y la comparación de tres estructuras de datos que podrían utilizarse para desarrollar el sistema: arreglo escalonado, List<int[]> y List<Titulo>.

## 2. PLANTEAMIENTO DEL PROBLEMA

En una biblioteca escolar existen libros con diferentes cantidades de ejemplares disponibles. Esto puede dificultar la organización y el control de los préstamos si no se utiliza una estructura de datos adecuada.

El bibliotecario necesita conocer qué libros están disponibles, cuántos ejemplares quedan de cada título y cuántos préstamos históricos ha tenido cada libro.

También necesita localizar libros mediante su código ISBN y mantener un catálogo organizado.

Por esta razón, se requiere seleccionar una estructura de datos que permita almacenar la información de manera ordenada, flexible y sin espacios vacíos.

## 3. OBJETIVO GENERAL

Analizar y seleccionar una estructura de datos adecuada en C# para representar los títulos de una biblioteca escolar que cuenta con diferentes cantidades de ejemplares.

## 4. OBJETIVOS ESPECÍFICOS

- Comparar tres estructuras de datos: arreglo escalonado, List<int[]> y List<Titulo>.
- Identificar las ventajas y desventajas de cada estructura.
- Determinar cuál permite administrar mejor los libros y sus ejemplares.
- Elegir una estructura que facilite el desarrollo de las funciones del sistema.
- Elaborar un diseño preliminar que sirva como base para las siguientes etapas del proyecto.

## 5. ANÁLISIS DE LAS ESTRUCTURAS DE DATOS

### 5.1. Arreglo escalonado (int[][])

Un arreglo escalonado es una estructura que contiene varios arreglos dentro de un arreglo principal. Cada arreglo interno puede tener una cantidad diferente de elementos.

En este proyecto permitiría representar los ejemplares de cada libro utilizando arreglos de diferentes tamaños.

**Ventajas:**
- Permite almacenar diferentes cantidades de ejemplares.
- No necesita utilizar espacios vacíos cuando cada arreglo se crea con el tamaño necesario.
- Permite acceder a los elementos mediante índices.
- Es una estructura útil cuando se conoce previamente la cantidad de datos.

**Desventajas:**
- Su administración puede ser complicada cuando se necesitan modificar los datos.
- Es necesario controlar manualmente los índices.
- No permite identificar fácilmente qué representa cada dato si se utilizan únicamente números.
- Puede dificultar la organización de información adicional de cada libro.

### 5.2. Lista de arreglos (List<int[]>)

Es una estructura que utiliza una lista dinámica para almacenar varios arreglos de números enteros. Cada arreglo puede representar la información numérica relacionada con un libro.

**Ventajas:**
- Permite agregar y eliminar arreglos fácilmente.
- Cada arreglo puede tener un tamaño diferente.
- Su tamaño es dinámico.
- Permite almacenar cantidades variables de información.

**Desventajas:**
- Los datos se identifican mediante posiciones numéricas.
- Es necesario recordar qué representa cada posición.
- Puede resultar complicado administrar información adicional de cada libro.
- El código puede ser menos claro y organizado.

### 5.3. Lista de objetos (List<Titulo>)

Es una estructura dinámica que permite almacenar objetos de una clase llamada Titulo. Cada objeto representa un libro y contiene sus propios atributos.

Por ejemplo, cada título puede almacenar su nombre, ISBN, cantidad de préstamos históricos y ejemplares disponibles.

**Ventajas:**
- Permite organizar la información de cada libro.
- Facilita almacenar diferentes cantidades de ejemplares.
- Permite agregar nuevos atributos cuando sea necesario.
- Hace que el código sea más claro y comprensible.
- Facilita la implementación de las funciones del sistema.
- Permite trabajar con programación orientada a objetos.

**Desventajas:**
- Es necesario crear una clase para representar los títulos.
- Se requiere conocer el funcionamiento de las clases y los objetos.
- Su implementación inicial puede requerir más código.

## 6. TABLA COMPARATIVA

| Estructura | Ventajas | Desventajas |
|---|---|---|
| Arreglo escalonado | Maneja arreglos de diferentes tamaños y permite acceder mediante índices. | Es menos flexible para modificar y administrar información. |
| List<int[]> | Es dinámica y permite almacenar arreglos de diferentes tamaños. | Los datos se identifican mediante posiciones numéricas. |
| List<Titulo> | Organiza los datos mediante objetos y permite agregar atributos. | Requiere crear una clase y utilizar objetos. |

## 7. ESTRUCTURA SELECCIONADA

Después de analizar las tres alternativas, se selecciona **List<Titulo>** como la estructura más adecuada para desarrollar el sistema de la biblioteca escolar.

Esta elección se debe a que permite almacenar los libros mediante objetos que contienen toda su información organizada.

Además, cada libro puede tener una cantidad diferente de ejemplares sin necesidad de utilizar espacios vacíos.

También facilita la implementación de las funciones que se desarrollarán posteriormente, como consultar disponibilidad, registrar préstamos, ordenar el catálogo y buscar libros mediante ISBN.

## 8. DISEÑO PRELIMINAR EN C#

Para representar cada libro se propone crear una clase llamada Titulo, que contendrá los siguientes atributos:

- Nombre: almacena el nombre del libro.
- ISBN: identifica al libro mediante su código.
- PrestamosHistoricos: almacena la cantidad de préstamos realizados.
- Ejemplares: almacena los ejemplares correspondientes al título.

### Ejemplo de código preliminar

```csharp
using System;
using System.Collections.Generic;

class Titulo
{
    public string Nombre;
    public string ISBN;
    public int PrestamosHistoricos;
    public List<int> Ejemplares;
}
```

Para almacenar los títulos de la biblioteca se utilizará una lista:

```csharp
List<Titulo> biblioteca = new List<Titulo>();
```
Este código representa únicamente una propuesta inicial de la estructura del sistema. La implementación completa se realizará durante las siguientes etapas del proyecto.

