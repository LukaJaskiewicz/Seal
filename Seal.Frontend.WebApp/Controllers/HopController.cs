using Microsoft.AspNetCore.Mvc;
using Seal.Common.Infrastructure.Services;
using Seal.Common.ViewModel.Hop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seal.Frontend.WebApp.Controllers
{
    [Route("api/[controller]")]
    public class HopController : Controller
    {
        readonly IIngredientsService _ingredientsService;
        public HopController(IIngredientsService ingredientsService)
        {
            _ingredientsService = ingredientsService;
        }

        [HttpGet]
        public async Task<HopViewModel> Get(int id)
        {
            var result = await _ingredientsService.GetHopAsync<HopViewModel>(id);

            return result;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody]HopViewModel hop)
        {
            await _ingredientsService.AddHop(hop);
            return Ok();
        }
    }
}
