using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Graph;
using Microsoft.Graph.Auth;

public class Program
{
    private const string _clientId = "38d0b720-050a-4e85-a0c2-ad08536590d4";
    private const string _tenantId = "7e6df344-43e9-4df5-83cf-d711bc6c4b3c";

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

        //AuthenticationResult result;

        /*result = await app
            .AcquireTokenInteractive(scopes)
            .ExecuteAsync();*/

        //Console.WriteLine($"Token:\t{result.AccessToken}");

        DeviceCodeProvider provider = new DeviceCodeProvider(app, scopes);

        GraphServiceClient client = new GraphServiceClient(provider);

        User myProfile = await client.Me
        .Request()
        .GetAsync();

        Console.WriteLine($"Name:\t{myProfile.DisplayName}");
        Console.WriteLine($"AAD Id:\t{myProfile.Id}");

    }
}
