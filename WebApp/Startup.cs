
using Commander.Data;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using System.Data.SqlClient;

namespace WebApp
{
     public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {

            var builder = new SqlConnectionStringBuilder(
            Configuration.GetConnectionString("CommanderConnection"));
            builder.Password = Configuration["DbPassword"];
            services.AddDbContext<CommanderContext>(opt => opt.UseSqlServer
            (builder.ConnectionString));
            services.AddControllers();
            services.AddScoped<ICommanderRepo, MockCommanderRepo>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}