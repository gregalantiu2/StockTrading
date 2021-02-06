using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using StockTrading.API.Interfaces;

namespace StockTrading.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockTradingController : ControllerBase
    {
        private IStockClient _stockClient;
        public StockTradingController(IStockClient stockClient)
        {
           _stockClient = stockClient;
        }
        [HttpGet]
        public string Get()
        {
           return "";
        }

    }
}
