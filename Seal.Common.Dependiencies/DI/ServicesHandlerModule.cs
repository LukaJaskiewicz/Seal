using Autofac;
using Seal.Backend.BLL.Services;
using Seal.Common.Infrastructure.Services;

namespace Seal.Common.Dependiencies.DI
{
    public class ServicesHandlerModule : Module
    {

        protected override void Load(ContainerBuilder builder)
        {
            
            builder.RegisterType<TemplateService>().As<ITemplateService>().InstancePerLifetimeScope();
        }
    }
}
