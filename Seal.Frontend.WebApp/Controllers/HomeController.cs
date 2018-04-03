using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Seal.Common.Infrastructure.Services;

namespace Seal.Frontend.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITemplateService _service;

        public HomeController(ITemplateService service)
        {
            this._service = service;
        }
        public IActionResult Index()
        {
            var x = _service.Foo(123);
            return View();
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }
}
