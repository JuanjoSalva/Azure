## MOD7_L3_2

### Using Microsoft Azure Cosmos DB with the MongoDB API

**Creamos un Azure  Cosmos Db**

![CreadoCosmoDB](https://github.com/JuanjoSalva/Using-Microsoft-Azure-Cosmos-DB-with-the-MongoDB-API/blob/main/img/CreadoCosmoDB.PNG)





**Creamos la coleccion de customers**

databaseid = mydb

collection id = customer

 Shard key = customerId  (Se corresponde con el campo clave del fichero json)

**Creamos la coleccion de orders**

databaseid  existente= mydb

collection id = orders

 Shard key = name (Se corresponde con el campo clave del fichero json)



**Creados los dos contenedores o colecciones**

![contenedores](https://github.com/JuanjoSalva/Using-Microsoft-Azure-Cosmos-DB-with-the-MongoDB-API/blob/main/img/contenedores.PNG)



**Cargamos los datos de los json en los contenedores**

- Sacamos un shell

  ![sacarshell](https://github.com/JuanjoSalva/Using-Microsoft-Azure-Cosmos-DB-with-the-MongoDB-API/blob/main/img/sacarshell.PNG)

- Al final de este cuadro se pega el json con los datos y se da enter

  ![sacarshell2](https://github.com/JuanjoSalva/Using-Microsoft-Azure-Cosmos-DB-with-the-MongoDB-API/blob/main/img/sacarshell2.PNG)

- Se han cargado los datos

  ![sacarshell4](https://github.com/JuanjoSalva/Using-Microsoft-Azure-Cosmos-DB-with-the-MongoDB-API/blob/main/img/\sacarshell4.PNG)

- Hacemos lo mismo para el contenedor de Order y con su json

  

   Right-click **orders**, and then select **New Query**.

![sacarquery](https://github.com/JuanjoSalva/Using-Microsoft-Azure-Cosmos-DB-with-the-MongoDB-API/blob/main/img/sacarquery.PNG)

1. To get all the orders, paste the following query, and then click **Execute Query**.

   ```json
    {}
   ```

![sacarquery1](https://github.com/JuanjoSalva/Using-Microsoft-Azure-Cosmos-DB-with-the-MongoDB-API/blob/main/img/sacarquery1.PNG)

28. To get all the orders at a price greater than $20, paste the following query, and then click **Execute Query**.

   ```query
    { price: {$gt: 20} }
   ```

![sacarquery2](https://github.com/JuanjoSalva/Using-Microsoft-Azure-Cosmos-DB-with-the-MongoDB-API/blob/main/img/sacarquery2.PNG)

29. To get all the orders of customer 1, paste the following query, and then click **Execute Query**.

   ```query
    { customerId: "1" }
   ```

![sacarquery3](https://github.com/JuanjoSalva/Using-Microsoft-Azure-Cosmos-DB-with-the-MongoDB-API/blob/main/img/sacarquery3.PNG)
