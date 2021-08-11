using ApiCore.Domain;
using ApiCore.Domain.Models;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Web.Service.Api
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // The generic ILogger<TCategoryName> service was added to the ServiceCollection by ASP.NET Core.
            // It was then registered with Autofac using the Populate method. All of this starts
            // with the services.AddAutofac() that happens in Program and registers Autofac
            // as the service provider.
            builder.Register(c=>new DbFactory()).As<IDbFactory>();
            builder.Register(c => new GenericRepository<Customer>(c.Resolve<IDbFactory>()))
              .As<IGenericRepository<Customer>>()
              .InstancePerLifetimeScope();
        }
    }
}
