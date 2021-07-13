# Lesson 3: Microsoft Azure Fundamentals

### Demonstration: How to Upload an Image to Microsoft Azure Blob Storage

#### Preparation Steps 

1. Ensure that you have cloned the **20486D** directory from GitHub. It contains the code segments for the labs and demos of this course. (**https://github.com/MicrosoftLearning/20486D-DevelopingASPNETMVCWebApplications/tree/master/Allfiles**)

2. Ensure that you have a Microsoft Azure account.

#### Demonstration Steps 

1. Open Microsoft Edge.

2. In Microsoft Edge, in the address bar type **http://portal.azure.com**, and then press Enter.

3. Sign in, and then click **Storage accounts**.

4. In the **Storage accounts** window, in the menu bar, click **Add**.

5. In the **Create storage account** window, in the **Storage account name** box, type **blobdemo{unique name}**.

   >**Note**: The name must be unique. You can add your first name, last name, or birthdate to the current name.

6. In the **Create storage account** window, under **Resource group**, click **Create new**.

7. In the pop-up window, in the **Name** box, type **blobdemo{unique name}**, and then click **OK**.

   >**Note**: The name must be unique. You can add your first name, last name or birthdate to the current name.

8. In the **Create storage account** window, click **Review + create**.

9. In the **Create storage account** window, click **Create**.

10. In the **Microsoft.StorageAccount - Overview** window, click **Go to resource**.

11. In the **blobdemo{unique name}** window, below **Blob service**, click **Blobs**.

12. In the **blobdemo{unique name}** **- Blobs** window, in the menu bar, click **Container**.

13. In the **New container** window, in the **Name** box, type **myfirstcontainer**.

14. In the **New container** window, in the **Public access level** list, click **Blob(anonymous read access for blobs only)**, and then click **OK**.

15. In the **blobdemo{unique name}** **- Blobs** window, click **myfirstcontainer**.

16. In the **myfirstcontainer** window, click **Upload**.

17. In the **Upload blob** window, click **Select a file**. 

18. In File Explorer, browse to **[Repository Root]\Allfiles\Mod14\Democode\02_AzureStorageDemo_Images**, click **blackberries.jpg**, and then click **Open**.

19. In the **Upload blob** window, click **Upload**.

20. Close the **Upload blob** window.



**Vamos a nuestra cuenta de Azure y creamos un Storage con un contenedor blob donde subimos 2 imagenes**

![14_p11](https://github.com/JuanjoSalva/How-to-Upload-an-Image-to-Microsoft-Azure-Blob-Storage/blob/master/AzureStorageDemo/img/14_p11.PNG)

![14_p13](https://github.com/JuanjoSalva/How-to-Upload-an-Image-to-Microsoft-Azure-Blob-Storage/blob/master/AzureStorageDemo/img/14_p13.PNG)



![14_15](https://github.com/JuanjoSalva/How-to-Upload-an-Image-to-Microsoft-Azure-Blob-Storage/blob/master/AzureStorageDemo/img/14_15.PNG)

** Ahora con el Visual Studio modificamos el proyecto para que suba a Azure imagenes de nuestro Local**

1. Open File Explorer.

2. In File Explorer, navigate to **[Repository Root]\Allfiles\Mod14\Democode\02_AzureStorageDemo_begin\AzureStorageDemo**, and then copy the address in the address bar.

3. Click **Start**, and then type **cmd**.

4. Under **Best match**, right-click **Command Prompt**, and then click **Run as administrator**.

5. In the **User Account Control** dialog box, click **Yes**.

6. In the **Administrator: Command Prompt** window, type the following command, and then press Enter.
<pre><code>
   ```cs
       cd *{copied folder path}*
  </code></pre>

**Note**: If the *{copied folder path}* is different from the disk drive where the command prompt is located, then you should type *{disk drive}:* before typing the **cd**  *{copied folder path}* command.

7. In the **Administrator: Command Prompt** window, type the following command, and then press Enter.
<pre><code>
   ```cs
       npm install
   ```
   </code></pre>
   **Note**: If warning messages are shown in the command prompt you can ignore them.

8. Close the window.

9. In File Explorer, browser to **[Repository Root]\AllFiles\Mod14\Democode\02_AzureStorageDemo_begin**,
   and then double-click **AzureStorageDemo.sln**.

   >**Note**: If a **Security Warning for AzureStorageDemo** dialog box appears, verify that the **Ask me for every project in this solution** check box is cleared, and then click OK.

10. In the **AzureStorageDemo – Microsoft Visual Studio** window, in Solution Explorer, right-click **AzureStorageDemo**,  point to **Add**, and then click **Connected Service**.

11. In the **Connected Service** window, click **Cloud Storage with Azure Storage**.

12. In the **Azure Storage** window, sign in to the Azure account.

    >**Note**: In case you are already signed in, you will not see the sign-in dialog box. In that case, proceed to the next step.

13. In the **Azure Storage** window, click  **blobdemo{unique name}** , and then click **Add**.

    >**Note**: Microsoft Edge displays the following URL: https://docs.microsoft.com/en-us/azure/visual-studio/vs-storage-aspnet-getting-started-blobs.

14. In Microsoft Edge, click **Close**.

15. In the **AzureStorageDemo – Microsoft Visual Studio** window, in Solution Explorer, click **appsettings.json**.

16. In the **appsettings.json** window, highlight the following code, and then right-click and click **Copy**.
<pre><code>
```cs
      AzureStorageConnectionString-1
```
</code></pre>

37.	In the **AzureStorageDemo – Microsoft Visual Studio** window, in Solution Explorer,  expand **Controllers**, and then click **BlobController.cs**.

38.	In the **BlobController.cs** window, locate the following code:
<pre><code>
```cs
       _connectionString = _configuration.GetConnectionString("{your_connection_string_name}");
```
</code></pre>

39. Replace **{your_connection_string_name}** with the connection string name copied in step 36.

40. In the **AzureStorageDemo - Microsoft Visual Studio** window, in Solution Explorer, right-click **AzureStorageDemo**, and then click **Manage NuGet Packages**.

41. In the **NuGet Package Manager: AzureStorageDemo** window, click **Browse**.

42. In the **Search** box, type **WindowsAzure.Storage**, and then press Enter.

43. Click **WindowsAzure.Storage**, select version **9.3.3**, and then click **Install.**

    >**Note**: If you have already installed a previous version of **WindowsAzure.Storage**, the button will display **Update** instead of **Install**.

44. If a **Preview Changes** dialog box appears, click **OK**.

45. If a **License Acceptance** dialog box appears, click **I Accept**.

46. Close the **NuGet Package Manager: AzureStorageDemo** window.

47. In the **AzureStorageDemo – Microsoft Visual Studio** window, in Solution Explorer, click **BlobController.cs**.

48. In the **BlobController.cs** code window, locate the following code:
<pre><code>
  ```cs
       using AzureStorageDemo.Data;
  ```
  </code></pre>

49. Ensure that the cursor is at the end of the **AzureStorageDemo.Data** namespace, press Enter, and then type the following code:
<pre><code>
  ```cs
       using Microsoft.WindowsAzure.Storage;
       using Microsoft.WindowsAzure.Storage.Blob;
  ```
</code></pre>

50. Ensure that the cursor is at the end of the **CreateImageAsync** code block, press Enter twice, and then type the following code:
<pre><code>
  ```cs
       public async Task UploadAsync(IFormFile photo)
       {
           CloudStorageAccount storageAccount = CloudStorageAccount.Parse(_connectionString);
           CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
           CloudBlobContainer container = blobClient.GetContainerReference("myimagecontainer");

           if (await container.CreateIfNotExistsAsync())
           {
               await container.SetPermissionsAsync(
               new BlobContainerPermissions
              {
                  PublicAccess = BlobContainerPublicAccessType.Blob
              });
           }
           CloudBlockBlob blob = container.GetBlockBlobReference(Path.GetFileName(photo.FileName));
           await blob.UploadFromStreamAsync(photo.OpenReadStream());
       }  ```
  </code></pre>

51. In the **BlobController.cs** code block, locate the following code:
<pre><code>
  ```cs
       using (var memoryStream = new MemoryStream())
       {
           photo.PhotoAvatar.CopyTo(memoryStream);
           photo.PhotoFile = memoryStream.ToArray();
       }  ```
</ode></pre>

52. Place the cursor at the end of the located code, press Enter, type the following code, and then press Enter twice.
<pre><code>
  ```cs
       await UploadAsync(photo.PhotoAvatar);
  ```
  </ode></pre>

53. In the **AzureStorageDemo - Microsoft Visual Studio** window, on the **FILE** menu, click **Save All**.

54. In the **AzureStorageDemo – Microsoft Visual Studio** window, on the **DEBUG** menu, click **Start Without Debugging**.

55. In Microsoft Edge, click **Upload New Image**.

56. On the **Add Photo to Album** page, in the **Title** box, type _&lt;A photo title of your choice&gt;._

57. On the **Add Photo to Album** page, in the **Description** box, type _&lt;A photo description of your choice&gt;._

58. In Microsoft Edge, click **Browse**.

59. In File Explorer, browse to **[Repository Root]\Allfiles\Mod14\Democode\02_AzureStorageDemo_Images**, click **fungi.jpg**, and then click **Open**.

60. In Microsoft Edge, click **Submit Photo to Azure**. 

61. In Microsoft Edge, open a new tab, type **http://portal.azure.com**, and then press Enter.

62. In the portal, in the menu on the left-hand side, click **Storage Accounts**. 

63. In the **Storage accounts** window, click **blobdemo{unique name}**.

64. In the **blobdemo{unique name}** window, below **Blob service**, click **Blobs**.

65. In the **Blobs** window, click **myimagecontainer**.

    >**Note**: Verify the presence of the uploaded image.

66. Click **fungi.jpg**.

67. Click **Edit blob**.

    >**Note**: The uploaded image is displayed.

68. Close all the Microsoft Edge windows.

69. In the **AzureStorageDemo - Microsoft Visual Studio** window, on the **FILE** menu, click **Exit**.

** Imagenes de estos últimos pasos**

![index](https://github.com/JuanjoSalva/How-to-Upload-an-Image-to-Microsoft-Azure-Blob-Storage/blob/master/AzureStorageDemo/img/index.PNG)

Yo he subido 

![upload](https://github.com/JuanjoSalva/How-to-Upload-an-Image-to-Microsoft-Azure-Blob-Storage/blob/master/AzureStorageDemo/img/upload.PNG)



Y se ve como está en Azure

![image-20201217152810810](https://github.com/JuanjoSalva/How-to-Upload-an-Image-to-Microsoft-Azure-Blob-Storage/blob/master/AzureStorageDemo/img/ultima.PNG)

