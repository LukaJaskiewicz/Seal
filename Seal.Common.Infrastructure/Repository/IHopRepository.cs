using Seal.Common.ViewModel.Interaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Seal.Common.Infrastructure.Repository
{
    public interface IHopRepository
    {
        Task<T> GetHopAsync<T>(int id) where T : class, IViewModel<int>;
        Task AddHopAsync<T>(T hop) where T : IViewModel<int>;
    }
}
