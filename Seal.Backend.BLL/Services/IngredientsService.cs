using Autofac;
using Seal.Backend.BLL.Base;
using Seal.Common.Infrastructure.Repository;
using Seal.Common.Infrastructure.Services;
using Seal.Common.ViewModel.Hop;
using Seal.Common.ViewModel.Interaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Seal.Backend.BLL.Services
{
    public class IngredientsService : ServiceBase, IIngredientsService
    {
        readonly IHopRepository _hopRepository;
        public IngredientsService(ILifetimeScope lifetimeScope, IHopRepository hopRepository) : base(lifetimeScope)
        {
            _hopRepository = hopRepository;
        }

        public async Task AddHop(HopViewModel hop)
        {
            using (var scope = base._lifetimeScope.BeginLifetimeScope())
            {
                await _hopRepository.AddHopAsync(hop);
            }
        }

        public async Task<T> GetHopAsync<T>(int id) where T : class, IViewModel<int>
        {
            using (var scope = base._lifetimeScope.BeginLifetimeScope())
            {
                var  result = await _hopRepository.GetHopAsync<T>(id);
                return result;
            }
        }
    }
}
