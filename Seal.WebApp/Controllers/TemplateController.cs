﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Seal.Common.Infrastructure.Services;

namespace Seal.Frontend.WebApp.Controllers
{
    public class TemplateController : Controller
    {
        public TemplateController(ITemplateService service)
        {

        }
    }
}