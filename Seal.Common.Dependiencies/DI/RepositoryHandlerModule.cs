using Autofac;
using Seal.Backend.DAL.TemplateRepository;
using Seal.Common.Infrastructure.Repository;

namespace Seal.Common.Dependiencies.DI
{
    public class RepositoryHandlerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //Rejestracja
            builder.RegisterType<TemplateRepository>().As<ITemplateRepository>().InstancePerLifetimeScope();
            builder.RegisterType<HopRepository>().As<IHopRepository>().InstancePerLifetimeScope();
        }
    }
}
