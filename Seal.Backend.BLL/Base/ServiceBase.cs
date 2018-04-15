using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace Seal.Backend.BLL.Base
{
    public class ServiceBase
    {
        protected readonly ILifetimeScope _lifetimeScope;
        public ServiceBase(ILifetimeScope lifetimeScope)
        {
            _lifetimeScope = lifetimeScope;
        }
    }
}
