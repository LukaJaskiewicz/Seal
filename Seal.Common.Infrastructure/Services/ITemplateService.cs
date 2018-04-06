using Seal.Common.ViewModel.Interaces;
using Seal.Common.ViewModel.Template;
using System.Threading.Tasks;

namespace Seal.Common.Infrastructure.Services
{
    public interface ITemplateService
    {
        /// <summary>
        /// Template test method
        /// </summary>
        /// <param name="number">number of foo in test. </param>
        /// <returns>Short foo's poem</returns>
        string Foo(int number);
        Task<T> GetFooAsync<T>(int id) where T: class, IViewModel<int>;
    }
}
