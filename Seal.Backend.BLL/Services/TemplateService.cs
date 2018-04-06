using Seal.Common.Infrastructure.Repository;
using Seal.Common.Infrastructure.Services;
using Seal.Common.ViewModel.Interaces;
using Seal.Common.ViewModel.Template;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Seal.Backend.BLL.Services
{
    public class TemplateService : ITemplateService
    {
        private readonly ITemplateRepository _repository;
        public TemplateService(ITemplateRepository repository)
        {
            _repository = repository;
        }

        public string Foo(int number)
        {
            var x = this._repository.GetFoo();
            return String.Format("The only {0} returns from forest", x);
        }
        public async Task<T> GetFooAsync<T>(int id) where T: class, IViewModel<int>
        {
            var result = await _repository.GetFooAsync<T>(id);

            return result;
        }
    }
}
