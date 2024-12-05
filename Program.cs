
internal class Program
{
    private static void Main(string[] args)
    {

        //Using PMC

        // Step #1: Package Manager Console (PMC)
        //    Tools -> Nuget Package Manager -> Package Manager Console

        // Step #2: Package Manager Console (PMC) Tool 
        //    Install-Package Microsoft.EntityFrameworkCore.Tools

        // Step #3: Install Nuget Page on Project Microsoft.EntityFrameworkCore.Design
        // Microsoft.EntityFrameworkCore.SqlServer

        // Step #4: Install Provider in the project Microsoft.EntityFrameworkCore.SqlServer

        // Step #5: Run Command (Full)
        //    Scaffold-DbContext '[Connection String]' [Provider]

        //Command to be Written In The PMC
        /*
Scaffold-DbContext "Data Source=ADMINISTRATOR\SQLEXPRESS;Initial Catalog=DigitalCurrency ;User ID=h1;Password=h1; Integrated Security = SSPI;Trusted_Connection=True;Trusted_Connection=yes;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -DataAnnotations -contextDir Data -outputdir Entities -context AppDbContext
        */


        //Using Dot Net cli

        // Step #1: Windows Terminal (Command Prompt) 

        // Step #2: Install Ef-Core tool globally
        //    dotnet tool install --global dotnet-ef    (new)
        //    dotnet tool update --global dotnet-ef     (to upgrade)

        // Step #3: Install Provider in the project Microsoft.EntityFrameworkCore.SqlServer

        // Step #4: Run Command (Full)
        //    dotnet ef dbcontext scaffold '[Connection String]' [Provider]


        //Command to be Written In The Dot net CLI

        /*
 dotnet ef dbcontext scaffold "Data Source=ADMINISTRATOR\SQLEXPRESS;Initial Catalog=DigitalCurrency ;User ID=h1;Password=h1; Integrated Security = SSPI;Trusted_Connection=True;Trusted_Connection=yes;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer --data-annotations --context-dir Data --output-dir Entities --context AppDbContext
        */













        //DigitalCurrencyContext digitalCurrencyContext = new DigitalCurrencyContext();
        //foreach (var item in digitalCurrencyContext.WalletsSes)
        //{

        //   Console.WriteLine(item.Holder);


        //}
    }
}