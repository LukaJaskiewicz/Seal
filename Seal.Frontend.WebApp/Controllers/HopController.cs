using Microsoft.AspNetCore.Mvc;
using Seal.Common.Infrastructure.Services;
using Seal.Common.ViewModel.Hop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seal.Frontend.WebApp.Controllers
{
    public class HopController : Controller
    {
        readonly IIngredientsService _ingredientsService;
        public HopController(IIngredientsService ingredientsService)
        {
            _ingredientsService = ingredientsService;
        }

        [HttpGet]
        public async Task<HopViewModel> Get()
        {
            var result = await _ingredientsService.GetAsync();

            return result;
        }
    }
}
