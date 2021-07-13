## MOD6_L4
## Deploying to Staging and Production Environments

Con los Slot conseguimos desplgar entre varios entornos. Lo que hace es camabiar el código de uno en otro, y de ese otro en el primero.
Con lo cual, lso cambios de Staging suben a Prod y los de Prod bajan a Staging. Si queremos conservar el origina en ambos habrña que tener varios slot.

**Portal Azure**
Creamos el App Service.
![creamosappservice](https://github.com/JuanjoSalva/Deploying-to-Staging-and-Production-Environments/blob/master/img/creamosappservice.PNG)

**Deployment center**

Seleccionamos despligue manual Ftp
![creamosappservice](https://github.com/JuanjoSalva/Deploying-to-Staging-and-Production-Environments/blob/master/img/ftp.PNG)

**Slot**
Creamos un Slot con nombre Staging.
Se crea un despliegue para Staging y queda el de produccion. Ahora podemos desplegar de Saging a Prod y viceversa
![creamosappservice](https://github.com/JuanjoSalva/Deploying-to-Staging-and-Production-Environments/blob/master/img/Staging.PNG)

**Para la prueba ejecutamos el app service original**7
![creamosappservice](https://github.com/JuanjoSalva/Deploying-to-Staging-and-Production-Environments/blob/master/img/web11.PNG)

![creamosappservice](https://github.com/JuanjoSalva/Deploying-to-Staging-and-Production-Environments/blob/master/img/web1.PNG)

**publicamos**
Para el despiegue es necesario que en el proyecto, en la carpeta de propiedades exita las propiedades para el despliegue Azure y el Staging
![creamosappservice](https://github.com/JuanjoSalva/Deploying-to-Staging-and-Production-Environments/blob/master/img/propiedades.PNG)

Luego cambiamos el código para ver el cambio 
![creamosappservice](https://github.com/JuanjoSalva/Deploying-to-Staging-and-Production-Environments/blob/master/img/web22.PNG)

publicamos y vemos el resultado 
![creamosappservice](https://github.com/JuanjoSalva/Deploying-to-Staging-and-Production-Environments/blob/master/img/web2.PNG)


**Swap**

Con el Swap hacemos sel intercambio de Staging a Prod y de Prdo a Staging.

![creamosappservice](https://github.com/JuanjoSalva/Deploying-to-Staging-and-Production-Environments/blob/master/img/Swap1.PNG)

![creamosappservice](https://github.com/JuanjoSalva/Deploying-to-Staging-and-Production-Environments/blob/master/img/Swap2.PNG)
