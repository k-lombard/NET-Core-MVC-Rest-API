using WebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Data
{
    public class CommanderContext : DbContext
    {   
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {
            
        }

        public DbSet<Command> Commands { get; set; }

    }
}