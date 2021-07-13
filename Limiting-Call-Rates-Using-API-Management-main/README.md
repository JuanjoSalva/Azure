## DEMO6_L6

## Limiting Call Rates Using API Management



Dentro del API Managment

Seleccionamos nuestra APIS

![API](https://github.com/JuanjoSalva/Limiting-Call-Rates-Using-API-Management/blob/main/API.PNG)

Seleccionamos todas las operaciones

En el panel de Inbound processing pinchamos en el simbolod e xml e insertamos este código:

![xml](https://github.com/JuanjoSalva/Limiting-Call-Rates-Using-API-Management/blob/main/xml.PNG)

![codigo](https://github.com/JuanjoSalva/Limiting-Call-Rates-Using-API-Management/blob/main/codigo.PNG)



Hemos creado una politíca a todos los métodos de manera que a la tercera vez que se envíe un método saltará el error.



Una vez:

![2](https://github.com/JuanjoSalva/Limiting-Call-Rates-Using-API-Management/blob/main/1.PNG)

Dos veces:

![2](https://github.com/JuanjoSalva/Limiting-Call-Rates-Using-API-Management/blob/main/1.PNG)



Tres veces:

![3](https://github.com/JuanjoSalva/Limiting-Call-Rates-Using-API-Management/blob/main/1.PNG)
