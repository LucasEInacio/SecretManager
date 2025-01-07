# SecretManager
PoC of how to use user secrets in .NET 9 console app

# How to Execute this PoC
run these commands in powershell in .csproj file folder

```powershell```
<br />dotnet user-secrets init
<br />$sa_password = "[SA password here]"
<br />dotnet user-secrets set "ConnectionStrings:MyDatabase" "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=$sa_password;"

<br /><br />
dotnet user-secrets set "APIKey" "08B7A27B-951A-48C1-BADA-EB80717C1DDD"
