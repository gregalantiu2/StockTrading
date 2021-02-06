using Alpaca.Markets;
using Microsoft.Extensions.Configuration;
using StockTrading.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockTrading.API.Models
{
  public class StockClient : IStockClient
  {
    private IConfiguration _config;
    public IAlpacaTradingClient Client { get; set; }
    public StockClient(IConfiguration config)
    {
      _config = config;
      Client = Alpaca.Markets.Environments.Paper.GetAlpacaTradingClient(new SecretKey(_config.GetValue<string>("apiKey"), _config.GetValue<string>("apiSecret")));
    }
  }
}
