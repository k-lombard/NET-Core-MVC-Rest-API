
using WebApp.Data;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Swashbuckle.AspNetCore.SwaggerGen;

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
            // services.AddEntityFrameworkSqlServer().AddDbContext<DbContext, CommanderContext>(opt => opt.UseSqlServer
            //     (Configuration.GetConnectionString("CommanderConnection")));
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