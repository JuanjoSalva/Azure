using System;
using System.Net.Http;
using System.Threading.Tasks;
using static System.Console;
namespace SimpleConsole
{
    class Program
{
    //private const string _api = "https://smapijsr.azurewebsites.net";
    private const string _api = "http://smpapibmvb.azurewebsites.net";

    //LLamando al PollyHandler hacenos que lo intente y si falla no da error y pasa al siguiente intento
    private static HttpClient _client = new HttpClient(new PollyHandler()){ BaseAddress = new Uri(_api) };
    //private static HttpClient _client = new HttpClient(){ BaseAddress = new Uri(_api) };

    static void Main(string[] args)
    {
	        Run().Wait();
    }

    static async Task Run()
    {
        int loops = 1;
        do {
            string response = await _client.GetStringAsync("/weatherforecast");
            WriteLine($"intento : {loops}");
            //WriteLine(response);
        } while (loops++<1000);
    }
}
}
