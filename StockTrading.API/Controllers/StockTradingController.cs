using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace StockTrading.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockTradingController : ControllerBase
    {
        private IConfiguration _configuration;
        public StockTradingController(IConfiguration configuration)
        {
           _configuration = configuration;
        }

        [HttpGet]
        public string Get()
        {
           return "";
        }

    }
}
