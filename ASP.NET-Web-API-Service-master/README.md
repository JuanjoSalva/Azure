## Laboratorio Módulo 3

Fichero de Instrucciones: Instructions\20487D_MOD03_LAK.md

Entregar el url de GitHub con la solución y un readme con las siguiente información:

1. **Nombres y apellidos:** Juan José Salvador Román
2. **Fecha:** 28/12/2020
3. **Resumen del Ejercicio:** 



```
Ahora que se ha creado la capa de datos, se pueden desarrollar servicios que brindan información sobre destinos de viaje, horarios de vuelos y capacidades de reserva. Blue Yonder Airlines tiene la intención de admitir muchos tipos de dispositivos. El servicio de back-end debe tener un servicio basado en HTTP. Por lo tanto, el servicio se implementará mediante ASP.NET Web API. En este lab, creará un servicio de API web que admita acciones CRUD básicas en la base de datos de Blue Yonder Airlines. Además, actualizará la aplicación Travel Companion de Windows Store para consumir el servicio recién creado.

Objetivos
Después de completar esta práctica de laboratorio, podrá:

- Cree un servicio de API web ASP.NET.

- Implementar acciones CRUD en el servicio.

- Consuma un servicio de API web ASP.NET con la biblioteca System.Net.HttpClient.
```



```

**Ejercicio 1:** creación de un servicio de API web ASP.NET

Implemente el servicio de los viajeros utilizando ASP.NET Web API. Comience por crear un nuevo controlador de API web ASP.NET e implemente la funcionalidad CRUD utilizando los métodos HTTP POST, GET, PUT y DELETE.

Las principales tareas de este ejercicio son las siguientes:

1. Cree un nuevo controlador de API para el servicio de destinos e implemente las acciones del controlador.

Tarea 1: crear un nuevo controlador de API para el servicio de destinos e implementar las acciones del controlador
1. Abra el archivo de solución D: \ AllFiles \ Mod03 \ LabFiles \ begin \ BlueYonder.Companion \ BlueYonder.Companion.sln y agregue una nueva clase de API web ApiController llamada TravelersController. Elimina todos los métodos generados automáticamente.

2. Cree una propiedad privada denominada Viajeros de tipo ITravelerRepository. Cree un constructor e inicialice la propiedad Travelers con una nueva instancia de TravelerRepository.

3. Cree un método de acción para manejar solicitudes GET. El método recibe un parámetro de cadena llamado id. Implemente el método llamando al método FindBy del repositorio de Travelers buscando un viajero con la propiedad TravelerUserIdentity que es igual al parámetro id. Devuelve un mensaje HTTP apropiado: un estado 200 OK y la entidad de viajero para una llamada exitosa, o un estado 404 No encontrado si el viajero no existe.

4. Inserte un punto de interrupción al principio del método Get.

5. Cree un método de acción para manejar las solicitudes POST. El método recibe un parámetro de viajero llamado viajero. Implemente el método llamando a los métodos Add y Save del repositorio de Travelers. Cree un mensaje HTTP que devuelva el estado 201 Creado. Agregue un encabezado de ubicación que contenga el URI donde se puede acceder al nuevo viajero creado.

6. Inserte un punto de interrupción al principio del método Post.

7. Cree un método de acción para manejar solicitudes PUT. El método recibe un parámetro de Traveler llamado traveler y un parámetro de cadena llamado id. Implemente el método comprobando si el viajero existe (y si no existe, devuelva un 404 Not Found). Si el viajero existe, llame a los métodos Editar y Guardar del repositorio de Viajeros para actualizar el viajero y devolver un estado 200 OK.
```

```
8. Inserte un punto de interrupción al principio del método Put.

9. Cree un método de acción para manejar las solicitudes DELETE. El método recibe un parámetro de cadena llamado id. Si existe un viajero con una identidad determinada en la base de datos, llame a los métodos Eliminar y Guardar del repositorio de Viajeros y devuelva un estado 200 OK. De lo contrario, devuelva un estado 404 No encontrado.
```



```
**Ejercicio 2**: Consumir un servicio API web ASP.NET

Consume el servicio de los viajeros desde la aplicación del cliente. Comience por implementar el método GetTravelerAsync invocando una solicitud GET para recuperar un viajero específico del servidor. Continúe implementando el método CreateTravelerAsync invocando una solicitud POST para crear un nuevo viajero. Y complete el ejercicio implementando el método UpdateTravelerAsync invocando una solicitud PUT para actualizar un viajero existente.

Las principales tareas de este ejercicio son las siguientes:

1. Utilice System.Net.HttpClient para obtener una lista de destinos del servicio de destinos

2. Depurar el proyecto BlueYonder.Companion.Client
```

```
**Tarea 1**: Utilice System.Net.HttpClient para obtener una lista de destinos del servicio de destinos

1. Inicie sesión en la máquina virtual 20487A-SEA-DEV-C como Admin con la contraseña Pa $$ w0rd.

2. Abre la Solución D: \ AllFiles \ Mod03 \ LabFiles \ begin \ BlueYonder.Companion.Client \ BlueYonder.Companion.Client.sln.

3. Abra la clase DataManager de la carpeta del proyecto Helpers.

4. Implemente el método GetTravelerAsync invocando una solicitud GET con la clase HttpClient. Utilice la identificación del hardware como identificación del viajero. Si la respuesta es válida, deserialícela en un objeto Traveler mediante la clase JsonConvert.

5. Inserte un punto de interrupción al principio del método GetTravelerAsync.

6. Comience a implementar el método CreateTravelerAsync creando un objeto TravelerDTO, estableciendo su TravelerUserIdentity en el ID de hardware y serializándolo en una cadena JSON.

7. Continúe implementando el método invocando una solicitud POST con la clase HttpClient. Antes de enviar la solicitud, configure el encabezado HTTP Content-Type en application / json.

8. Complete la implementación del método deserializando la respuesta a un objeto Traveler.

9. Inserte un punto de interrupción al principio del método CreateTravelerAsync.

10. Comience a implementar el método UpdateTravelerAsync convirtiendo el parámetro Traveler en un objeto TravelerDTO y serializando el objeto en una cadena JSON.

11. Complete la implementación del método invocando una solicitud PUT con la clase HttpClient. Antes de enviar la solicitud, configure el encabezado HTTP Content-Type en application / json.

12. Inserte un punto de interrupción al comienzo del método UpdateTravelerAsync.
```



```
**Tarea 2:** depurar el proyecto BlueYonder.Companion.Client

1. Regrese a la máquina virtual 20487A-SEA-DEV-A y comience a depurar el proyecto BlueYonder.Companion.Host.

2. Regrese a la máquina virtual 20487A-SEA-DEV-C y comience a depurar el proyecto BlueYonder.Companion.Client.

3. Depura la aplicación cliente y verifica que no funciona antes de enviar una solicitud GET al servidor.

4. Vuelva a la máquina virtual 20487A-SEA-DEV-A y depure el código de servicio.

5. Vuelva a la máquina virtual 20487A-SEA-DEV-C y depure la aplicación cliente.

6. Vuelva a la máquina virtual 20487A-SEA-DEV-A y depure el código de servicio.

7. Vuelva a la máquina virtual 20487A-SEA-DEV-C y use la aplicación cliente para comprar un vuelo de Seattle a Nueva York. Depura la aplicación del cliente al actualizar los datos del viajero.

8. Vuelva a la máquina virtual 20487A-SEA-DEV-A y depure el código de servicio.

9. Vuelva a la máquina virtual 20487A-SEA-DEV-C y cierre la aplicación cliente.

10. Vuelva a la máquina virtual 20487A-SEA-DEV-A y detenga la depuración en Visual Studio 2012.
```



Al ejecutar el servicio podemos ver las reservas:

![inicio1](C:\Users\Juanjo\Desktop\demo3_LAK\img\inicio1.PNG)

![inicio2](C:\Users\Juanjo\Desktop\demo3_LAK\img\inicio2.PNG)



Al ejecutar el cliente vemos todo:

![cliente](C:\Users\Juanjo\Desktop\demo3_LAK\img\cliente.PNG)