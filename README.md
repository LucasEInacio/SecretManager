# SecretManager
PoC of how to use user secrets in .NET 9 console app

# How to Execute this PoC
run these commands in powershell in .csproj file folder

```powershell```
dotnet user-secrets init
$sa_password = "[SA password here]"
dotnet user-secrets set "ConnectionStrings:GameStoreContext" "Server=mieeesssServerAddress;Database=myDataBase;User Id=myUsername;Password=$sa_password;"