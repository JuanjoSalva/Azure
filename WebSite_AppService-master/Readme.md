# Lesson 2: Deployment to Microsoft Azure

### Demonstration: How to Deploy a Web Application to Microsoft Azure

#### Preparation Steps 

1. Ensure that you have cloned the **20486D** directory from GitHub. It contains the code segments for the labs and demos of this course. (https://github.com/MicrosoftLearning/20486D-DevelopingASPNETMVCWebApplications/tree/master/Allfiles)

2. Ensure that you have a Microsoft Azure account.

#### Demonstration Steps 

1. Start Microsoft Visual Studio 2017.

2. In the **Start Page - Microsoft Visual Studio** window, on the **FILE** menu, point to **New**, and then click **Project**.

3. In the **New Project** dialog box, in the left pane, expand **Installed**, expand **Visual C#**, and then click **Cloud**.

4. In the **New Project** dialog box, in the result pane, click **ASP.NET Core Web Application**.

5. In the **Name** box, type **AzureWebAppExample**.

6. In the **Location** box, type **[Repository Root]\Allfiles\Mod14\Democode\01_AzureWebAppExample_Begin**, and then click **OK**.

7. In the **New ASP.NET Core Web Application - AzureWebAppExample** dialog box, in the result pane, click **Web Application (Model-View-Controller)**, ensure that the check boxes are cleared, and then click **OK**.

8. In the **AzureWebAppExample – Microsoft Visual Studio** window, on the **DEBUG** menu, click **Start Without Debugging**. 

   >**Note**: The browser displays the default home page.

9. In Microsoft Edge, click **Close**.

10. In the **AzureWebAppExample – Microsoft Visual Studio** window, in Solution Explorer, right-click **AzureWebAppExample**, and then click **Publish.**

11. In the **Pick a publish target** dialog box, in the left pane, click **App Service**.

12. In the **Pick a publish target** dialog box, in the result pane, click **Create New**, and then click **Create Profile**.

13. In the **Create App Service** dialog box, click **Sign in**.

    >**Note**: In case you have already signed in, you will not see this dialog box. In that case, go to step 16.

14. In the **Sign in to your account** dialog box, enter the email address, phone number, or Skype ID of your Azure account, and then click **Next**. 

15. In the **Sign in to your account** dialog box, type **Password**, and then click **Sign in**.

16. In the **Create App Service** dialog box, in the **App Name** box, type  **AzureWebAppExample{unique name}**.  

    >**Note**: The name must be unique. You can add your first name, last name, or birthdate to the current name.

17. In the **Create App Service** dialog box, below the **Resource Group** box, click **New**. 

18. In the **New resource group name** box, type **AzureWebAppExample**, and then click **OK**.

19. In the **Create App Service** dialog box, below the **Hosting Plan** box, click **New**. 

20. In the **Configure Hosting Plan** dialog box, in the **App Service Plan** box, type **AzureWebAppExample{unique name}**, and then click **OK**. 

21. In the **Create App Service** dialog box, click **Create**.

22. In the **Publish** window, click **Publish**.

    >**Note**: The browser displays the home page, and the URL is: http://azurewebapp{unique name}.azurewebsites.net/
    >
    >![public1](https://github.com/JuanjoSalva/DEMO14_L2/blob/master/AzureWebAppExample/img/public1.PNG)
    >
    >![public2](https://github.com/JuanjoSalva/DEMO14_L2/blob/master/AzureWebAppExample/img/Local.PNG)


![creando_app_services](https://github.com/JuanjoSalva/DEMO14_L2/blob/master/AzureWebAppExample/img/creando_app_services.PNG)

![publicando](https://github.com/JuanjoSalva/DEMO14_L2/blob/master/AzureWebAppExample/img/publicando.PNG)





![Publicado](https://github.com/JuanjoSalva/DEMO14_L2/blob/master/AzureWebAppExample/img/Publicado.PNG)



1. In Microsoft Edge, in the address bar, type **http://portal.azure.com**, and then press Enter.

   >**Note**: In case you are already signed in, you will not see the **Sign in** dialog box. In that case, go to step 26.

2. In the **Sign in to your account** dialog box, enter the email address, phone number, or Skype ID of your Azure account, and then click **Next**. 

3. In the **Sign in** dialog box, type **Password**, and then click **Sign in**. 

   >**Note**: The browser displays the dashboard that contains the App Service and the App Service Plan.

   

4. In Microsoft Edge, click the **AzureWebApp{unique name}** app service.

   >**Note**: View the details in the overview window.

5. In Microsoft Edge, click **Close**.

6. In **AzureWebAppExample - Microsoft Visual Studio**, in Solution Explorer, expand **Views**, expand **Home**, and then click **Index.cshtml**.

7. In the **Index.cshtml** window, delete all the content.

8. In the **Index.cshtml** window, type the following code:

```cs
@{
    ViewData["Title"] = "Home Page";
}

<h2> This is a ASP .NET web application deployed on Azure App Service </h2>
```

31. In the **AzureWebAppExample - Microsoft Visual Studio** window, on the **FILE** menu, click **Save All**.

32. In the **AzureWebAppExample – Microsoft Visual Studio** window, in Solution Explorer, right-click **AzureWebAppExample**, and then click **Publish**.

33. In the **Publish** window, click **Publish**.

    >**Note**: The browser displays:  **This is a ASP .NET web application deployed on Azure App Service**. 

34. In Microsoft Edge, click **Close**.

35. In the **AzureWebAppExample - Microsoft Visual Studio** window, on the **FILE** menu, click **Exit**.





**Vemos la página en local:**

![URL_publica](https://github.com/JuanjoSalva/DEMO14_L2/blob/master/AzureWebAppExample/img/URL_publica.PNG)

** Ahora la vemos en el app s![URL_publica](https://github.com/JuanjoSalva/DEMO14_L2/blob/master/AzureWebAppExample/img/URL_publica.PNG)ervice**



