using Microsoft.EntityFrameworkCore.Design;
using WebApp.Data;
using Microsoft.EntityFrameworkCore;
public class CommanderContextFactory : IDesignTimeDbContextFactory<CommanderContext>
{
    public CommanderContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<CommanderContext>();
        optionsBuilder.UseSqlServer("Server=DESKTOP-2RJE8G5\\SQLEXPRESS;Initial Catalog=CommanderDB;User ID=CommanderAPI;Password=password;");
        return new CommanderContext(optionsBuilder.Options);
    }
}