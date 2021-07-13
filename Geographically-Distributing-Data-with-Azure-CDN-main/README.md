##DEMO7_L4

### Configuring a CDN Endpoint for a Static Website



**Lo primero es ir a Azure y activar DNS.**





**Segundo, creamos una Storage accounts**.

![creadostorage](https://github.com/JuanjoSalva/Geographically-Distributing-Data-with-Azure-CDN/blob/main/img/creadostorage.PNG)



1. **Habilitamos el Static Web Site y guardamos**

   ![staticwebsite](https://github.com/JuanjoSalva/Geographically-Distributing-Data-with-Azure-CDN/blob/main/img/staticwebsite.PNG)

   

2. Click the **$web** container 

   ![web1](https://github.com/JuanjoSalva/Geographically-Distributing-Data-with-Azure-CDN/blob/main/img/web1.PNG)

3. Subimos nuestro fichero de prueba **Upload**.

   ![subida](https://github.com/JuanjoSalva/Geographically-Distributing-Data-with-Azure-CDN/blob/main/img/subida.PNG)

4. Volvemos al mod7demo5jsr y ponemos como Index document name: index.html para que abra ese por defecto

   ![url](https://github.com/JuanjoSalva/Geographically-Distributing-Data-with-Azure-CDN/blob/main/img/url.PNG)

5. Seleccionamos el pimary endpoint y lo abrinos en un browser.

   ![web11](https://github.com/JuanjoSalva/Geographically-Distributing-Data-with-Azure-CDN/blob/main/img/web11.PNG)

   6. Definimos el CDN

   ![cdndef](https://github.com/JuanjoSalva/Geographically-Distributing-Data-with-Azure-CDN/blob/main/img/cdndef.PNG)

   

7. Creado el CDN

![creadoCDN](https://github.com/JuanjoSalva/Geographically-Distributing-Data-with-Azure-CDN/blob/main/img/creadoCDN.PNG)



8. Click **Endpoint hostname** y abrimos la url

![url](https://github.com/JuanjoSalva/Geographically-Distributing-Data-with-Azure-CDN/blob/main/img/url.PNG)



Abrimos en web:

![result](https://github.com/JuanjoSalva/Geographically-Distributing-Data-with-Azure-CDN/blob/main/img/result.PNG)

Press F12, and then click the **Network** tab.

In **URL**, type **/airplane1.jpg**, and then press Enter.

In the **Network** tab, click **airplane1.jpg** and in **Response Headers**, verify that **x-cache: HIT** is not present.

![result2](https://github.com/JuanjoSalva/Geographically-Distributing-Data-with-Azure-CDN/blob/main/img/result2.PNG)

Refresh the page five times.

In **Response Headers**, verify that **x-cache: HIT** is present.

