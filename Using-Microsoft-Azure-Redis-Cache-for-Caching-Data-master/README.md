## MOD7_5

**Using Microsoft Azure Redis Cache for Caching Data**

**Creamos en el portal Azure un Azure Cache for Redis**



![Redis_Creado](img/Redis_Creado.PNG)



**Accedemos a su Conection String**

![conetStringCaptura](img/conetStringCaptura.PNG)



**Code**

- Enlazamos nuestro proyecto a nuestro Redis de Azure:

  ![code_conectstring](img/code_conectstring.PNG)

- Programamos nuestro controlador para que: en caso de que haya datos muestre los nuevos valores y en caso de que sean los mismo traiga la cache de Redis.

  ![code_comntrolador](img/code_comntrolador.PNG)

**Probamos**

**vemos nuestra página cacheada**

![primera_vez](img/primera_vez.PNG)

**insertamos un valor nuevo**

![insertamos](img/insertamos.PNG)

**Mostramos en wev**

Ya no lo coge de la caché porque hay un nuevo valor

![web_nuevo](img/web_nuevo.PNG)

****

**Refrescamos la página**

Coge los datos de la caché porque son los mismos

![web_nuevo_cacheado](img/web_nuevo_cacheado.PNG)
