# repasoSummer | Actividad Evaluable 👁️‍🗨️

Este README proporciona una guía paso a paso para la creación de un proyecto de API en C# y Angular. A continuación, se detallan los pasos que se deben seguir:

## 1. Crear el Proyecto API Vacío

   - Iniciar creando un proyecto de API vacío en tu entorno de desarrollo.

## 2. Crear la Biblioteca de Clases "Entidades"

   - Crear una biblioteca de clases llamada "Entidades" para definir tus modelos de datos.
   - En este caso, crear la entidad "Persona" que representa la estructura de los datos.

## 3. Crear la Biblioteca de Clases "Context"

   - Crear una biblioteca de clases llamada "Context" para definir el contexto de datos de Entity Framework.
   - En el contexto, configurar la conexión a la base de datos y definir las tablas y relaciones.

## 4. Agregar la Cadena de Conexión en appsettings.json

   - Agregar la cadena de conexión a tu base de datos en el archivo `appsettings.json`.
   - Esto permite que la aplicación sepa dónde encontrar la base de datos.

## 5. Agregar el Servicio de la Cadena de Conexión en program.cs

   - Configurar el servicio para la cadena de conexión en el archivo `Program.cs` de tu API.
   - Esto es esencial para que Entity Framework pueda interactuar con la base de datos.

## 6. Crear el Controlador

   - Crear un controlador API en tu proyecto para definir las rutas y las acciones que permitirán a los clientes de la API interactuar con tus datos.
   - En este caso, crear el controlador "PersonasController".

## 7. Crear el Repositorio y el IRepositorio

   - Crear un repositorio que actúe como una capa intermedia entre el controlador y la base de datos.
   - Utilizar una interfaz (`IRepositorio`) para definir las operaciones que se pueden realizar en el repositorio, como la obtención y modificación de datos.

## 8. Instalar AutoMapper

   - Instalar AutoMapper, una biblioteca que facilita la conversión entre tus modelos de datos (entidades) y los modelos de transferencia de datos (DTOs) que se utilizan en la API.

## 9. Crear los DTOs

   - Crear objetos DTO (Data Transfer Objects) para representar los datos que se enviarán o recibirán desde la API.
   - Estos objetos permiten controlar qué datos se exponen a través de la API.

## 10. Crear el Perfil y Aplicar los Mapeos

   - Crear un perfil AutoMapper para definir cómo se mapean tus modelos de datos a los DTOs y viceversa.
   - Luego, aplicar estos mapeos en la configuración de AutoMapper.

## 11. Actualizar el Controlador para Llamar al Repositorio

   - Actualizar las acciones en el controlador "PersonasController" para que llamen al repositorio y puedan interactuar con los datos de la base de datos.
   - Esto incluye la obtención de datos, la creación de nuevos registros, la actualización de registros existentes y la eliminación de registros.

Estos pasos proporcionan una base sólida para crear una API que interactúe con una base de datos utilizando Entity Framework. A medida que avances en tu proyecto, podrás agregar más funcionalidades, como validaciones, autenticación, autorización y documentación, para adaptar la API a tus necesidades específicas. ¡Buena suerte con tu proyecto!
