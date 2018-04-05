using Seal.Common.Infrastructure.Repository;
using Seal.Common.Infrastructure.Services;
using Seal.Common.ViewModel.Hop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Seal.Backend.BLL.Services
{
    public class IngredientsService : IIngredientsService
    {
        readonly IHopRepository _hopRepository;
        public IngredientsService(IHopRepository hopRepository)
        {
            _hopRepository = hopRepository;
        }

        public Task<HopViewModel> GetAsync()
        {
            throw new NotImplementedException();
        }
    }
}
