using Seal.Common.ViewModel.Hop;
using Seal.Common.ViewModel.Interaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Seal.Common.Infrastructure.Services
{
    public interface IIngredientsService
    {
        Task<T> GetHopAsync<T>(int id) where T : class, IViewModel<int>;
        Task AddHop(HopViewModel hop);
    }
}
