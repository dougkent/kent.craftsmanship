﻿using KCS.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KCS.Web.Controllers
{
    [Route("api/values")]
    public class ValuesController : Controller
    {
        private readonly IOptions<ConfigSettings> _settingsAccessor;

        public ValuesController(IOptions<ConfigSettings> settingsAccessor)
        {
            _settingsAccessor = settingsAccessor;
        }

        [HttpGet("")]
        public IActionResult GetData()
        {
            return Ok(new { env = _settingsAccessor.Value.Env });
        }
    }
}