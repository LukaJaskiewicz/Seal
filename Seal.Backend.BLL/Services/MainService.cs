using Seal.Common.Infrastructure.Repository;
using Seal.Common.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Seal.Backend.BLL.Services
{
    
    public class MainService 
    {
        private readonly ITemplateRepository _repository;
        public MainService(ITemplateRepository repository)
        {
            _repository = repository;
        }

        public string Foo(int number)
        {
            this._repository.GetFoo();
            return String.Format("The only {0} returns from forest", number - 1);
        }
    }
}
