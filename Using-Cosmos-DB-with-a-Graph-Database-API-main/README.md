## DEMO3_L3_3

### Using Cosmos DB with a Graph Database API



**Azure** CReamos una **Azure Cosmos DB**

![CreadoCosmoDb](img/CreadoCosmoDb.PNG)

**Pulsamos Create 'Persons' cointainer** para crear una bbdd de Cosmos hacia el contenedor de Grafos.

**Pulsamos DataExplorer y New Graph**

![dataexplorer](img/dataexplorer.PNG)



Ahora  desde un Cmd o PowerShell clonamos el trabajo

![clonamos datos](img/clonamos%20datos.PNG)

**Abrimos el proyecto con el Visual Studio 2019. **

- Instalamos con el Nuget el Gremlin.Net

- Vemos el código del proyecto donde se usan estas variables:

  host	PrimaryKey  Database	Container

  - Le damos valor por cmd con datos de azure:

    ![variables](img/variables.PNG)

Quedan así:

![variables1](img/variables1.PNG)

![variables2](img/variables2.PNG)

**Construimos aplicación desde Visual Studio Debug Without Debugging**

**Desde linea de comando vamos a la ruta**

![ruta](img/ruta.PNG)

**Ejecutamos**

![ejecutado](img/ejecutado.PNG)

Ahora vamos al portal, en Data Explorer, graphdb, Persons, Graph y Load Graph

![CargarGrafos](img/CargarGrafos.PNG)



**Revisamos SLAs**

![latencia](img/latencia.PNG)

