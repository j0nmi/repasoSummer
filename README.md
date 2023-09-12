# repasoSummer | Actividad evaluable 👁️‍🗨️​
Paso 1: Crear el Proyecto API Vacío

Inicias creando un proyecto de API vacío en tu entorno de desarrollo.
Paso 2: Crear la Biblioteca de Clases "Entidades"

Creas una biblioteca de clases llamada "Entidades" para definir tus modelos de datos. En este caso, creaste la entidad "Persona" que representa la estructura de tus datos.
Paso 3: Crear la Biblioteca de Clases "Context"

Creas una biblioteca de clases llamada "Context" para definir el contexto de datos de Entity Framework. En el contexto, configuras la conexión a la base de datos y defines las tablas y relaciones.
Paso 4: Agregar la Cadena de Conexión en appsettings.json

En el archivo appsettings.json, agregas la cadena de conexión a tu base de datos. Esto permite que la aplicación sepa dónde encontrar la base de datos.
Paso 5: Agregar el Servicio de la Cadena de Conexión en program.cs

En el archivo Program.cs de tu API, configuras el servicio para la cadena de conexión, lo cual es esencial para que Entity Framework pueda interactuar con la base de datos.
Paso 6: Crear el Controlador

Creas un controlador API en tu proyecto para definir las rutas y las acciones que permitirán a los clientes de la API interactuar con tus datos. En tu caso, se trata del controlador "PersonasController".
Paso 7: Crear el Repositorio y el IRepositorio

Creas un repositorio que actúa como una capa intermedia entre el controlador y la base de datos. El uso de una interfaz (IRepositorio) ayuda a definir las operaciones que se pueden realizar en el repositorio, como la obtención y modificación de datos.
Paso 8: Instalar AutoMapper

Instalas AutoMapper, una biblioteca que facilita la conversión entre tus modelos de datos (entidades) y los modelos de transferencia de datos (DTOs) que se utilizan en la API.
Paso 9: Crear los DTOs

Creas objetos DTO (Data Transfer Objects) que se utilizan para representar los datos que se enviarán o recibirán desde la API. Estos objetos permiten controlar qué datos se exponen a través de la API.
Paso 10: Crear el Perfil y Aplicar los Mapeos

Creas un perfil AutoMapper para definir cómo se mapean tus modelos de datos a los DTOs y viceversa. Luego, aplicas estos mapeos en la configuración de AutoMapper.
Paso 11: Actualizar el Controlador para Llamar al Repositorio

En el controlador "PersonasController", actualizas las acciones para que llamen al repositorio para interactuar con los datos de la base de datos. Esto incluye la obtención de datos, la creación de nuevos registros, la actualización de registros existentes y la eliminación de registros.
