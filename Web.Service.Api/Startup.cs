using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Web.Http;
using ApiCore;
using ApiCore.Domain;
using ApiCore.Domain.Models;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Autofac.Integration.WebApi;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Web.Service.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.

        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule(new AutofacModule());

        }
            public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options => options.EnableEndpointRouting = false);
            //services.AddScoped<IGenericRepository<Customer>, GenericRepository<Customer>>(); // you populte the builder a below
            //services.AddAutofac();

        
            //AutofacConfig.RegisterAutofac();
            //var builder = new ContainerBuilder();
            //builder.Populate(services);

            //builder.RegisterType<GenericRepository<Customer>>().As<IGenericRepository<Customer>>().AsSelf();

            //builder.RegisterModule<SetupModule>();
            //builder.Populate(services);
            //var container = builder.Build();


            //builder.Build();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseRouting();


            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints => {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Customer}/{action=GetCustomerList}");
                endpoints.MapRazorPages();
            });
        }
    }
}
