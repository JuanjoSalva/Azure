# Lab: Authenticating to and querying Microsoft Graph by using MSAL and .NET SDKs

# Student lab answer key

### Exercise 1: Create an Azure Active Directory (Azure AD) application registration

#### Task 1: Open the Azure portal

1. On the taskbar, select the **Microsoft Edge** icon.

1. In the open browser window, go to the Azure portal (<https://portal.azure.com>).

1. Enter the email address for your Microsoft account, and then select **Next**.

1. Enter the password for your Microsoft account, and then select **Sign in**.

   > **Note**: If this is your first time signing in to the Azure portal, you'll be offered a tour of the portal. Select **Get Started** to skip the tour and begin using the portal.

![Conexion](img/Conexion.PNG)

#### Task 2: Create an application registration

1. In the Azure portal's navigation pane, select **All services**.

1. From the **All services** blade, select **Azure Active Directory**.

1. From the **Azure Active Directory** blade, select **App registrations** in the **Manage** section.

   ![appregistration](img/appregistration.PNG)

1. In the **App registrations** section, select **New registration**.

1. In the **Register an application** section, perform the following actions:

   1. In the **Name** text box, enter **graphapp**.

   1. In the **Supported account types** list, select the **Accounts in this organizational directory only (Default Directory only - Single tenant)** check box.

   1. In the **Redirect URI** drop-down list, select **Public client/native (mobile & desktop)**.

   1. In the **Redirect URI** text box, enter **http\://localhost**.

      ![appregistrationdef](img/appregistrationdef.PNG)

   1. Select **Register**.

      ![appregiscreada](img/appregiscreada.PNG)

#### Task 3: Enable the default client type

1. In the **graphapp** application registration blade, select **Authentication** in the **Manage** section.

   ![appregistrationmanage](img/appregistrationmanage.PNG)

1. In the **Authentication** section, perform the following actions:

   1. In the **Default client type** subsection, select **Yes**.

   1. Select **Save**.

      ![yes](img/yes.PNG)

#### Task 4: Record unique identifiers

1.  On the **graphapp** application registration blade, select **Overview**.

1.  In the **Overview** section, find and record the value of the **Application (client) ID** text box. You'll use this value later in the lab.

1.  In the **Overview** section, find and record the value of the **Directory (tenant) ID** text box. You'll use this value later in the lab.

![ids](img/ids.PNG)

#### Review

In this exercise, you created a new application registration and recorded important values that you'll need later in the lab.

### Exercise 2: Obtain a token by using the MSAL.NET library

#### Task 1: Create a .NET project

1. On the **Start** screen, select the **Visual Studio Code** tile.

1. On the **File** menu, select **Open Folder**.

1. In the **File Explorer** window that opens, browse to **Allfiles (F):\\Allfiles\\Labs\\06\\Starter\\GraphClient**, and then select **Select Folder**.

1. In the **Visual Studio Code** window, right-click or activate the shortcut menu for the Explorer pane, and then select **Open in Terminal**.

1. At the open command prompt, enter the following command, and then select Enter to create a new .NET project named **GraphClient** in the current folder:

   ```
   dotnet new console --name GraphClient -f netcoreapp2.1 --output .
   ```

   > **Note**: The **dotnet new** command will create a new **console** project in a folder with the same name as the project.

   ![newconsole](img/newconsole.PNG)

1. At the command prompt, enter the following command, and then select Enter to import version 4.7.1 of **Microsoft.Identity.Client** from NuGet:

   ```
   dotnet add package Microsoft.Identity.Client --version 4.7.1
   ```

   > **Note**: The **dotnet add package** command will add the **Microsoft.Identity.Client** package from NuGet. For more information, go to [Microsoft.Identity.Client](https://www.nuget.org/packages/Microsoft.Identity.Client/4.7.1).

   ![newconsole2](img/newconsole2.PNG)

1. At the command prompt, enter the following command, and then select Enter to build the .NET web application:

   ```
   dotnet build
   ```

   ![build](img/build.PNG)

1. Select **Kill Terminal** or the **Recycle Bin** icon to close the currently open terminal and any associated processes.

#### Task 2: Modify the Program class

1. In the Explorer pane of the **Visual Studio Code** window, open the **Program.cs** file.

1. On the code editor tab for the **Program.cs** file, delete all the code in the existing file.

1. Add the following line of code to import the **Microsoft.Identity.Client** namespace from the **Microsoft.Identity.Client** package imported from NuGet:

   ```
   using Microsoft.Identity.Client;
   ```

   

1. Add the following lines of code to add **using** directives for the built-in namespaces that will be used in this file:

   ```
   using System;
   using System.Collections.Generic;
   using System.Threading.Tasks;
   ```

   

1. Enter the following code to create a new **Program** class:

   ```
   public class Program
   {
   }
   ```

   

1. In the **Program** class, enter the following code to create a new asynchronous **Main** method:

   ```
   public static async Task Main(string[] args)
   {
   }
   ```

   

1. In the **Program** class, enter the following line of code to create a new string constant named **_clientId**:

   ```
   private const string _clientId = "";
   ```

   

1. Update the **_clientId** string constant by setting its value to the **Application (client) ID** that you recorded earlier in this lab.

1. In the **Program** class, enter the following line of code to create a new string constant named **_tenantId**:

   ```
   private const string _tenantId = "";
   ```

   

1. Update the **_tenantId** string constant by setting its value to the **Directory (tenant) ID** that you recorded earlier in this lab.

1. Observe the **Program.cs** file, which should now include:

   ```
   using Microsoft.Identity.Client;
   using System;
   using System.Collections.Generic;
   using System.Threading.Tasks;
   
   public class Program
   {
       private const string _clientId = "<app-reg-client-id>";        
       private const string _tenantId = "<aad-tenant-id>";
   
       public static async Task Main(string[] args)
       {
       }
   }
   ```

![Code1](img/Code1.PNG)

#### Task 3: Obtain a Microsoft Authentication Library (MSAL) token

1. In the **Main** method, add the following line of code to create a new variable named *app* of type **[IPublicClientApplication](https://docs.microsoft.com/dotnet/api/microsoft.identity.client.ipublicclientapplication)**:

   ```
   IPublicClientApplication app;
   ```

1. In the **Main** method, perform the following actions to build a public client application instance by using the static **[PublicClientApplicationBuilder](https://docs.microsoft.com/dotnet/api/microsoft.identity.client.publicclientapplicationbuilder)** class, and then store it in the *app* variable:

   1. Add the following line of code to access the static **[PublicClientApplicationBuilder](https://docs.microsoft.com/dotnet/api/microsoft.identity.client.publicclientapplicationbuilder)** class:

      ```
      PublicClientApplicationBuilder
      ```

   1. Update the previous line of code by adding another line of code to use the **[Create()](https://docs.microsoft.com/dotnet/api/microsoft.identity.client.publicclientapplicationbuilder.create)** method of the **PublicClientApplicationBuilder** class, passing in the *_clientId* variable as a parameter:

      ```
      PublicClientApplicationBuilder
          .Create(_clientId)
      ```

   1. Update the previous line of code by adding another line of code to use the **[WithAuthority()](https://docs.microsoft.com/dotnet/api/microsoft.identity.client.abstractapplicationbuilder-1.withauthority)** method of the base **[AbstractApplicationBuilder<>](https://docs.microsoft.com/dotnet/api/microsoft.identity.client.abstractapplicationbuilder-1)** class, passing in the enumeration value **[AzureCloudInstance.AzurePublic](https://docs.microsoft.com/dotnet/api/microsoft.identity.client.azurecloudinstance)** and the *_tenantId* variable as parameters:

      ```
      PublicClientApplicationBuilder
          .Create(_clientId)
          .WithAuthority(AzureCloudInstance.AzurePublic, _tenantId)
      ```

   1. Update the previous line of code by adding another line of code to use the **[WithRedirectUri()](https://docs.microsoft.com/dotnet/api/microsoft.identity.client.abstractapplicationbuilder-1.withredirecturi)** method of the base **AbstractApplicationBuilder<>** class, passing in a string value of **http://localhost**:

      ```
      PublicClientApplicationBuilder
          .Create(_clientId)
          .WithAuthority(AzureCloudInstance.AzurePublic, _tenantId)
          .WithRedirectUri("http://localhost")
      ```

   1. Update the previous line of code by adding another line of code to use the **[Build()](https://docs.microsoft.com/dotnet/api/microsoft.identity.client.publicclientapplicationbuilder.build)** method of the **PublicClientApplication** class:

      ```
      PublicClientApplicationBuilder
          .Create(_clientId)
          .WithAuthority(AzureCloudInstance.AzurePublic, _tenantId)
          .WithRedirectUri("http://localhost")
          .Build();
      ```

   1. Update the previous line of code by adding more code to store the result of the expression in the *app* variable:

      ```
      app = PublicClientApplicationBuilder
          .Create(_clientId)
          .WithAuthority(AzureCloudInstance.AzurePublic, _tenantId)
          .WithRedirectUri("http://localhost")
          .Build();
      ```

1. In the **Main** method, add the following line of code to create a new generic string **[List<>](https://docs.microsoft.com/dotnet/api/system.collections.generic.list-1)** with a single value of **user.read**:

   ```
   List<string> scopes = new List<string> 
   { 
       "user.read" 
   };
   ```

1. In the **Main** method, add the following line of code to create a new variable named *result* of type **[AuthenticationResult](https://docs.microsoft.com/dotnet/api/microsoft.identity.client.authenticationresult)**:

   ```
   AuthenticationResult result;
   ```

1. In the **Main** method, perform the following actions to acquire a token interactively and store the output in the *result* variable:

   1. Add the following line of code to access the *app* variable:

      ```
      app
      ```

   1. Update the previous line of code by adding another line of code to use the **[AcquireTokenInteractive()](https://docs.microsoft.com/dotnet/api/microsoft.identity.client.ipublicclientapplication.acquiretokeninteractive)** method of the **IPublicClientApplicationBuilder** interface, passing in the *scopes* variable as a parameter:

      ```
      app
          .AcquireTokenInteractive(scopes)
      ```

   1. Update the previous line of code by adding another line of code to use the **[ExecuteAsync()](https://docs.microsoft.com/dotnet/api/microsoft.identity.client.abstractacquiretokenparameterbuilder-1.executeasync)** method of the **[AbstractAcquireTokenParameterBuilder](https://docs.microsoft.com/dotnet/api/microsoft.identity.client.abstractacquiretokenparameterbuilder-1)** class:

      ```
      app
          .AcquireTokenInteractive(scopes)
          .ExecuteAsync();
      ```

   1. Update the previous line of code by adding more code to process the expression asynchronously by using the **await** keyword:

      ```
      await app
          .AcquireTokenInteractive(scopes)
          .ExecuteAsync();
      ```

   1. Update the previous line of code by adding more code to store the result of the expression in the *result* variable:

      ```
      result = await app
          .AcquireTokenInteractive(scopes)
          .ExecuteAsync();
      ```

1. In the **Main** method, add the following line of code to use the **Console.WriteLine** method to render the value of the **[AuthenticationResult.AccessToken](https://docs.microsoft.com/dotnet/api/microsoft.identity.client.authenticationresult.accesstoken)** member to the console:

   ```
   Console.WriteLine($"Token:\t{result.AccessToken}");
   ```

1. Observe the **Main** method, which should now include:

   ```
   public static async Task Main(string[] args)
   {
       IPublicClientApplication app;
   
       app = PublicClientApplicationBuilder
           .Create(_clientId)
           .WithAuthority(AzureCloudInstance.AzurePublic, _tenantId)
           .WithRedirectUri("http://localhost")
           .Build();
   
       List<string> scopes = new List<string> 
       { 
           "user.read"
       };
   
       AuthenticationResult result;
       
       result = await app
           .AcquireTokenInteractive(scopes)
           .ExecuteAsync();
   
       Console.WriteLine($"Token:\t{result.AccessToken}");
   }
   ```

1. Save the **Program.cs** file.

   ![Code2](img/Code2.PNG)

#### Task 4: Test the updated application

1. In the **Visual Studio Code** window, right-click or activate the shortcut menu for the Explorer pane, and then select **Open in Terminal**.

1. At the open command prompt, enter the following command, and then select Enter to run the .NET web application:

   ```
   dotnet run
   ```

   > **Note**: If there are any build errors, review the **Program.cs** file in the **Allfiles (F):\\Allfiles\\Labs\\06\\Solution\\GraphClient** folder.

1. The running console application will automatically open an instance of the default browser.

   ![permisos](img/permisos.PNG)

1. In the open browser window, perform the following actions:

   1.  Enter the email address for your Microsoft account, and then select **Next**.

   1.  Enter the password for your Microsoft account, and then select **Sign in**.

   > **Note**: You might have the option to select an existing Microsoft account as opposed to signing in again.

1. The browser window will automatically open the **Permissions requested** webpage. On this webpage, perform the following actions:

   1. Review the requested permissions.

   1. Select **Accept**.

      ![permitido](img/permitido.PNG)

1. Return to the currently running Visual Studio Code application.

1. Observe the token rendered in the output from the currently running console application.

   ![token](img/token.PNG)

1. Select **Kill Terminal** or the **Recycle Bin** icon to close the currently open terminal and any associated processes.

#### Review

In this exercise, you acquired a token from the Microsoft identity platform by using the MSAL.NET library.

### Exercise 3: Query Microsoft Graph by using the .NET SDK

#### Task 1: Import the Microsoft Graph SDK from NuGet

1. In the **Visual Studio Code** window, right-click or activate the shortcut menu for the Explorer pane, and then select **Open in Terminal**.

1. At the command prompt, enter the following command, and then select Enter to import version 1.21.0 of **Microsoft.Graph** from NuGet:

   ```
   dotnet add package Microsoft.Graph --version 1.21.0
   ```

   > **Note**: The **dotnet add package** command will add the **Microsoft.Graph** package from NuGet. For more information, go to [Microsoft.Graph](https://www.nuget.org/packages/Microsoft.Graph/1.21.0).

   ![anadido](img/anadido.PNG)

1. At the command prompt, enter the following command, and then select Enter to import version 1.0.0-preview.2 of **Microsoft.Graph.Auth** from NuGet:

   ```
   dotnet add package Microsoft.Graph.Auth --version 1.0.0-preview.2
   ```

   > **Note**: The **dotnet add package** command will add the **Microsoft.Graph.Auth** package from NuGet. For more information, go to [Microsoft.Graph.Auth](https://www.nuget.org/packages/Microsoft.Graph.Auth/1.0.0-preview.2).

   ![anadido2](img/anadido2.PNG)

1. At the command prompt, enter the following command, and then select Enter to build the .NET web application:

   ```
   dotnet build
   ```

   ![build2](img/build2.PNG)

1. Select **Kill Terminal** or the **Recycle Bin** icon to close the currently open terminal and any associated processes.

#### Task 2: Modify the Program class

1. In the Explorer pane of the **Visual Studio Code** window, open the **Program.cs** file.

1. On the code editor tab for the **Program.cs** file, add the following line of code to import the **Microsoft.Graph** namespace from the **Microsoft.Graph** package imported from NuGet:

   ```
   using Microsoft.Graph;
   ```

1. Add the following line of code to import the **Microsoft.Graph.Auth** namespace from the **Microsoft.Graph.Auth** package imported from NuGet:

   ```
   using Microsoft.Graph.Auth;
   ```

1. Observe the **Program.cs** file, which should now include the following **using** directives:

   ```
   using Microsoft.Graph;    
   using Microsoft.Graph.Auth;
   using Microsoft.Identity.Client;
   using System;
   using System.Collections.Generic;
   using System.Threading.Tasks;
   ```

#### Task 3: Use the Microsoft Graph SDK to query user profile information

1. Within the **Main** method, perform the following actions to remove unnecessary code:

   1. Delete the following line of code:

      ```
      AuthenticationResult result;
      ```

   1. Delete the following block of code:

      ```
      result = await app
              .AcquireTokenInteractive(scopes)
              .ExecuteAsync();
      ```

   1. Delete the following line of code:

      ```
      Console.WriteLine($"Token:\t{result.AccessToken}");
      ```

1. Observe the **Main** method, which should now include:

   ```
   public static async Task Main(string[] args)
   {
       IPublicClientApplication app;
   
       app = PublicClientApplicationBuilder
           .Create(_clientId)
           .WithAuthority(AzureCloudInstance.AzurePublic, _tenantId)
           .WithRedirectUri("http://localhost")
           .Build();
   
       List<string> scopes = new List<string> 
       { 
           "user.read"
       };
   }
   ```

1. In the **Main** method, add the following line of code to create a new variable named *provider* of type **DeviceCodeProvider** that passes in the variables *app* and *scopes* as constructor parameters:

   ```
   DeviceCodeProvider provider = new DeviceCodeProvider(app, scopes);
   ```

1. In the **Main** method, add the following line of code to create a new variable named *client* of type **GraphServiceClient** that passes in the variable *provider* as a constructor parameter:

   ```
   GraphServiceClient client = new GraphServiceClient(provider);
   ```

1. In the **Main** method, perform the following actions to use the **GraphServiceClient** instance to asynchronously get the response of issuing an HTTP request to the relative **/Me** directory of the REST API:

   1. Add the following line of code to get the **Me** property of the *client* variable:

      ```
      client.Me
      ```

   1. Update the previous line of code by adding another line of code to get an object representing the HTTP request by using the **Request()** method:

      ```
      client.Me
          .Request()
      ```

   1. Update the previous line of code by adding another line of code to issue the request asynchronously by using the **GetAsync()** method:

      ```
      client.Me
          .Request()
          .GetAsync()
      ```

   1. Update the previous line of code by adding more code to process the expression asynchronously by using the **await** keyword:

      ```
      await client.Me
          .Request()
          .GetAsync()
      ```

   1. Update the previous line of code by adding more code to store the result of the expression in a new variable named *myProfile* of type **User**:

      ```
      User myProfile = await client.Me
          .Request()
          .GetAsync();
      ```

1. In the **Main** method, add the following line of code to use the **Console.WriteLine** method to render the value of the **User.DisplayName** member to the console:

   ```
   Console.WriteLine($"Name:\t{myProfile.DisplayName}");
   ```

1. In the **Main** method, add the following line of code to use the **Console.WriteLine** method to render the value of the **User.Id** member to the console:

   ```
   Console.WriteLine($"AAD Id:\t{myProfile.Id}");
   ```

1. Observe the **Main** method, which should now include:

   ```
   public static async Task Main(string[] args)
   {
       IPublicClientApplication app;
   
       app = PublicClientApplicationBuilder
           .Create(_clientId)
           .WithAuthority(AzureCloudInstance.AzurePublic, _tenantId)
           .WithRedirectUri("http://localhost")
           .Build();
   
       List<string> scopes = new List<string> 
       { 
           "user.read" 
       };
   
       DeviceCodeProvider provider = new DeviceCodeProvider(app, scopes);
   
       GraphServiceClient client = new GraphServiceClient(provider);
   
       User myProfile = await client.Me
           .Request()
           .GetAsync();
   
       Console.WriteLine($"Name:\t{myProfile.DisplayName}");
       Console.WriteLine($"AAD Id:\t{myProfile.Id}");
   }
   ```

1. Save the **Program.cs** file.

#### Task 4: Test the updated application

1. In the **Visual Studio Code** window, right-click or activate the shortcut menu for the Explorer pane, and then select **Open in Terminal**.

1. At the open command prompt, enter the following command, and then select Enter to run the .NET web application:

   ```
   dotnet run
   ```

   > **Note**: If there are any build errors, review the **Program.cs** file in the **Allfiles (F):\\Allfiles\\Labs\\06\\Solution\\GraphClient** folder.

   ![token2](img/token2.PNG)

1. Observe the message in the output from the currently running console application. Record the value of the code in the message. You'll use this value later in the lab.

   **Me da el token: D3A3KJ6XV**

1. On the taskbar, select the **Microsoft Edge** icon.

1. In the open browser window, go to <https://microsoft.com/devicelogin>.

   ![web](img/web.PNG)

1. On the **Enter code** webpage: **el mio es:D3A3KJ6XV**, perform the following actions:

   1.  In the **Code** text box, enter the value of the code that you copied earlier in the lab.

   1.  Select **Next**.  

   ![web2](img/web2.PNG)

1. On the login webpage, perform the following actions:

   1.  Enter the email address for your Microsoft account, and then select **Next**.

   1.  Enter the password for your Microsoft account, and then select **Sign in**.

   > **Note**: You might have the option to select an existing Microsoft account as opposed to signing in again.

   ![web3](img/web3.PNG)

1. Return to the currently running Visual Studio Code application.

1. Observe the output from the Microsoft Graph request in the currently running console application.

   ![aceptado](img/aceptado.PNG)

1. Select **Kill Terminal** or the **Recycle Bin** icon to close the currently open terminal and any associated processes.
