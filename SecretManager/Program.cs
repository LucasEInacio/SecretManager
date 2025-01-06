// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Configuration;

Console.WriteLine("Hello, World!");


// Access secrets
string connectionString = new SecretManager().GetSecret("ConnectionStrings:MyDatabase");
var appName = System.Configuration.ConfigurationManager.ConnectionStrings["MyDatabase1"].ConnectionString;

Console.WriteLine(connectionString);
Console.WriteLine(appName);


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