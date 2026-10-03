# Sistema de Reservas de Transporte Terrestre

## Descripción del proyecto

Este proyecto consiste en el desarrollo de un sistema sencillo de reservas de transporte terrestre. Su objetivo principal es permitir simular la creación de vehículos, la generación de una reserva, la adición de servicios adicionales y el procesamiento de un pago.

El proyecto fue desarrollado como ejercicio académico para aplicar patrones de diseño de software y comprender cómo estos pueden ayudar a organizar y facilitar el mantenimiento del código.

El sistema funciona mediante consola y utiliza cuatro patrones de diseño:

* **Factory Method**: para la creación de los diferentes tipos de vehículos.
* **Adapter**: para adaptar un sistema externo de pagos PSE al sistema de reservas.
* **Decorator**: para agregar servicios adicionales a una reserva.
* **Facade**: para simplificar y coordinar el proceso completo de una reserva.

---

## Problema

Un sistema de reservas de transporte necesita manejar diferentes tipos de vehículos, formas de pago y servicios adicionales.

Si toda esta lógica se encuentra directamente en el programa principal, el código puede volverse difícil de entender y modificar. Por ejemplo, agregar un nuevo tipo de vehículo o un nuevo servicio podría requerir realizar cambios en diferentes partes del programa.

Para solucionar este problema se utilizaron patrones de diseño que permiten separar las responsabilidades y organizar mejor el código.

---

## Objetivo

Desarrollar una aplicación de consola que simule el proceso básico de una reserva de transporte terrestre, aplicando patrones de diseño creacionales y estructurales.

Los principales objetivos son:

* Crear diferentes tipos de vehículos.
* Realizar una reserva básica.
* Agregar servicios adicionales a la reserva.
* Simular un pago mediante PSE.
* Integrar los diferentes componentes mediante una fachada.
* Aplicar correctamente los patrones de diseño seleccionados.

---

## Tecnologías utilizadas

* **Lenguaje:** C#
* **Framework:** .NET 10
* **IDE:** Visual Studio
* **Tipo de aplicación:** Aplicación de consola
* **Control de versiones:** Git / GitHub

---

## Patrones de diseño utilizados

### 1. Factory Method

Se utiliza para controlar la creación de los vehículos.

En lugar de crear directamente un `Bus` o un `Microbus` desde `Program.cs`, se utilizan diferentes creadores.

Principales clases:

```text
Vehiculo
├── Bus
└── Microbus

CreadorVehiculo
├── CreadorBus
└── CreadorMicrobus
```

El método principal del patrón es:

```csharp
CrearVehiculo()
```

Por ejemplo, `CreadorBus` crea un objeto `Bus`, mientras que `CreadorMicrobus` crea un objeto `Microbus`.

Esto permite separar la lógica de creación de los vehículos del resto del programa.

---

### 2. Adapter

Se utiliza para adaptar un sistema externo de pagos PSE a la interfaz que espera nuestro sistema.

Nuestro sistema trabaja con:

```csharp
IPago
```

y espera utilizar:

```csharp
ProcesarPago()
```

Sin embargo, el sistema externo simulado utiliza:

```csharp
RealizarTransaccion()
```

El `AdaptadorPSE` permite conectar ambos componentes.

La estructura utilizada es:

```text
IPago
   ↓
AdaptadorPSE
   ↓
PagoPSEExterno
```

De esta forma, el sistema puede utilizar el pago externo sin modificar la clase que representa el sistema PSE.

---

### 3. Decorator

Se utiliza para agregar servicios adicionales a una reserva sin modificar directamente la clase de reserva básica.

La reserva comienza como:

```text
Reserva básica
```

Luego se pueden agregar diferentes servicios:

```text
Reserva básica
      ↓
+ Equipaje adicional
      ↓
+ Seguro de viaje
```

Las principales clases son:

* `IReserva`
* `ReservaBasica`
* `ReservaDecorator`
* `DecoradorEquipaje`
* `DecoradorSeguro`

Esto permite combinar diferentes servicios de acuerdo con las necesidades de la reserva.

---

### 4. Facade

Se utiliza para simplificar el uso del sistema.

La clase:

```text
SistemaReservasFacade
```

coordina internamente los diferentes componentes del sistema.

Desde `Program.cs` solamente se necesita realizar una llamada:

```csharp
sistema.RealizarReserva(true, true, true, 200.00m);
```

La fachada se encarga internamente de:

1. Crear el vehículo utilizando Factory Method.
2. Crear la reserva básica.
3. Agregar los servicios mediante Decorator.
4. Procesar el pago mediante Adapter.
5. Mostrar el resultado de la reserva.

---

## Estructura del proyecto

```text
Proyecto-Sistema de Reservas de Transporte Terrestre
│
├── Openspec
│   └── SDD.md
│
├── src
│   ├── Models
│   │   ├── Vehiculo.cs
│   │   ├── Bus.cs
│   │   └── Microbus.cs
│   │
│   ├── Factories
│   │   ├── CreadorVehiculo.cs
│   │   ├── CreadorBus.cs
│   │   └── CreadorMicrobus.cs
│   │
│   ├── Adapters
│   │   ├── IPago.cs
│   │   ├── PagoPSEExterno.cs
│   │   └── AdaptadorPSE.cs
│   │
│   ├── Decorators
│   │   ├── IReserva.cs
│   │   ├── ReservaBasica.cs
│   │   ├── ReservaDecorator.cs
│   │   ├── DecoradorEquipaje.cs
│   │   └── DecoradorSeguro.cs
│   │
│   └── Facade
│       └── SistemaReservasFacade.cs
│
├── Program.cs
└── README.md
```

---

## Funcionamiento del sistema

El flujo principal de una reserva es:

```text
Inicio
  │
  ▼
Seleccionar vehículo
  │
  ▼
Factory Method
  │
  ▼
Crear Bus o Microbus
  │
  ▼
Crear reserva básica
  │
  ▼
Agregar extras
  │
  ├── Equipaje
  │
  └── Seguro
  │
  ▼
Decorator
  │
  ▼
Procesar pago
  │
  ▼
Adapter
  │
  ▼
Pago PSE simulado
  │
  ▼
Fin de la reserva
```

---

## Ejemplo de ejecución

Al ejecutar el programa se obtiene una salida similar a:

```text
=== SISTEMA DE RESERVAS DE TRANSPORTE ===

=== VEHICULO ===
Bus - Capacidad: 40 pasajeros - Precio base: $ 150,00

=== RESERVA ===
Descripción: Reserva básica + Equipaje adicional + Seguro de viaje
Precio: $ 200,00

Procesando pago PSE por $ 200,00.

=== PAGO ===
Pago realizado correctamente.

=== PRUEBA FINALIZADA ===
```

El resultado demuestra que los cuatro patrones están conectados dentro del sistema.

---

## Cómo ejecutar el proyecto

### Requisitos

Para ejecutar el proyecto se necesita:

* Visual Studio.
* .NET 10 SDK.
* Windows u otro sistema operativo compatible con .NET.

### Pasos

1. Abrir Visual Studio.
2. Abrir la solución del proyecto.
3. Compilar la solución.
4. Ejecutar el proyecto de consola.
5. Revisar el resultado mostrado en la consola.

También se puede ejecutar desde una terminal ubicada en la carpeta del proyecto mediante:

```bash
dotnet run
```

---

## Alcance del proyecto

Este proyecto es una implementación académica y simplificada.

El sistema **no incluye**:

* Base de datos.
* Usuarios reales.
* Inicio de sesión.
* Pagos reales.
* Conexión real con PSE.
* Servicios web.
* Aplicación web.
* Aplicación móvil.
* Gestión real de tiquetes.
* Integración con empresas de transporte.

El pago PSE utilizado en el proyecto es solamente una simulación para demostrar el funcionamiento del patrón Adapter.

---

## Conclusiones

La implementación permitió aplicar cuatro patrones de diseño en un mismo problema.

**Factory Method** permitió separar la creación de los vehículos del resto del sistema.

**Adapter** permitió conectar una interfaz de pago propia con un sistema externo que utiliza un método diferente.

**Decorator** permitió agregar servicios adicionales a una reserva sin modificar la reserva básica.

**Facade** permitió reunir y simplificar el uso de los diferentes componentes, haciendo que `Program.cs` tenga una interacción más sencilla con el sistema.

Con esta implementación se puede observar cómo los patrones de diseño ayudan a organizar el código y separar responsabilidades dentro de una aplicación de software.
