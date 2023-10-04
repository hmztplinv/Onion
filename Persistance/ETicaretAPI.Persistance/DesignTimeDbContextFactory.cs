using ETicaretAPI.Persistance;
using ETicaretAPI.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ETicaretAPIDbContext>
{
    public ETicaretAPIDbContext CreateDbContext(string[] args)
    {
        //ConfigurationManager configurationManager = new ConfigurationManager();
        //configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/ETicaretAPI.API"));
        //configurationManager.AddJsonFile("appsettings.json");
        
        var builder = new DbContextOptionsBuilder<ETicaretAPIDbContext>();
        //builder.UseNpgsql("User ID=postgres;Host=localhost;Password=3330;Port=5432;Database=ETicaretAPIDb;");
        builder.UseNpgsql(Configuration.ConnectionString);
        return new ETicaretAPIDbContext(builder.Options);
    }

    
}
