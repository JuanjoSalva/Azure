## DEMO3_L3_3

### Using Cosmos DB with a Graph Database API



**Azure** CReamos una **Azure Cosmos DB**

![CreadoCosmoDb](https://github.com/JuanjoSalva/Using-Cosmos-DB-with-a-Graph-Database-API/blob/main/img/CreadoCosmoDb.PNG)

**Pulsamos Create 'Persons' cointainer** para crear una bbdd de Cosmos hacia el contenedor de Grafos.

**Pulsamos DataExplorer y New Graph**

![dataexplorer](https://github.com/JuanjoSalva/Using-Cosmos-DB-with-a-Graph-Database-API/blob/main/img/dataexplorer.PNG)



Ahora  desde un Cmd o PowerShell clonamos el trabajo

![clonamos datos](https://github.com/JuanjoSalva/Using-Cosmos-DB-with-a-Graph-Database-API/blob/main/img/clonamos%20datos.PNG)

**Abrimos el proyecto con el Visual Studio 2019. **

- Instalamos con el Nuget el Gremlin.Net

- Vemos el código del proyecto donde se usan estas variables:

  host	PrimaryKey  Database	Container

  - Le damos valor por cmd con datos de azure:

    ![variables](https://github.com/JuanjoSalva/Using-Cosmos-DB-with-a-Graph-Database-API/blob/main/img/variables.PNG)

Quedan así:

![variables1](https://github.com/JuanjoSalva/Using-Cosmos-DB-with-a-Graph-Database-API/blob/main/img/variables1.PNG)

![variables2](https://github.com/JuanjoSalva/Using-Cosmos-DB-with-a-Graph-Database-API/blob/main/img/variables2.PNG)

**Construimos aplicación desde Visual Studio Debug Without Debugging**

**Desde linea de comando vamos a la ruta**

![ruta](https://github.com/JuanjoSalva/Using-Cosmos-DB-with-a-Graph-Database-API/blob/main/img/ruta.PNG)

**Ejecutamos**

![ejecutado](https://github.com/JuanjoSalva/Using-Cosmos-DB-with-a-Graph-Database-API/blob/main/img/ejecutado.PNG)

Ahora vamos al portal, en Data Explorer, graphdb, Persons, Graph y Load Graph

![CargarGrafos](https://github.com/JuanjoSalva/Using-Cosmos-DB-with-a-Graph-Database-API/blob/main/img/CargarGrafos.PNG)



**Revisamos SLAs**

![latencia](https://github.com/JuanjoSalva/Using-Cosmos-DB-with-a-Graph-Database-API/blob/main/img/latencia.PNG)

