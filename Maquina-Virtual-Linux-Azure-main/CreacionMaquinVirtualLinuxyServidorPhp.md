## Creacion de la maquina virtual en Azure Cli

### Conectarse desde Azure Cli A Azure

```
az login
```

![image-20201116230804470](https://github.com/JuanjoSalva/Maquina-Virtual-Linux-Azure/blob/main/images/image-20201116230804470.png)

![image-20201116230854908](https://github.com/JuanjoSalva/Maquina-Virtual-Linux-Azure/blob/main/images/image-20201116230854908.png)

![image-20201116230921196](https://github.com/JuanjoSalva/Maquina-Virtual-Linux-Azure/blob/main/images/image-20201116230921196.png)

![image-20201116231010716](https://github.com/JuanjoSalva/Maquina-Virtual-Linux-Azure/blob/main/images/image-20201116231010716.png)



### Creando un grupo de recursos

```
az group create -l EastUS -n myRGCLI 
```

![image-20201116231051102](https://github.com/JuanjoSalva/Maquina-Virtual-Linux-Azure/blob/main/images/image-20201116231051102.png)

![image-20201116231230703](https://github.com/JuanjoSalva/Maquina-Virtual-Linux-Azure/blob/main/images/image-20201116231230703.png)



### Creando una máquina virtual Linux

```
az vm create ^
 --name myVMCLI ^
 --resource-group myRGCLI ^
 --image UbuntuLTS ^
 --location EastUS ^
 --admin-username azureuser ^
 --admin-password Pa$$w0rd1234 ^
 --no-wait
```

![image-20201116232818758](https://github.com/JuanjoSalva/Maquina-Virtual-Linux-Azure/blob/main/images/image-20201116232818758.png)

![image-20201116233044148](https://github.com/JuanjoSalva/Maquina-Virtual-Linux-Azure/blob/main/images/image-20201116233044148.png)



Conectarse a la máquina Virtual de Linux

![image-20201116233108760](https://github.com/JuanjoSalva/Maquina-Virtual-Linux-Azure/blob/main/images/image-20201116233108760.png)



```
ssh azureuser@23.96.93.40
Nota: Dar que si en la creación del certificado SSH
```

![image-20201116233233350](https://github.com/JuanjoSalva/Maquina-Virtual-Linux-Azure/blob/main/images/image-20201116233233350.png)

![image-20201116234014697](https://github.com/JuanjoSalva/Maquina-Virtual-Linux-Azure/blob/main/images/image-20201116234014697.png)





1 - Actualizar en Linux

```
sudo apt-get update
```

![image-20201116234125815](https://github.com/JuanjoSalva/Maquina-Virtual-Linux-Azure/blob/main/images/image-20201116234125815.png)



2 - Hacer el upgrade

```
sudo apt upgrade
```

![image-20201116234212433](https://github.com/JuanjoSalva/Maquina-Virtual-Linux-Azure/blob/main/images/image-20201116234212433.png)



3 - Instalar un servidor web

```
sudo apt install -y apache2 apache2-utils
```

![image-20201116234301883](https://github.com/JuanjoSalva/Maquina-Virtual-Linux-Azure/blob/main/images/image-20201116234301883.png)



4 - Vemos el estatus de Apache

```
systemctl status apache2
```

![image-20201116234322162](https://github.com/JuanjoSalva/Maquina-Virtual-Linux-Azure/blob/main/images/image-20201116234322162.png)



5 - Ponemos un mensaje en nuestra página de Apache

```
cd /var/www/html
```

![image-20201116234347582](https://github.com/JuanjoSalva/Maquina-Virtual-Linux-Azure/blob/main/images/image-20201116234347582.png)

6 - Poner una nota en la página inde.html

```
sudo vi index.html <ENTER>
<ESC> : 198 <ENTER> // irme a la linea 198 que es donde esta el mensaje de index.html
<i> PONER EL MENSAJE <ESC>
: x <ENTER>

```

![image-20201116235157691](https://github.com/JuanjoSalva/Maquina-Virtual-Linux-Azure/blob/main/images/image-20201116235157691.png)

7 - Salir del SSH

```
exit <ENTER>
```

**Nota:**

El puerto 80 deberá ser abierto desde NSG.

Destination PortRanges: 80

Name: Port_80

![image-20201116234724276](https://github.com/JuanjoSalva/Maquina-Virtual-Linux-Azure/blob/main/images/image-20201116234724276.png)



Probariamos que llegamos a la maquina virtual: con la IP desde cualquier navegador.

![image-20201116235301777](https://github.com/JuanjoSalva/Maquina-Virtual-Linux-Azure/blob/main/images/image-20201116235301777.png)

## Parar y "deallocate" la máquina virtual

```
az vm stop --resource-group myRGCLI --name myVMCLI --no-wait
```

```
az vm deallocate -g myRGCLI -n myVMCLI --no-wait
```

![image-20201116235443451](https://github.com/JuanjoSalva/Maquina-Virtual-Linux-Azure/blob/main/images/image-20201116235443451.png)

![image-20201116235512729](https://github.com/JuanjoSalva/Maquina-Virtual-Linux-Azure/blob/main/images/image-20201116235512729.png)

![image-20201116235541768](https://github.com/JuanjoSalva/Maquina-Virtual-Linux-Azure/blob/main/images/image-20201116235541768.png)



## Iniciar la máquina virtual

```
az vm start -g myRGCLI -n myVMCLI --no-wait
```

![image-20201116235612455](https://github.com/JuanjoSalva/Maquina-Virtual-Linux-Azure/blob/main/images/image-20201116235612455.png)



## Borrar la máquina virtual

```
az vm delete -g myRGCLI -n myVMCLI --yes --no-wait
```

![image-20201116235948425](https://github.com/JuanjoSalva/Maquina-Virtual-Linux-Azure/blob/main/images/image-20201116235948425.png)

![image-20201117000134808](https://github.com/JuanjoSalva/Maquina-Virtual-Linux-Azure/blob/main/images/image-20201117000134808.png)



### Mostrar informacion de la máquina virtual

```
az vm show -g myRGCLI -n myVMCLI -d
```

![image-20201117000050953](https://github.com/JuanjoSalva/Maquina-Virtual-Linux-Azure/blob/main/images/image-20201117000050953.png)



Borrar el grupo de recursos

```
az group delete -n myRGCLI  --yes --no-wait
```

![image-20201117000242964](https://github.com/JuanjoSalva/Maquina-Virtual-Linux-Azure/blob/main/images/image-20201117000242964.png)

![image-20201117000435441](https://github.com/JuanjoSalva/Maquina-Virtual-Linux-Azure/blob/main/images/image-20201117000435441.png)



## Desconectamos de Azure

```
az logout
```

![image-20201117000932443](https://github.com/JuanjoSalva/Maquina-Virtual-Linux-Azure/blob/main/images/image-20201117000932443.png)

Mas información:

[Manage Linux or Windows virtual machines.](https://docs.microsoft.com/en-us/cli/azure/vm?view=azure-cli-latest)

