using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.Framework.ConfigurationModel;
using Microsoft.Framework.DependencyInjection;
using Microsoft.AspNet.Mvc;
using MicrobrewitAspNet5.Models;
using Microsoft.Framework.Runtime;
using MicrobrewitAspNet5.Repository;

namespace MicrobrewitAspNet5
{
    public class Startup
    {
        public static IConfiguration Configuration { get; set; }
        public Startup(IHostingEnvironment env)
        {

            //Configuration = new Configuration(appEnv.ApplicationBasePath).AddJsonFile("config.json").AddEnvironmentVariables();
        }

        // This method gets called by a runtime.
        // Use this method to add services to the container
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddMvc().Configure<MvcOptions>(o =>
            {
                var jsonOutputFormatter = new JsonOutputFormatter();
                jsonOutputFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                for (int i = 0; i < o.OutputFormatters.Count; i++)
                {
                    if (o.OutputFormatters[i].GetType() == typeof(JsonOutputFormatter))
                        o.OutputFormatters.Remove(o.OutputFormatters[i]);
                }
                o.OutputFormatters.Add(jsonOutputFormatter);
            });
            // Uncomment the following line to add Web API services which makes it easier to port Web API 2 controllers.
            // You will also need to add the Microsoft.AspNet.Mvc.WebApiCompatShim package to the 'dependencies' section of project.json.
            // services.AddWebApiConventions();

            //services.AddEntityFramework().AddSqlServer().AddDbContext<RecipeContext>();
            services.AddEntityFramework().AddSqlite().AddDbContext<MbContext>();
            services.AddTransient<IGlassRepository, GlassRepository>();
        }

        // Configure is called after ConfigureServices is called.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //app.UseWelcomePage();
            // Configure the HTTP request pipeline.
            app.UseStaticFiles();
            // Add MVC to the request pipeline.
            app.UseMvc();

        }
    }
}
