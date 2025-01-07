// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Configuration;

Console.WriteLine("Hello, World!");


// Access secrets
string connectionString = new SecretManager().GetSecret("ConnectionStrings:MyDatabase");
var connectionString1 = System.Configuration.ConfigurationManager.ConnectionStrings["MyDatabase1"].ConnectionString;


#if DEBUG
string connectionStrings = new SecretManager().GetSecret("ConnectionStrings:MyDatabase");
#else
var connectionStrings = Environment.GetEnvironmentVariable("OneDrive");
#endif

string apiKey = new SecretManager().GetSecret("APIKey");
string environment = Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT") ?? "Production";


Console.WriteLine(connectionString);
Console.WriteLine(connectionString1);

Console.WriteLine(apiKey);


public class SecretManager
{
    private readonly IConfiguration _configuration;

    public SecretManager()
    {
        // Build the configuration to include user secrets
        _configuration = new ConfigurationBuilder()
            .AddUserSecrets<SecretManager>() // Use the class type for identifying secrets
            .Build();
    }

    public string GetSecret(string key)
    {
        // Retrieve the secret by key
        return _configuration[key];
    }
}