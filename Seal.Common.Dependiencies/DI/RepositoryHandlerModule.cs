using Autofac;
using Seal.Backend.DAL.TemplateRepository;
using Seal.Common.Infrastructure.Repository;

namespace Seal.Common.Dependiencies.DI
{
    public class RepositoryHandlerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<MainRepository>().As<ITemplateRepository>().InstancePerLifetimeScope();
        }
    }
}
