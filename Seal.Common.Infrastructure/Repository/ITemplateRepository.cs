using Seal.Common.ViewModel.Interaces;
using System.Threading.Tasks;

namespace Seal.Common.Infrastructure.Repository
{
    public interface ITemplateRepository
    {
        int GetFoo();
        Task<T> GetFooAsync<T>(int id) where T : class, IViewModel<int>;
    }
}
