# Proyecto de API - Autos

## Descripci�n del Proyecto

Este proyecto es una API construida en .NET 6 que permite gestionar informaci�n relacionada con autos, incluyendo marcas, submarcas, modelos y descripciones. Proporciona funcionalidades para filtrar y obtener datos desde una base de datos.

## Requisitos

Para ejecutar este proyecto, aseg�rate de tener lo siguiente:

- .NET 6 SDK
- SQL Server

## Archivos de Base de Datos

Este proyecto incluye los archivos de base de datos necesarios para su ejecuci�n en la carpeta Database:

- **Archivos MDF**
- **Archivos LDF**

Estos archivos son necesarios para que la API funcione correctamente y almacenan toda la informaci�n relacionada con los autos.

## Pasos para Configurar la Base de Datos

 **Adjuntar la Base de Datos en SQL Server**:
   - Abre SQL Server Management Studio.
   - Con�ctate a tu instancia de SQL Server.
   - Haz clic derecho en "Bases de datos" y selecciona "Adjuntar".
   - En la ventana que aparece, haz clic en "Agregar" y selecciona el archivo MDF.
   - SQL Server detectar� autom�ticamente el archivo LDF asociado. Haz clic en "OK" para adjuntar la base de datos.


. **Conectar la API a la Base de Datos**:
   - Aseg�rate de que la cadena de conexi�n en `appsettings.json` apunte a tu base de datos.

```json
{
  "ConnectionStrings": {
    "AutosDbContext": "Server=your_server;Database=EXAMNET;User Id=your_username;Password=your_password;TrustServerCertificate=True"
  }
}

## C�mo Ejecutar la API

1. Abre el proyecto en Visual Studio.
2. Aseg�rate de que la base de datos est� correctamente configurada y adjunta.
3. Compila y ejecuta la aplicaci�n.

## Ejemplos de Peticiones y Respuestas

En filterType puedes ingresar: null, 0, 1 y 2 para filtrar.

Por marca (1) 

Por submarca (2) 

Todos los registros (0 o null) 

Si es 1 debes agregar una marca

Si es 2 debes agregar una submarca

### Obtener Datos del Dashboard

**Request:**



{
  "filterType": 1,
  "string": "Toyota"
}

**Response**

[
  {
    "marca": "Toyota",
    "submarca": "Corolla",
    "modelo": 2020,
    "descripcion": "Descripci�n del modelo"
  }
]
