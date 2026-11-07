# 🚲 BiciGestión – Sistema de Gestión de Alquileres de Bicicletas

## 📌 Descripción del proyecto

BiciGestión es una aplicación de escritorio desarrollada en C# con Windows Forms y SQL Server, que permite administrar el alquiler de bicicletas.

El proyecto fue desarrollado como parte de un trabajo práctico universitario y consiste en la refactorización de una aplicación anterior, aplicando una arquitectura en capas, programación orientada a objetos y separación de responsabilidades.

## 🎯 Objetivo

El objetivo principal es implementar un sistema que permita registrar, consultar, buscar, modificar y eliminar alquileres de bicicletas, aplicando validaciones de negocio y utilizando transacciones para garantizar la integridad de los datos.

## ⚙️ Funcionalidades

- Registrar alquileres de bicicletas.
- Consultar todos los alquileres registrados.
- Buscar un alquiler mediante su ID.
- Modificar el importe total y la fecha del alquiler.
- Eliminar alquileres por ID.
- Seleccionar el tipo de bicicleta.
- Agregar varios alquileres a una lista temporal.
- Quitar alquileres de la lista antes de guardarlos.
- Guardar múltiples alquileres mediante una transacción.
- Validar los datos ingresados.

## 🏗️ Arquitectura del sistema

La aplicación está organizada en cinco capas:

### ENTIDAD
Contiene las clases que representan los objetos del sistema.

- `Alquiler`
- `TipoBicicleta`

Se utiliza una relación entre objetos, donde cada alquiler tiene asociado un tipo de bicicleta.

### MAPPER
Se encarga de convertir los registros obtenidos de SQL Server en objetos de las entidades correspondientes.

### DAL – Data Access Layer
Contiene los métodos encargados de acceder a la base de datos y ejecutar las operaciones SQL.

Se utilizan consultas parametrizadas para realizar las operaciones de inserción, consulta, modificación y eliminación.

### BLL – Business Logic Layer
Contiene las reglas de negocio y las validaciones necesarias para gestionar los alquileres.

También implementa `TransactionScope` para realizar el guardado de múltiples alquileres dentro de una misma transacción.

### UI – Interfaz de usuario
Desarrollada con Windows Forms.

Permite al usuario interactuar con el sistema mediante formularios, botones, cuadros de texto, listas desplegables y tablas de datos.

## 🗄️ Base de datos

Se utiliza SQL Server con la base de datos:

`GESTION_BICICLETAS`

El sistema trabaja principalmente con dos tablas:

**TIPO_BICICLETA**
- ID_TIPO_BICICLETA
- DESCRIPCION

**ALQUILER**
- ID_ALQUILER
- ID_TIPO_BICICLETA
- DNI_CLIENTE
- IMPORTE_TOTAL
- FECHA_REGISTRO
- FECHA_ALQUILER

La tabla ALQUILER se relaciona con TIPO_BICICLETA mediante una clave foránea.

El repositorio incluye el script `BDBicicletas.sql` para crear la estructura de la base de datos.

## 🔄 Manejo de transacciones

Se implementó `TransactionScope` en la capa BLL para guardar múltiples alquileres.

El objetivo es garantizar que todas las operaciones se completen correctamente.

Si ocurre un error durante alguna inserción, la transacción se revierte para evitar que los alquileres queden registrados parcialmente.

## 🛠️ Tecnologías utilizadas

- C#
- .NET
- Windows Forms
- SQL Server
- Microsoft.Data.SqlClient
- LINQ
- TransactionScope
- Visual Studio
- Git y GitHub

## 📋 Validaciones implementadas

- El DNI no puede estar vacío y debe contener más de cinco caracteres.
- El importe total debe ser mayor que cero.
- La fecha del alquiler no puede ser anterior a la fecha actual.
- Debe seleccionarse un tipo de bicicleta válido.
- El ID debe ser mayor que cero.
- Para modificar o eliminar un alquiler, primero se verifica su existencia.
- La fecha de registro se asigna automáticamente al guardar el alquiler.

## ▶️ Ejecución del proyecto

1. Clonar o descargar el repositorio.
2. Abrir la solución `RefactorPrimerParcial.slnx` en Visual Studio.
3. Ejecutar el script `BDBicicletas.sql` en SQL Server.
4. Configurar la cadena de conexión `BDBicicletas` en el archivo `App.config` de la interfaz de usuario, según la instancia local de SQL Server.
5. Compilar y ejecutar la aplicación.

## 📚 Contexto académico

Proyecto desarrollado como trabajo práctico de refactorización, aplicando los conceptos de:

- Programación orientada a objetos.
- Arquitectura en capas.
- Acceso a datos.
- Reglas de negocio.
- Relaciones entre entidades.
- Mapeo de objetos.
- Manejo de excepciones.
- Transacciones de base de datos.
- Control de versiones con Git y GitHub.
