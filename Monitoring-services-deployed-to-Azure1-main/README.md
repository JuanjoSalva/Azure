# Lab: Monitoring services deployed to Azure

# Student lab answer key

## Microsoft Azure user interface

Given the dynamic nature of Microsoft cloud tools, you might experience Azure user interface (UI) changes after the development of this training content. These changes might cause the lab instructions and steps to not match up.

Microsoft updates this training course as soon as the community brings needed changes to our attention. However, because cloud updates occur frequently, you might encounter UI changes before this training content is updated. **If this occurs, adapt to the changes and work through them in the labs as needed.**

## Instructions

### Before you start

#### Sign in to the lab virtual machine

Sign in to your **Windows 10** virtual machine by using the following credentials:

- **Username**: Admin
- **Password**: Pa55w.rd

> **Note**: Instructions to connect to the virtual lab environment will be provided by your instructor.

#### Review installed applications

Observe the taskbar located at the bottom of your **Windows 10** desktop. The taskbar contains the icons for the applications that you will use in this lab:

- Microsoft Edge
- File Explorer
- Visual Studio Code
- Windows PowerShell

### Exercise 1: Create and configure Azure resources

#### Task 1: Open the Azure portal

1. On the taskbar, select the **Microsoft Edge** icon.
2. In the open browser window, navigate to the [**Azure portal**](https://portal.azure.com/) (portal.azure.com).
3. At the sign-in page, enter the **email address** for your Microsoft account.
4. Select **Next**.
5. Enter the **password** for your Microsoft account.
6. Select **Sign in**.

> **Note**: If this is your first time signing in to the **Azure portal**, a dialog box will display an offer to tour the portal. Select **Get Started** to skip the tour and begin using the portal.

#### Task 2: Create an Application Insights resource

1. In the left navigation pane of the portal, select **+ Create a resource**.

2. At the top of the **New** blade, locate the **Search the Marketplace** field.

3. In the search field, enter **Insights** and press Enter.

4. In the **Everything** search results blade, select the **Application Insights** result.

5. In the **Application Insights** blade, select **Create**.

6. In the second **Application Insights** blade, locate the tabs in the blade, such as **Basics**.

   > **Note**: Each tab represents a step in the workflow to create a new **Application Insights instance**. At any time, you can select **Review + create** to skip the remaining tabs.

7. In the **Basics** tab, perform the following actions:

   1. Leave the **Subscription** text box set to its default value.
   2. In the **Resource group** section, select **Create new**, enter **MonitoredAssets**, and then select **OK**.
   3. In the **Name** text box, enter **instrm[your name in lowercase]**.
   4. In the **Location** drop-down list, select the **(US) East US** region.
   5. Select **Review + Create**.

8. In the **Review + Create** tab, review the options that you selected during the previous steps.

9. Select **Create** to create the Application Insights instance by using your specified configuration.

10. Wait for the creation task to complete before you move forward with this lab.

11. In the left navigation pane of the portal, select **Resource groups**.

12. In the **Resource groups** blade, select the **MonitoredAssets** resource group that you created earlier in this lab.

13. In the **MonitoredAssets** blade, select the **instrm\*** Application Insights account that you created earlier in this lab.

14. In the **Application Insights** blade, on the left side of the blade, within the **Configure** category,, select the **Properties** link.

15. In the **Properties** section, observe the value of the **Instrumentation Key** field. This key is used by client applications to connect to Application Insights.

#### Task 3: Create an Web App resource

1. In the left navigation pane of the portal, select **+ Create a resource**.

2. At the top of the **New** blade, locate the **Search the Marketplace** field.

3. In the search field, enter **Web** and press Enter.

4. In the **Everything** search results blade, select the **Web App** result.

5. In the **Web App** blade, select **Create**.

6. In the second **Web App** blade, locate the tabs in the blade, such as **Basics**.

   > **Note**: Each tab represents a step in the workflow to create a new **Web App**. At any time, you can select **Review + create** to skip the remaining tabs.

7. In the **Basics** tab, perform the following actions:

   1. Leave the **Subscription** text box set to its default value.
   2. In the **Resource group** drop-down list, select **MonitoredAssets**.
   3. In the **Name** text box, enter **smpapi[your name in lowercase]**.
   4. In the **Publish** section, select **Code**.
   5. In the **Runtime stack** drop-down list, select **.NET Core 3.1 (LST)**.
   6. In the **Operating System** section, select **Windows**.
   7. In the **Region** drop-down list, select the **East US** region.
   8. In the **Windows Plan (East US)** section, select **Create new**, enter the value **MonitoredPlan** into the **Name** text box, and then select **OK**.
   9. Leave the **Sku and size** section set to its default value.
   10. Select **Next: Monitoring**.

8. In the **Monitoring** tab, perform the following actions:

   1. In the **Enable Application Insights** section, select **Yes**.
   2. In the **Application Insights** drop-down list, select the **instrm\*** Application Insights account that you created earlier in this lab.
   3. Select **Review + Create**.

9. In the **Review + Create** tab, review the options that you selected during the previous steps.

10. Select **Create** to create the Web App by using your specified configuration.

11. Wait for the creation task to complete before you move forward with this lab.

12. In the left navigation pane of the portal, select **Resource groups**.

13. In the **Resource groups** blade, select the **MonitoredAssets** resource group that you created earlier in this lab.

14. In the **MonitoredAssets** blade, select the **smpapi\*** Web App you that created earlier in this lab.

15. In the **App Service** blade, on the left side of the blade, within the **Settings** category, select the **Configuration** link.

16. In the **Configuration** section, perform the following actions:

    1. Select the **Application settings** tab.
    2. Select **Show Values** to view the secrets associated with your API.
    3. Observe the value corresponding to the **APPINSIGHTS_INSTRUMENTATIONKEY** key. This value was set automatically when you built your Web App resource.

17. In the **App Service** blade, on the left side of the blade within the **Settings** category, select the **Properties** link.

18. In the **Properties** section, record the value of the **URL** field. You will use this value later in the lab to make requests against the API.

#### Task 4: Configure Web App auto-scale options

1. In the **App Service** blade, on the left side of the blade, within the **Settings** category, select the **Scale out (App Service Plan)** link.
2. In the **Scale out** section, perform the following actions:
   1. Select **Custom autoscale**.
   2. In the **Autoscale setting name** field, enter **ComputeScaler**.
   3. In the **Resource group** list, select **MonitoredAssets**.
   4. In the **Scale mode** section, select **Scale based on a metric**.
   5. In the **Minimum** field within the **Instance limits** section, enter **2**.
   6. In the **Maximum** field within the **Instance limits** section, enter **8**.
   7. In the **Default** field within the **Instance limits** section, enter **3**.
   8. Select **+ Add a rule**. In the **Scale rule** popup that appears, leave all fields set to their default values and then select **Add**.
   9. At the top of the section, select **Save**.
3. Wait for the save operation to complete before you move forward with this lab.

#### Review

In this exercise, you created the resources that you will use for the remainder of the lab.

### Exercise 2: Monitor a local web application by using Application Insights

#### Task 1: Build a .NET Core Web API project

1. On the taskbar, select the **Visual Studio Code** icon.

2. On the **File** menu, select **Open Folder**.

3. In the File Explorer pane that opens, go to **Allfiles (F):\Allfiles\Labs\12\Starter\Api**, and then select **Select Folder**.

4. In the Visual Studio Code window, access the context menu or right-click the **Explorer** pane and then select **Open in Terminal**.

5. In the open command prompt, enter the following command and press Enter to create a new .NET Core Web API application named **SimpleApi** in the current directory:

   

   ```
   dotnet new webapi --output . --name SimpleApi -f netcoreapp3.1
   ```

6. At the command prompt, enter the following command, and then select Enter to import version 2.14.0 of **Microsoft.ApplicationInsights** from NuGet to the current project:

   

   ```
   dotnet add package Microsoft.ApplicationInsights --version 2.14.0
   ```

7. In the command prompt, enter the following command and press Enter to add the **2.14.0** version of the **Microsoft.ApplicationInsights.AspNetCore** package from NuGet to the current project:

   

   ```
   dotnet add package Microsoft.ApplicationInsights.AspNetCore --version 2.14.0
   ```

8. At the command prompt, enter the following command, and then select Enter to import version 2.14.0 of **Microsoft.ApplicationInsights.PerfCounterCollector** from NuGet to the current project:

   

   ```
   dotnet add package Microsoft.ApplicationInsights.PerfCounterCollector  --version 2.14.0
   ```

9. In the command prompt, enter the following command and press Enter to build the .NET Core web application:

   

   ```
   dotnet build
   ```

#### Task 2: Update application code to disable HTTPS and use Application Insights

1. On the left side of the **Visual Studio Code** window, in the **Explorer** pane, double-click the **Startup.cs** file to open the file in the editor.

2. In the editor, in the **Startup** class, locate and delete the following line of code at line **43**:

   

   ```
   app.UseHttpsRedirection();
   ```

   > **Note**: This line of code forces the Web App to use HTTPS. For this lab, this is unnecessary.

3. Within the **Startup** class, add a new **static string constant** named **INSTRUMENTATION_KEY** with its value set to the **Instrumentation Key** you copied from the **Application Insights** resource you created earlier in this lab:

   

   ```
   private const string INSTRUMENTATION_KEY = "{your_instrumentation_key}";
   ```

   > **Note**: For example, if you **Instrumentation Key** is `d2bb0eed-1342-4394-9b0c-8a56d21aaa43`, your line of code would be `private const string INSTRUMENTATION_KEY = "d2bb0eed-1342-4394-9b0c-8a56d21aaa43";`

4. Locate the **ConfigureServices** method within the **Startup** class:

   

   ```
   public void ConfigureServices(IServiceCollection services)
   {
       services.AddControllers();
   }
   ```

5. Add a new line of code at the end of the **ConfigureServices** method to configure Application Insights using the provided instrumentation key:

   

   ```
   services.AddApplicationInsightsTelemetry(INSTRUMENTATION_KEY);
   ```

6. Your **ConfigureServices** method should now look like this:

   

   ```
   public void ConfigureServices(IServiceCollection services)
   {
       services.AddControllers();
       services.AddApplicationInsightsTelemetry(INSTRUMENTATION_KEY);
   }
   ```

7. **Save** the **Startup.cs** file.

8. Locate the command prompt at the bottom of the screen. In the command prompt, enter the following command and press Enter to build the .NET Core web application.

   

   ```
   dotnet build
   ```

#### Task 3: Test an API application locally

1. Locate the command prompt at the bottom of the screen. In the command prompt, enter the following command and press Enter to execute the .NET Core web application.

   

   ```
   dotnet run
   ```

2. On the taskbar, select the **Microsoft Edge** icon.

3. In the open browser window, navigate to the **/weatherforecast** relative path of your test application hosted at **localhost** on port **5000**.

   > **Note**: The full URL is http://localhost:5000/weatherforecast

4. In the same browser window, navigate to the **/weatherforecast** relative path of your test application hosted at **localhost** on port **5000**.

   > **Note**: The full URL is http://localhost:5000/weatherforecast

5. Close the browser window displaying the http://localhost:5000/weatherforecast address.

6. Close the currently running **Visual Studio Code** application.

#### Task 4: Get metrics in Application Insights

1. Return to your currently open browser window displaying the **Azure portal**.

2. On the left side of the portal, select **Resource groups**.

3. In the **Resource groups** blade, locate and select the **MonitoredAssets** resource group that you created earlier in this lab.

4. In the **MonitoredAssets** blade, select the **instrm\*** Application Insights account that you created earlier in this lab.

5. In the **Application Insights** blade, in the tiles located in the center of the blade, observe the metrics displayed. Specifically, observe the number of **server requests** that have occurred and the average **server response time**.

   > **Note**: It can take up to five minutes for the requests to show within the Application Insights metrics charts.

#### Task 5: Deploy an application to Web App

1. On the taskbar, select the **Visual Studio Code** icon.

2. On the **File** menu, select **Open Folder**.

3. In the File Explorer pane that opens, go to **Allfiles (F):\Allfiles\Labs\12\Starter\Api**, and then select **Select Folder**.

4. In the Visual Studio Code window, access the context menu or right-click the **Explorer** pane, and then select **Open in Terminal**.

5. In the open command prompt, enter the following command and press Enter to sign in to the Azure CLI:

   

   ```
   az login
   ```

6. In the browser window that appears, perform the following actions:

   1. Enter the **email address** for your Microsoft account.
   2. Select **Next**.
   3. Enter the **password** for your Microsoft account.
   4. Select **Sign in**.

7. Return to the currently open **command prompt** application. Wait for the sign-in process to finish.

8. At the command prompt, enter the following command and press Enter to list all the **apps** in your **MonitoredAssets** resource group:

   

   ```
   az webapp list --resource-group MonitoredAssets
   ```

9. Enter the following command and press Enter to find the **apps** that have the prefix **smpapi\***:

   

   ```
   az webapp list --resource-group MonitoredAssets --query "[?starts_with(name, 'smpapi')]"
   ```

10. Enter the following command and press Enter to print out only the name of the single app that has the prefix **smpapi\***:

    

    ```
    az webapp list --resource-group MonitoredAssets --query "[?starts_with(name, 'smpapi')].{Name:name}" --output tsv
    ```

11. Enter the following command and press Enter to change the current directory to the **Allfiles (F):\Allfiles\Labs\12\Starter\Api** directory that contains the deployment files:

    

    ```
    cd F:\Allfiles\Labs\12\Starter\Api
    ```

12. In Code.

    Create **Azure.pubxml** in Properties\PublishProfiles Folders:

    

    ```
    <Project>
        <PropertyGroup>
          <PublishProtocol>Kudu</PublishProtocol>
          <PublishSiteName>smpapi[yourname]</PublishSiteName>
          <UserName>ftpAz20412</UserName>
          <Password>P@ssword99</Password>
        </PropertyGroup>
    </Project>
    ```

    In Azure Portal set in Deployment Center FTP credentials for "Users Credentials like above values: UserName and Password

    

    ```
    dotnet publish /p:PublishProfile=Azure /p:Configuration=Release -f netcoreapp3.1
    ```

    **Note:** Stop Web App if is necessary.

13. Enter the following command and press Enter to deploy the **api.zip** file to the **Web App** that you created earlier in this lab: (Optional) "**donet publish -o D:\0Az-204\Allfiles\Labs\12\Starter\Api\Api -f netcoreapp3.1**" and zip result, if you try the below command:

    

    ```
    az webapp deployment source config-zip --resource-group MonitoredAssets --src api.zip --name <name-of-your-api-app>
    ```

    > **Note**: Replace the **<name-of-your-api-app>** placeholder with the name of the Web App that you created earlier in this lab. You recently queried this app’s name in the previous steps.

14. Wait for the deployment to complete before you move forward with this lab.

15. Close the currently running **Visual Studio Code** application.

16. In the left navigation pane of the portal, select **Resource groups**.

17. In the **Resource groups** blade, select the **MonitoredAssets** resource group that you created earlier in this lab.

18. In the **MonitoredAssets** blade, select the **smpapi\*** Web App that you created earlier in this lab.

19. In the **App Service** blade, select **Browse** at the top of the blade.

20. A new browser window or tab will open and return a **404 (Not Found)** error. In the browser address bar, update the URL by appending the suffix **/weatherforecast** to the end of the current URL and then press Enter.

    > **Note**: For example, if your URL is [http://smpapistudent.azurewebsites.net](http://smpapistudent.azurewebsites.net/), the new URL would be http://smpapistudent.azurewebsites.net/weatherforecast.

21. Observe the JSON array that is returned as a result of using the API.

#### Review

In this exercise, you created an API by using ASP.NET Core and configured it to stream application metrics to Application Insights. You then used the Application Insights dashboard to view performance details about your Web App and the API running in the app.

### Exercise 3: Build a client application by using .NET Core

#### Task 1: Build a .NET Core console project

1. On the taskbar, select the **Visual Studio Code** icon.

2. On the **File** menu, select **Open Folder**.

3. In the File Explorer pane that opens, go to **Allfiles (F):\Allfiles\Starter\Console**, and then select **Select Folder**.

4. In the Visual Studio Code window, access the context menu or right-click the **Explorer** pane, and then select **Open in Terminal**.

5. In the open command prompt, enter the following command and press Enter to create a new .NET Core console application named **SimpleConsole** in the current directory:

   

   ```
   dotnet new console --output . --name SimpleConsole -f netcoreapp3.1
   ```

6. In the command prompt, enter the following command and press Enter to add the **7.1.0** version of the **Polly** package from NuGet to the current project:

   

   ```
   dotnet add package Polly --version 7.1.0
   ```

7. In the command prompt, enter the following command and press Enter to build the .NET Core web application:

   

   ```
   dotnet build
   ```

#### Task 2: Add HTTP client code

1. On the left side of the **Visual Studio Code** window, in the **Explorer** pane, double-click the **Program.cs** file to open the file in the editor.

2. In the editor, add the following **using** directive for the **System.Net.Http** namespace:

   

   ```
   using System.Net.Http;
   ```

3. In the editor, add the following **using** directive for the **System.Threading.Tasks** namespace:

   

   ```
   using System.Threading.Tasks;
   ```

4. In the **SimpleConsole** namespace, locate the following class at line **7**:

   

   ```
   class Program
   {
       static void Main(string[] args)
       {
           Console.WriteLine("Hello World!");
       }
   }
   ```

5. Replace the entire **Program** class with the following implementation:

   

   ```
   class Program
   {
       private const string _api = "";
       private static HttpClient _client = new HttpClient(){ BaseAddress = new Uri(_api) };
   
       static void Main(string[] args)
       {
   	        Run().Wait();
       }
   
       static async Task Run()
       {
           int loops = 1
           do {
               
           } while (loops++<1000);
       }
   }
   ```

6. Locate the **_api** constant at line **9**:

   

   ```
   private const string _api = "";
   ```

7. Update the **_api** constant by setting the value of the variable to the **URL** of the Web App you recorded earlier in this lab:

   > **Note**: For example, if your URL is [http://smpapistudent.azurewebsites.net](http://smpapistudent.azurewebsites.net/), the new line of code will be: private const string _api = "[http://smpapistudent.azurewebsites.net](http://smpapistudent.azurewebsites.net/)";

8. Within the **Run** method, add the following line of code to asynchronously invoke the **HttpClient.GetStringAsync** method passing in a string for the relative path of **/weatherforecast**:

   

   ```
   string response = await _client.GetStringAsync("/weatherforecast");
   ```

9. Within the **Run** method, add an additional line of code to write out the response from the **GET** request to the console:

   

   ```
   WriteLine(response);
   ```

10. Your **Program.cs** file should now have the following code:

    

    ```
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;
    using static System.Console;
    namespace SimpleConsole
    {
        class Program
        {
            private const string _api = "http://<your-api-name>.azurewebsites.net/";
            private static HttpClient _client = new HttpClient(){ BaseAddress = new Uri(_api) };
    
            static void Main(string[] args)
            {
                Run().Wait();
            }
    
            static async Task Run()
            {
    			int loops = 1
                do {
    		        string response = await _client.GetStringAsync("/weatherforecast");
            	    WriteLine(response);
                } while (loops++<1000);
            }
        }
    }
    ```

11. **Save** the **Program.cs** file.

#### Task 3: Test a console application locally

1. At the bottom of the screen, in the command prompt, enter the following command and press Enter to execute the .NET Core web application.

   

   ```
   dotnet run
   ```

2. Observe that the application successfully invokes the Web App in Azure and returns the same JSON array that you observed earlier in this lab. Your result should appear similar to the following JSON content:

   

   ```
   [{"date":"2021-01-21T10:00:16.9934406+00:00","temperatureC":51,"temperatureF":123,"summary":"Balmy"},{"date":"2021-01-22T10:00:16.9936983+00:00","temperatureC":19,"temperatureF":66,"summary":"Warm"},{"date":"2021-01-23T10:00:16.9936995+00:00","temperatureC":41,"temperatureF":105,"summary":"Sweltering"},{"date":"2021-01-24T10:00:16.9936997+00:00","temperatureC":26,"temperatureF":78,"summary":"Chilly"},{"date":"2021-01-25T10:00:16.9936999+00:00","temperatureC":9,"temperatureF":48,"summary":"Freezing"}]
   ```

3. Return to your currently open browser window displaying the **Azure portal**.

4. On the left side of the portal, select **Resource groups**.

5. In the **Resource groups** blade, locate and select the **MonitoredAssets** resource group that you created earlier in this lab.

6. In the **MonitoredAssets** blade, select the **smpapi\*** Web App that you created earlier in this lab.

7. In the **App Service** blade, select **Stop** at the top of the blade to halt the execution of the Web App.

8. In the **Stop web app** confirmation dialog box, select **Yes**.

9. On the taskbar, select the **Visual Studio Code** icon.

10. On the **File** menu, select **Open Folder**.

11. In the File Explorer pane that opens, go to **Allfiles (F):\Allfiles\Labs\05\Starter\Console**, and then select **Select Folder**.

12. In the Visual Studio Code window, access the context menu or right-click the **Explorer** pane, and then select **Open in Terminal**.

13. In the open command prompt, enter the following command and press Enter to execute the .NET Core web application.

    

    ```
    dotnet run
    ```

14. Observe that the application execution fails and displays a **HttpRequestException** message that is similar to the following exception message:

    

    ```
    System.Net.Http.HttpRequestException: Response status code does not indicate
    
    success: 403 (Site Disabled).
    
    at System.Net.Http.HttpResponseMessage.EnsureSuccessStatusCode()
    
    at System.Net.Http.HttpClient.GetStringAsyncCore(Task\`1 getTask)
    
    at SimpleConsole.Program.Run() in F:\Allfiles\Labs\05\Starter\Console\Program.cs:line 20
    ```

    > **Note**: This exception occurs because the Web App is no longer available.

#### Task 4: Add retry logic by using Polly

1. On the left side of the **Visual Studio Code** window, in the **Explorer** pane double-click the **PollyHandler.cs** file to open the file in the editor.

2. Within the **PollyHandler** class, observe lines **13-24**. These lines of code use the **Polly** library from the **.NET Foundation** to create a retry policy that will retry a failed HTTP request every five minutes.

3. Add the following class to your project **PollyHandler.cs**

   

   ```
   using System;
   using System.Net.Http;
   using System.Threading;
   using System.Threading.Tasks;
   using static System.Console;
   using Polly;
   namespace SimpleConsole
   {
       public class PollyHandler : DelegatingHandler
       {
           public PollyHandler() : base(new HttpClientHandler()) {}
           protected override Task<HttpResponseMessage> SendAsync(
               HttpRequestMessage request,
               CancellationToken cancellationToken) =>  
               Policy
               .Handle<HttpRequestException>()
               .Or<TaskCanceledException>()
               .OrResult<HttpResponseMessage>( x=> !x.IsSuccessStatusCode)
               .WaitAndRetryForeverAsync(
               retryAttempt => TimeSpan.FromSeconds(5),
               (ex,time) => WriteLine("Failed Attempt")
           ).ExecuteAsync(()=> base.SendAsync(request,cancellationToken));          
       }
   }
   ```

4. On the left side of the **Visual Studio Code** window, in the **Explorer** pane, double-click the **Program.cs** file to open the file in the editor.

5. Locate the **_client** constant at line **10**:

   

   ```
   private static HttpClient _client = new HttpClient(){ BaseAddress = new Uri(_api) };
   ```

6. Update the **_client** constant by updating the **HttpClient** constructor to use a new instance of the **PollyHandler** class:

   

   ```
   private static HttpClient _client = new HttpClient(new PollyHandler()){ BaseAddress = new Uri(_api) };
   ```

7. **Save** the **Program.cs** file.

#### Task 5: Validate retry logic

1. At the bottom of the screen, in the command prompt, enter the following command and press Enter to execute the .NET Core web application.

   

   ```
   dotnet run
   ```

2. Observe that the HTTP request execution continues to fail and is re-attempted every five seconds. You will observe the following message in the console while the application is failing:

   

   ```
   Failed Attempt
   ```

3. Leave the console application running. It will attempt to access the Web App infinitely until it is successful.

4. Return to your currently open browser window displaying the **Azure portal**.

5. On the left side of the portal, select **Resource groups**.

6. In the **Resource groups** blade, locate and select the **MonitoredAssets** resource group that you created earlier in this lab.

7. In the **MonitoredAssets** blade, select the **smpapi\*** Web App that you created earlier in this lab.

8. In the **App Service** blade, select **Start** at the top of the blade to resume the Web App.

9. Return to the currently running **Visual Studio Code** application.

10. Observe that the application finally successfully invokes the Web App in Azure and returns the same JSON array that you observed earlier in this lab. Your result should resemble the following JSON content:

    

    ```
    [{"date":"2021-01-21T10:00:16.9934406+00:00","temperatureC":51,"temperatureF":123,"summary":"Balmy"},{"date":"2021-01-22T10:00:16.9936983+00:00","temperatureC":19,"temperatureF":66,"summary":"Warm"},{"date":"2021-01-23T10:00:16.9936995+00:00","temperatureC":41,"temperatureF":105,"summary":"Sweltering"},{"date":"2021-01-24T10:00:16.9936997+00:00","temperatureC":26,"temperatureF":78,"summary":"Chilly"},{"date":"2021-01-25T10:00:16.9936999+00:00","temperatureC":9,"temperatureF":48,"summary":"Freezing"}]
    ```

11. Close the currently running **Visual Studio Code** application.

#### Review

In this exercise, you created a console application to access your API by using conditional retry logic. The application continued to work regardless of whether the Web App was available.

### Exercise 4: Load test Web App (Deprecated)

[Load test overview | Microsoft Docs](https://docs.microsoft.com/en-us/previous-versions/azure/devops/test/load-test/overview)

#### Task 1: Run a performance test on an Web App

1. Open Visual Studio 2019

2. Verify Web Load Tester is setting up (Tools Options).

   [![image-20210120111539835](https://github.com/BillyClassTime/Monitoring-services-deployed-to-Azure/raw/master/img/image-20210120111539835.png)](https://github.com/BillyClassTime/Monitoring-services-deployed-to-Azure/blob/master/img/image-20210120111539835.png)

3. Create a web load tester

   1. Open VS

   2. Create new proyect **Web Performance and Load Test Project (Deprecated)**

   3. Named **WebLoadTest**

   4. Select open **D:\0Az-204\Allfiles\Labs\12\Starter\Test**

   5. In WebTest1.webtest explorer, rigth click and add "loop"

   6. Select "For loop"

      1. Max Number of iterations: **1000**
      2. Terminating value: **1000**
      3. Advanced Data Cursors: **True**
      4. Context Parameter Name: **iterator**
      5. Initial Value: **1**
      6. Increment Value: **1**

   7. Add "foo loop" "Request loop" (Rigth click in Loop)

      1. Open Propertie Windows: (F4)

      2. In the **URL** field, update the URL by appending the suffix **/weatherforecast** to the end of the current URL.

         > **Note**: For example, if your URL is [http://smpapistudent.azurewebsites.net](http://smpapistudent.azurewebsites.net/), the new URL would be http://smpapistudent.azurewebsites.net/api/weatherforecast.

4. Back in the **WebTest1.webtest** blade, select **Run test**.

   [![image-20210120114531930](https://github.com/BillyClassTime/Monitoring-services-deployed-to-Azure/raw/master/img/image-20210120114531930.png)](https://github.com/BillyClassTime/Monitoring-services-deployed-to-Azure/blob/master/img/image-20210120114531930.png)

5. In the **Test Result window**, wait for the test to start before you proceed with the lab.

   [![image-20210120115015991](https://github.com/BillyClassTime/Monitoring-services-deployed-to-Azure/raw/master/img/image-20210120115015991.png)](https://github.com/BillyClassTime/Monitoring-services-deployed-to-Azure/blob/master/img/image-20210120115015991.png)

   > **Note**: Most load tests take about 3 minutes to gather the resources and start. You can wait at this blade because it will automatically refresh when the load testing is started.

6. Wait for the load test to finish before you proceed with the lab. Observe the live chart updating as your Web App experiences increased usage.

   > **Note**: The load test will take the 10 minutes you specified in the previous steps of the lab.

#### Task 2: Use Azure Monitor metrics after load test

1. In the left navigation pane of the Azure portal, select **All services**.
2. In the **All services** blade, select **Monitor**.
3. In the **Monitor** blade, on the left side of the blade, select **Metrics**.
4. In the **Metrics** section, perform the following actions:
   1. In the **Resource** section, select **Select a scope**.
   2. In the **Select a resource** window that appears, in the **Resource group** list, select **MonitoredAssets**. Then, in the **Resource** list, select the **instrm\*** Application Insights account option. Finally, select **Apply** to close the window and confirm your selection.
   3. In the **Metric Namespace** list, in the **Standard** category, select **Application Insights standard metrics**.
   4. In the **Metric** list, in the **Performance Counter** category, select **Process CPU**.
   5. In the **Aggregation** list, select **Avg**.
   6. At the top of the section, select **Last 24 hours (Automatic - 5 minutes)**. In the window that appears, in the **Time range** category, select **Last 30 minutes** and then select **Apply** to save your selection.
   7. At the top of the section, select **Line chart**. In the menu that appears, select **Area chart**.
5. Observe your newly created chart.
6. At the top of the section, select **Add metric**.
7. In the **Metrics** section, perform the following actions with the new metric item in the list:
   1. In the **Metric Namespace** list, in the **Standard** category, select **Log-based metrics**.
   2. In the **Metric** list, in the **Server** category, select **Server response time**.
   3. In the **Aggregation** list, select **Avg**.
8. Observe your updated chart. Observe the information displayed in your chart. You can observe how the server response time correlates with the CPU time as load on the application increased.

#### Review

In this exercise, you performed a performance (load) test of your Web App by using the tools available in Visual Studo 2019 (Deprecated). After you performed the load test, you were able to measure your API app’s behavior by using metrics in the Azure Monitor interface.

### Exercise 5: Clean up subscription

#### Task 1: Open Cloud Shell

1. At the top of the Azure portal, select the **Cloud Shell** icon to open a new shell instance.

   > **Note**: The **Cloud Shell** icon is represented by a greater than symbol and underscore character.

2. If this is your first time opening the **Cloud Shell** by using your subscription, a **Welcome to Azure Cloud Shell Wizard** will appear that allows you to configure **Cloud Shell** for first-time usage. Perform the following actions in the wizard:

   1. A dialog box will appear that prompts you to create a new Storage Account to begin using the shell. Accept the default settings and select **Create storage**.
   2. Wait for the **Cloud Shell** to finish its first-time setup procedures before moving forward with the lab.

   > **Note**: If you do not see the configuration options for the **Cloud Shell**, this is most likely because you are using an existing subscription with this course's labs. The labs are written from the presumption that you are using a new subscription.

3. At the bottom of the portal in the **Cloud Shell** command prompt, type the following command and press Enter to list all resource groups in the subscription:

   

   ```
   az group list
   ```

4. Type the following command and press Enter to view a list of possible commands to delete a resource group:

   

   ```
   az group delete --help
   ```

#### Task 2: Delete resource groups

1. Type the following command and press Enter to delete the **MonitoredAssets** resource group:

   

   ```
   az group delete --name MonitoredAssets --no-wait --yes
   ```

2. Close the **Cloud Shell** pane at the bottom of the portal.

#### Task 3: Close active applications

1. Close the currently running **Microsoft Edge** application.
2. Close the currently running **Visual Studio Code** application.
3. Close the currently running **Visual Studio 2019** application.

#### Review

In this exercise, you cleaned up your subscription by removing the **resource groups** used in this lab.
