using Alpaca.Markets;
using StockTrading.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockTrading.API.Models
{
  public class StockClient : IStockClient
  {
    public IAlpacaTradingClient GetStockClient()
    {
      return Alpaca.Markets.Environments.Paper.GetAlpacaTradingClient(new SecretKey(API_KEY, API_SECRET));
    }
  }
}
