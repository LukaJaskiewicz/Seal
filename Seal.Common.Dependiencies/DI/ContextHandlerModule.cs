using Autofac;
using Seal.Backend.DAL.DataContext;
using Seal.Common.Domain.DataContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace Seal.Common.Dependiencies.DI
{
    public class ContextHandlerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ApplicationDbContext>().As<IApplicationDbContext>().InstancePerLifetimeScope();
        }
    }
}

    
       

