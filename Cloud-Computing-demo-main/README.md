## Module1_L4 

### Exploring the Microsoft Azure Portal




subir una aplicacion a un appService




Creamos la aplicacion web 

![c1](imagenes/c1.PNG)

Ejecutamos

![c1](imagenes/c2.PNG)

Probamos en local !

![c1](imagenes/c3.PNG)


Lo subimos a Azure
Nos logamos con az login

![c1](imagenes/c4.PNG)

y la subimos he utilizado las siguientes opciones  

```
az webapp update --resource-group MyRG --plan MyPlanWin --os-type Windows --location francecentral --subscription "Pase para Azure: patrocinio" --sku F1 --name appHelloWorld 
```

![c1](imagenes/c5.PNG)

Se ha creado el grupo de recursos 

![c1](imagenes/c6.PNG)

Se ha creado el app plan service 

![c1](imagenes/c7.PNG)

y la app web

![c1](imagenes/c8.PNG)

Abrimos web

![c1](imagenes/c9.PNG)

Bien ahora la vamos a modificar y atualizar

![c1](imagenes/c10.PNG)

el comando utilizado es 

```
az webapp up  --subscription "Pase para Azure: patrocinio" --name appHelloWorld
```

![c1](imagenes/c11.PNG)

ejecutamos y ok

![c1](imagenes/c12.PNG)


