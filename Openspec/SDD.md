# SDD - Sistema de Reservas de Transporte Terrestre

## 1. Problema

Actualmente, una empresa de transporte terrestre necesita organizar de una manera sencilla el proceso de creación de reservas para sus viajes. El sistema debe permitir seleccionar una ruta, elegir el tipo de vehículo, agregar algunos servicios adicionales y realizar el pago de la reserva.

El problema principal que se quiere representar en este proyecto está relacionado con la creación y organización de los diferentes objetos que participan en una reserva. Si cada objeto se crea directamente desde el programa principal, el código puede volverse difícil de mantener y modificar cuando se agreguen nuevos tipos de vehículos, medios de pago o servicios.

Por esta razón, se propone desarrollar un pequeño sistema de consola que permita demostrar el uso de diferentes patrones de diseño de software.

El sistema será utilizado principalmente por un empleado de la empresa de transporte encargado de registrar las reservas.

El proyecto tendrá un alcance académico y no pretende ser un sistema comercial completo.

---

## 2. Objetivo

Desarrollar una aplicación de consola en C# que permita representar el proceso básico de una reserva de transporte terrestre y demostrar el uso de un patrón creacional y tres patrones estructurales.

Los patrones seleccionados son:

- Factory Method
- Adapter
- Decorator
- Facade

---

## 3. Requisitos funcionales

### RF01 - Selección de ruta

El sistema debe permitir seleccionar una ruta de transporte entre las rutas disponibles.

Las rutas de ejemplo serán:

- Bogotá → Tunja
- Bogotá → Villavicencio
- Bogotá → Girardot

### RF02 - Selección de vehículo

El sistema debe permitir seleccionar entre diferentes tipos de vehículos, como Bus y Microbus.

### RF03 - Creación de vehículos

El sistema debe crear los diferentes tipos de vehículos utilizando el patrón Factory Method.

### RF04 - Creación de reserva

El sistema debe permitir crear una reserva asociada a una ruta y un vehículo.

### RF05 - Selección del medio de pago

El sistema debe permitir seleccionar un medio de pago para realizar la reserva.

### RF06 - Adaptación de medio de pago

El sistema debe permitir utilizar un medio de pago externo mediante el patrón Adapter.

Para el ejemplo se utilizará un sistema externo de pago simulado llamado PSE.

### RF07 - Servicios adicionales

El sistema debe permitir agregar servicios adicionales a una reserva.

Los servicios disponibles serán:

- Equipaje adicional
- Seguro de viaje

### RF08 - Decoración de la reserva

Los servicios adicionales deben agregarse mediante el patrón Decorator sin modificar directamente la clase de la reserva básica.

### RF09 - Proceso simplificado de reserva

El sistema debe permitir realizar el proceso completo de una reserva mediante una clase Facade.

### RF10 - Cálculo del costo

El sistema debe calcular el costo total de la reserva teniendo en cuenta el precio base y los servicios adicionales.

### RF11 - Pago

El sistema debe simular el proceso de pago y mostrar si la operación fue realizada correctamente.

### RF12 - Resumen

El sistema debe mostrar un resumen de la reserva que incluya:

- Ruta
- Tipo de vehículo
- Servicios adicionales
- Medio de pago
- Costo total
- Estado de la reserva

---

## 4. Requisitos no funcionales

### RNF01 - Lenguaje

El sistema debe desarrollarse utilizando C#.

### RNF02 - Plataforma

El proyecto debe poder ejecutarse desde Visual Studio en Windows.

### RNF03 - Tipo de aplicación

El sistema será una aplicación de consola.

### RNF04 - Simplicidad

La solución debe mantenerse sencilla y apropiada para un proyecto académico de Ingeniería de Software.

### RNF05 - Organización

El código debe estar organizado en carpetas de acuerdo con la responsabilidad de cada clase.

### RNF06 - Comprensión

El código debe ser fácil de comprender y explicar durante una sustentación.

### RNF07 - Sin servicios externos

El proyecto no utilizará bases de datos, APIs, pagos reales ni conexiones externas.

---

## 5. Patrones seleccionados

### 5.1 Factory Method

Factory Method será utilizado para crear los diferentes tipos de vehículos.

El sistema tendrá diferentes tipos de vehículos, como Bus y Microbus. En lugar de crear directamente estos objetos desde el programa principal, se utilizará una fábrica para controlar su creación.

Este patrón permitirá separar la creación de los objetos de la lógica principal del sistema.

La principal ventaja será que en el futuro se podrían agregar nuevos tipos de vehículos sin tener que modificar toda la lógica principal de la aplicación.

---

### 5.2 Adapter

Adapter será utilizado para integrar un medio de pago externo simulado.

El sistema tendrá una interfaz de pago propia, pero el servicio externo tendrá una forma diferente de realizar el pago.

El Adapter permitirá convertir la interfaz del servicio externo a la interfaz que necesita nuestro sistema.

De esta manera, el sistema podrá utilizar PSE sin tener que modificar la estructura principal del proceso de pago.

---

### 5.3 Decorator

Decorator será utilizado para agregar servicios adicionales a una reserva.

La reserva básica tendrá un costo inicial y posteriormente se podrán agregar servicios como:

- Equipaje adicional
- Seguro de viaje

Cada servicio podrá aumentar el costo y modificar la descripción de la reserva.

La ventaja es que se pueden agregar diferentes combinaciones de servicios sin tener que crear una clase diferente para cada combinación posible.

---

### 5.4 Facade

Facade será utilizado para simplificar el proceso completo de una reserva.

La clase Facade será responsable de coordinar diferentes partes del sistema, como:

- creación del vehículo;
- creación de la reserva;
- adición de servicios;
- selección del medio de pago;
- cálculo del costo;
- confirmación del pago.

De esta forma, el programa principal no tendrá que conocer todos los detalles internos del sistema.

---

## 6. Diseño propuesto

El proyecto se organizará de la siguiente manera:

```text
Proyecto-Sistema de Reservas de Transporte Terrestre
│
├── Openspec
│   └── SDD.md
│
├── src
│   ├── Models
│   ├── Factories
│   ├── Adapters
│   ├── Decorators
│   └── Facade
│
├── Program.cs
└── README.md