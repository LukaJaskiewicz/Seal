using Seal.Common.ViewModel.Hop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Seal.Common.Infrastructure.Services
{
    public interface IIngredientsService
    {
        Task<HopViewModel> GetAsync();
    }
}
